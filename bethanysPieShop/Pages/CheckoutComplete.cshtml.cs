using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace bethanysPieShop.Pages
{
    public class CheckoutCompleteModel : PageModel
    {
        public void OnGet()
        {
            ViewData["CheckoutCompleteMessage"] = "Thank`s for your order";
        }
    }
}
