using AspnetIdentityTest.Data.Entity;
using AspnetIdentityTest.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetIdentityTest
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<NgoVM, NGO>();
        }
    }
}
