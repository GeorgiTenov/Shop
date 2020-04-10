using System;

namespace Shop_homework13_GeorgiTenov
{
    public class Order
    {

        public Product[] Products { get; private set; }

        public string DateOfOrder { get; private set; }

        public User User { get; private set; }

        public Shipment Shipment { get; private set; }

        public Order(User user,Product[] products,string dateOfOrder,Shipment shipment)
        {
            this.User = user;

            this.Products = products;

            this.DateOfOrder = dateOfOrder;

            this.Shipment = shipment;

          
        }

        public decimal CalculateShipment()
        {
            if (this.Shipment != Shipment.Europe) return 10.5m;
            return 0;
        }

        public void MakeAnOrder()
        {
            decimal price = 0;

            for (int i = 0; i < this.Products.Length; i++)
            {

                try
                {
                    if (this.Products[i].AvailableQuantity > 0)

                    {
                        if (this.Products[i].Status == StatusEnum.Available)
                        {
                            this.Products[i].AvailableQuantity--;
                            price += this.Products[i].Price;
                        }
                    }
                }
                catch (Exception)
                {

                }

                if (this.Products[i].Status == StatusEnum.NotAvailable)
                {
                    Console.WriteLine("Not available: " + this.Products[i].Name);
                }

            }
            price += this.CalculateShipment();
            Console.WriteLine("Your total sum is: " + price);
            Console.WriteLine("Order made by: "+this.User.Username +" on "+this.DateOfOrder+"\n" );
        }

    }
}
