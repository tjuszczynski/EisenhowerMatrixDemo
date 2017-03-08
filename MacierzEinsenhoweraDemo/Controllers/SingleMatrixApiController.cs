using AutoMapper;
using MacierzEinsenhoweraDemo.Loaders;
using MacierzEinsenhoweraDemo.Models.Api;
using MacierzEinsenhoweraDemo.Models.DbResults;
using MacierzEinsenhoweraDemo.Models.Dto;
using System.Web.Http;

namespace MacierzEinsenhoweraDemo.Controllers
{
    public class SingleMatrixApiController : ApiController
    {
        private readonly IMatrixLoader _matrixLoader;

        public SingleMatrixApiController()
        {
            _matrixLoader = new MatrixLoader();
        }

        public MatrixTasksResponse GetTasks()
        {
            //dla testu podaje macierz o ID = 1
            var tasks = _matrixLoader.GetTasks(1);

            return Mapper.Map<TasksDb, MatrixTasksResponse>(tasks);
        }

        [HttpPost]
        public void RemoveTask([FromBody] int taskID)
        {
            _matrixLoader.RemoveTask(taskID);
        }

        [HttpPost]
        public void ChangeQuarter([FromBody] DropDto data)
        {
            _matrixLoader.ChangeQuarter(data);
        }
    }
}
