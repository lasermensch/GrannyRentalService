using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrannyRentalService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GrannyRentalService.Controllers
{
    [AllowAnonymous]
    public class GranniesController : Controller
    {
        private readonly GrannyRentalContext _context;
        public GranniesController(GrannyRentalContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Granny> grannies = new List<Granny>();
            //using(GrannyRentalContext db = new GrannyRentalContext())
            //{
            //    foreach (Granny g in db.Grannies)
            //    {
            //        grannies.Add(g);
            //    }
            //}

            return View(await _context.Grannies.ToListAsync());
        }
    }
}
