package com.guidetech.gt668.samples.measurements;
import com.guidetech.driver.gt668.api.IGT668;
import com.guidetech.driver.gt668.core.GT668Slr;
import com.guidetech.driver.gt668.data.TimetagsSet;
import com.guidetech.driver.gt668.data.constants.Impedance;
import com.guidetech.driver.gt668.data.constants.Prescale;
import com.guidetech.driver.gt668.data.constants.Signal;
import com.guidetech.driver.gt668.data.constants.ThresholdMode;


public class ShowData {

	static IGT668 gt;
	public static void main(String[] args) throws InterruptedException {

		gt = new GT668Slr();

		double threshold = 0.2;
		int use50Ohms = 1;
		double timeout = 2.0;
		int board = 0;
		//prepare instrument

		System.out.println("--- ShowData sample program for java  v16 ---");
		System.out.println("--- Program collects 100 samples on either channel ---\n");
		System.out.println("Initializing and calibrating the instrument...\n");
		gt.initialize(board);
		gt.selfCal();
				
		
		gt.setMeasEnable(1, false);

		System.out.println("   Channel threshold set to " + threshold + " [Volts]\n");
		gt.setInputThreshold(Signal.GT_SIG_A, ThresholdMode.GT_THR_VOLTS, 0.2);
		gt.setInputThreshold(Signal.GT_SIG_B, ThresholdMode.GT_THR_VOLTS, 0.2);

		System.out.println("   Input impedance set to 50 Ohm termination\n");
		gt.setInputImpedance(Signal.GT_SIG_A, use50Ohms == 1 ? Impedance.GT_IMP_LO : Impedance.GT_IMP_HI);
		gt.setInputImpedance(Signal.GT_SIG_B, use50Ohms == 1 ? Impedance.GT_IMP_LO : Impedance.GT_IMP_HI);
		
		gt.setInputPrescale(Signal.GT_SIG_A, Prescale.GT_DIV_1024);
		gt.setInputPrescale(Signal.GT_SIG_B, Prescale.GT_DIV_AUTO);

		timeout = 5.0;

		System.out.println("Waiting for measurements (ctrl+c to abort)...\n");
		System.out.print("--------------------------------------------------------");

		gt.startMeasurements();                    /* reset measurement memory   */

		double start_time = gt.readSysTime();
		TimetagsSet tags = new TimetagsSet();
		while(gt.readSysTime() - start_time < timeout) {
			tags.addTags(
					gt.readTimetags(15, 15)
					);
			if(tags.getChannel0Count() >= 100 || tags.getChannel1Count() >= 100)
				break;
		}

		checkForErrors();
		

		//display channel 0 tags
		System.out.println("Count : "+tags.getChannel0Count());
		System.out.println("\n");
		System.out.println("Data points for Channel: 0");
		System.out.println("Index       Time Tag [uS]    Time Interval [uS]		Frequency \n");
		System.out.println("================================================\n");
		for(int i = 0; i < tags.getChannel0Count(); i++)
		{
			if(i ==0) 
			{
				System.out.printf("%5d.    %.6f\n", i, tags.getChannel0Tags()[i] * 1.0e6);
			}
			else
			{
				double diff1 = (tags.getChannel0Tags()[i] - tags.getChannel0Tags()[i - 1]) * 1.0e6;
				System.out.format("%5d.    %.6f     %.6f	%.6f\n", i, (tags.getChannel0Tags()[i] * 1.0e6), diff1, 1.0e6/diff1);
			}
		}



		System.out.println("--------------------------------------------------------");
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

}
