using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_proj_for_learn.BasicLevel.MethodAndOverload
{
    class ExerciseOverload : IExercise
    {
        // - -> Olo Technic 

        public void StartTest()
        {            
            Console.WriteLine(GetSomeValue());
            string code = Console.ReadLine();
            Console.WriteLine(GetSomeValue(code));
            Console.WriteLine(GetSomeValue(10));
        }

        public int GetSomeValue()
        {
            return 1;
        }

        public int GetSomeValue(string name)
        {
            if (name == "one")
                return 1;

            if (name == "two")
                return 2;

            return 0;
        }

        public int GetSomeValue(int number)
        {
            return 2 * number;
        }
    }
}
