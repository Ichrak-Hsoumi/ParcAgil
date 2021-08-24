using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Parc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parc.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Assurence> Assurence { get; set; }
        public DbSet<Chauffeur> Chauffeur { get; set; }
        public DbSet<EquipementEmbarque> EquipementEmbarque { get; set; }
        public DbSet<Maintenance> Maintenance { get; set; }
        public DbSet<Parcs> Parcs { get; set; }
        public DbSet<Vehicule> Vehicule { get; set; }
        public DbSet<Visite> Visite { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                  .UseMySql("server=localhost;port=3306;user=root;password=;database=ParcDb");

        }
    }
}
