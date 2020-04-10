using System;
namespace Shop_homework13_GeorgiTenov
{
    public class User
    {
       public string Username { get; private set; }

       public Password Password { get; private set; }

       public string Address { get; private set; }
        
       public User(string username,Password password,string address)
        {
            this.Username = username;

            this.Password = password;

            this.Address = address;
        }

       
    }
}
