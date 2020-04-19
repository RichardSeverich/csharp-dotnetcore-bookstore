using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using csharp_dotnetcore_projects.Models;

namespace csharp_dotnetcore_projects.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {

        private ApplicationDbContext context;

        // ApplicationDbContext is injected by dependency injection.
        public ProjectsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET api/projects
        [HttpGet]
        public ActionResult<IEnumerable<Project>> Get()
        {
            return context.Projects.ToList();
        }

        // GET api/projects/5
        [HttpGet("{id}", Name = "GetProjectById")]
        public ActionResult<Project> Get(string id)
        {
            var projectFound = context.Projects
                .FirstOrDefault(project => project.Id.Equals(id));
            if (projectFound == null)
            {
                return NotFound();
            }
            return Ok(projectFound);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Project> Post([FromBody] Project value)
        {
            if (ModelState.IsValid)
            {
                context.Projects.Add(value);
                context.SaveChanges();
                return new CreatedAtRouteResult("GetProjectById", new { id = value.Id});
            }
            return BadRequest(ModelState);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Project> Put(string id, [FromBody] Project value)
        {
            var projectFound = context.Projects
                .FirstOrDefault(project => project.Id.Equals(id));
            if (projectFound == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            projectFound.Name = value.Name;
            projectFound.Description = value.Description;
            projectFound.State = value.State;
            projectFound.CreatedDate = value.CreatedDate;
            context.Entry(projectFound).State = EntityState.Modified;
            context.SaveChanges();
            return Ok(projectFound);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<Project> Delete(string id)
        {
            var projectFound = context.Projects
               .FirstOrDefault(project => project.Id.Equals(id));
            if (projectFound == null)
            {
                return NotFound();
            }
            context.Projects.Remove(projectFound);
            context.SaveChanges();
            return Ok();
        }
    }
}
