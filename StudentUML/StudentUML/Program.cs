using System;

namespace StudentUML
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 student = new Class1();
            student.FirstName = "Collin";
            student.LastName = "McGhee";
            student.IsOnProbation = false;
            student.SoonerID = 113433631;

            Console.WriteLine(student);
            Console.ReadKey();

        }
    }
}
