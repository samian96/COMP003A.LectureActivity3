namespace COMP003A.LectureActivity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SECTION A - Academic Term Identification");

            int currentMonth = DateTime.Now.Month;

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

                Console.WriteLine("SECTION B - Campus Access Check");

            Console.WriteLine("SECTION C - Semester Code Loopup");
        }
    }
}
