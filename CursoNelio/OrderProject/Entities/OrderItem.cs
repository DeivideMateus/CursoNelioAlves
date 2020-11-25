using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProject.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }

        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem()
        {
        }

        //Price = price; Recebendo o parâmetro price no construtor?
        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Price = product.Price;      
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
