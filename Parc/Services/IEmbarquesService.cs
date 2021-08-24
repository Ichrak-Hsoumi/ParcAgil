using Parc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Services
{
    public interface IEmbarquesService
    {
        Task<IEnumerable<EquipementEmbarque>> getEmbarques();
        Task<EquipementEmbarque> createEmbarque(EquipementEmbarque equipementEmbarque);
        Task<EquipementEmbarque> editEmbarque(EquipementEmbarque equipementEmbarque);
        Task<EquipementEmbarque> deleteEmbarque(string id);
    }
}
