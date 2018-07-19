using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeeStore.Models;

namespace CoffeeStore.Controllers
{
    public class ProductController : Controller
    {
        //instantiating a new list using Product Class, calling it _products
        private List<Product> _products;


        public ProductController()
        {
            //making a list of products now to mock things up
            _products = new List<Product>();
            _products.Add(new Product
            {
                ID = 1,
                Name = "Black Coffee",
                Description = "Bold Venezuelan Blend",
                Image = "",
                Price = 2.99m

            });

            _products.Add(new Product
            {
                ID = 1,
                Name = "Cafe Latte",
                Description = "Our Smooth Colombian Blend with whole milk",
                Image = "",
                Price = 4.99m

            });


        }


        public IActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                Product p = _products.Single(x => x.ID == id.Value);
                return View(p);
            }
            return NotFound();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}