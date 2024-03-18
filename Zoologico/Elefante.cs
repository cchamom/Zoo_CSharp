using System;

namespace Zoologico
{
    class Elefante
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Sonido { get; set; }
        public string Comida { get; set; }
        public string Lugar { get; set; }

        //metodos
        public Elefante(string Nombre, string Especie, string Sonido, string Comida, string Lugar)

        {
            this.Nombre = Nombre;
            this.Especie = Especie;
            this.Sonido = Sonido;
            this.Comida = Comida;
            this.Lugar = Lugar;

        }

    }
}
