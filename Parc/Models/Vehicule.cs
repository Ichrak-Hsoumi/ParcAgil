using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Models
{
    public class Vehicule
    {
        [Key]
        public string Matricule { get; set; }
        public string Type { get; set; }
        public string NumSerie { get; set; }
        public DateTime DateFabrication { get; set; }
        public string Etat { get; set; }
        public DateTime DateMiseEnCirculation { get; set; }
        public int Kilometrage { get; set; }
        public string Moteur { get; set; }
        public int NbrPortes { get; set; }
        public Maintenance Maintenance { get; set; }
        public Parcs Parc { get; set; }
        public Chauffeur Chauffeur { get; set; }
        public Assurence Assurence { get; set; }
        public Visite Visite { get; set; }
        public virtual ICollection<EquipementEmbarque> EquipementEmbarques { get; set; }
    }
}
