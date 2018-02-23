using System;
using System.Threading;
using App3.Core.Connections;

namespace App3.Infrastructure.Services
{
    public class GetPriceService : IGetPriceService
    {
        long id = Config.auctionId;
        string auctionTitle = Config.auctionTitle;
        string webApi = Config.webApi;
        bool run = true; 

        //create request
        void getPrice()
        {
            var sendRequest = CreateConnectToAllegroWDSL.connect;

            Allegro.FilterOptionsType[] filter = new Allegro.FilterOptionsType[1];
            filter[0] = new Allegro.FilterOptionsType();
            filter[0].filterId = "search";
            string[] title = new string[1];
            title[0] = auctionTitle;
            filter[0].filterValueId = title;
            
            var request = new Allegro.doGetItemsListRequest(webApi,1,filter,null,100,0,1);
           
            while(run)
            {
                
                Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
                var data = sendRequest.doGetItemsListAsync(request);
                Allegro.ItemsListType[] tab = data.Result.itemsList;


                for(int i = 0; i < data.Result.itemsList.Length ; i++ ){
                    if(id == tab[i].itemId){
                        Console.WriteLine("Id aukcji: " + tab[i].itemId 
                        + " | " + "Sprzedawca: " + tab[i].sellerInfo.userLogin 
                        + " | " + "Cena: " + tab[i].priceInfo[0].priceValue);
                    }
                }

                Console.WriteLine("----------------------------");
                Thread.Sleep(60000);
            }
        }
    }
}