using System;
using System.Collections.Generic;
using TestDotnet.Entidades;

namespace TestDotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            LlamadaDepartamental llamadaDepto = new LlamadaDepartamental();
            llamadaDepto.Franja = 0;
            llamadaDepto.Duracion = 10;
            llamadaDepto.PrecioUno = 1.5;
            llamadaDepto.NumeroOrigen = "46681000";
            llamadaDepto.NumeroDestino = "12345678";

            LlamadaLocal llamadaLocal = new LlamadaLocal();
            llamadaLocal.Duracion = 5;
            llamadaLocal.Precio = 0.96;
            llamadaLocal.NumeroOrigen = "56688745";
            llamadaLocal.NumeroDestino = "98765432";

            LlamadaLocal local = new LlamadaLocal();
            local.Duracion = 25;
            local.Precio = 0.96;
            local.NumeroOrigen = "56128932";
            local.NumeroDestino = "45329864";

            List<Llamada> llamadasRealizadas = new List<Llamada>();
            llamadasRealizadas.Add(llamadaDepto);
            llamadasRealizadas.Add(llamadaLocal);
            llamadasRealizadas.Add(local);

            foreach (Llamada item in llamadasRealizadas)
            {
                if (item is LlamadaLocal)
                {
                    Console.WriteLine($"Precio Llamada Local ({item}): {item.CalcularPrecio()}");
                }
                else if (item is LlamadaDepartamental)
                {
                    Console.WriteLine($"Precio Llamada Departamental ({item}): {item.CalcularPrecio()}");
                }
            }
            Console.ReadKey();
        }
    }
}
