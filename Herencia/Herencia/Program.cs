using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia de una clase Sub Clase
            // de la cual se hara uso de las propiedades de la Super Clase Persona

            Artista a = new Artista();
            a.Id = 1;
            a.Nombre = "Juan de las Pitayas";
            a.Direccion = "Ave. De las Flores No 2010";
            a.Email = "Pitayas@mail.com";
            a.Genero = "M";
            a.GenMusical = "Rock Metalico Muy Metalico";

            Console.WriteLine(a.Nombre+"\t"+a.Direccion);
            Console.ReadLine();
        }
    }
}
