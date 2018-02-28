using System;
using System.Threading;
using App3.Infrastructure.ConnectionToAllegro;
using App3.Infrastructure.FiltersForAllegroRequest;
using App3.Infrastructure.Services;

namespace App3.View
{
    public class View
    {
        IGetPriceService price;
        float isPriceChange = 0;
        public View()
        {
            price = new GetPriceService(new SearchFilter(), new CreateConnectToAllegroWDSL());
        }
        
        
        public void show()
        {
            var data = price.getPrice();
            if (isPriceChange != data.price)
            {
                Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
                Console.WriteLine("Id aukcji: " + data.auctionId
                + " | " + "Sprzedawca: " + data.sellerLogin 
                + " | " + "Cena: " + data.price);
                Console.WriteLine("----------------------------");
                isPriceChange = data.price;
            }
            Thread.Sleep(60000);
        }
    }
}