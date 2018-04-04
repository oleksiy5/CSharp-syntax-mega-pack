using CSharp_proj_for_learn.BasicLevel.String;
using CSharp_proj_for_learn.BasicLevel.Null;
using CSharp_proj_for_learn.BasicLevel.Comment;
using CSharp_proj_for_learn.BasicLevel.File;
using CSharp_proj_for_learn.BasicLevel.Arrays;
using CSharp_proj_for_learn.BasicLevel.TypeConversion;
using CSharp_proj_for_learn.BasicLevel.Loop;
using CSharp_proj_for_learn.BasicLevel.Conditions;
using CSharp_proj_for_learn.BasicLevel.Enum;
using CSharp_proj_for_learn.BasicLevel.BoxingAndUnboxing;
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
                case "NULL":
                    exercise = new ExerciseNull();
                    break;
                case "COMMENT":
                    exercise = new ExerciseComment();
                    break;
                case "FILE":
                    exercise = new ExerciseFile();
                    break;
                case "ARRAY":
                    exercise = new ExerciseArrays();
                    break;
                case "TYPE_CONVERT":
                    exercise = new ExerciseTypeConvert();
                    break;
                case "LOOP":
                    exercise = new ExerciseLoop();
                    break;
                case "CONDITION":
                    exercise = new ExerciseConditions();
                    break;
                case "ENUM":
                    exercise = new ExerciseEnum();
                    break;
                case "BOXING":
                    exercise = new ExerciseBoxingAndUnboxing();
                    break;
            }

            return exercise;
        }
        
    }
}
