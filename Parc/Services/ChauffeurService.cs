using Microsoft.EntityFrameworkCore;
using Parc.Data;
using Parc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Services
{
    public class ChauffeurService : IChauffeurService
    {
        private readonly ApplicationDbContext _db;
        public ChauffeurService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Chauffeur> createChauffeur(Chauffeur chauffeur)
        {
            _db.Chauffeur.Add(chauffeur);
            await _db.SaveChangesAsync();
            return chauffeur;
        }

        public async Task<Chauffeur> deleteChauffeur(int id)
        {
            var ChauffeurInDb = await _db.Chauffeur.FindAsync(id);
            _db.Chauffeur.Remove(ChauffeurInDb);
            await _db.SaveChangesAsync();
            return ChauffeurInDb;
        }

        public async Task<Chauffeur> editChauffeur(Chauffeur chauffeur)
        {
            _db.Entry(chauffeur).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return chauffeur;
        }

        public async Task<IEnumerable<Chauffeur>> getChauffeurs()
        {
            var ch = await _db.Chauffeur.ToListAsync();
            return ch;
        }
    }
}
