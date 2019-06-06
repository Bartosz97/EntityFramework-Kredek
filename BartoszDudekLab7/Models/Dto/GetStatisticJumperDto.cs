using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartoszDudekLab7.Models.Dto
{
    public class GetStatisticJumperDto
    {
        public int Id { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public float PersonalBest { get; set; }
    }
}
