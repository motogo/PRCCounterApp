package com.guidetech.gt668.samples.configuration;

import java.io.IOException;

import com.guidetech.driver.gt668.api.IGT668Slr;
import com.guidetech.driver.gt668.api.exceptions.CardNotInitializedException;
import com.guidetech.driver.gt668.commons.GT668Utils;
import com.guidetech.driver.gt668.core.GT668Slr;
import com.guidetech.driver.gt668.data.utils.Config;

public class ConfigManagement {
	
	static IGT668Slr gt;
	
	static int deviceNumber 	= 0;
	
	static String xmlPath 		= "/path/to/config.xml";
	
	static String bytesPath 	= "/path/to/bytes.ser";
	
	public static void readAndStoreConfig() throws CardNotInitializedException, IOException {	
		//initialize the board
		gt.initialize(deviceNumber);
		
		//read configuration parameters
		Config config = gt.readCurrentConfig(deviceNumber);
		
		//output config string to console
		System.out.println(config.toString());
		
		//store as XML
		GT668Utils.saveConfigAsXML(config, xmlPath);
		
		//store as bytes
		GT668Utils.saveConfigAsBytes(config, bytesPath);
	}
	
	public static void retrieveAndLoadConfig() throws IOException, ClassNotFoundException, CardNotInitializedException {
		//read config from XML
		Config configFromXml = GT668Utils.readConfigFromXml(xmlPath);
		
		//read config from bytes
		Config configFromBytes = GT668Utils.readConfigFromBytes(bytesPath);
		
		//output both config strings to console
		System.out.println("Config from XML: " + configFromXml.toString());
		System.out.println("Config from Bytes: " + configFromBytes.toString());
		
		//load config to card
		gt.loadConfig(deviceNumber, configFromXml);
	}
	
	public static void main(String [] args) throws CardNotInitializedException, IOException, ClassNotFoundException {
		//initialize library object
		gt = new GT668Slr();
		
		//read and store config
		readAndStoreConfig();
		
		//retrieve and load config
		retrieveAndLoadConfig();
		
		//close card
		gt.close();
	}

}
