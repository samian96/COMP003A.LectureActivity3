using System.Net.Cache;

namespace COMP003A.LectureActivity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SECTION A - Academic Term Identification");

            int currentMonth = DateTime.Now.Month;
            // if else if else is used to check which statement is true
            // passes from top to bottom to check which is a true statement, if first statement true the rest will not execute and be skipped
            if (currentMonth >= 1 && currentMonth <= 5)
            { 
                Console.WriteLine(currentMonth + " " + "Spring Term");
            }
            else if (currentMonth >=6 && currentMonth <=7)
            {
                Console.WriteLine(currentMonth + " " + "Summer Term");
            }
            else
            {
                Console.WriteLine(currentMonth + " " + "Fall Term");
            }

            Console.WriteLine("\n                          ");

            Console.WriteLine("SECTION B - Campus Access Check");

            Console.WriteLine("\n                          ");
          
            int age =18;

            Console.WriteLine("Please enter your age");

            string ageInput = Console.ReadLine();

            Console.WriteLine("Are you currently enrolled? (yes/no)");

            string idInput = Console.ReadLine();

            bool hasStudentId = idInput.ToLower() == "yes";

            if (age >= 18)
            {
                Console.WriteLine("Campus access granted");
                if (hasStudentId = yes)
                {
                    Console.WriteLine("Campus access granted");
                }
                else
                {
                    Console.WriteLine("Campus acces denied");
                }
            }
            else
            {
                Console.WriteLine("Campus access denied");
            }


                Console.WriteLine("\n                           ");

            Console.WriteLine("SECTION C - Semester Code Loopup");
        }
    }
}
