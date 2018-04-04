using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_proj_for_learn.BasicLevel.Enum
{
    class ExerciseEnum : IExercise
    {
        public void StartTest()
        {

            Color color = Color.BLACK;

            if(color == Color.RED)            
                Console.WriteLine("Your choice is red.");
            else if(color == Color.BLACK)
                Console.WriteLine("Your choice is black.");
            else if(color == Color.GREEN)
                Console.WriteLine("Your choice is green.");
        }
    }

    enum Color
    {
        RED,
        GREEN,
        WHITE,
        BLACK
    }
}
