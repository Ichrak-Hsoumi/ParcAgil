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
    public class ChauffeurController : ControllerBase
    {
        private IChauffeurService chauffeurService;
        public ChauffeurController(IChauffeurService chauffeurService)
        {
            this.chauffeurService = chauffeurService;
        }
        [HttpGet]
        public async Task<IActionResult> getAllChauffeurs()
        {
            var ch = await chauffeurService.getChauffeurs();
            return Ok(ch);
        }
        [HttpPost]
        public async Task<IActionResult> addChauffeur(Chauffeur chauffeur)
        {
            var ch = await chauffeurService.createChauffeur(chauffeur);
            return Ok(ch);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> updateChauffeur(int id, Chauffeur chauffeur)
        {
            if (!ModelState.IsValid) return BadRequest();
            var ch = await chauffeurService.editChauffeur(chauffeur);
            return Ok(ch);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteChauffeur(int id)
        {
            var ch = await chauffeurService.deleteChauffeur(id);
            return Ok(ch);
        }
    }
}
