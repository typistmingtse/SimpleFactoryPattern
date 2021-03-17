using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.Model
{
    /// <summary>
    /// 飲料店類別
    /// </summary>
    public class BeverageStore
    {
        public IBeverage BeverageOrders(string pBeverageType)
        {
            //創立何種飲料物件交由飲料工廠
            var beverage = BeverageFactory(pBeverageType);

            beverage.Pay();
            beverage.Straw();

            return beverage;
        }

        public IBeverage BeverageFactory(string pBeverageType) => pBeverageType switch
        {
            "GreenTea" => new BubbleTea(),
            "BlackTea" => new BlackTea(),
            _ => null
        };

        /*
        //Before C# 7.3
        public IBeverage CreateBeverage(string pBeverageType)
        {


            IBeverage beverage;
            switch (pBeverageType)
            {
                case "GreenTea":
                    return beverage = new GreenTea();
                case "BlackTea":
                    return beverage = new BlackTea();
                default:
                    return null;
            }
        }
        */
    }
}
