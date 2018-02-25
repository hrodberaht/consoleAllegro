namespace App3.Infrastructure.FiltersForAllegroRequest
{
    public class SearchFilter : IFilter
    {
        string auctionTitle = Config.auctionTitle;
        public Allegro.FilterOptionsType[] createFilter()
        {
            Allegro.FilterOptionsType[] filter = new Allegro.FilterOptionsType[1];
            filter[0] = new Allegro.FilterOptionsType();
            filter[0].filterId = "search";
            string[] title = new string[1];
            title[0] = auctionTitle;
            filter[0].filterValueId = title;

            return filter;
        }
    }
}