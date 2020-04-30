using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class UniversityStudent : Student
    {
        private string specialized;

        public string Specialized { get => specialized; set => specialized = value; }
    }
}
