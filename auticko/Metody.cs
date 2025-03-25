using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auticko
{
    internal class Metody
    {
        private float palivo;
        public void Natankuj(int litr)
        {
            palivo += litr;
        }
        public void stavPaliva()
        {
            Console.WriteLine($"momentálně máš {palivo} litrů paliva");
            Thread.Sleep(2000);
        }
        public void Jed()
        {
            Console.WriteLine("Kolik km chceš ujet?");
            int km = Convert.ToInt32(Console.ReadLine());
            float spotreba = (km/palivo)*100;
            palivo -= spotreba;
            if(palivo < 0)
            {
                Console.WriteLine("Není možné ujet tolik km s tímto množstím palivem");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine($"Spotřeboval jsi {spotreba} paliva na {km} km");
                Thread.Sleep(2000);
            }
            //Debug.Write(spotreba);
            //Debug.Write(palivo);
        }
    }
}
