using System;
using System.Threading;
using App3;
using App3.View;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            View view = new View();
            IMenu menu = new Menu();
            menu.start();

            while(run)
            {
                view.show();
            }
        }
    }
}
