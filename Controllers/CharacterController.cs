using System.Collections.Generic;
using WebAPIService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using WebAPIService.Services.CharacterService;
using System.Threading.Tasks;
using WebAPIService.Dtos.Character;

namespace WebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController: ControllerBase
    {
        private readonly ICharacterService _characterService;

         public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
            
        }

        //Return character list method
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        //Return sigle character method
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSigle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        //Add Character method
        [HttpPost]
        public async Task<IActionResult> AddCharcter(AddCharacterDto newCharacter) 
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        //Update Character method
        [HttpPut]
        public async Task<IActionResult> UpdatedCharacter(UpdateCharacterDto updatedCharacter) 
        {
            return Ok(await _characterService.UpdateCharacter(updatedCharacter));
        }
    }
}