using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_proj_for_learn.BasicLevel.Arrays
{
    class ExerciseArrays : IExercise
    {
        public void StartTest()
        {
            int[] intArr = new int[3];
            intArr[0] = 100;
            intArr[1] = 150;
            intArr[2] = 170;

            foreach (int i in intArr)
                Console.WriteLine(i);

            string[] strArr = new string[2];
            strArr[0] = "Ala";
            strArr[1] = "ma";
            //strArr[2] = "kota";

            for (int i = 0; i < strArr.Length; i++)
                Console.Write($"{strArr[i]} ");
                
        }
    }
}
