using AutoMapper;
using MacierzEinsenhoweraDemo.DAL;
using MacierzEinsenhoweraDemo.Models.DbResults;
using MacierzEinsenhoweraDemo.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MacierzEinsenhoweraDemo.Loaders
{
    public class MatrixLoader : IMatrixLoader
    {
        // Dodać DI
        private readonly MatrixContext _dbContext;

        public MatrixLoader()
        {
            _dbContext = new MatrixContext();
        }

        public TasksDb GetTasks(int arrayID)
        {
            var tasks = Mapper.Map<List<MatrixTask>, List<QuarterItem>>(_dbContext.MatrixTasks.Where(x => x.ArraytID == arrayID).ToList());

            var result = new TasksDb()
            {
                firstQuarter = tasks.Where(x => x.Priority.Equals("WP")).ToList(),
                secondQuarter = tasks.Where(x => x.Priority.Equals("WN")).ToList(),
                thirdQuarter = tasks.Where(x => x.Priority.Equals("NP")).ToList(),
                fourthQuarter = tasks.Where(x => x.Priority.Equals("NN")).ToList()
            };

            return result;
        }

        public void RemoveTask(int taskID)
        {
            var taskToRemove = _dbContext.MatrixTasks.SingleOrDefault(x => x.MatrixTaskID == taskID);

            if (taskToRemove != null)
            {
                _dbContext.MatrixTasks.Remove(taskToRemove);
            }

            _dbContext.SaveChanges();
        }

        public void ChangeQuarter(Models.Dto.DropDto data)
        {
            var task = _dbContext.MatrixTasks.Single(x => x.MatrixTaskID == data.taskID);
            task.Priority = data.Priority;

            _dbContext.SaveChanges();
        }
    }
}