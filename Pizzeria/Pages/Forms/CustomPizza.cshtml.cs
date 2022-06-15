using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Models;

namespace Pizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 70;
            if (Pizza.Cheese) PizzaPrice += 200;
            if (Pizza.Peporoni) PizzaPrice += 180;
            if (Pizza.Mushroom) PizzaPrice += 190;
            if (Pizza.Tuna) PizzaPrice += 230;
            if (Pizza.Pineapple) PizzaPrice += 90;
            if (Pizza.Chicken) PizzaPrice += 280;
            if (Pizza.Paneer) PizzaPrice += 170;

            return RedirectToPage("/Checkout/Checkout",new { Pizza.PizzaName,PizzaPrice});
        }
    }
}
