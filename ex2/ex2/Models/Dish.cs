using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex2.Models
{
    public class Dish
    {
        public virtual int Id { get; set; }
        public virtual decimal Cost { get; set; }
        public virtual string Description { get; set; }
    }
}
