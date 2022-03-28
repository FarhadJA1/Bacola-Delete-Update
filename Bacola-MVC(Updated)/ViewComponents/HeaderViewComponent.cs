using Bacola_MVC_Updated_.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bacola_MVC_Updated_.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly LayoutService _layoutService;
        public HeaderViewComponent(LayoutService layoutService)
        {
            _layoutService = layoutService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Dictionary<string, string> settings = _layoutService.GetSettings();
            return (await Task.FromResult(View(settings)));
        }
    }
}
