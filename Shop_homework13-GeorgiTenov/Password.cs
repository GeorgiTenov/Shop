using System;

namespace Shop_homework13_GeorgiTenov
{
    public class Password
    {
        private string _pass;
        public string Pass
        {
            get
            {
                return this._pass;
            }

            private set
            {
                if (value.Length == Password.Characters)
                {
                    this._pass = value;
                    Console.WriteLine("Successfull Registration");
                }
                else
                {
                    Console.WriteLine("Passord must contain 6 characters or numbers");
                }
            }
        }

        public const int Characters = 6;

        public Password(string password)
        {
            this.Pass = password;
        }
    }
}
