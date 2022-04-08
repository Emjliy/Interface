using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Excell : IPrintableFile
    {
        public int RowCount { get; set; }
        public int ColumnCount { get; set; }
        public Excell(int rowCount, int columnCount,string fileName)
        {
            RowCount = rowCount;
            ColumnCount = columnCount;
            FileName = fileName;
        }
        public string FileName { get; set; } 

        public void Print()
        {
            Console.WriteLine($"{RowCount} {ColumnCount} {FileName}");
        }
    }
}
