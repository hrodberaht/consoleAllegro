using Allegro;


namespace App3.Infrastructure.ConnectionToAllegro
{
    public class CreateConnectToAllegroWDSL : ICreateConnectToAllegroWDSL
    {
        public servicePortClient connect()
        {
            return new  Allegro.servicePortClient();
        }
    }
}