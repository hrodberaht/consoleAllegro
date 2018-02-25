namespace App3.Infrastructure.ConnectionToAllegro
{
    public interface ICreateConnectToAllegroWDSL
    {
         Allegro.servicePortClient connect();
    }
}