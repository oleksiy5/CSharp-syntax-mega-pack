using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_proj_for_learn.BasicLevel.Null
{
    class ExerciseNull : IExercise
    {
        public void StartTest()
        {
            //your place to practice

            #region reference type

            string msg = "";
            Console.WriteLine(msg.ToString());
            //msg = null;//<--null to nie to samo co pusty ciąg znaków
            //Console.WriteLine(msg.ToString());

            #endregion reference type

            #region value type

            int count = 0;
            Console.WriteLine(count.ToString());
            //count = null;//error compilator

            int? count2 = null;
            if(count2.HasValue)
                Console.WriteLine(count2.Value.ToString());

            Nullable<int> count3 = null;
            if (count3.HasValue)
                Console.WriteLine(count3.Value.ToString());

            #endregion value type
        }
    }
}
