using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Persons
    {
        public int personId { get; set; }
        public string? name { get; set;}
        public string? surname { get; set; }

        public List<Tasks>? tasks { get; set; }
    }
}
