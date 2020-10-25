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

				public async Task<IActionResult> DeliveryIndex()
				{
					return View();
				}


				// GET: Employees/DeliveryIndex
				[HttpGet, ActionName("Delivery Filter")]
				public async Task<IActionResult> DeliveryIndex(DayOfWeek? day)
				{
						var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
						var CurrentEmployee = _context.Employee.Where(e => e.IdentityUserId == userId).SingleOrDefault();
						if(CurrentEmployee == null)
						{
								return RedirectToAction("Create");
						}
						List<SelectListItem> daysList = new List<SelectListItem>();
						daysList.Add(new SelectListItem() { Text = "Sunday", Value = "0" });
						daysList.Add(new SelectListItem() { Text = "Monday", Value = "1" });
						daysList.Add(new SelectListItem() { Text = "Tuesday", Value = "2" });
						daysList.Add(new SelectListItem() { Text = "Wednesday", Value = "3" });
						daysList.Add(new SelectListItem() { Text = "Thursday", Value = "4" });
						daysList.Add(new SelectListItem() { Text = "Friday", Value = "5" });
						daysList.Add(new SelectListItem() { Text = "Saturday", Value = "6" });
						var employeeDayChoice = from d in daysList select d.Text;
						ViewBag.Day = employeeDayChoice;

						var applicationDbContext = _context.Customer.Where(c => c.PickupDay == day);
						applicationDbContext = applicationDbContext.Where(c => c.Address.PostalCode == CurrentEmployee.Address.PostalCode && c.trashPickupStatus != Customer.TrashPickupStatus.Settled);
						if (applicationDbContext == null)
						{
							var applicationDbContextNoDaySelected = _context.Customer.Include(c => c.IdentityUser);
							return View(await applicationDbContextNoDaySelected.ToListAsync());
						}
						return View(await applicationDbContext.ToListAsync());
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
