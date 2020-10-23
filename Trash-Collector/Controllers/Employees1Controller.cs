using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trash_Collector.Data;
using Trash_Collector.Models;

namespace Trash_Collector.Controllers
{
	public class Employees1Controller : Controller
	{
		private ApplicationDbContext _db;   // Represents DB anywhere inside of class

		// Constructor
		public Employees1Controller(ApplicationDbContext db)   // Passes the project's INSTANCE into the controller
		{
			_db = db;   // Assigns input to _db member variable on line 14
		}
		// GET: EmployeesTest
		public ActionResult Index()
		{
			return View();
		}

		// GET: EmployeesTest/Details/5
		public ActionResult Details(int id)
		{
			var employeesDetails = _db.Employee.Find(id);
			return View(employeesDetails);
		}

		// GET: EmployeesTest/Create
		public ActionResult Create()
		{

			return View();
		}

		// POST: EmployeesTest/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Employee employee)
		{
			try
			{
				_db.Employee.Add(employee);   // Takes captured employee data and sends to DB
				_db.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: EmployeesTest/Edit/5
		public ActionResult Edit(int id)
		{
			var employeeEdit = _db.Employee.Find(id);
			return View(employeeEdit);
		}

		// POST: EmployeesTest/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, Employee employee)
		{
			try
			{
				_db.Employee.Update(employee);
				_db.SaveChanges();
				return RedirectToAction(nameof(Details));
			}
			catch
			{
				return View();
			}
		}

		// GET: EmployeesTest/Delete/5
		public ActionResult Delete(int id)
		{
			var employeeDelete = _db.Employee.Find(id);
			return View(employeeDelete);
		}

		// POST: EmployeesTest/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, Employee employee)
		{
			try
			{
				_db.Employee.Remove(employee);
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
