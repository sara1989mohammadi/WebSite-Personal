using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class ActivityController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public ActivityController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<ActivityDto>> Get()
        {
            var list = _serviceManager.ActivityService.GetAll();
           return Ok( list);
           

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _serviceManager.ActivityService.GetById(id);
            return Ok(item);

        }
        [HttpPost]
        public IActionResult Post(ActivityDto val)
        {
            _serviceManager.ActivityService.Insert(val);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Upadate(int id)
        {
            _serviceManager.ActivityService.Update(id);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _serviceManager.ActivityService.Delete(id);
            return Ok();
        }
    }
}
