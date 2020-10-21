using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
	public class CustomerAddressFormViewModel
	{
		// Props
		public Customer Customer { get; set; }
		public Address Address { get; set; }

		// Constructor
		//public CustomerAddressFormViewModel(Customer customer)
		//{
		//	Customer = customer;
		//	customer.Address.Address1
		//}
	}
}
