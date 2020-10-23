using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trash_Collector.Data;
using Trash_Collector.Models;

namespace Trash_Collector.Controllers
{
	public class Customers1Controller : Controller
	{
		private ApplicationDbContext _db;   // Represents DB anywhere inside of class

		// Constructor
		public Customers1Controller(ApplicationDbContext db)   // Passes the project's INSTANCE into the controller
		{
			_db = db;   // Assigns input to _db member variable on line 14
		}
		// GET: CustomersTest
		public ActionResult Index()
		{
			var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
				var CurrentCustomer = _db.Customer.Where(e => e.IdentityUserId == userId).SingleOrDefault();
				if (CurrentCustomer == null)
				{
				  return RedirectToAction("Details");
				}
			var applicationDbContext = _db.Customer.Include(c => c.IdentityUser);
			return View(applicationDbContext.ToListAsync());
			}

		// GET: CustomersTest/Details/5
		public ActionResult Details(int id)
		{
			var customerDetails = _db.Customer.Find(id);
			return View(customerDetails);
		}

		// GET: CustomersTest/Create
		public ActionResult Create()
		{
			Customer customer = new Customer();
			return View(customer);
		}

		// POST: CustomersTest/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Customer customer)
		{
			try
			{
				_db.Customer.Add(customer);
				_db.SaveChanges();
				return RedirectToAction(nameof(Details));
			}
			catch
			{
				return View();
			}
		}

		// GET: CustomersTest/Edit/5
		public ActionResult Edit(int id)
		{
			var customerEdit = _db.Customer.Find(id);
			return View();
		}

		// POST: CustomersTest/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, Customer customer)
		{
			try
			{
				_db.Customer.Update(customer);
				_db.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: CustomersTest/Delete/5
		public ActionResult Delete(int id)
		{
			var customerDelete = _db.Customer.Find(id);
			return View();
		}

		// POST: CustomersTest/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, Customer customer)
		{
			try
			{
				_db.Customer.Remove(customer);
				_db.SaveChanges();
				return RedirectToAction("Index", "Home", null);
			}
			catch
			{
				return View();
			}
		}
	}
}
