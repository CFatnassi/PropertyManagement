using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PropertyManagement.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Company> Companys { get; set; }
        public DbSet<Units> Units { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<RealEstateKind> RealEstateKinds { get; set; }
        public DbSet<RentKind> RentKinds { get; set; }
        public DbSet<UnitKind> UnitKinds { get; set; }


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}