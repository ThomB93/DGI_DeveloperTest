using AutoMapper;
using DeveloperTest.Models;
using DeveloperTest.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperTest.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Resource to Domain mapping - used when modifying/creating data
            CreateMap<DistinctTextRequestResource, DistinctText>();
        }
    }
}
