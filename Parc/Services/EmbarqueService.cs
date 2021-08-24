using Microsoft.EntityFrameworkCore;
using Parc.Data;
using Parc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Services
{
    public class EmbarqueService : IEmbarquesService
    {
        private readonly ApplicationDbContext _db;
        public EmbarqueService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<EquipementEmbarque> createEmbarque(EquipementEmbarque equipementEmbarque)
        {
            _db.EquipementEmbarque.Add(equipementEmbarque);
            await _db.SaveChangesAsync();
            return equipementEmbarque;
        }

        public async Task<EquipementEmbarque> deleteEmbarque(string id)
        {
            var EqInDb = await _db.EquipementEmbarque.FindAsync(id);
            _db.EquipementEmbarque.Remove(EqInDb);
            await _db.SaveChangesAsync();
            return EqInDb;
        }

        public async Task<EquipementEmbarque> editEmbarque(EquipementEmbarque equipementEmbarque)
        {
            _db.Entry(equipementEmbarque).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return equipementEmbarque;
        }

        public async Task<IEnumerable<EquipementEmbarque>> getEmbarques()
        {
            var eq = await _db.EquipementEmbarque.ToListAsync();
            return eq;
        }
    }
}
