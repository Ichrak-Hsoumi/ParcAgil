using Microsoft.EntityFrameworkCore;
using Parc.Data;
using Parc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Services
{
    public class VehiculeService : IVehiculeService
    {
        private readonly ApplicationDbContext _db;
        public VehiculeService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Vehicule> createVehicule(Vehicule vehicule)
        {
            _db.Vehicule.Add(vehicule);
            await _db.SaveChangesAsync();
            return vehicule;
        }

        public async Task<Vehicule> deleteVehicule(string id)
        {
            var VehiculeInDb = await _db.Vehicule.FindAsync(id);
            _db.Vehicule.Remove(VehiculeInDb);
            await _db.SaveChangesAsync();
            return VehiculeInDb;
        }

        public async Task<Vehicule> editVehicule(Vehicule vehicule)
        {
            //var vehiculeInDb = await _db.Vehicule.FindAsync(id);
            //vehiculeInDb.nbrPortes = vehicule.nbrPortes;
            //await _db.SaveChangesAsync();
            //return vehiculeInDb;

            //_db.Vehicule.Update(vehicule);

            _db.Entry(vehicule).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return vehicule;
        }

        public async Task<IEnumerable<Vehicule>> GetVehicules()
        {
            var veh = await _db.Vehicule.ToListAsync();
            return veh;
        }
    }
}
