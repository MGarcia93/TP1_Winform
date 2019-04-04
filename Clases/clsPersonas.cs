using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class clsPersonas
    {
        public string Nombre{ get; set; }

        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public string Sexo { get; set; }
        public string EstiloMusical { get; set; }
        public string ColorFavorito { get; set; }
        public clsPersonas(string nombre, string apellido, DateTime fecha, string sexo, string musica,string color)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNac = fecha;
            this.EstiloMusical = musica;
            this.Sexo = sexo;
            this.ColorFavorito = color;
       }
        public clsPersonas() { }
    }
}
