using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using todos_core.Models;

namespace todos_core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private int _numTodos = 5;

        [HttpGet]
        public IEnumerable<Todo> GetAll()
        {
            return Enumerable.Range(1, _numTodos).Select(index => new Todo
            {
                Id = index,
                CreatedOn = System.DateTime.Now.AddDays(-index),
                CreatedBy = "system",
                Title = $"title{index}"
            }).ToArray();
        }

        [HttpGet]
        [Route("{id}")]
        public Todo GetById(long id)
        {
            return new Todo
            {
                Id = id,
                CreatedOn = System.DateTime.Now.AddDays(-id),
                CreatedBy = "system",
                Title = $"title{id}"
            };
        }

        [HttpPost]
        public bool Save([FromBody] Todo todo)
        {
            _numTodos++;
            return true;
        }
    }
}
