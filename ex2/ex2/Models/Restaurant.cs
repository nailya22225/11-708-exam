using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex2.Models
{
    public class Restaurant
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }

        public virtual List<Dish> Dishes { get; set; }
    }
}
