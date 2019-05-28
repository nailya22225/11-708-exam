using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_708_exam
{
    public class File
    {
        public virtual int Id { get; set; }
        public virtual string Url { get; set; }
        public virtual string BaseName { get; set; }
        public virtual string NewName { get; set; }
        public virtual string Description { get; set; }
        public virtual string Extension { get; set; }
        public virtual string LongDescription { get; set; }
        public virtual string Path { get; set; }

    }
}
