using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Website_Bewerbung.Pages.Shared.Components.CVItem
{
    public class CVItemViewComponent : ViewComponent
    {

        public string headerLeft;

        public string HeaderLeft { get { return headerLeft; } }

        public async Task<IViewComponentResult> InvokeAsync(string headerLeft)
        {
            Console.Write(headerLeft);
            this.headerLeft = headerLeft;
            return View("CVItem");
        }
    }
}
