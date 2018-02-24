using System;
using System.Threading;
using App3;
using App3.Core.Connections;
using App3.View;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            View view = new View();

            while(run)
            {
                view.show();
                Thread.Sleep(1000);
            }
            view.show();

            // Console.WriteLine("Id aukcji: " + tab[i].itemId 
            //         + " | " + "Sprzedawca: " + tab[i].sellerInfo.userLogin 
            //         + " | " + "Cena: " + tab[i].priceInfo[0].priceValue);
        }
    }
}
