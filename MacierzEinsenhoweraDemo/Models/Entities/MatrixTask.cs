namespace MacierzEinsenhoweraDemo.Models.Entities
{
    public class MatrixTask
    {
        public MatrixTask() { }
        public MatrixTask(string priority, string title, int id)
        {
            Priority = priority;
            Title = title;
            ArraytID = id;
        }

        public int MatrixTaskID { get; set; }
        public int ArraytID { get; set; }
        public string Priority { get; set; }
        public string Title { get; set; }
        public virtual Matrix Arrayt { get; set; }
    }
}
