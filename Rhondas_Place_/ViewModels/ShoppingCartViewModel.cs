using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rhondas_Place_.Models;
using System.ComponentModel.DataAnnotations;

namespace Rhondas_Place_.ViewModels
{
    public class ShoppingCartViewModel
    {
        [Key]
        public int ShoppingCartId { get; set; }
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}