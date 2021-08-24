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
    public class AssurenceController : ControllerBase
    {
        private IAssurenceService assurenceService;
        public AssurenceController(IAssurenceService assurenceService)
        {
            this.assurenceService = assurenceService;
        }
        [HttpGet]
        public async Task<IActionResult> getAllAssurences()
        {
            var ass = await assurenceService.getAssurences();
            return Ok(ass);
        }
        [HttpPost]
        public async Task<IActionResult> addAssurence(Assurence assurence)
        {
            var ass = await assurenceService.createAssurence(assurence);
            return Ok(ass);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> updateAssurence(int  id, Assurence assurence)
        {
            if (!ModelState.IsValid) return BadRequest();
            var ass = await assurenceService.editAssurence(assurence);
            return Ok(ass);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteAssurence(int id)
        {
            var ass = await assurenceService.deleteAssurence(id);
            return Ok(ass);
        }
    }
}
