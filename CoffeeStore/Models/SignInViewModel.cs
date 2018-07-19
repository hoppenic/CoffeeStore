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
        [MinLength(5, ErrorMessage = "Must be at least 5 characters")]
        [MaxLength(20)]
        public string UserName { get; set; }

        [Required]
        [MinLength(8,ErrorMessage ="Must be at least 8 characters")]
        public string Password { get; set; }


    }
}
