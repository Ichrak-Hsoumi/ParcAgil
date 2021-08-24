using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Models
{
    public class Assurence
    {
        [Key]
        public int Numero { get; set; }
        public string Nom { get; set; }
        public DateTime Date { get; set; }
    }
}
