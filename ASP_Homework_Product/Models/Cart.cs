﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP_Homework_Product.Models
{
    public class Cart
    {
        public Guid Id {  get; set; }
        public string userId {  get; set; }


        public List<CartItem> Items { get; set; }

        public decimal Cost
        {
            get
            {
                return Items.Sum(x => x.Cost);
            }
        }
    }
}