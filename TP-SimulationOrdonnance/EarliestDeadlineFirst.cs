using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_SimulationOrdonnance
{
    class EarliestDeadlineFirst
    {
        public List<Tache> MesTache { get; }
        public EarliestDeadlineFirst(List<Tache> _MesTache)
        {
            MesTache = _MesTache;
        }
        public void Start()
        {
            int temps = 0;
            Console.WriteLine(String.Format("Début de l'EarliestDeadlineFirst, Temps : {0}", temps));
            int TempsFinal = MesTache.OrderByDescending(x => x.Pi).First().Pi;
            while (temps < TempsFinal)
            {
                MesTache.ForEach(x => x.VerifiePI(temps));
                List<Tache> TacheSelect = MesTache.Where(x => !x.Effectuer).ToList();
                if (TacheSelect != null && TacheSelect.Count > 0)
                {
                    Tache MaTache = TacheSelect.OrderBy(x => x.DeadLine).First();
                    MaTache.TimeExecute++;
                    if (MaTache.TimeExecute == MaTache.Ci)
                    {
                        MaTache.TacheFaite();
                    }
                    MaTache.ToStringTache(temps);
                }
                else
                    Console.WriteLine(String.Format("Aucune Tache en cours : Temps : {0}", temps));
                temps++;
            }

            Console.WriteLine();
            MesTache.ForEach(x => x.ToString());
        }
    }
}
