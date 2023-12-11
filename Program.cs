using System;

namespace DemoEnums
{
    public enum ShippingMethod //what ever you name here make sure to name it down on the bottom of code
    {
        RegularAirMail = 1,
        RegisteredAirMail=  2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express; //So you use shippingMethod here

            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); //also here use shipping method

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
