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
    public class EmbarquesController : ControllerBase
    {
        private IEmbarquesService embarquesService;
        public EmbarquesController(IEmbarquesService embarquesService)
        {
            this.embarquesService = embarquesService;
        }
        [HttpGet]
        public async Task<IActionResult> getAllEmbarques()
        {
            var em = await embarquesService.getEmbarques();
            return Ok(em);
        }
        [HttpPost]
        public async Task<IActionResult> addEmbarque(EquipementEmbarque equipementEmbarque)
        {
            var em = await embarquesService.createEmbarque(equipementEmbarque);
            return Ok(em);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> updateEmbarque(string id, EquipementEmbarque equipementEmbarque)
        {
            if (!ModelState.IsValid) return BadRequest();
            var em = await embarquesService.editEmbarque(equipementEmbarque);
            return Ok(em);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteEmbarque(string id)
        {
            var em = await embarquesService.deleteEmbarque(id);
            return Ok(em);
        }
    }
}
