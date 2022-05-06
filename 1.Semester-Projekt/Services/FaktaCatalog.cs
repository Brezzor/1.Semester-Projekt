using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1.Semester_Projekt.Models;

namespace _1.Semester_Projekt.Services
{
    public class FaktaCatalog
    {
        private Dictionary<double, Fakta> faktas { get; }

        public FaktaCatalog()
        {
            faktas = new Dictionary<double, Fakta>();
            faktas.Add(1, new Fakta() { Id = 1, Emne = "Dans", Navn = "HipHop", Tekst = "HipHop er en dans" });
            // Andre Emner: Kultur, Dans, Genre, Fans, Lys, Lyd, Politik, Instrumenter, Afspillere.
        }    


        public void CreateFakta(Fakta fakta)
        {
            if (!(faktas.ContainsKey(fakta.Id)))
            {
                faktas.Add(fakta.Id, fakta);
            }
        }

        public Fakta ReedFakta(double id)
        {
            foreach (var fak in faktas)
            {
                if (fak.Key == id)
                {
                    return fak.Value;
                }
            }
            return new Fakta();
        }

        public void UpdataFakta(Fakta fakta)
        {
            foreach (var fak in faktas.Values)
            {
                if (fak.Id == fakta.Id)
                {
                    fak.Id = fakta.Id;
                    fak.Emne = fakta.Emne;
                    fak.Navn = fakta.Navn;
                    fak.Tekst = fakta.Tekst;
                }
            }
        }

        public void DeleteFakta(Fakta fakta)
        {
            foreach (var fak in faktas.Values)
            {
                if (fak.Id == fakta.Id)
                {
                    faktas.Remove(fak.Id);
                }
            }
        }

    }   
}
