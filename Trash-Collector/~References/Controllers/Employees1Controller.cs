﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using Trash_Collector.Data;
//using Trash_Collector.Models;

//namespace Trash_Collector.Controllers
//{
//    public class EmployeesController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public EmployeesController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        //// GET: Employees
//        //public async Task<IActionResult> Index()
//        //{
//        //   var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
//        //   var CurrentEmployee = _context.Employee.Where(e => e.IdentityUserId == userId).SingleOrDefault();
//        //   if (CurrentEmployee == null)
//        //   {
//        //     return RedirectToAction("Create");
//        //   }
//        //   string today = DateTime.Today.DayOfWeek.ToString();
//        //   var applicationDbContext = await _context.Customer.Where
//        //     //((c => c.ZipTemporary == CurrentEmployee.ZipTemporary && c.PickupDay == today)).ToListAsync();
//        //   return View(applicationDbContext);

//        //}

//        // GET: Employees/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var employee = await _context.Employee
//                //.Include(e => e.Address)
//                .Include(e => e.IdentityUser)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (employee == null)
//            {
//                return NotFound();
//            }

//            return View(employee);
//        }

//        // GET: Employees/Create
//        public IActionResult Create()
//        {

//            return View();
//        }

//        // POST: Employees/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//      //  public async Task<IActionResult> Create([Bind("Id,IdentityUserId,AddressId,FirstName,LastName")] Employee employee)
//      //  {
//      //      if (ModelState.IsValid)
//      //      {
//      //          _context.Add(employee);
//      //          await _context.SaveChangesAsync();
//      //          return RedirectToAction(nameof(Index));
//      //      }
//      ////ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Id", employee.AddressId);
//      //DayOfWeek dayOfWeek = new DayOfWeek();
//      //List<int> dayList = new List<int>();
//      //dayList = dayOfWeek.    //.Where(dayOfWeek => dayOfWeek).ToList();
//        //    ViewData["IdentityUserId"] = new SelectList(dayOfWeek);
//        //    return View(employee);
//        //}

//        //// GET: Employees/Edit/5
//        //public async Task<IActionResult> Edit(int? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    var employee = await _context.Employee.FindAsync(id);
//        //    if (employee == null)
//        //    {
//        //        return NotFound();
//        //    }
//        //   
//        //    return View(employee);
//        }

//        // POST: Employees/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,IdentityUserId,AddressId,FirstName,LastName")] Employee employee)
//        {
//            if (id != employee.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(employee);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!EmployeeExists(employee.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            //ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Id", employee.AddressId);
//            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
//            return View(employee);
//        }

//        // GET: Employees/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var employee = await _context.Employee
//                //.Include(e => e.Address)
//                .Include(e => e.IdentityUser)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (employee == null)
//            {
//                return NotFound();
//            }

//            return View(employee);
//        }

//        // POST: Employees/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var employee = await _context.Employee.FindAsync(id);
//            _context.Employee.Remove(employee);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool EmployeeExists(int id)
//        {
//            return _context.Employee.Any(e => e.Id == id);
//        }
//    }
//}
