using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEvaluacion
{
    public class Candidato : Persona
    {
        public Candidato(int id, string nombre) : base(id, nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }
    }
}
