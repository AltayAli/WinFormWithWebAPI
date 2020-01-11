using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonApi.Infrastructure;
using PersonApi.Models;

namespace PersonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public readonly IPersonRepository repo;
        private readonly IMapper mapper;
        public PersonController(IPersonRepository repo,IMapper mapper)
        {
            this.mapper = mapper;
            this.repo = repo;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetPeople()
        {
            try
            {
                return Ok(await repo.GetPeopleAsync());
            }
            catch (Exception)
            {

                return BadRequest("Emeliyyatda yanlisliq var");
            }
           
        }
        [HttpPost]
        public async Task<IActionResult> AddPerson(ViewModel model)
        {
            try
            {
                var person = mapper.Map<Person>(model);
                await repo.AddPersonAsync(person);
                return Created("", "Data ugurla bazaya elave olundu!");
            }
            catch (Exception)
            {

                return BadRequest("Emeliyyatda yanlisliq var!!!Data bazaya elave olunmadi."); 
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePerson(int id,[FromBody] ViewModel model)
        {
            try
            {
                var person = mapper.Map<Person>(model);
                await repo.UpdatePersonAsync(id, person);
                return Ok($"{id} ID-li data ugurla deysdirildi");
            }
            catch (Exception)
            {

                return BadRequest($"Emeliyyatda yanlisliq var!!!{id} ID-li data deyisdirile bilmedi!!");
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson(int id)
        {
            try
            {
                await repo.Delete(id);
                return Ok($"{id} ID-li  data silindi");
            }
            catch (Exception)
            {

                return BadRequest($"Emeliyyatda yanlisliq var!!!{id} ID-li data siline bilmedi!!");
            }
        }
    }
}