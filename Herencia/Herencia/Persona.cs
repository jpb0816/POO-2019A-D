using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Persona //esta sera la clase Base o la super clase.
    {
        //las super clases tienen propiedades como las clases normales
        //pero a diferencia de las otras clases no tienen un Identificador
        // de tipo (Id), solo tienen propiedades generales de  las cuales 
        //se haran uso en otras clases
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Genero { get; set; }

    }
}
