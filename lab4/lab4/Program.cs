using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            University kpi = new University("КПI");
            #region Факультети
            kpi.CreateFaculty("ФIОТ", 2250, 260, 1962);
            kpi.CreateFaculty("ФПМ", 1000, 110, 1967);
            kpi.CreateFaculty("ФТI", 700, 80, 1995);
            #endregion

            School school = new School("Загальноосвiтня школа", 400);

            Console.WriteLine("Виберiть навчальний заклад: \n1) Унiверситет (КПI) \n2) Школа");
            int change = Convert.ToInt32(Console.ReadLine());
            bool bl = true;

            if (change == 1)
            {
                Console.WriteLine("Виберiть бажану операцiю:" +
                       "\n1) Вивести загальну кiлькiсть студентiв" +
                       "\n2) Вивести загальну кiлькiсть викладачiв" +
                       "\n3) Вивести кiлькiсть факультетiв" +
                       "\n4) Рiк заснування факультетiв" +
                       "\n5) Вихiд");
            }
            else if (change == 2)
            {
                Console.WriteLine("Виберiть бажану операцiю:" +
                      "\n1) Вивести загальну кiлькiсть учнiв" +
                      "\n2) Вивести загальну кiлькiсть вчителiв" +
                      "\n3) Вивести кiлькiсть класiв" +
                      "\n4) Вихiд");
            }
            else
            {
                Console.WriteLine("Вибiр здiйснено невiрно!!!");
            }

            do
            {
                if (change == 1)
                {
                    int changeOperation = Convert.ToInt32(Console.ReadLine());
                    switch (changeOperation)
                    {
                        case 1:
                            kpi.CalcNumOfStudents();
                            Console.WriteLine($"{kpi.AllStudentCount} студентiв");
                            break;
                        case 2:
                            kpi.CalcNumOfTeachers();
                            Console.WriteLine($"{kpi.AllTeacherCount} викладачiв");
                            break;
                        case 3:
                            Console.WriteLine(kpi.FacultyCount() + " факультети");
                            break;
                        case 4:
                            kpi.YearOfFoundationFaculty();
                            break;
                        case 5:
                            bl = false;
                            break;
                        default: break;
                    }

                }
                else if (change == 2)
                {
                    int changeOperation = Convert.ToInt32(Console.ReadLine());
                    switch (changeOperation)
                    {
                        case 1:
                            Console.WriteLine(school.AllStudentCount + " студентiв");
                            break;
                        case 2:
                            Console.WriteLine(school.AllTeacherCount + " викладачiв");
                            break;
                        case 3:
                            Console.WriteLine(school.ClassCount + " класiв");
                            break;
                        case 4: bl = false; break;
                        default: break;
                    }
                }
                else
                {
                    Console.WriteLine("Вибiр здiйснено невiрно!!!");
                    bl = false;
                }
            }
            while (bl);
        }
    }
}
