using App3.Domain;

namespace App3.Infrastructure.Services
{
    public interface IGetPriceService
    {
        TrackingAuctions getPrice(); 
    }
}