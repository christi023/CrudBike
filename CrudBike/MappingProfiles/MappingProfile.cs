using CrudBike.Controllers.Resources;
using CrudBike.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudBike.MappingProfiles
{
    public class MappingProfile:Profile
    {        public MappingProfile()
        {
            CreateMap<Model, ModelResources>();
        }
    }
}
