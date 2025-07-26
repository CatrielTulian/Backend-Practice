using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Persons
    {
        public int Id { get; set; }
        public string? Name { get; set;}
        public string? Surname { get; set; }

        public List<Tasks>? Tasks { get; set; }
        public string User {  get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
