using System;

namespace Shop_homework13_GeorgiTenov
{
    public class Product
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public decimal Price { get; private set; }

        public StatusEnum Status { get; private set; }

        public ProductCategory ProductCategory { get; private set; }

        public int AvailableQuantity { get;set; } 

        public Product(int id,
                       string name,
                       string description,
                       decimal price,
                       StatusEnum status,
                       ProductCategory productCategory,
                       int availableQuantity)
        {
            this.Id = id;

            this.Name = name;

            this.Description = description;

            this.Price = price;

            this.Status = status;

            this.ProductCategory = productCategory;

            this.AvailableQuantity = availableQuantity;
        }

        public Product(int id,
                       string name,
                       string description,
                       decimal price,
                       ProductCategory productCategory
                       )
        {
            this.Id = id;

            this.Name = name;

            this.Description = description;

            this.Price = price;

            this.Status = StatusEnum.NotAvailable;

            this.ProductCategory = productCategory;
        }


        public void ChangeProductCategory(ProductCategory productCategory)
        {
            this.ProductCategory = productCategory;
        }

        }
    }

