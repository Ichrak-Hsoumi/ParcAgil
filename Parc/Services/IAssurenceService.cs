using Parc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Services
{
    public interface IAssurenceService
    {
        Task<IEnumerable<Assurence>> getAssurences();
        Task<Assurence> createAssurence(Assurence assurence);
        Task<Assurence> editAssurence(Assurence assurence);
        Task<Assurence> deleteAssurence(int id);
    }
}
