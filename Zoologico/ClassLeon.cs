using System;

namespace Zoologico
{
    class Leon
    {
        //propiedades
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Sonido { get; set; }
        public string Comida { get; set; }
        //metodos
        public Leon(string Nombre, string Especie, string Sonido, string Comida)

        {
            this.Nombre = Nombre;
            this.Especie = Especie;
            this.Sonido = Sonido;
            this.Comida = Comida;
        }


    }
}
