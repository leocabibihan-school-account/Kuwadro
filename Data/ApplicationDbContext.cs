﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kuwaderno.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Kuwaderno.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Art> artList { get; set; }
        
    }
}
