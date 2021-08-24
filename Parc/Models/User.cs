using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Models
{
    public abstract class User
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
    }
}
