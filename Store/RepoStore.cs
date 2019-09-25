using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class RepoStore
    {
        public void ShowProduct(Product[] p)
        {
            Console.WriteLine("Lista de Productos");

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i]!=null)
                {
                    Console.WriteLine(p[i].Id + "\t" + p[i].Name);
                }
                else
                {
                    break;
                }
            }

            
            
        }

        public void DetailProduct(Product p)
        {
            Console.WriteLine(p.Id+"\t"+p.Name); //Completar lo demas
        }

        public void SaleProduct(Product[] p)
        {

        }
    }
}
