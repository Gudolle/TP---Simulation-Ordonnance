using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SimulationOrdonnance
{
    class Tache
    {
        public string Nom { get; set; }
        public int Ci { get; set; }
        public int Di { get; set; }
        public int Pi { get; set; }

        public Boolean Effectuer { get; set; }
        private int Nombre { get; set; }

        public int TimeExecute { get; set; }
        public int DeadLine { get; set; }

        public Tache(string _nom, int _Ci, int _Di, int _Pi)
        {
            Nom = _nom;
            Ci = _Ci;
            Di = _Di;
            Pi = _Pi;
            Effectuer = false;
            Nombre = 0;
            TimeExecute = 0;
        }

        public void TacheFaite()
        {
                Nombre++;
                Effectuer = true;
        }
        public void VerifiePI(int temps)
        {
            DeadLine = ((Nombre * Pi) + Di) - (Ci - TimeExecute);

            if (temps >= (Nombre+1) * Pi)
            {
                TimeExecute = Effectuer ? 0 : TimeExecute;
                //TimeExecute = 0;
                Effectuer = false;
            }
        }

        public void ToStringTache(int temps)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Nom);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" à été executé. Temps : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(temps);
            Console.ForegroundColor = ConsoleColor.White;
        }
        

        public void ToString()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Nom);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" à été executé : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Nombre);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" fois.");


        }
    }
}
