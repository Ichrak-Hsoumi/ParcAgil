﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Models
{
    public class EquipementEmbarque
    {
        [Key]
        public string NumSerie { get; set; }
        public Equipements Nom { get; set; }
        public DateTime DateFabrication { get; set; }
        public string VehiculeId { get; set; }
        public Vehicule Vehicule { get; set; }
    }
}
