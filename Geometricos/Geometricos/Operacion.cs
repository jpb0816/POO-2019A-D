using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos
{
    public class Operacion
    {

        public double Calcular(Figura f)
        {
            //solo hacemos el calculo, para poder reutilizar el metodo
            var area = f.LadoA * f.LadoB;

            return area;
        }
        public void Bienvenida()
        {
            //Despliega el metodo Bienvenida con su respectivo Mensaje.
            Console.WriteLine("Hola Bienvenido");
        }
    }
}
