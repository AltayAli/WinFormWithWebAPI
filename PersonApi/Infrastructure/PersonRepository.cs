using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PersonApi.Models;
using PersonApi.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApi.Infrastructure
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PersonAPIDBContext personAPIDBContext;

        public PersonRepository(PersonAPIDBContext personAPIDBContext)
        {
            this.personAPIDBContext = personAPIDBContext;
        }
        public async Task AddPersonAsync(Person person)
        { 
          
            await personAPIDBContext.People.AddAsync(person);
            await personAPIDBContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var item = personAPIDBContext.People.Find(id);
            personAPIDBContext.People.Remove(item);
            await personAPIDBContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Person>> GetPeopleAsync()
        {
            return await personAPIDBContext.People.ToListAsync();
        }

        public async Task UpdatePersonAsync(int id,Person model)
        {
            var item = personAPIDBContext.People.Find(id);
            item.Email = model.Email;
            item.Name = model.Name;
            item.Surname = model.Surname;
            await personAPIDBContext.SaveChangesAsync();
        }
    }
}
