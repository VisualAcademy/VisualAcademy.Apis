﻿using Microsoft.AspNetCore.Mvc;

namespace VisualAcademy.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        // GET: api/<DocumentsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DocumentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DocumentsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DocumentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DocumentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
