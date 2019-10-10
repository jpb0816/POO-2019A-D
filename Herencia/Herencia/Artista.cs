using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    //La herencia en c# se hace poniendo : despues de la clase
    //la herencia nos indica que podra heredar todas los atributos 
    //asi como sus metodos. por lo tanto se podran hacer uso d ellos
    // sin que tengamos que escribirlas en la Subclase, que en este caso es la clase hija.
    public class Artista:Persona
    {
        public int Id { get; set; }
        public string GenMusical { get; set; }

    }
}
