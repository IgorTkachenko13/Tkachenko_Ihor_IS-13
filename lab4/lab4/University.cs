using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class University : EducationalInstitution
    {
        List<Faculty> faculties = new List<Faculty>();

        public Faculty CreateFaculty(string nameOfFaculty, int studentsCount, int teachersCount, int yearOfFoundationFaculty)
        {
            Faculty faculty = new Faculty(nameOfFaculty, studentsCount, teachersCount, yearOfFoundationFaculty);
            faculties.Add(faculty);
            return faculty;
        }
        public Faculty CreateFaculty()
        {
            Faculty faculty = new Faculty();
            faculties.Add(faculty);
            return faculty;
        }
        public int FacultyCount()
        {
            return faculties.Count();
        }
        public void CalcNumOfStudents()
        {
            for (int i = 0; i < faculties.Count; i++)
                AllStudentCount += faculties[i].StudentsCount;
        }
        public void CalcNumOfTeachers()
        {
            for (int i = 0; i < faculties.Count; i++)
                AllTeacherCount += faculties[i].TeachersCount;                
        }
        public void YearOfFoundationFaculty()
        {
            for (int i = 0; i < faculties.Count; i++)
            {
                Console.WriteLine(faculties[i].NameOfFaculty + ": " + faculties[i].YearOfFoundationFaculty + "рiк");
            }
        }

        public University(string name, int allStudentCount, int allTeacherCount)
            : base(name, allStudentCount, allTeacherCount)
        {
           
        }
        public University(string name)
            : base(name)
        {
        }
    }
}
