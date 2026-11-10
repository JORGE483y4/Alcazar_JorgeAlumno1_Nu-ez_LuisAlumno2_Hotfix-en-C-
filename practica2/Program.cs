using System;

namespace practica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Valores valores = new Valores();
            Personaje p = valores.personaje;

            Console.WriteLine($"Nombre:  {p.Nombre}");
            Console.WriteLine($"Vida:    {p.Vida}");
            Console.WriteLine($"Ataque:  {p.Ataque}");
            Console.WriteLine($"Defensa: {p.Defensa}");
            Console.WriteLine($"Nivel:   {p.Nivel}");

            Console.ReadKey(); 
        }
    }
}