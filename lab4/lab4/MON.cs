using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class MON
    {
        List<School> schools= new List<School>();
        List<University> universities= new List<University>();
        List<EducationalInstitution> educationalInstitutions = new List<EducationalInstitution>();

        public School AddSchool(string name, int allStudentCount)
        {
            School school = new School(name, allStudentCount);
            educationalInstitutions.Add(school);
            schools.Add(school);
            return school;
        }
        public University AddUniversity(string name, int allStudentCount, int allTeacherCount)
        {
            University university = new University(name, allStudentCount, allTeacherCount);
            educationalInstitutions.Add(university);
            universities.Add(university);
            return university;
        }

        public int AverageCountOfStudent()
        {
            int averageCount;
            int allCount = 0;
            for (int i = 0; i < universities.Count; i++)
            {
                allCount += universities[i].AllStudentCount;
            }
            averageCount = allCount / universities.Count();
            return averageCount;
        }
        public int AverageCountOfPupil()
        {
            int averageCount;
            int allCount = 0;
            for (int i = 0; i < schools.Count; i++)
            {
                allCount += schools[i].AllStudentCount;
            }
            averageCount = allCount / schools.Count();
            return averageCount;
        }
        public int  AllCountOfStudent()
        {
            int allCount = 0;
            for (int i = 0; i < universities.Count; i++)
            {
                allCount += universities[i].AllStudentCount;
            }
            return allCount;
        }
        public int AllCountOfPupil()
        {
            int allCount = 0;
            for (int i = 0; i < schools.Count; i++)
            {
                allCount += schools[i].AllStudentCount;
            }
            return allCount;
        }
    }
}
