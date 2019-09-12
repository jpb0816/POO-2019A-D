using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciacion de la clase
            Operacion op = new Operacion();
            //llamada al metodo Bienvenida
            op.Bienvenida();

            //Instanciacion del objeto Figura.
            Figura figura = new Figura();

            figura.LadoA = 20;
            figura.LadoB = 30;

            //Creamos una variable y le asignamos lo que nos retorna el metodo.
            var area=op.Calcular(figura);

            //Imprimimos el valor de retorno.s
            Console.WriteLine("El Area de la Figura es {0}",area);
            Console.ReadKey();
        }
    }
}
