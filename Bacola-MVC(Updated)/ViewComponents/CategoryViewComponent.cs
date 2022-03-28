using Bacola_MVC_Updated_.Data;
using Bacola_MVC_Updated_.Models;
using Bacola_MVC_Updated_.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bacola_MVC_Updated_.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public CategoryViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Categories> categories = await _context.Categories.ToListAsync();
            HomeVM homeVM = new HomeVM()
            {
                Categories = categories
            };
            return (await Task.FromResult(View(homeVM)));
        }
    }
}
