using System;

namespace GT668Library
{
    public static class StaticMeasFunctions
    {
        public static int GetActDateTimeCnt()
        {
            long tck = DateTime.Now.Ticks / 100000L;
            return (int)tck;
        }
    }

    public class ResultDataClass
    {
        public Guid ID { get; set; }
        public DateTime STAMP { get; set; }
        public double DATASTAMP { get; set; }
        public double VALUE { get; set; }

        public string MEASNAME { get; set; }
    }
    
}
