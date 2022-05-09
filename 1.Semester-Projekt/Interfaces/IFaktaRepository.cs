using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1.Semester_Projekt.Models;

namespace _1.Semester_Projekt.Interfaces
{
    public interface IFaktaRepository
    {
        Dictionary<int, Fakta> GetAllFakta();

        void CreateFakta(Fakta fakta);
        Fakta ReadFakta(int Id);
        void UpdateFakta(Fakta fakta);
        void DeleteFakta(Fakta fakta);
        
    }
}
