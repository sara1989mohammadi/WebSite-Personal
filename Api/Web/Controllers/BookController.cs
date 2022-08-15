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
    public class BookController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public BookController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var list = _serviceManager.BookService.GetAll();
            return Ok(list);

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _serviceManager.BookService.GetById(id);
            return Ok(item);

        }
        [HttpPost]
        public IActionResult Post(BookDto val)
        {
            _serviceManager.BookService.Insert(val);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Upadate(int id)
        {
            _serviceManager.BookService.Update(id);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _serviceManager.BookService.Delete(id);
            return Ok();
        }
    }
}
