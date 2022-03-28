using Bacola_MVC_Updated_.Data;
using Bacola_MVC_Updated_.Models;
using Bacola_MVC_Updated_.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bacola_MVC_Updated_.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }



        public async Task<IActionResult> Index()
        {
            Slider slider = await _context.Sliders.FirstOrDefaultAsync();
            List<DiscountProducts> discountProducts = await _context.DiscountProducts.ToListAsync();
            HomeVM homeVM = new HomeVM()
            {
                Slider = slider,
                DiscountProducts = discountProducts
                
            };
            return View(homeVM);
        }

        
        
    }
}
