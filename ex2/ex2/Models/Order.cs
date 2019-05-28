using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex2.Models
{
    public class Order
    {
        public virtual int Id { get; set; }

        public virtual User Customer { get; set; }
        public virtual Dish Dish { get; set; }
        public virtual int Count { get; set; }
    }
}
