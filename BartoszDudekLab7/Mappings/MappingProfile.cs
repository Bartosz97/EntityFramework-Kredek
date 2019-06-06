using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BartoszDudekLab7.Models;
using BartoszDudekLab7.Models.Dto;

namespace BartoszDudekLab7.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Jumper, GetStatisticJumperDto>();
        }
    }
}
