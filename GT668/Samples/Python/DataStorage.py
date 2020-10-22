from GT668Driver import *


gt = GT668Driver()
gt.initialize(0)

# size of array per channel
size = 10

# read timeout
timeout = 10.0

# configure inputs
gt.set_input_prescale(GT668.Signal.GT_SIG_A, GT668.Prescale.GT_DIV_1)
gt.set_input_threshold(GT668.Signal.GT_SIG_A, GT668.ThresholdMode.GT_THR_VOLTS, 0.0)

# configure inputs
gt.set_input_prescale(GT668.Signal.GT_SIG_B, GT668.Prescale.GT_DIV_1)
gt.set_input_threshold(GT668.Signal.GT_SIG_B, GT668.ThresholdMode.GT_THR_VOLTS, 0.0)

#read tags up to 100 tags on either channel
gt.start_measurements()

# initialize timetags set object
timetagsSet = TimetagsSet(channel0Size=size, channel1Size=size)

# read time
start_time = gt.read_sys_time()

# the measurement will last untill the timeout
while gt.read_sys_time() - start_time < timeout:
    gt.read_timetags(timetagsSet)

    # when both channels have the specified tags count, terminates
    if timetagsSet.channel0Count == timetagsSet.channel0Size and timetagsSet.channel1Count == timetagsSet.channel1Size:
        break

#free card
gt.close()

#store as time aligned two row csv
GT668DataUtils.save_tags_to_time_aligned_two_collumns_CSV(timetagsSet, ',', "ch0", "ch1", "/path/to/simple_two_column.csv")

#store as simple csv
GT668DataUtils.save_tags_as_simple_csv(timetagsSet, True, "/path/to/simple.csv", ",")

#store as simple txt
GT668DataUtils.save_tags_as_simple_text(timetagsSet, True, "/path/to/simple.txt")

#store as formatted file
dff = Data_Format_Factory()

dff.file_type = File_Type.csv               #optional: default CSV
dff.tags_per_file = 50                      #optional: default -1 (save all tags in single file)
dff.delimiter = ';'                         #optional: default ','
dff.empty_tag_representation = "n/a"        #optional: default "---"
dff.file_name = "Some_file_name"            #optional: default GT668Tags
dff.restart_numbering_in_new_file = True    #optional: default false
dff.include_row_numbering = True            #optional: default true
dff.header = "HEADER"                       #optional: default None (no header)
dff.store_header_in_each_file = True        #optional: default false

#cell initialization
c1 = Cell()
c2 = Cell()
c3 = Cell()
c4 = Cell()

#single cell consists of prefix Var [either tags from channel 0 or 1] and suffix
#each cell can have all or just one of above fields
#cells are separated by Data_Format_Factory.delimiter field value

c1.prefix = "prefix"

c2.prefix = "pre_before_tag_value: "
c2.var = Var.ch_0_tags

c3.var = Var.ch_1_tags

c4.suffix = "suffix"

#row definition
dff.row = [c1, c2, c3, c4]                  #required: sets row definition, see documentation for details

GT668DataUtils.save_tags_with_formatting(timetagsSet, dff, "/path/to/")