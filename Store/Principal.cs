using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Principal
    {
        int n = 0;
        int count = 0;
        Product[] products = new Product[1000];

        public void Welcome()
        {
            Console.WriteLine("==== Bienvenidos a Nuestra Tienda ======");

            Menu();
        }

        public void Menu()
        {
            Console.WriteLine("Elija un numero del menú para hacer alguna Acción");
            Console.WriteLine("1.- Agregar Producto");
            Console.WriteLine("2.- Mostrar Producto");
            Console.WriteLine("3.- Detalles de Producto");
            Console.WriteLine("4.- Vender Producto");
            Console.WriteLine("5.- Salir");
            RepoStore r = new RepoStore();
            

            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    GetProduct();
                    break;
                case 2:
                    Console.Clear();
                    r.ShowProduct(products);
                    Console.WriteLine();
                    Menu();
                    break;

                case 3:
                    Console.Clear();
                    r.ShowProduct(products);
                    Console.WriteLine("Elije un numero de la lista");
                    var choice = Convert.ToInt32(Console.ReadLine());
                    r.DetailProduct(products[choice]);
                    break;

                default:
                    Console.WriteLine("Elige un elemento");
                 break;
            }


        }

        private void GetProduct()
        {
            Console.WriteLine("===== Ingrese un Producto ======");

            Product p = new Product();

            p.Id = count;
            Console.WriteLine("Ingrese un Nombre");
            p.Name = Console.ReadLine();
            Console.WriteLine("Ingrese una Descripcion");
            p.Description = Console.ReadLine();
            Console.WriteLine("Ingrese un Precio");
            p.Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese una Cantidad");
            p.Quantity = Convert.ToInt32(Console.ReadLine());

            products[count] = p;
            
            count += 1;
            Console.Clear();
            Menu();
            
            

        }
    }
}
