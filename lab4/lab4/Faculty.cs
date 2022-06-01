using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Faculty
    {
        public string NameOfFaculty { get; private set; }
        public int StudentsCount { get; private set; }
        public int TeachersCount { get; private set; }
        public int YearOfFoundationFaculty { get; private set; }

        public void EnterNameOfFaculty()
        {
            Console.Write("Введiть назву факультету -> ");
            NameOfFaculty = Console.ReadLine();
        }
        public void EnterStudentsCount()
        {
            Console.Write("Введiть кiлькiсть студентiв -> ");
            StudentsCount = Convert.ToInt32(Console.ReadLine());
        }
        public void EnterTeachersCount()
        {
            Console.Write("Введiть кiлькiсть викладачiв -> ");
            TeachersCount = Convert.ToInt32(Console.ReadLine());
        }
        public void EnterYearOfFoundationFacultyt()
        {
            Console.Write("Введiть рiк заснування факультету -> ");
            YearOfFoundationFaculty = Convert.ToInt32(Console.ReadLine());
        }

        public Faculty(string nameOfFaculty, int studentsCount, int teachersCount, int yearOfFoundationFaculty)
        {
            NameOfFaculty = nameOfFaculty;
            StudentsCount = studentsCount;
            TeachersCount = teachersCount;
            YearOfFoundationFaculty = yearOfFoundationFaculty;
        }
        public Faculty()
        {
        }

    }
}
