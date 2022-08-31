using bethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace bethanysPieShop.Pages
{
    public class CheckoutModel : PageModel
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IShoppingCart _shoppingCart;
        public CheckoutModel(IOrderRepository orderRepository, IShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        [BindProperty]
        public Order Order{ get; set; }
        
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your shopping car is empty");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(Order);
                _shoppingCart.ClearCart();
                return RedirectToPage("CheckOutComplete");
            }
            return Page();
        }
    }
}
