using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class PrintFileGen <T> where T: IPrintableFile
    {
        public string FileName { get; set; }

        public void Print<T>(T obj)
        {
            Console.WriteLine(obj);
        }
    }
}
