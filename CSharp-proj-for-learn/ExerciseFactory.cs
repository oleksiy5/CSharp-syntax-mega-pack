using CSharp_proj_for_learn.BasicLevel.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_proj_for_learn
{
    interface IExercise
    {
        void StartTest();
    }

    class ExerciseFactory
    {
        private ExerciseFactory() { }

        public static IExercise CreateObject(string code)
        {
            IExercise exercise = null;
            switch(code.ToUpper())
            {
                case "STRING":
                    exercise = new ExerciseString();
                    break;


            }
            return exercise;
        }
        
    }
}
