using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trash_Collector.Models;

namespace Trash_Collector.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
				: base(options)
		{
		}
		protected override void OnModelCreating(ModelBuilder builder)		// Seeds data to DB
		{
			base.OnModelCreating(builder);
			builder.Entity<IdentityRole>()
				.HasData(
				new IdentityRole { Name = "Customer", NormalizedName = "CUSTOMER" },
				new IdentityRole { Name = "Employee", NormalizedName = "EMPLOYEE" });

		}
		public DbSet<Trash_Collector.Models.Customer> Customer { get; set; }
		public DbSet<Trash_Collector.Models.Employee> Employee { get; set; }
		//public DbSet<Trash_Collector.Models.Address> Address { get; set; }
	}
}
