using System.Collections.Generic;
using App3.Domain;

namespace App3.Repositiores
{
    public class MemoryRepositiores : IMemoryRepository
    {
        List<TrackingAuctions> data;
        public void connectToData()
        {
            List<TrackingAuctions> data = new List<TrackingAuctions>();
        }
        public void addToMemoryRepository()
        {
            data.Add(new TrackingAuctions());
        }

        public void deleteFromMemoryRepository()
        {
            throw new System.NotImplementedException();
        }
    }
}