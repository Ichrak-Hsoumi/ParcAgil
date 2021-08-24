using Parc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Services
{
    public interface IMaintenanceService
    {
        Task<IEnumerable<Maintenance>> getMaintenances();
        Task<Maintenance> createMaintenance(Maintenance maintenance);
        Task<Maintenance> editMaintenance(Maintenance maintenance);
        Task<Maintenance> deleteMaintenance(int id);
    }
}
