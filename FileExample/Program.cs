using System;
using System.IO;

namespace FileExample
{
    // Collin McGhee
    class Program
    {
        static void Main(string[] args)
        {
            // @ symbol means to read everything literally
            // this helps the computer configure around the \
            string filepath = @"C:\RandomFiles\Pride and Prejudice by Jane Austen.txt";

            var lines = File.ReadAllLines(filepath);

            /* Reads file into one single string
            string contentsOfFile = File.ReadAllText(filepath);
            Console.WriteLine(contentsOfFile); */

            // Outputs every 5th line
            //var lines = File.ReadAllLines(filepath);
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    if (i % 5 == 0 && i != 0)
            //    {
            //        Console.ReadKey();
            //    }
            //    Console.WriteLine(lines[i]);
            //}
            //Console.WriteLine(lines);


            //Outputs a chapter at a time
            for (int i = 0; i < lines.Length; i++)
            {
                string currentline = lines[i];
                if (currentline.Contains("Chapter"))
                {
                    Console.ReadKey();
                }
                Console.WriteLine(currentline);
            }
        }
    }
}
