using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto productoX = new Producto();
            productoX.Id = 5;
            productoX.Codigo = "Sod-05";
            productoX.Precio = 12.00m;

            Console.WriteLine("Datos del Producto");
            productoX.Ver_Producto(productoX);

            Operaciones op = new Operaciones();
            op.MostrarProducto(productoX);
            Console.ReadKey();
        }
    }
}
