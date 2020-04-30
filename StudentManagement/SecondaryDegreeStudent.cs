using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class SecondaryDegreeStudent : Student
    {
        private string firstDegree;
        private string workPlace;

        public string FirstDegree { get => firstDegree; set => firstDegree = value; }
        public string WorkPlace { get => workPlace; set => workPlace = value; }

    }
}
