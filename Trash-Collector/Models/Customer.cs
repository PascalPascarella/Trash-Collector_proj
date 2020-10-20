using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
	public class Customer
	{
		// Member Variables
		[Key]
		public int Id { get; set; }

		[ForeignKey("IdentityUser")]
		public string IdentityUserId { get; set; }
		public IdentityUser IdentityUser { get; set; }

		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		[Display(Name = "Desired Pickup Date")]
		public DayOfWeek PickupDay { get; set; }

		[Display(Name = "Optional One-Time Pickup Date")]
		public DateTime ExtraPickUpDay { get; set; }

		[Display(Name = "Optional Pickup Suspension Start Date")]
		public DateTime SuspendServiceStartDate { get; set; }

		[Display(Name = "Optional Pickup Suspension End Date")]
		public DateTime SuspendServiceEndDate { get; set; }

		[Display(Name = "Balance Due On Account")]
		public int BalanceDue { get; set; }

		[Display(Name = "Confirm Pickup")]
		public TrashPickupStatus trashPickupStatus { get; set; }

		// Constructor
		public Customer()		// Customers start with no balance due and trash pending pickup
		{
			BalanceDue = 0;
			trashPickupStatus = TrashPickupStatus.Unsettled;
		}

		// Member Constants
		public enum TrashPickupStatus
		{
			Unsettled,
			Settled
		}
	}
}
