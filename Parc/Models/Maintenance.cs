using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Models
{
    public class Maintenance
    {
        public int Id { get; set; }
        public string Operations { get; set; }
        public DateTime Date { get; set; }
        public float Cout { get; set; }
        public string Lieu { get; set; }
    }
}
