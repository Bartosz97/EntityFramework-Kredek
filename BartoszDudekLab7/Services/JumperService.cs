using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BartoszDudekLab7.Models;
using BartoszDudekLab7.Models.Dto;

namespace BartoszDudekLab7.Services
{
    public class JumperService : IJumperService
    {
        private readonly SkiJumpingContext _context;
        private readonly IMapper _mapper;
        public JumperService(SkiJumpingContext context, IMapper mapper)
        {
            _context = context;
            _mapper =  mapper;
        }
        public GetStatisticJumperDto GetStatisticJumper(int id)
        {
            var jumper = _context.Jumpers.FirstOrDefault(c => c.Id == id);

            var statisticDto = _mapper.Map<GetStatisticJumperDto>(jumper);

            return statisticDto;
        }
    }
}
