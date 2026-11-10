using System;
using System.Collections.Generic;
using System.Text;

namespace practica2
{
    internal class Valores
    {
        public Personaje personaje = new Personaje();

        public Valores()
        {
            personaje.Nombre = "Jorge";
            personaje.Vida = 100;
            personaje.Ataque = 20;
            personaje.Defensa = 10;
            personaje.Nivel = 1;
        }
    }
}
