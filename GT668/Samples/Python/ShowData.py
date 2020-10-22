"""
This example shows how to read and display time tags.
Please note that using the API to access the tags can 
be slower than working directly on the internal lists.
Examples of both approcheas are shown below.
"""
from GT668Driver import GT668Driver, GT668, TimetagsSet, RealTimetagsSet, RawTimetagsSet
import time
import sys

# variables
timeout = 10.0
size = 10     # size of array per channel

# initialize the driver
gt = GT668Driver()
gt.initialize(0)
timetagsSet = TimetagsSet(channel0Size=size, channel1Size=size)     # initialize timetags set object

# start measurement
gt.start_measurements()     # reset measurement memory
start_time = gt.read_sys_time()

# the measurement will last untill the timeout
while gt.read_sys_time() - start_time < timeout:
    gt.read_timetags(timetagsSet)

    # when both channels have the specified tags count, terminates 
    if timetagsSet.channel0Count == timetagsSet.channel0Size and timetagsSet.channel1Count == timetagsSet.channel1Size:
        break

# check for errors
err = gt.get_error()
if err != 0:
    print("Error: ", gt.get_error_message(err))

if err != 0:
    gt.close()
    print(gt.get_error_message(err))
    sys.exit(0)
else:
    print( "No errors, continuing...")

step = 1

# DISPLAYING TAGS USING THE API ==========================================
channel_0_tags = timetagsSet.get_tags(0, step=step)
channel_1_tags = timetagsSet.get_tags(1, step=step)

#show samples
print("Index       Channel 0              Channel 1")
print("=============================================")

for i, sample in enumerate(zip(channel_0_tags, channel_1_tags)):
    print("{0: >4}:       {1: <20}   {2: <20}".format(i*step, sample[0], sample[1]))
print("=============================================\n")

# DISPLAYING TAGS USING VARIABLES ==========================================
channel_0_tags = [tag for tag in timetagsSet.channel0Tags[::step]] 
channel_1_tags = [tag for tag in timetagsSet.channel1Tags[::step]]

#show samples
print("Index       Channel 0              Channel 1")
print("=============================================")

for i, sample in enumerate(zip(channel_0_tags, channel_1_tags)):
    print("{0: >4}:       {1: <20}   {2: <20}".format(i*step, sample[0], sample[1]))
print("=============================================")