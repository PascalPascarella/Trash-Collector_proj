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
		public class EmployeesController : Controller
		{
				private readonly ApplicationDbContext _context;

				public EmployeesController(ApplicationDbContext context)
				{
						_context = context;
				}

				// GET: Employees
				public async Task<IActionResult> Index()
				{
						var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
						var CurrentEmployee = _context.Employee.Where(c => c.IdentityUserId == userId).FirstOrDefault();
						if (CurrentEmployee == null)
						{
								return RedirectToAction("Create");
						}
						var applicationDbContext = _context.Employee.Include(c => c.IdentityUser);
						return View(await applicationDbContext.ToListAsync());
				}

				// GET: Employees/Details/5
				public async Task<IActionResult> Details(int? id)
				{
						if (id == null)
						{
								return NotFound();
						}

						var employee = await _context.Employee
								.Include(e => e.IdentityUser)
								.FirstOrDefaultAsync(m => m.Id == id);
						if (employee == null)
						{
								return NotFound();
						}

						return View(employee);
				}

				public async Task<IActionResult> CustomerDetails(int? id)
				{
					var customer = _context.Customer
					.Include(c => c.Address)
					.Where(c => c.Id == id)
					.FirstOrDefault();
					return View("CustomerDetails", customer);
				}


		// Customer List View and Logic

		public async Task<IActionResult> DeliveryIndex()
		{
				var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
				var CurrentEmployee = _context.Employee.Where(c => c.IdentityUserId == userId).FirstOrDefault();
				if (CurrentEmployee == null)
				{
						return RedirectToAction("Create");
				}
			var customersList = CustomersList(CurrentEmployee);
						return View();
		}
		//
		private List<Customer> CustomersList(Employee employee)
		{
				var customers = FetchRegularSchedule(employee);
				customers = ExtraServicesChecker(employee, customers);
				customers = ExcludeCompletedPickups(customers);
				return customers;
		}

		private List<Customer> FetchRegularSchedule(Employee employee)
		{
				List<Customer> customers = new List<Customer>();
				foreach (Customer customer in _context.Customer.Include(c => c.Address))
				{
						if (customer.Address.PostalCode == employee.Address.PostalCode
						&& customer.PickupDay == DateTime.Today.DayOfWeek
						&& customer.trashPickupStatus == Customer.TrashPickupStatus.Unsettled)
						{
							customers.Add(customer);
						}
				}
				return customers;
		}

		private List<Customer> ExtraServicesChecker(Employee employee, List<Customer> customers)
		{
			customers = ExtraPickupChecker(employee, customers);
			customers = ExcludeServiceSuspensions(employee, customers);
			return customers;
		}

		private List<Customer> ExtraPickupChecker(Employee employee, List<Customer> customers)
		{
			foreach (Customer customer in _context.Customer)
			{
				if (customer.ExtraPickUpDay != null)
				{
					if (customer.ExtraPickUpDay.Equals(DateTime.Today.Date) && customer.Address.PostalCode == employee.Address.PostalCode)
					{
						customers.Add(customer);
					}
				}
			}
			return customers;
		}

		private List<Customer> ExcludeServiceSuspensions(Employee employee, List<Customer> customers)
		{
			foreach (Customer customer in customers.ToList())
			{
				if (customer.SuspendServiceStartDate?.CompareTo(DateTime.Today.Date) <= 0
				&& customer.SuspendServiceEndDate?.CompareTo(DateTime.Today.Date) > 0
				&& customer.Address.PostalCode == employee.Address.PostalCode)
				{
					customers.Remove(customer);
				}
			}
			return customers;
		}
		private List<Customer> ExcludeCompletedPickups(List<Customer> customers)
		{
			foreach (Customer customer in customers.ToList())
			{
				if (customer.trashPickupStatus == Customer.TrashPickupStatus.Settled)
				{
					customers.Remove(customer);
				}
			}
			return customers;
		}

		public async Task<IActionResult> ConfirmPickup(int? id)
		{
			var customer = _context.Customer
			.Where(c => c.Id == id)
			.FirstOrDefault();
			AccountSettler(customer);
			await _context.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		private static void AccountSettler(Customer customer)
		{
			customer.BalanceDue += 10;
			customer.trashPickupStatus = Customer.TrashPickupStatus.Settled;
		}

		// GET: Employees/Create
		public IActionResult Create()
				{
						return View();
				}

				// POST: Employees/Create
				// To protect from overposting attacks, enable the specific properties you want to bind to, for
				// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
				[HttpPost]
				[ValidateAntiForgeryToken]
				public async Task<IActionResult> Create(Employee employee)
				{
						if (ModelState.IsValid)
						{
								var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
								employee.IdentityUserId = userId;
								_context.Add(employee);
								await _context.SaveChangesAsync();
								return RedirectToAction(nameof(Index));
						}

						return View(employee);
				}

				// GET: Employees/Edit/5
				public async Task<IActionResult> Edit(int? id)
				{
						if (id == null)
						{
								return NotFound();
						}

						var employee = await _context.Employee.FindAsync(id);
						if (employee == null)
						{
								return NotFound();
						}
						ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
						return View(employee);
				}

				// POST: Employees/Edit/5
				// To protect from overposting attacks, enable the specific properties you want to bind to, for
				// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
				[HttpPost]
				[ValidateAntiForgeryToken]
				public async Task<IActionResult> Edit(int id, Employee employee)
				{
						if (id != employee.Id)
						{
								return NotFound();
						}

						if (ModelState.IsValid)
						{
								try
								{
										_context.Update(employee);
										await _context.SaveChangesAsync();
								}
								catch (DbUpdateConcurrencyException)
								{
										if (!EmployeeExists(employee.Id))
										{
												return NotFound();
										}
										else
										{
												throw;
										}
								}
								return RedirectToAction(nameof(Index));
						}
						ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
						return View(employee);
				}

				// GET: Employees/Delete/5
				public async Task<IActionResult> Delete(int? id)
				{
						if (id == null)
						{
								return NotFound();
						}

						var employee = await _context.Employee
								.Include(e => e.IdentityUser)
								.FirstOrDefaultAsync(m => m.Id == id);
						if (employee == null)
						{
								return NotFound();
						}

						return View(employee);
				}

				// POST: Employees/Delete/5
				[HttpPost, ActionName("Delete")]
				[ValidateAntiForgeryToken]
				public async Task<IActionResult> DeleteConfirmed(int id)
				{
						var employee = await _context.Employee.FindAsync(id);
						_context.Employee.Remove(employee);
						await _context.SaveChangesAsync();
						return RedirectToAction(nameof(Index));
				}

				private bool EmployeeExists(int id)
				{
						return _context.Employee.Any(e => e.Id == id);
				}
		}
}
