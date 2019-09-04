using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_1
{
    public class Producto
    {
        private int id;
        private string codigo;
        private string nombre;
        private Decimal precio;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        } 
        public void Ver_Producto(Producto producto)
        {

            Console.WriteLine(producto.Id+" "+producto.Nombre+" "+producto.Codigo+" "+producto.Precio);
        }
    }
    
}
