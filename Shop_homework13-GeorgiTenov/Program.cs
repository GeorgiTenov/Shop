using System;
namespace Shop_homework13_GeorgiTenov
{
    public class Program
    {
       public static void Main(string[] args)
        {
           
            ProductCategory productCategory = new ProductCategory("Shoes");

            ProductCategory productCategoryTwo = new ProductCategory("Bags");

            Product product = new Product(12,"Adidas","jacket",120.5m,StatusEnum.Available,productCategory,12);

            Product product2 = new Product(10,"Jack Wolfskin","official bags",24.3m,StatusEnum.Available,productCategoryTwo,4);

            Product product3 = new Product(12, "Nike", "boxing gloves", 120.5m, productCategory);

            Product product4 = new Product(12, "Lacoste", "trainers", 120.5m, StatusEnum.Available, productCategory, 12);

            Product[] products = { product,product2,product3,product4};

            product2.ChangeProductCategory(productCategoryTwo);

            Password password = new Password("myname");

            Password password2 = new Password("123456");

            User user = new User("Georgi",password,"Plovdiv");

            User user2 = new User("Ivan",password2,"Sofia");

            Order order = new Order(user2,products,"12/30/2020",Shipment.Europe);

            Page page = new Page("Contact","contact us");

            order.MakeAnOrder();

            Console.WriteLine(product3.AvailableQuantity);

            Console.WriteLine(product2.AvailableQuantity);

            Console.WriteLine(product4.AvailableQuantity);

            Menu menu = new Menu("main",PositionEnum.Bottom,12,page);

            Menu menus = new Menu("top", PositionEnum.Top, 3, page);

            Page page1 = new Page("Home", "leads to home page");

            menu.AddPage(page1);

            
            Shop shop = new Shop(5,5,5,5,10);

            shop.AddProduct(product);

            shop.AddProduct(product2);

            shop.AddUser(user);

            shop.AddUser(user2);

            shop.ShowUsers();

            shop.AddProduct(product3);

            shop.AddProductCategory(productCategoryTwo);

            shop.AddProductCategory(productCategory);

            shop.GetProductCategories();

            shop.GetProductsByCategoryName("Shoes");

            shop.GetProducts();

            shop.GetActiveProducts();

            shop.AddMenu(menus);

            shop.AddMenu(menu);

            shop.ShowMenus();

            Console.ReadKey();
        }
    }
}
