package com.guidetech.gt668.samples.slr;

import java.io.FileWriter;
import java.io.IOException;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;
import java.util.Locale;

import com.guidetech.driver.gt668.api.IGT668Slr;
import com.guidetech.driver.gt668.commons.GT668TimeUtils;
import com.guidetech.driver.gt668.core.GT668Slr;
import com.guidetech.driver.gt668.core.slr.AbstractGT668TimeReferencer;
import com.guidetech.driver.gt668.data.T0ExSet;
import com.guidetech.driver.gt668.data.TimetagsSet;
import com.guidetech.driver.gt668.data.constants.Impedance;
import com.guidetech.driver.gt668.data.constants.Prescale;
import com.guidetech.driver.gt668.data.constants.RefClkSrc;
import com.guidetech.driver.gt668.data.constants.Signal;
import com.guidetech.driver.gt668.data.constants.Sort;
import com.guidetech.driver.gt668.data.constants.ThresholdMode;
import com.guidetech.driver.gt668.data.utils.TimeRefTag;

import jssc.SerialPort;
import jssc.SerialPortException;

public class SampleWithAPI extends AbstractGT668TimeReferencer {

	static IGT668Slr gt;
	static SerialPort serialPort;

	public SampleWithAPI(IGT668Slr gt) {
		super(gt);
		// TODO Auto-generated constructor stub
	}

	public static void main(String[] args) throws Exception {
		gt = new GT668Slr();
		SampleWithAPI app = new SampleWithAPI(gt);
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

		//get time from GPS receiver
		int t0 = app.getEpochTime();

		//get the reference tag for error correction
		TimetagsSet refTag = app.measureReference1ppsPulse(t0, 0);

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
		T0ExSet t0set =  gt.getT0Ex();

		//calculate t0 error from ARM tag
		double errorCorrectionFrac = app.calculateReferenceError(refTag);

		//stop measurements
		gt.stopMeasurements();

		List<TimeRefTag> tagsToRef = app.refTagsToRealTime(tags, t0set, 0, errorCorrectionFrac, Sort.TIME_SORTED);
		//save to file
		saveToFile(tagsToRef);

		checkForErrors();

		gt.close();

	}

	@Override
	public int getEpochTime() throws Exception
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

	public static void saveToFile(List<TimeRefTag> tags) throws IOException
	{
		String filePath = "/file/path/file.txt";

		//writer
		FileWriter writer = new FileWriter(filePath);

		StringBuilder sb = new StringBuilder();

		for(TimeRefTag tag : tags) {
			sb.append(tag.getChannel());
			sb.append(" : ");
			sb.append(GT668TimeUtils.parseTag(tag));
			sb.append(System.getProperty("line.separator"));
		}

		writer.append(sb.toString());
		writer.flush();
		writer.close();
	}

}
