﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursov.Context
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(length:100)]
        public string NameBrand { get; set; }
    }
}
