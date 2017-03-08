using System.Collections.Generic;

namespace MacierzEinsenhoweraDemo.Models.Api
{
    public class MatrixTasksResponse
    {
    public MatrixTasksResponse() { }

    public List<MatrixQuarter> firstQuarter { get; set; }
    public List<MatrixQuarter> secondQuarter { get; set; }
    public List<MatrixQuarter> thirdQuarter { get; set; }
    public List<MatrixQuarter> fourthQuarter { get; set; }
    }
}