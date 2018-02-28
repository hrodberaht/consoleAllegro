using System;
using System.Threading;
using App3.Domain;
using App3.Infrastructure.ConnectionToAllegro;
using App3.Infrastructure.FiltersForAllegroRequest;

namespace App3.Infrastructure.Services
{
    public class GetPriceService : IGetPriceService
    {
        long id = Config.auctionId;
        string auctionTitle = Config.auctionTitle;
        string webApi = Config.webApi;

        private readonly Allegro.FilterOptionsType[] _filter;
        private readonly Allegro.servicePortClient _sendRequest;
        public GetPriceService(IFilter serach,ICreateConnectToAllegroWDSL allegro)
        {
            _filter = serach.createFilter();
            _sendRequest = allegro.connect();
        }

        //create request
        public TrackingAuctions getPrice()
        {
           
            var request = new Allegro.doGetItemsListRequest(webApi,1,_filter,null,100,0,1);
        
            var data = _sendRequest.doGetItemsListAsync(request);
            Allegro.ItemsListType[] tab = data.Result.itemsList;

            for(int i = 0; i < data.Result.itemsList.Length ; i++ ){
                if(id == tab[i].itemId){
                return new TrackingAuctions(auctionTitle, tab[i].itemId, tab[i].sellerInfo.userLogin, tab[i].priceInfo[0].priceValue );  
                } 
            } 
            return new TrackingAuctions("",0,"",0); 
        }
    }
}