using System;

namespace Práctica5
{
    class Program
    {
        static void Main(string[] args)
        {
            dias();
            Console.ReadKey();
        }
        static void dias()
        {
            DateTime hoy = DateTime.Today;
            String fecha = "31 Diciembre 2019";
            DateTime cambio = DateTime.Parse(fecha);
            TimeSpan dif = cambio - hoy;
            int dias = dif.Days;
            Console.WriteLine("Faltan {0:N2} dias", dias.ToString());


        }
    }
}
