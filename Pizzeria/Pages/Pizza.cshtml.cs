using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Models;

namespace Pizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDb = new List<PizzasModel>
        {
            new PizzasModel(){
                ImageTitle ="Margerita",
                PizzaName="Margerita",
                BasePrice=200,
                TomatoSauce=true,
                Mushroom=true,
                FinalPrice=500
            },
            new PizzasModel(){
                ImageTitle ="Bolognese",
                PizzaName="Bolognese",
                BasePrice=300,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=440
            },
            new PizzasModel(){
                ImageTitle ="Carbonara",
                PizzaName="Carbonara",
                BasePrice=240,
                Paneer=true,
                Cheese=true,
                Peporoni=true,
                FinalPrice=550
            },
            new PizzasModel(){
                ImageTitle ="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=290,
                Tuna=true,
                Cheese=true,
                FinalPrice=340
            }

        };
        public void OnGet()
        {
        }
    }
}
