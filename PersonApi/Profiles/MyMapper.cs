using AutoMapper;
using AutoMapper;
using PersonApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApi.Profiles
{
    public class MyMapper : Profile
    {
        public MyMapper()
        {
            this.CreateMap<Person, ViewModel>().ReverseMap();
        }
    }
}
