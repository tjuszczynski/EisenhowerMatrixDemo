using MacierzEinsenhoweraDemo.Models.DbResults;

namespace MacierzEinsenhoweraDemo.Loaders
{
    public interface IMatrixLoader
    {
        TasksDb GetTasks(int arrayID);

        void RemoveTask(int taskID);

        void ChangeQuarter(Models.Dto.DropDto data);
    }
}
