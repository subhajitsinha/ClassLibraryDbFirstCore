using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class Teacher
    {
        public Teacher() {
            Students = new List<Student>();
        }
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
        public List<Student> Students { get; set; }
    }
}
