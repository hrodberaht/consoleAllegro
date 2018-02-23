namespace App3.Core.Connections
{
    public class CreateConnectToAllegroWDSL
    {
        public static readonly Allegro.servicePortClient connect = new Allegro.servicePortClient();

        public int MyProperty { get; set; }
    }
}