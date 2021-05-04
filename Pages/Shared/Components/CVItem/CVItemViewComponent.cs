using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Website_Bewerbung.Pages.Shared.Components.CVItem
{
    public class CVItemViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("CVItem");
        }
    }
}
