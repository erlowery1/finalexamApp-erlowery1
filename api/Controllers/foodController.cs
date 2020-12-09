using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Controllers.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class foodController : ControllerBase
    {
        // GET: api/food
        [HttpGet]
        public string Get()
        {
            Pasta pasta = new Pasta();
            string message = pasta.Boil();
            return message;
        }

        // GET: api/food/5
        [Route("/Chicago")]
        [HttpGet("{id}", Name = "Get")]
        public string GetChicago()
        {
            Chicago chicago = new Chicago();
            string message = chicago.Cook();
            return message;
        }

        [Route("/Deep")]
        [HttpGet("{id}", Name = "Get")]
        public string GetDeep()
        {
            DeepDish deep = new DeepDish();
            string message = deep.Cook();
            return message;
        }

        // POST: api/food
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/food/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
