using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CSharp_proj_for_learn.BasicLevel.String;
// - - -> Olo Technic
namespace CSharp_proj_for_learn
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowIntro(30);

            string command = string.Empty;
            while(command.ToUpper() != "END")
            {
                Console.WriteLine("Get the exercise code:");
                command = Console.ReadLine();
                var exercise = ExerciseFactory.CreateObject(command);
                if (exercise != null)
                    exercise.StartTest();
                else
                    Console.WriteLine($"< {command} > is incorrect exercise code");

            }            
        }

        static void ShowIntro(int countSign)
        {
            Console.Clear();
            for (int i= 0; i <= countSign; i++)
            {
                Console.Write("*");
                Thread.Sleep(10);
            }
            Console.WriteLine("");
            Console.WriteLine(".NET and C# project for learn");
            Console.WriteLine("");
            for (int i = 0; i <= countSign; i++)
            {
                Console.Write("*");
                Thread.Sleep(20);
            }
            Console.WriteLine("");
        }
    }
}
