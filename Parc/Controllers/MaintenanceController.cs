using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parc.Models;
using Parc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceController : ControllerBase
    {
        private IMaintenanceService maintenanceService;
        public MaintenanceController(IMaintenanceService maintenanceService)
        {
            this.maintenanceService = maintenanceService;
        }
        [HttpGet]
        public async Task<IActionResult> getAllMaintenances()
        {
            var maint = await maintenanceService.getMaintenances();
            return Ok(maint);
        }
        [HttpPost]
        public async Task<IActionResult> addMaintenance(Maintenance maintenance)
        {
            var maint = await maintenanceService.createMaintenance(maintenance);
            return Ok(maint);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> updateMaintenance(int id, Maintenance maintenance)
        {
            if (!ModelState.IsValid) return BadRequest();
            var maint = await maintenanceService.editMaintenance(maintenance);
            return Ok(maint);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteMaintenance(int id)
        {
            var maint = await maintenanceService.deleteMaintenance(id);
            return Ok(maint);
        }
    }
}
