package com.guidetech.gt668.samples.slr;

import java.io.FileWriter;
import java.io.IOException;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Date;
import java.util.List;
import java.util.Locale;

import com.guidetech.driver.gt668.api.IGT668Slr;
import com.guidetech.driver.gt668.commons.comp.TagComparator;
import com.guidetech.driver.gt668.core.GT668Slr;
import com.guidetech.driver.gt668.data.T0ExSet;
import com.guidetech.driver.gt668.data.TimetagsSet;
import com.guidetech.driver.gt668.data.constants.Impedance;
import com.guidetech.driver.gt668.data.constants.InputSel;
import com.guidetech.driver.gt668.data.constants.Prescale;
import com.guidetech.driver.gt668.data.constants.RefClkSrc;
import com.guidetech.driver.gt668.data.constants.Signal;
import com.guidetech.driver.gt668.data.constants.ThresholdMode;
import com.guidetech.driver.gt668.data.utils.Channel;
import com.guidetech.driver.gt668.data.utils.Tag;

import jssc.SerialPort;
import jssc.SerialPortException;

public class Sample {

	static IGT668Slr gt;
	static SerialPort serialPort;

	public static void main(String[] args) throws InterruptedException, ParseException, IOException {

		gt = new GT668Slr();

		//adjust the threshold levels
		double chA_threshold = 0.0;
		double chB_threshold = 0.0;
		double ARM_threshold = 5.0;
		
		//use 50ohm termination?
		int use50Ohms = 1;
		
		//adjust measurements timeout
		double timeout = 5.0;
		
		//select board number
		int board = 0;

		//initialize card
		gt.initialize(board);
		
		//calibrate card
		gt.selfCal();

		//set predefined threshold levels
		gt.setInputThreshold(Signal.GT_SIG_A, ThresholdMode.GT_THR_VOLTS, chA_threshold);
		gt.setInputThreshold(Signal.GT_SIG_B, ThresholdMode.GT_THR_VOLTS, chB_threshold);
		gt.setInputThreshold(Signal.GT_SIG_ARM, ThresholdMode.GT_THR_VOLTS, ARM_threshold);

		//set 50ohm termination
		gt.setInputImpedance(Signal.GT_SIG_A, use50Ohms == 1 ? Impedance.GT_IMP_LO : Impedance.GT_IMP_HI);
		gt.setInputImpedance(Signal.GT_SIG_B, use50Ohms == 1 ? Impedance.GT_IMP_LO : Impedance.GT_IMP_HI);

		//set prescale
		gt.setInputPrescale(Signal.GT_SIG_A, Prescale.GT_DIV_AUTO);
		gt.setInputPrescale(Signal.GT_SIG_B, Prescale.GT_DIV_AUTO);
		
		//set ref clock
		gt.setReferenceClock(RefClkSrc.GT_REF_EXTERNAL, false, false);

		//read T0 from arm
		gt.setT0Mode(true, false);
		
		//get time from GPS receiver
		int t0 = getEpochTime();
		
		//set the realtime value to value obtained from gps receiver and synchronize with 1pps signal on ARM input
		gt.setRealTime(t0, true);
		
		//set channel 0 input to ARM
		gt.setMeasInput(0, InputSel.GT_ARM_POS);
		
		//disable channel 1 for arm measurement
		gt.setMeasEnable(1, false);
		
		//reset measurement memory and start measurements
		gt.startMeasurements();                    
		
		//measure one time tag with full accuracy on ARM input
		TimetagsSet refTag = new TimetagsSet();
		while(refTag.getChannel0Count() < 1)
		{
			refTag.addTags(
					gt.readTimetags(1, 0)
					);
		}
		gt.stopMeasurements();

		//set channel 0 input back to channel A
		gt.setMeasInput(0, InputSel.GT_CHA_POS);
		
		//enable channel
		gt.setMeasEnable(1, true);
		
		//gt.setT0Mode(true, false);
		gt.startMeasurements();

		//Sample program gathers measurements for 5 seconds or until it collects 100 samnples on either channel
		//Get the stat time
		double start_time = gt.readSysTime();
		
		TimetagsSet tags = new TimetagsSet();
		
		while(gt.readSysTime() - start_time < timeout) {
			tags.addTags(
					gt.readTimetags(100, 100)
					);
			if(tags.getChannel0Count() >= 100 || tags.getChannel1Count() >= 100)
				break;
		}

		//read T0Ex
		T0ExSet t0tags =  gt.getT0Ex();
		
		//calculate t0 error from ARM tag
		double errorCorrectionFrac = getFraction(refTag.getChannel0Tags()[0]);

		//stop measurements
		gt.stopMeasurements();
		
		//save to file
		saveToFile(tags, t0tags, errorCorrectionFrac, "c:/dev/file.txt");

		checkForErrors();

		gt.close();
	}

	public static void checkForErrors()
	{
		int err = gt.getError();
		if(err != 0) {
			System.err.println(gt.getErrorMessage(err));
			gt.close();
			System.exit(0);
		} else {
			System.out.println("No errors. Continuing measurements.");
		}

	}

	/**
	 * This methods obtains time from GPS receiver.
	 * Please tailor this method so that it provides time obtained from GPS receiver in epoch format
	 * @return
	 * @throws ParseException
	 */
	public static int getEpochTime() throws ParseException
	{
		int epoch = 0;
		serialPort = new SerialPort("COM4");
		try {
			//Open serial port
			serialPort.openPort();
			serialPort.setParams(SerialPort.BAUDRATE_9600, 
					SerialPort.DATABITS_8,
					SerialPort.STOPBITS_1,
					SerialPort.PARITY_NONE);
			while(true) 
			{ 
				byte[] msg = serialPort.readBytes();
				
				if(msg != null)
				{
					String timeStr = new String(msg);
					if(timeStr.startsWith("$GPZDA"))
					{
						String [] timeArr = timeStr.split(",");

						String dt = timeArr[4] + "-" + timeArr[3] + "-" + timeArr[2] + " " + timeArr[1];
						DateFormat format = new SimpleDateFormat("yyyy-MM-dd hhmmss.S", Locale.ENGLISH);
						Date date = format.parse(dt);

						epoch = (int) (date.getTime()/1000);

						serialPort.closePort();

						break;
					}
				}
			}
		}
		catch (SerialPortException ex) {
			System.out.println(ex);
		}
		
		return epoch;
	}
	
	/**
	 * This method will be part of generic SLR API
	 * @param highDec
	 * @return
	 */
	public static double getFraction(double highDec)
	{
		String ys = Double.toString(highDec);
			
		String fracPart = ys.split("\\.")[1].substring(8);
		
		String fracDoubleStr = "0."; 
		for(int i = 0; i < 8; i++)
		{
			fracDoubleStr += "0";
		}
		
		fracDoubleStr += fracPart;
		
		return Double.parseDouble(fracDoubleStr);
	}
	
	/**
	 * This method is partially supported by generic SLR API. Updated version will be available in new release.
	 * @param tts
	 * @param t0set
	 * @param frac
	 * @param filePath
	 * @throws IOException
	 */
	public static void saveToFile(TimetagsSet tts, T0ExSet t0set, double frac, String filePath) throws IOException
	{
		int index = tts.getChannel0Tags().length > tts.getChannel1Tags().length ? tts.getChannel0Tags().length : tts.getChannel1Tags().length;
		
		double T0frac = t0set.getT0frac() + frac;
		
		StringBuilder sb = new StringBuilder();
				
		List<Tag> tags = new ArrayList<Tag>();
		
		for(int i = 0; i < index; i++) {
			if(tts.getChannel0Tags().length > i)
				tags.add(new Tag(Channel.CHANNEL_0, tts.getChannel0Tags()[i] + T0frac));
			if(tts.getChannel1Tags().length > i)
				tags.add(new Tag(Channel.CHANNEL_1, tts.getChannel1Tags()[i] + T0frac ));
		}

		//sort
		Collections.sort(tags, new TagComparator());
				
		//writer
		FileWriter writer = new FileWriter(filePath);
		
		for(Tag tag : tags) {
			sb.append(tag.getChannel());
			sb.append(" : ");
			sb.append(t0set.getT0sec() + " " + tag.getTagValue());
			sb.append(System.getProperty("line.separator"));
		}
		
		writer.append(sb.toString());
		writer.flush();
		writer.close();
	}

}
