using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class School
    {
        public School() {
            Teachers = new List<Teacher>();
        }
        public int SchoolId { get; set; }
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
