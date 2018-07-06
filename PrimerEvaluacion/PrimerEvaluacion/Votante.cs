using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEvaluacion
{
    public class Votante : Persona
    {
        public int Edad;
        public string Genero;

        public Votante(int id, string nombre, int edad, string genero) : base(id, nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
        }
    }
}
