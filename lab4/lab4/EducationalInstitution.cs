using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class EducationalInstitution
    {
        public int AllStudentCount { get; set; }
        public int AllTeacherCount { get; set; }
        public string Name { get; set; }

        public EducationalInstitution(string name, int allStudentCount, int allTeacherCount)
        {
            AllStudentCount = allStudentCount;
            AllTeacherCount = allTeacherCount;
            Name = name;
        }
        public EducationalInstitution(string name)
        {
            Name = name;
        }
        public EducationalInstitution()
        {
        }
        public EducationalInstitution(string name, int allStudentCount)
        {
            Name = name;
            AllStudentCount = allStudentCount;
            AllTeacherCount = allStudentCount / 13 + 2;
        }
    }
}
