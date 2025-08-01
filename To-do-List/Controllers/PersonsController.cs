﻿using Application.Interfaces;
using Contract.Persons.Request;
using Contract.Persons.Response;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace To_do_List.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonsController : Controller
    {
        private readonly IPersonsService _personsService;

        public PersonsController(IPersonsService personsService)
        {
            _personsService = personsService;
        }

        [HttpPost]
        
        public IActionResult CreatePerson([FromBody] PersonRequest person)
        {
            _personsService.CreatePerson(person);
            return Ok();
        }

        [HttpGet]
        
        public IActionResult GetAllPersons()
        {
            var Response = _personsService.GetAllPersons();
            if (Response.Count is 0)
            {
                return NotFound("No registered persons were found in the database");
            }
            return Ok(Response);
        }
        [HttpGet("{id}")]
        
        public ActionResult<PersonResponse?> GetPersonById([FromRoute] int Id)
        {
            var response = _personsService.GetPersonById(Id);

            if (response is null)
            {
                return NotFound("That person with that ID does not exist");
            }
            return Ok(response);
        }

        [HttpPut("{id}")]
        
        public ActionResult<bool> UpdatePerson([FromRoute] int Id, [FromBody] PersonRequest Person)
        {
            return Ok(_personsService.UpdatePerson(Id, Person));
        }

        [HttpDelete("{id}")]
        
        public ActionResult<bool> DeletePerson([FromRoute] int Id) 
        {
            return Ok(_personsService.DeletePerson(Id));
        }
    }
}
