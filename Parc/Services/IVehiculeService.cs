using Parc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Services
{
    public interface IVehiculeService
    {
        Task<IEnumerable<Vehicule>> GetVehicules();
        Task<Vehicule> createVehicule(Vehicule vehicule);
        Task<Vehicule> editVehicule(Vehicule vehicule);
        Task<Vehicule> deleteVehicule(string id);
    }
}
