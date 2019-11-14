using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.hw1
{
    class Cell
    {
        char colum;
        int line;
        public Cell(char colum, int line)
        {
            if ((colum < 'a' || colum > 'h') || (line > 8) || (line < 1))
            {
                throw new OutOfRange("Exception");
            }
            this.colum = colum;
            this.line = line;


        }
        public void WhatCellColour()
        {
            if ((Convert.ToInt32(colum) + line) % 2 == 0)
            {
                Console.WriteLine("Black");
            }
            else
                Console.WriteLine("White ");
        }
        public bool VerticalPosition(char colum, char colum2)
        {
            if (Convert.ToInt32(colum) == Convert.ToInt32(colum2))
            {
                return true;
            }
            else
                return false;
        }
        public bool HorizontalPosition(int line, int line2)
        {
            if (line == line2)
            {
                return true;
            }
            else
                return false;
        }
        public bool DiagonalPosition(int line, char colum, int line2, char colum2)
        {
            int letterDif = Convert.ToInt32(colum) - Convert.ToInt32(colum2);
            int numberDif = line - line2;
            if (Math.Abs(letterDif) == Math.Abs(numberDif))
            {
                return true;
            }
            else
                return false;
        }
    }
}
