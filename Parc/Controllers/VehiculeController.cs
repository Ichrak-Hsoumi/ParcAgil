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
    public class VehiculeController : ControllerBase
    {
        private IVehiculeService vehiculeService;
        public VehiculeController(IVehiculeService vehiculeService)
        {
            this.vehiculeService = vehiculeService;
        }
        [HttpGet]
        public async Task<IActionResult> getAllVehicules()
        {
            var veh = await vehiculeService.GetVehicules();
            return Ok(veh);
        }
        [HttpPost]
        public async Task<IActionResult> addVehicule(Vehicule vehicule)
        {
            var veh = await vehiculeService.createVehicule(vehicule);
            return Ok(veh);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> updateVehicule(string id, Vehicule vehicule)
        {
            if (!ModelState.IsValid) return BadRequest();
            var veh = await vehiculeService.editVehicule(vehicule);
            return Ok(veh);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteVehicule(string id)
        {
            var veh = await vehiculeService.deleteVehicule(id);
            return Ok(veh);
        }
    }
}
