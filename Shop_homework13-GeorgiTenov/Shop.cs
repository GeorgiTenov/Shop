using System;

namespace Shop_homework13_GeorgiTenov
{
    public class Shop
    {
        public ProductCategory[] Categories { get; private set; }

        public Product[] Products { get; private set; }

        public Menu[] Menus { get; private set; }

        public Page[] Pages { get; private set; }

        public User[] Users { get; private set; }

        public Shop(int productCategories,int totalProducts,int menus,int pages,int users)
        {
            this.Categories = new ProductCategory[productCategories];

            this.Products = new Product[totalProducts];

            this.Menus = new Menu[menus];

            this.Pages = new Page[pages];

            this.Users = new User[users];
        }
        public void GetProducts()
        {
            string[] products = new string[this.Products.Length];
           
            if (this.Products != null)
            {
               
                for (int i = 0; i < this.Products.Length; i++)
                {
                    if(this.Products[i] != null)
                    {
                        products[i] = "Name: "+this.Products[i].Name + " Description: "+this.Products[i].Description +"\n";
                        Console.WriteLine(products[i]);
                    }
                   
                }
             
            }

        }
        public void AddProduct(Product product)
        {
            if(this.Products != null)
            {
                for(int i = 0; i < this.Products.Length; i++)
                {
                    if(this.Products[i] == null)
                    {
                        this.Products[i] = product;
                        break;
                    }
                }
            }
        }

        public void GetProductCategories()
        {
           
            if(this.Categories != null)
            {
                for(int i = 0; i < this.Categories.Length; i++)
                {
                    if(this.Categories[i] != null)
                    {
                        Console.WriteLine("Categories: "+this.Categories[i].Name +"\n");
                    }
                   
                }
            }
            
        }
        public void AddProductCategory(ProductCategory category)
        {
            if (this.Categories != null)
            {
                for (int i = 0; i < this.Categories.Length; i++)
                {
                    if (this.Categories[i] == null)
                    {
                        this.Categories[i] = category;
                        break;
                    }

                }

            }
        }

        public void GetActiveProducts()
        {
            if(this.Products != null)
            {
                for(int i = 0; i < this.Products.Length; i++)
                {
                    if(this.Products[i] != null)
                    {
                        if (this.Products[i].Status == StatusEnum.Available)
                        {
                            Console.WriteLine("Active Products: " + this.Products[i].Name +"\n");
                        }
                    }
                  
                }
               
            }
           
        }

        public void GetProductsByCategoryName(string category)
        {
            if(this.Products != null)
            {
                for(int i = 0; i < this.Products.Length; i++)
                {
                    if(this.Products[i] != null)
                    {
                        if (this.Products[i].ProductCategory.Name.Equals(category))
                        {
                            Console.WriteLine("Products: "+this.Products[i].Name +"\n");
                        }
                    }
                   
                }
               
            }
        }

        public void AddMenu(Menu menu)
        {
            if(this.Menus != null)
            {
                for(int i = 0; i < this.Menus.Length; i++)
                {
                    if(this.Menus[i] == null)
                    {
                        this.Menus[i] = menu;
                        break;
                    }
                }
            }
        }
        public void ShowMenus()
        {
            if(this.Menus != null)
            {
                foreach(Menu menu in Menus)
                {
                    if(menu != null)
                    {
                        Console.WriteLine("Menus: " + menu.Title + "\n");
                    }
                }
            }
        }

        public bool AddUser(User user)
        {
            try
            {
                if (this.Users != null)
                {
                    for (int i = 0; i < this.Users.Length; i++)
                    {
                        if (this.Users[i] == null)
                        {
                            this.Users[i] = user;
                            break;
                        }
                    }
                    return true;
                }
                
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Users out of size");
            }

            return false;
        }

        public void ShowUsers()
        {
            foreach(User user in this.Users)
            {
                if(user != null)
                {
                    Console.WriteLine("Username: " + user.Username + "\n" + "Password: " + user.Password.Pass + "\n");
                }
                
            }
        }



    }
}
