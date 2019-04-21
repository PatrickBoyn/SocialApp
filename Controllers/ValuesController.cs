﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialAppAPI.Data;
using SocialAppAPI.Models;

namespace SocialAppAPI.Controllers
{
    // The link to hit this controller:
    // http://localhost:5000/api/values
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public IActionResult GetValuesAsync()
        {
            List<Value> values = _context.Values.ToList();
            
            if(values != null)
            {
                return Ok(values);
            }

            return NoContent();
        }
        
        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetValueAsync(int id)
        {
            Value value =  _context.Values.FirstOrDefault(i => i.Id == id);

            if(value != null)
            {
                return Ok(value);
            }

            return NoContent();
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
