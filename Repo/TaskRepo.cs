using TaskApi.DataContext;
using TaskApi.ITaskRepository;
using TaskApi.Models;

namespace TaskApi.Repo
{
    public class TaskRepo: ITask
    {
        TaskDbContext _context;
        public TaskRepo(TaskDbContext context)
        {
            _context = context;
        }

        public void AddTask(Models.Task task)
        {
            task.CreatedOn = DateTime.Now;
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public bool DeleteTask(int id)
        {
            var data = _context.Tasks.Where(x=>x.Id == id).SingleOrDefault();
            if(data==null)
            {
                return false;
            }

            else
            {
                _context.Tasks.Update(data);
                _context.SaveChanges();
                return true;
            }
        }
        public List<Models.Task> GetAllTasks()
        {
            var data = _context.Tasks.ToList();
            return data;
        }

        public Models.Task GetTaskById(int id)
        {
            var data = _context.Tasks.Where(x=>x.Id==id).FirstOrDefault();
            return data;
        }

        public int UpdateTask(Models.Task task)
        {
            var data = _context.Tasks.Where(x=>x.Id==task.Id).SingleOrDefault();
            if(data==null)
            {
                return 0;
            }
            else
            {
                data.Name = task.Name;
                data.Description = task.Description;
                _context.Tasks.Update(data);
                _context.SaveChanges();
                return 1;
            }
        }

        System.Threading.Tasks.Task ITask.GetTaskById(int id)
        {
            throw new NotImplementedException();
        }
    }
}


