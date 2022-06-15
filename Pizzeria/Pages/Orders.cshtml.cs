using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Models;
using Pizzeria.Data;

namespace Pizzeria.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrderModel> PizzaOrderModels = new List<PizzaOrderModel>();
        private readonly ApplicationDbContext _context;

        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            PizzaOrderModels = _context.PizzaOrdersModel.ToList();
        }
    }
}
