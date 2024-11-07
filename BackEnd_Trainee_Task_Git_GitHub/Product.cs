using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_Trainee_Task_Git_GitHub
{
     class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public int Price { get; set; }

        public Product() {}

        public Product(int Id, string Name, int Category, int Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Category = Category;
            this.Price = Price;
        }

        public override string ToString()
        {
            return string.Format("ID: {0}\nName: {1}\nCategory: {2}\nPrice: {3}",Id,Name,Category,Price);
        }


    }
}
