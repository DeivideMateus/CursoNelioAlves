using System;
using System.Collections.Generic;
using System.Globalization;
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
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Product.Name + ", $" + Price + ", Quantity: " + Quantity + ", Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
