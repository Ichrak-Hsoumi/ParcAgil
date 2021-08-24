using Microsoft.EntityFrameworkCore;
using Parc.Data;
using Parc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Services
{
    public class VisiteService : IVisiteService
    {
        private readonly ApplicationDbContext _db;
        public VisiteService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Visite> createVisite(Visite visite)
        {
            _db.Visite.Add(visite);
            await _db.SaveChangesAsync();
            return visite;
        }

        public async Task<Visite> deleteVisite(int id)
        {
            var VisiteInDb = await _db.Visite.FindAsync(id);
            _db.Visite.Remove(VisiteInDb);
            await _db.SaveChangesAsync();
            return VisiteInDb;
        }

        public async Task<Visite> editVisite(Visite visite)
        {
            _db.Entry(visite).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return visite;
        }

        public async Task<IEnumerable<Visite>> getVisites()
        {
            var visites = await _db.Visite.ToListAsync();
            return visites;
        }
    }
}
