namespace App3.Infrastructure.FiltersForAllegroRequest
{
    public interface IFilter
    {
         Allegro.FilterOptionsType[] createFilter();
    }
}