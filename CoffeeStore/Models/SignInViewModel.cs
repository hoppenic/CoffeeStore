using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeStore.Models;
using System.ComponentModel.DataAnnotations;


namespace CoffeeStore.Models
{
    public class SignInViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
