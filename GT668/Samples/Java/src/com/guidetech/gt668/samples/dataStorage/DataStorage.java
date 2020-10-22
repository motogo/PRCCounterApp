package com.guidetech.gt668.samples.dataStorage;

import java.io.IOException;

import com.guidetech.driver.gt668.api.IGT668Slr;
import com.guidetech.driver.gt668.api.exceptions.NoCellsDefinedException;
import com.guidetech.driver.gt668.api.exceptions.RowNotDefinedException;
import com.guidetech.driver.gt668.commons.GT668DataUtils;
import com.guidetech.driver.gt668.data.TimetagsSet;
import com.guidetech.driver.gt668.data.utils.Cell;
import com.guidetech.driver.gt668.data.utils.DataFormatFactory;
import com.guidetech.driver.gt668.data.utils.FileType;
import com.guidetech.driver.gt668.data.utils.Row;
import com.guidetech.driver.gt668.data.utils.Var;

public class DataStorage {

	static IGT668Slr gt;
	
	static int deviceNumber = 0;
	
	static double timeout = 2.0;
	
	public static void main(String[] args) throws IOException, ClassNotFoundException, RowNotDefinedException, NoCellsDefinedException {
		//initialize the board
	    gt.initialize(deviceNumber);


	    /**
	     * Configure card here
	     * Calibrate
	     */
	  
	    gt.startMeasurements();                    

	    //read tags
		double start_time = gt.readSysTime();
		TimetagsSet tags = new TimetagsSet();
		while(gt.readSysTime() - start_time < timeout) {

			tags.addTags(
					gt.readTimetags(15, 15)
					);
			//read up to 100 tags on either channel
			if(tags.getChannel0Count() >= 100 || tags.getChannel1Count() >= 100)
				break;
		}
		
		//free card
		gt.close();
		
		//include header?
		boolean includeHeader = true;
		
		//store as simple csv
		String simpleCSVPath = "/path/to/simple.csv";
		String delimiter = ",";
		GT668DataUtils.saveTagsAsSimpleCSV(tags, includeHeader, simpleCSVPath, delimiter);
		
		//store as simple txt
		String simpleTXTPath = "/path/to/simple.txt";
		GT668DataUtils.saveTagsAsSimpleText(tags, includeHeader, simpleTXTPath);
		
		//store as time aligned two row csv
		String ch0representation = "ch0";
		String ch1representation = "ch1";
		String twoRowCSVPath = "/path/to/two_row.csv";
		char delimiterCSV = ',';
		GT668DataUtils.saveTagsToTimeAlignedTwoColumnsCSV(tags, delimiterCSV, ch0representation, ch1representation, twoRowCSVPath);
		
		//store as bytes
		String bytesPath = "/path/to/bytes.ser";
		GT668DataUtils.saveTagsAsBytes(tags, bytesPath);
		
		//read bytes
		TimetagsSet retrievedTags = GT668DataUtils.readTagsFromBytes(bytesPath);
		
		//store tags with complex formatting
		//Data format object defines file structure
		DataFormatFactory dfe = new DataFormatFactory();
		dfe
			.setOutputFileType(FileType.CSV)					//optional: default CSV
			.setDelimiter(';') 									//optional: default ','
			.setFileName("FormattedFile")						//optional: default GT668Tags
			.setEmptyTagRepresentation("n/a")					//optional: default "---"
			.setIncludeRowNumbering(false)						//optional: default true
			.setMaxTagsPerFile(5)								//optional: default -1 (save all tags in single file)
			.setHeader("channel_0_tag;channel_1_tag")			//optional: default null (no header)
			.setStoreHeaderInEachFile(true)						//optional: default false
			.setRestartNumberingInNewFile(true)					//optional: default false
			.setRowDefinition((new Row())						//required: sets row definition, see documentation for details
										.addCell(new Cell("", "", Var.CH_0_TAG)) // This row definition has 4 cells, each cell has following structure:
										.addCell(new Cell("", "", Var.CH_1_TAG)) // String prefix + Var + String suffix
										.addCell(new Cell("someText"))			 // Single string constructor should be used for string only cells
										.addCell(new Cell("otherText")));		 // String Var consturctor should be used for String prefix + Var var cell
																				 // Var String constructor should be used for Var var + String suffix cell
																				 // String String Var constructor should be used for String prefix + Var var + String suffix cell
																			     // this row definition will result with following line:
																				 // Channel_0_tag Channel_1_tag someText otherText e.g. : 0.12345 0.67899 someText otherText
		String pathToFormattedFile = "/path/to/";
		GT668DataUtils.saveTagsWithFormatting(dfe, tags, pathToFormattedFile);
		

	}

}
