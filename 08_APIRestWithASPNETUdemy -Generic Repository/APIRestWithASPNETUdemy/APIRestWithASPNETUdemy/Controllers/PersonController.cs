using APIRestWithASPNETUdemy.Model;
using APIRestWithASPNETUdemy.Business.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIRestWithASPNETUdemy.Business;

namespace APIRestWithASPNETUdemy.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private IPersonBusiness _personbusiness;



        public PersonController(ILogger<PersonController> logger, IPersonBusiness personBusiness)
        {

            _logger = logger;
            _personbusiness = personBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_personbusiness.FindAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personbusiness.FindById(id);
            if (person == null) return NotFound();


            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            
            if (person == null) return BadRequest();


            return Ok(_personbusiness.Create(person));
        } 
        
        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            
            if (person == null) return BadRequest();


            return Ok(_personbusiness.Update(person));
        }
        [HttpDelete("{id}")]
        public IActionResult Deletet(long id)
        {
            _personbusiness.Delete(id);
           

            return NoContent();
        }


    }
}
