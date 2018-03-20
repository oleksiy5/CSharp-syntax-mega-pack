using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_proj_for_learn.BasicLevel.String
{
    class ExerciseString : IExercise
    {
        private void DisplayMessage(string message)
        {
            string msg = string.Format("To jest tekst: {0}", message);
            Console.WriteLine(msg);
            Console.ReadLine();
        }

        private void DisplayMessageCSharp6(string message)
        {
            string msg = $"To jest tekst (ale C# 6.0): {message}";
            Console.WriteLine(msg);
            Console.ReadLine();
        }

        private void DisplayMessage(string message, int displayCount)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < displayCount; i++)
            {
                sb.AppendLine(string.Format("{0}: {1}", i, message));
            }
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }

        public void StartTest()
        {
            //your place to practice

            DisplayMessage("Jakiś tekst.");

            DisplayMessage("Ala ma kota.", 5);

            DisplayMessageCSharp6("Lubie mróz.");
        }
    }
}
