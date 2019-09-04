using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_1
{
    public class Operaciones
    {
        public void MostrarProducto(Producto prod)
        {
            Console.WriteLine(prod.Id + " " + prod.Nombre + " " + prod.Codigo + " " + prod.Precio);
        }
    }
}
