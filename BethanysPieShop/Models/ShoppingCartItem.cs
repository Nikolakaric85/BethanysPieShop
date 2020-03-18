﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoopingCartItemId { get; set; }
        public Pie Pie { get; set;}
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
