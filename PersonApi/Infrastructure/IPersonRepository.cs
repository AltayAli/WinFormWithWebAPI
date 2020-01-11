using PersonApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApi.Infrastructure
{
   public  interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetPeopleAsync();
        Task AddPersonAsync(Person person);
        Task UpdatePersonAsync(int id,Person model);
        Task Delete(int id);

    }
}
