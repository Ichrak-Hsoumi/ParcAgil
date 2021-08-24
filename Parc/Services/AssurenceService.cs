using Microsoft.EntityFrameworkCore;
using Parc.Data;
using Parc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Services
{
    public class AssurenceService : IAssurenceService
    {
        private readonly ApplicationDbContext _db;
        public AssurenceService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Assurence> createAssurence(Assurence assurence)
        {
            _db.Assurence.Add(assurence);
            await _db.SaveChangesAsync();
            return assurence;
        }

        public async Task<Assurence> deleteAssurence(int id)
        {
            var AssurenceInDb = await _db.Assurence.FindAsync(id);
            _db.Assurence.Remove(AssurenceInDb);
            await _db.SaveChangesAsync();
            return AssurenceInDb;
        }

        public async Task<Assurence> editAssurence(Assurence assurence)
        {
            _db.Entry(assurence).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return assurence;
        }

        public async Task<IEnumerable<Assurence>> getAssurences()
        {
            var ass = await _db.Assurence.ToListAsync();
            return ass;
        }
    }
}
