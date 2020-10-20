using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
	public class Employee
	{
		[Key]
		public int Id { get; set; }

		[ForeignKey("IdentityUser")]
		public int IdentityUserId { get; set; }
		public IdentityUser	IdentityUser { get; set; }

		[ForeignKey("Address")]
		public string AddressId { get; set; }
		public Address Address { get; set; }

		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		public string LastName { get; set; }
	}
}
