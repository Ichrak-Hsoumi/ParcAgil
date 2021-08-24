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
    public class VisiteController : ControllerBase
    {
        private IVisiteService visiteService;
        public VisiteController(IVisiteService visiteService)
        {
            this.visiteService = visiteService;
        }
        [HttpGet]
        public async Task<IActionResult> getAllVisites()
        {
            var visites = await visiteService.getVisites();
            return Ok(visites);
        }
        [HttpPost]
        public async Task<IActionResult> addVisite(Visite visite)
        {
            var vis = await visiteService.createVisite(visite);
            return Ok(vis);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> updateVisite(int id, Visite visite)
        {
            if (!ModelState.IsValid) return BadRequest();
            var vis = await visiteService.editVisite(visite);
            return Ok(vis);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteVisite(int id)
        {
            var vis = await visiteService.deleteVisite(id);
            return Ok(vis);
        }
    }
}
