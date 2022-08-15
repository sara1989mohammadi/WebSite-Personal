using Contracts;
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
    public class CVController : Controller
    {
        private readonly IServiceManager _serviceManager;
        public CVController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var list = _serviceManager.CVService.GetAll();
            return Ok(list);

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _serviceManager.CVService.GetById(id);
            return Ok(item);

        }
        [HttpPost]
        public IActionResult Post(CVDto val)
        {
            _serviceManager.CVService.Insert(val);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Upadate(int id)
        {
            _serviceManager.CVService.Update(id);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _serviceManager.CVService.Delete(id);
            return Ok();
        }
    }
}