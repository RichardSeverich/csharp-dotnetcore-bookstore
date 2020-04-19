using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using csharp_dotnetcore_projects.Models;

namespace csharp_dotnetcore_projects.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {

        private ApplicationDbContext context;

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
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Project";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
