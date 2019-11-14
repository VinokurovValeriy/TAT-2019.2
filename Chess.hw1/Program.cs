using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            int line1;
            char colum1;
            int line2;
            char colum2;
            while (true)
            {
                try
                {
                    Console.WriteLine("Colums 1");
                    colum1 = char.Parse(Console.ReadLine());
                    Console.WriteLine("Line 1");
                    line1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Colums 2");
                    colum2 = char.Parse(Console.ReadLine());
                    Console.WriteLine("Line 2");
                    line2 = int.Parse(Console.ReadLine());

                    Cell cell1 = new Cell(colum1, line1);
                    Cell cell2 = new Cell(colum2, line2);
                    cell1.WhatCellColour();
                    cell2.WhatCellColour();
                    Console.WriteLine(cell1.HorizontalPosition(line1, line2));
                    Console.WriteLine(cell1.VerticalPosition(colum1, colum2));
                    Console.WriteLine(cell1.DiagonalPosition(line1, colum1, line2, colum2));

                    break;
                }
                catch (OutOfRange ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}

