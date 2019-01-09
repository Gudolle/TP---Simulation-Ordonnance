using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SimulationOrdonnance
{
    class Program
    {
        static void Main(string[] args)
        {
            EarliestDeadlineFirst EDF = new EarliestDeadlineFirst(RetourneTaches());
            EDF.Start();
            Console.ReadKey();
        }


        static public List<Tache> RetourneTaches()
        {
            return new List<Tache>()
            {
                new Tache("Tache 1", 3, 5, 30),
                new Tache("Tache 2", 1, 10, 45),
                new Tache("Tache 3", 2, 10, 60),
                new Tache("Tache 4", 4, 16, 86),
                new Tache("Tache 5", 2,15,25),
                new Tache("Tache 6", 5, 9, 100),
                new Tache("Tache 7", 6, 15, 150),
                new Tache("Tache 8", 15, 60, 3000),
                new Tache("Tache 9", 5, 11, 123)
            };
        }
    }
}
