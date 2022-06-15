using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Data;
using Pizzeria.Models;

namespace Pizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        
        public string  PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }
            PizzaOrderModel pizzaOrderModel = new PizzaOrderModel();
          
            pizzaOrderModel.PizzaName = PizzaName; 
            pizzaOrderModel.BasePrice = PizzaPrice;

            _context.PizzaOrdersModel.Add(pizzaOrderModel);
            _context.SaveChanges();
        }
    }
}
