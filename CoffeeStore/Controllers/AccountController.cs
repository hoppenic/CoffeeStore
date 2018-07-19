using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeeStore.Models;
using Microsoft.AspNetCore.Identity;

namespace CoffeeStore.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Responds on GET  Account/Register
        public IActionResult Register()
        {

            return View();

        }

        //Responds on post Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(string username, string password)
        {
            return Ok();


        }



    }
}