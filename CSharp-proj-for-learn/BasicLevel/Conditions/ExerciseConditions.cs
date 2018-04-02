using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_proj_for_learn.BasicLevel.Conditions
{
    class ExerciseConditions : IExercise
    {
        public void StartTest()
        {
            TestIf();
            TestSwitch();
        }

        void TestIf()
        {
            string yourName = Console.ReadLine();

            Console.WriteLine($"--1--{Environment.NewLine}");
            if (!string.IsNullOrEmpty(yourName))
            {
                Console.WriteLine($"Hi {yourName}");
            }
            else
            {
                Console.WriteLine("Your name is empty");
            }

            Console.WriteLine($"--2--{Environment.NewLine}");
            if (!string.IsNullOrEmpty(yourName))            
                Console.WriteLine($"Hi {yourName}");            
            else            
                Console.WriteLine("Your name is empty");

            Console.WriteLine($"--3--{Environment.NewLine}");
            string displayMessage = !string.IsNullOrEmpty(yourName) ? $"Hi {yourName}" : "Your name is empty";
            Console.WriteLine(displayMessage);

            Console.WriteLine($"--4--{Environment.NewLine}");
            Console.WriteLine(displayMessage ?? "is empty");
            displayMessage = null;
            Console.WriteLine(displayMessage ?? "is empty");
        }

        void TestSwitch()
        {
            string countryName = "";
            while (countryName != "end")
            {
                countryName = Console.ReadLine();

                switch (countryName.ToUpper())
                {
                    case "POLAND":
                        Console.WriteLine("Population 40M");
                        break;
                    case "ESTONIA":
                        Console.WriteLine("Population 5M");
                        break;
                    case "SLOVAKIA":
                        Console.WriteLine("Population 1.3M");
                        break;
                    default:
                        Console.WriteLine($"The {countryName} doesn't exist");
                        break;
                }
            }
        }
    }
}
