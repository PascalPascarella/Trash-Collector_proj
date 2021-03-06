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
//    public class Customers1Controller : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public Customers1Controller(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // GET: Customers
//        public async Task<IActionResult> Index()
//        {
//           var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
//           var CurrentCustomer = _context.Customer.Where(e => e.IdentityUserId == userId).SingleOrDefault();
//           if (CurrentCustomer == null)
//           {
//             return RedirectToAction("Details");
//           }
//            var applicationDbContext = _context.Customer
//        //.Include(c => c.Address)
//        .Include(c => c.IdentityUser);
//            return View(await applicationDbContext.ToListAsync());
//        }

//        // GET: Customers/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var customer = await _context.Customer
//                .Include(c => c.Address)
//                .Include(c => c.IdentityUser)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (customer == null)
//            {
//                return NotFound();
//            }

//            return View(customer);
//        }

//        // GET: Customers/Create
//        public IActionResult Create()
//        {

//            return View();
//        }

//        // POST: Customers/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,IdentityUserId,AddressId,FirstName,LastName,PickupDay,ExtraPickUpDay,SuspendServiceStartDate,SuspendServiceEndDate,BalanceDue,trashPickupStatus")] Customer1 customer)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(customer);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            //ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Id", customer.AddressId);
//            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
//            return View(customer);
//        }

//        // GET: Customers/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var customer = await _context.Customer.FindAsync(id);
//            if (customer == null)
//            {
//                return NotFound();
//            }
//            //ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Id", customer.AddressId);
//            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
//            return View(customer);
//        }

//        // POST: Customers/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,IdentityUserId,AddressId,FirstName,LastName,PickupDay,ExtraPickUpDay,SuspendServiceStartDate,SuspendServiceEndDate,BalanceDue,trashPickupStatus")] Customer1 customer)
//        {
//            if (id != customer.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(customer);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!CustomerExists(customer.Id))
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
//            //ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Id", customer.AddressId);
//            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
//            return View(customer);
//        }

//        // GET: Customers/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var customer = await _context.Customer
//                //.Include(c => c.Address)
//                .Include(c => c.IdentityUser)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (customer == null)
//            {
//                return NotFound();
//            }

//            return View(customer);
//        }

//        // POST: Customers/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var customer = await _context.Customer.FindAsync(id);
//            _context.Customer.Remove(customer);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool CustomerExists(int id)
//        {
//            return _context.Customer.Any(e => e.Id == id);
//        }
//    }
//}
