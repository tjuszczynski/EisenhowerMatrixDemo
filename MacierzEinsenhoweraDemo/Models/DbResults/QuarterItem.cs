using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MacierzEinsenhoweraDemo.Models.DbResults
{
    public class QuarterItem
    {
        public QuarterItem(string priority, string title)
        {
            Priority = priority;
            Title = title;
        }

        public int QuarterItemID { get; set; }
        public string Priority { get; set; }
        public string Title { get; set; }
    }
}