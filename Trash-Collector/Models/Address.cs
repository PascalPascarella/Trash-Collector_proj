using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
	public class Address
	{
    [Key]
		public int AddressId { get; set; }

		[Display(Name = "Address Line 1")]
		public string Address1 { get; set; }

		[Display(Name = "Address Line 2")]
		public string Address2 { get; set; }

		[Display(Name = "City, State")]
		public string CityState { get; set; }

		[Display(Name = "Postal/Zip Code")]
		public int PostalCode { get; set; }
	}
}
