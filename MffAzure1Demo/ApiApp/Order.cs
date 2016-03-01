using System;

namespace ApiApp
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Number { get; set; }

        public decimal Price { get; set; }
    }
}