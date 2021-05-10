using System;

namespace ExHerancaPolimorfismo.Entities
{
    class Product
    {
        public string Name { get; set; }
        public Double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " $ " + Price;
        }
    }
}
