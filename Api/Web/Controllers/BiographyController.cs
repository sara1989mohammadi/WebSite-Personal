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
    public class BiographyController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public BiographyController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var list = _serviceManager.BiographyService.GetAll();
            return Ok(list);

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _serviceManager.BiographyService.GetById(id);
            return Ok(item);

        }
        [HttpPost]
        public IActionResult Post(BiographyDto val)
        {
            _serviceManager.BiographyService.Insert(val);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Upadate(int id)
        {
            _serviceManager.BiographyService.Update(id);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _serviceManager.BiographyService.Delete(id);
            return Ok();
        }
    }
}
