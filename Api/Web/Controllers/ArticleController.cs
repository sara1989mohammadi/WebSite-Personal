using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using System.Collections.Generic;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public ArticleController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ArticleDto>> Get()
        {
            var list = _serviceManager.ArticleService.GetAll();
            return Ok(list);


        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _serviceManager.ArticleService.GetById(id);
            return Ok(item);

        }
        [HttpPost]
        public IActionResult Post(ArticleDto val)
        {
            _serviceManager.ArticleService.Insert(val);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Upadate(int id)
        {
            _serviceManager.ArticleService.Update(id);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _serviceManager.ArticleService.Delete(id);
            return Ok();
        }
    }
}
