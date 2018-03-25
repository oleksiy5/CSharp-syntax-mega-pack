using CSharp_proj_for_learn.BasicLevel.String;
using CSharp_proj_for_learn.BasicLevel.Null;
using CSharp_proj_for_learn.BasicLevel.Comment;
using CSharp_proj_for_learn.BasicLevel.File;


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
            }

            return exercise;
        }
        
    }
}
