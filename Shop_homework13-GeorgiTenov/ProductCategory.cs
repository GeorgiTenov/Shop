using System;

namespace Shop_homework13_GeorgiTenov
{
    public class ProductCategory
    {
        public string Name { get;private set; }

        public Order Order { get; private set; }

        public ProductCategory(string name)
        {
            this.Name = name;
        }
        public void ChangeOrder(Order order)
        {
            this.Order = order;
        }
      
    }
}
