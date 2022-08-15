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
    public class ShortArticleController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public ShortArticleController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var list = _serviceManager.ShortArticleService.GetAll();
            return Ok(list);

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _serviceManager.ShortArticleService.GetById(id);
            return Ok(item);

        }
        [HttpPost]
        public IActionResult Post(ShortArticleDto val)
        {
            _serviceManager.ShortArticleService.Insert(val);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Upadate(int id)
        {
            _serviceManager.ShortArticleService.Update(id);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _serviceManager.ShortArticleService.Delete(id);
            return Ok();
        }
    }
}
