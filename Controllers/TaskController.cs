using Microsoft.AspNetCore.Mvc;
using TaskApi.ITaskRepository;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        // Add required dependencies here
        ITask _repo;

        public TaskController(ITask repo)
        {
            _repo = repo;
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Models.Task task) 
        { 
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            else
            {
                _repo.AddTask(task);
                return Ok("Added Sucessfully");
            }
        }

        [HttpPost]
        [Route("GetAll")]

        public IActionResult GetAll ()
        {
            var data = _repo.GetAllTasks();
            if(data == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(data);
            }
        }

        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            if(id==0)
            {
                return NotFound();
            }
            else
            {
                var data = _repo.GetTaskById(id);
                if(data == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(data);
                }
            }
        }

        [HttpPost]
        [Route("Update")]
        public IActionResult Update(Models.Task task)
        {
            var data = _repo.UpdateTask(task);

            if(data==0)
            {
                return BadRequest();
            }
            else
            {
                return Ok("Updated");
            }
        }

        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            bool data = _repo.DeleteTask(id);
            if(data==false)
            {
                return NotFound();
            }
            else
            {
                return Ok(data);
            }
        }
    }
}
