using Parc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Services
{
    public interface IVisiteService
    {
        Task<IEnumerable<Visite>> getVisites();
        Task<Visite> createVisite(Visite visite);
        Task<Visite> editVisite(Visite visite);
        Task<Visite> deleteVisite(int id);
    }
}
