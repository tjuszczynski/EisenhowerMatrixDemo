namespace MacierzEinsenhoweraDemo.Models.Api
{
    public class MatrixQuarter
    {
    public MatrixQuarter() { }
        public MatrixQuarter(string priority, string title)
        {
            Priority = priority;
            Title = title;
        }

        public int MatrixQuarterID { get; set; }
        public string Priority { get; set; }
        public string Title { get; set; }
    }
}