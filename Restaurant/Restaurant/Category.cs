using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Category
    {
        //Encapsulación de propiedades
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}
