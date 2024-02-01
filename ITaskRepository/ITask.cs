namespace TaskApi.ITaskRepository
{
    public interface ITask
    {
        //Declare all following functions only for CRUD for Task & SubTask

        // Add a Task
        // Get all Tasks
        // Get a particular Task
        // Edit some Task
        // Delete some task, in case there is no subtask

        // Add a SubTack for a Task
        // Get all subtasks for a particular Task
        // Here in display Task Name, SubtTask Name,Created By, When

        void AddTask(Models.Task task) ;
        List<Models.Task> GetAllTasks();
        Task GetTaskById(int id);
        int UpdateTask(Models.Task task);
        bool DeleteTask(int id);



    }
}
