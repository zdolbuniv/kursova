﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursov.Context
{
    public class BrendCar
    {
        [Key]
        public int ID { get; set; }
        [Required,MaxLength(length:200)]
        public string NameCar { get; set; }
    }
}
