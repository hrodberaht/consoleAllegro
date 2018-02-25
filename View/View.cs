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
        public View()
        {
            price = new GetPriceService(new SearchFilter(), new CreateConnectToAllegroWDSL());
        }
        
        
        public void show()
        {
            Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
            var data = price.getPrice();
            
            Console.WriteLine("Id aukcji: " + data.auctionId
            + " | " + "Sprzedawca: " + data.sellerLogin 
            + " | " + "Cena: " + data.price);
            Console.WriteLine("----------------------------");
            Thread.Sleep(60000);
        }
    }
}