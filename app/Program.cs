using System;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hello");
            Random rnd = new Random();
            for (int i = 0; i == 50; i++ ){
                int[] grades = {rnd.Next(0,100)};
                Console.WriteLine(grades);
            }
            
        }
    }
}
