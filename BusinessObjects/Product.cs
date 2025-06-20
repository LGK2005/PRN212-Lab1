﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Product
    {
        public Product(int id, string name, int catId, short unitInStock, decimal price)
        {
            ProductId = id;
            ProductName = name;
            CategoryId = catId;
            UnitInStock = unitInStock;
            UnitPrice = price;
        }

        public Product()
        {
        }

        public int? CategoryId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public short? UnitInStock { get; set; }
        public decimal? UnitPrice { get; set; }
        public virtual Category Category { get; set; }
    }
}
