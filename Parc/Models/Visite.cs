using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Models
{
    public class Visite
    {
        public int Id { get; set; }
        public DateTime DateVisite { get; set; }
        public DateTime DateExpiration { get; set; }
        public string VehiculeId { get; set; }
    }
}
