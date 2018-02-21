using System;
using System.Threading;
using App3;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            long id = Config.auctionId;
            string auctionTitle = Config.auctionTitle;
            string webApi = Config.webApi;
            bool run = true;
            
            //create connect to Allegro WDSL
            Allegro.servicePortClient all = new Allegro.servicePortClient(); 
            
            //create filter
            Allegro.FilterOptionsType[] filter = new Allegro.FilterOptionsType[1];
            filter[0] = new Allegro.FilterOptionsType();
            filter[0].filterId = "search";
            string[] title = new string[1];
            title[0] = auctionTitle;
            filter[0].filterValueId = title;
            
            
            Allegro.doGetItemsListRequest request = new Allegro.doGetItemsListRequest(webApi,1,filter,null,100,0,1);
            
            while(run)
            {
                var data = all.doGetItemsListAsync(request);
                Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
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
