﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursov.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("connect")
        { }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Register> Register { get; set; }
        public DbSet<BrendCar> BrendCar { get; set; }
        public DbSet<Detal> Detal { get; set; }
        public DbSet<DetailsClass> DetailsClass { get; set; }
    }
}
