using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Product modelidan foydalaning 
//unda quyidagi propertylar bo'lsin 
//- Name
//- Price


namespace OnlineMarket_HT.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }

        public Product(int id, string name, double price, int number)
        {
            Id = id;
            Name = name;
            Price = price;
            Number = number;
        }
    }
}
