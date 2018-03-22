using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_proj_for_learn.BasicLevel.Comment
{
    class ExerciseComment: IExercise
    {
        /// <summary>
        /// 
        /// </summary>
        public void StartTest()
        {
            //jakiś opis lini kodu
            /*
            int number = 1 + 2;
            int number2 = 1 + 2;            
            */
        }

        /// <summary>
        /// opis metody
        /// </summary>
        /// <param name="param1">opis prametru</param>
        /// <returns>opis tego co zwaca metoda</returns>
        public int GetNumber(int param1)
        {
            return param1 + 1;
        }
    }
}
