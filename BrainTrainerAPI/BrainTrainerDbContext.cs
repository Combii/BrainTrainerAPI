using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainTrainerAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BrainTrainerAPI
{
    public class BrainTrainerDbContext : IdentityDbContext<BrainTrainerUser>
    {
        public BrainTrainerDbContext(DbContextOptions<BrainTrainerDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<BrainTrainerUser>(user => user.HasIndex(x => x.Locale).IsUnique(false));

            builder.Entity<Organization>(org =>
            {
                org.ToTable("Organizations");
                org.HasKey(x => x.Id);

                org.HasMany<BrainTrainerUser>().WithOne().HasForeignKey(x => x.OrgId).IsRequired(false);
            });
        }
    }
}
