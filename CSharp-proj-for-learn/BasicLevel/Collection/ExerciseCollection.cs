using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_proj_for_learn.BasicLevel.Collection
{
    class ExerciseCollection : IExercise
    {
        public void StartTest()
        {
            //kolekcje służą do przechowania 
            //zbiorów elementów
            //jest w przestrzeni nazw:
            //      System.Collections lub 
            //      System.Collections.Generic

            // - - List - -
            var names = new List<string>();
            names.Add("Ola");
            names.Add("Paweł");
            names.Add("Albert");

            foreach(string name in names)
            {
                if(name.Contains('e'))
                    Console.WriteLine($"contains (e) {name}");
            }
            
            var numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(6);
            numbers.Add(9);

            for (int i = 0; i < numbers.Count(); i++)
                Console.WriteLine($"{numbers[i]}");


            // - - Dictionary - - 
            var numbersDic = new Dictionary<int, string>();
            numbersDic.Add(1, "one");
            numbersDic.Add(2, "two");
            numbersDic.Add(3, "three");

            var numberTwo = numbersDic.Where(p => p.Key == 2).First();
            Console.WriteLine(numberTwo.Value);
        }
    }
}
