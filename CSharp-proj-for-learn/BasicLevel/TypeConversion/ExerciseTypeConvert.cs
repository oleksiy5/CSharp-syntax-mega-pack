using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_proj_for_learn.BasicLevel.TypeConversion
{
    class ExerciseTypeConvert : IExercise
    {
        public void StartTest()
        {
            string strValue = "100";

            //int numberValue1 = strValue;
            if (strValue.All(char.IsDigit))
            {
                int numberValue2 = Convert.ToInt32(strValue);

                int numberValue3 = int.Parse(strValue);
            }
            int numberValue4;
            int.TryParse(strValue, out numberValue4);
        }
    }
}
