using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_proj_for_learn.BasicLevel.GarbageCollector
{
    class ExerciseGC : IExercise
    {
        public void StartTest()
        {
            //Garbage Collector (GC)

            //--Stos (Stack)--
            //GC go nie czyści jest czyszczony gdy 
            //kończy się metoda (odpowiada za to CLR)

            //--Sterta (Heap)--
            //GC pracuje na stercie. Jego zadaniem jest 
            //usuwanie obiektów ze sterty.
            //1. GC uruchamia się
            //2. GC sprawdza które obiekty ze stosu
            // mają powiązanie/referencje 
            //3. Usuwa te które nie mają referencji 
        }
    }
}
