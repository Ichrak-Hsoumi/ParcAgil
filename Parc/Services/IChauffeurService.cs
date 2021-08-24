using Parc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Services
{
    public interface IChauffeurService
    {
        Task<IEnumerable<Chauffeur>> getChauffeurs();
        Task<Chauffeur> createChauffeur(Chauffeur chauffeur);
        Task<Chauffeur> editChauffeur(Chauffeur chauffeur);
        Task<Chauffeur> deleteChauffeur(int id);
    }
}
