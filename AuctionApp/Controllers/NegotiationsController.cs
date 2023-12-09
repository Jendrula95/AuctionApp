using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AuctionApp.Data;
using AuctionApp.Models;

namespace AuctionApp.Controllers
{
    public class NegotiationsController : Controller
    {
        private readonly AuctionAppContext _context;

        public NegotiationsController(AuctionAppContext context)
        {
            _context = context;
        }

        // GET: Negotiations
        public async Task<IActionResult> Index()
        {

            return View(await _context.Negotiation.ToListAsync());
        }

        

       

       
       

       
    }
}
