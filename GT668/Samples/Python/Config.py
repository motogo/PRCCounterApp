from GT668Driver import *
from pprint import pprint

#initialize driver
gt = GT668Driver()

#initialize card
gt.initialize(0)

#read current config
config = gt.read_current_config(0)

#pretty print current config
pprint(config)

#store config as json
GT668Utils.save_config_to_file(config, "/path/to/config.json")

#read config from file
readConfig = GT668Utils.read_config_from_file("/path/to/config.json")

#pretty print read config
pprint(readConfig)

#load config to the card
gt.load_config(0, readConfig)

#free card
gt.close()
