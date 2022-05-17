using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1.Semester_Projekt.Models;

namespace _1.Semester_Projekt.Interfaces
{
    public interface IFaktaRepository
    {

        Dictionary<int, Fakta> GetAllFakta(string JsonFileName);
        void CreateFakta(Fakta fakta, string JsonFileName);
        Fakta ReadFakta(int Id, string JsonFileName);
        void UpdateFakta(Fakta fakta, string JsonFileName);
        void DeleteFakta(Fakta fakta, string JsonFileName);
    }
}
