using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_proj_for_learn.BasicLevel.ConstructorAndFinalizer
{
    class ExerciseConstructorAndFinalizer : IExercise
    {
        public void StartTest()
        {
            new City("Poland");
            Console.ReadKey();
            GC.Collect();
            Console.ReadKey();
        }
    }

    class City
    {
        string _name;

        //konstrukor to metoda wolana 
        //w czasie tworzenia obiektu       
        public City(string name)
        {
            _name = name;
            Console.WriteLine($"The object {_name} is created.");
        }
        
        //destrktor wolany w momencie
        //niszeczenia obiketu (usuwania z pamięci)
        ~City()
        {
            Console.WriteLine($"The object {_name} is removed.");
        }

    }
}
