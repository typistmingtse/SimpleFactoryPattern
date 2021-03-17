using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.Model
{
    public class BlackTea : IBeverage
    {
        void IBeverage.Pay()
        {
            Console.WriteLine("付25元");
        }

        void IBeverage.Straw()
        {
            Console.WriteLine("拿正常吸管");
        }
    }
}
