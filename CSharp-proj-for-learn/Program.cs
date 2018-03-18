using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// - - -> Olo Technic
namespace CSharp_proj_for_learn
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowIntro(30);
        }

        static void ShowIntro(int countSign)
        {
            Console.Clear();
            for (int i= 0; i <= countSign; i++)
            {
                Console.Write("*");
                Thread.Sleep(50);
            }
            Console.WriteLine("");
            Console.WriteLine(".NET and C# project for learn");
            Console.WriteLine("");
            for (int i = 0; i <= countSign; i++)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }

        }
    }
}
