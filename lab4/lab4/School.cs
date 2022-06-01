using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class School : EducationalInstitution
    {
        public int ClassCount { get; set; }


        public School (string name, int allStudentCount)
            :base(name, allStudentCount)
        {
            ClassCount = allStudentCount / 15;
        }
    }
}
