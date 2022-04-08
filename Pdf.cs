using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Pdf : IPrintableFile
    {
        public int PageCount { get; set; }
        public Pdf(int pagecount, string fileName)
        {
            PageCount = pagecount;
            FileName = fileName;
        }

        public string FileName { get; set; }

        public void Print()
        {
            Console.WriteLine($"{PageCount}  {FileName}");
        }
    }
}
