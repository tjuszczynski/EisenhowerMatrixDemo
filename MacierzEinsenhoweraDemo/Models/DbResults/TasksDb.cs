using System.Collections.Generic;

namespace MacierzEinsenhoweraDemo.Models.DbResults
{
    public class TasksDb
    {
        public List<QuarterItem> firstQuarter { get; set; }
        public List<QuarterItem> secondQuarter { get; set; }
        public List<QuarterItem> thirdQuarter { get; set; }
        public List<QuarterItem> fourthQuarter { get; set; }
    }
}