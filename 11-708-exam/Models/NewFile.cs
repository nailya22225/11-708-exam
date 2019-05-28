using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_708_exam
{
    public class NewFile
    {
        public IFormFileCollection FileData { get; set; }
        public File File { get; set; }
    }
}
