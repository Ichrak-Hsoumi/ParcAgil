using Microsoft.EntityFrameworkCore;
using Parc.Data;
using Parc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Services
{
    public class MaintenanceService : IMaintenanceService
    {
        private readonly ApplicationDbContext _db;
        public MaintenanceService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Maintenance> createMaintenance(Maintenance maintenance)
        {
            _db.Maintenance.Add(maintenance);
            await _db.SaveChangesAsync();
            return maintenance;
        }

        public async Task<Maintenance> deleteMaintenance(int id)
        {
            var MaintenanceInDb = await _db.Maintenance.FindAsync(id);
            _db.Maintenance.Remove(MaintenanceInDb);
            await _db.SaveChangesAsync();
            return MaintenanceInDb;
        }

        public async Task<Maintenance> editMaintenance(Maintenance maintenance)
        {
            _db.Entry(maintenance).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return maintenance;
        }

        public async Task<IEnumerable<Maintenance>> getMaintenances()
        {
            var maint = await _db.Maintenance.ToListAsync();
            return maint;
        }
    }
}
