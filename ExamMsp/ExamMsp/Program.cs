using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMsp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            ShowRandomNumber();
            Console.ReadLine();
        }

        static void ShowRandomNumber()
        {
            Random rand = new Random();
            Console.WriteLine(rand.Next());
        }
    }
}
