using SimpleFactoryPattern.Model;
using System;

namespace SimpleFactoryPattern
{
    class Program
    {
        //*Sample主要流程為:
        //一家飲料店提供幾種飲料,每一種飲料除了價格和吸管不同
        //其它的出餐手續都相同,
        //這時候可以使用一個飲料工廠的概念將飲料出餐不同的部分封裝進去
        //由這個飲料工廠統一負責這些不同的邏輯
        //而主要的邏輯只需要對"飲料"這種物件作處理即可
        //
        //*定義一個建立物件的介面，但讓實作這個介面的類別來決定例項化哪個類別。
        //工廠方法讓類別的實例化推遲到子類別中進行。

        static void Main(string[] args)
        {
            var store = new BeverageStore();

            Console.WriteLine("A 客人點了綠茶");
            store.BeverageOrders("GreenTea");

            Console.WriteLine("B 客人點了紅茶");
            store.BeverageOrders("BlackTea");

            Console.ReadLine();
        }
    }
}
