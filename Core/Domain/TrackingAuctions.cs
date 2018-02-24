namespace App3.Domain
{
    public class TrackingAuctions
    {
        public string auctionTitle { get; private set; }
        public long auctionId { get; private set; }
        public string sellerLogin { get; private set; }
        public float price { get; private set; }

        public TrackingAuctions(string auctionTitle, long auctionId, string sellerLogin,float price = 0)
        {
            this.auctionTitle = auctionTitle;
            this.auctionId = auctionId;
            this.sellerLogin = sellerLogin;
            this.price = price;
        }
    }
}