﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Models
{
    public class Parcs
    {
        [Key]
        public string Nom { get; set; }
        public string Materiels { get; set; }
    }
}
