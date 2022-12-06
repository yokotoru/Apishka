using System;
using Apishka.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apishka.Models
{
    public class ProductModel
    {

        public ProductModel(Product products)
        {
            Id = products.Id;
            Products = products.Products;
            Amount = products.Amount;
            Image = products.Image;

        }

        public int Id { get; set; }
        public string Products { get; set; }
        public string Amount { get; set; }
        public string Image { get; set; }

    }
}