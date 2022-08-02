using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Composite : IComponent
    {
        public string Name { get; set; }
        List <IComponent> Components = new List<IComponent>(); 
        public Composite(string name)
        {
            this.Name = name;
        }
        public void AddComponent (IComponent component)
        {
            this.Components.Add(component);
        }
        public void GetPrice()
        {
            Console.WriteLine(Name);
            foreach (var item in Components)
            {
                item.GetPrice();
            }
        }
    }
}
