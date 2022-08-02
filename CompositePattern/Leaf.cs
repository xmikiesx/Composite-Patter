using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Leaf : IComponent
    {
        public int Price { get; set; }
        public string? Name { get; set; }
        public Leaf(string Name,int Price )
        {
            this.Price = Price;
            this.Name = Name;
        }
        public void GetPrice()
        {
            Console.WriteLine($"{Name} : {Price}");
        }

    }
}
