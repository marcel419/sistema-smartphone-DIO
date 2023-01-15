using DesafioPOO.Models;
using System;

namespace DesaioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Smartphone Iphone");
            Smartphone iphone = new Iphone("8190003030", "iphone 15", "12121200012131", 128);
            iphone.Ligar();
            iphone.InstalarAplicativo("Instagram");

            Console.WriteLine("");

            Console.WriteLine("Smartphone Nokia");
            Smartphone nokia = new Nokia("81999778830", "nokia 3000", "1233423243223", 64);
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Maps");
        }
    }
}

