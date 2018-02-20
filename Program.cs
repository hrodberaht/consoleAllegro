using System;
using System.Threading;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            long id = 6830104511;
            string webapi = "";
            bool run = true;
            

            Allegro.servicePortClient all = new Allegro.servicePortClient();
            
            Allegro.FilterOptionsType[] ar = new Allegro.FilterOptionsType[1];
            ar[0] = new Allegro.FilterOptionsType();
            ar[0].filterId = "search";
            string[] title = new string[1];
            title[0] = "BUTELKA ANTYKOLKOWA AVENT NATURAL 260 ml + smoczek";
            ar[0].filterValueId = title;
            
            Allegro.doGetItemsListRequest request = new Allegro.doGetItemsListRequest(webapi,1,ar,null,100,0,1);
            
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
                Thread.Sleep(60000);
                Console.WriteLine("----------------------------");
            }
            
            
        }
    }
}
