using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BartoszDudekLab7.Models.Dto;

namespace BartoszDudekLab7.Services
{
    public interface IJumperService
    {
        GetStatisticJumperDto GetStatisticJumper(int id);
    }
}
