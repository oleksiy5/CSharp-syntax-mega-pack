using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_proj_for_learn.BasicLevel.File
{
    class ExerciseFile : IExercise
    {
        public void StartTest()
        {
            string[] strArr = new string[5];
            strArr[0] = "|1|Mon|";
            strArr[1] = "|2|Tuesday|";
            strArr[2] = "|3|Wednesday|";
            strArr[3] = "|4|Thursday|";
            strArr[4] = "|5|Friday|";
            if(System.IO.Directory.Exists(@"C:\FileStor"))
                System.IO.File.WriteAllLines(@"c:\FileStor\file_data.txt", strArr);
            else
            {
                System.IO.Directory.CreateDirectory(@"C:\FileStor");
                System.IO.File.WriteAllLines(@"c:\FileStor\file_data.txt", strArr);
            }
        }
    }
}
