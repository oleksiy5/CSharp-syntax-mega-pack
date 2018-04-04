using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_proj_for_learn.BasicLevel.BoxingAndUnboxing
{
    class ExerciseBoxingAndUnboxing : IExercise
    {
        //Olo Technic
        //--value type--
        //int, double, decimal, byte, char, struct, enum, ...
        //stack (PL: stos)

        //--reference type--
        //string, class, interface, delegate, object
        //heap (PL: sterta)

        public void StartTest()
        {
            //boxing (value type --> ref type)
            int number = 10;
            object obj = number;
            //unboxing (ref type --> value type)
            int number2 = (int)obj;
        }

    }
}
