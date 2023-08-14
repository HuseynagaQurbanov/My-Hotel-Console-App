using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHotel myHotel = new MyHotel(10);
            Console.WriteLine("--------------");
            Customer customer = new Customer();
            customer.Name = "Johny";
            customer.Surname = "Deep";
            myHotel.SetUser(5, customer, "standart");
        }
    }
}
