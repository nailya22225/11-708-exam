using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_708_exam
{
    public class FileManager
    {
        public byte[] LoadFile(string path)
        {
            return System.IO.File.ReadAllBytes(path);
        }
    }
}
