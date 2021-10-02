using System.Collections.Generic;
using WebAPIService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController: ControllerBase
    {
        private static List<Character> characters = new List<Character> 
        {
            new Character(),
            new Character { Id = 1, Name = "Sam" }
        };

        //Return character list
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(characters);
        } 

        //Return sigle character
        [HttpGet("{id}")]
        public IActionResult GetSigle(int Id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }
    }
}