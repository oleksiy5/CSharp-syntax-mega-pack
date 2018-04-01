using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_proj_for_learn.BasicLevel.Loop
{
    //Olo Technic
    class ExerciseLoop : IExercise
    {
        //--LOOP--
        // [1] while
        // [2] do
        // [3] for
        // [4] foreach

        public void StartTest()
        {
            Console.WriteLine($"-- while -- {Environment.NewLine}");
            TestWhile();
            Console.WriteLine($"-- do -- {Environment.NewLine}");
            TestDo();
            Console.WriteLine($"-- for -- {Environment.NewLine}");
            TestFor();
            Console.WriteLine($"-- foreach -- {Environment.NewLine}");
            TestForeach();
        }

        void TestWhile()
        {
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine($"iteration [{i}]");
                i++;
            }
        }

        void TestDo()
        {
            int i = 0;
            while (i < 0)           
            {
                Console.WriteLine($"iteration [{i}]");
                i++;
            };

            i = 0;
            do
            {
                Console.WriteLine($"iteration [{i}]");
                i++;
            }
            while (i < 0);
        }

        void TestFor()
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"iteration [{i}]");
            }
        }

        void TestForeach()
        {
            string str = "ala ma kota";
            foreach(char ch in str)
            {
                Console.Write($"{ch} - ");
            }

            Console.WriteLine("");
            Array arr = str.Split(' ');
            foreach (string s in arr)
                Console.WriteLine($"{s}");
        }
    }
}
