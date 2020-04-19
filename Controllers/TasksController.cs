using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ApplicationDbContext = csharp_dotnetcore_projects.Models.ApplicationDbContext;
using Task = csharp_dotnetcore_projects.Models.Task;

namespace csharp_dotnetcore_projects.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {

        private ApplicationDbContext context;

        // ApplicationDbContext is injected by dependency injection.
        public TasksController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET api/tasks
        [HttpGet]
        public ActionResult<IEnumerable<Task>> Get()
        {
            return context.Tasks.ToList();
        }

        // GET api/tasks/5
        [HttpGet("{id}", Name = "GetTaskById")]
        public ActionResult<Task> Get(string id)
        {
            var taskFound = context.Tasks
                .FirstOrDefault(task => task.Id.Equals(id));
            if (taskFound == null)
            {
                return NotFound();
            }
            return Ok(taskFound);
        }

        // POST api/tasks
        [HttpPost]
        public ActionResult<Task> Post([FromBody] Task value)
        {
            if (ModelState.IsValid)
            {
                context.Tasks.Add(value);
                context.SaveChanges();
                return new CreatedAtRouteResult("GetTaskById", new { id = value.Id });
            }
            return BadRequest(ModelState);
        }

        // PUT api/tasks/5
        [HttpPut("{id}")]
        public ActionResult<Task> Put(string id, [FromBody] Task value)
        {
            var taskFound = context.Tasks
                .FirstOrDefault(task => task.Id.Equals(id));
            if (taskFound == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            taskFound.Name = value.Name;
            taskFound.Description = value.Description;
            taskFound.State = value.State;
            taskFound.CreatedDate = value.CreatedDate;
            context.Entry(taskFound).State = EntityState.Modified;
            context.SaveChanges();
            return Ok(taskFound);
        }

        // DELETE api/tasks/5
        [HttpDelete("{id}")]
        public ActionResult<Task> Delete(string id)
        {
            var taskFound = context.Tasks
               .FirstOrDefault(task => task.Id.Equals(id));
            if (taskFound == null)
            {
                return NotFound();
            }
            context.Tasks.Remove(taskFound);
            context.SaveChanges();
            return Ok();
        }
    }
}
