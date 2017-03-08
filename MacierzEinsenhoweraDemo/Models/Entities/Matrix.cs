using System.Collections.Generic;

namespace MacierzEinsenhoweraDemo.Models.Entities
{
    public class Matrix
    {
        public Matrix() { }
        public Matrix(string name)
        {
            Name = name;
        }
        public int MatrixID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MatrixTask> Tasks { get; set; }
    }
}