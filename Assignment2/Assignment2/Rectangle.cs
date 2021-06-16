using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Rectangle
    {
        private int Length;
        private int Width;
        private int Perimeter;
        private int Area;

        public Rectangle()
        {
            Length = 1;
            Width = 1;
        }

        public Rectangle(int l, int w)
        {
            Length = l;
            Width = w;
        }

        public int GetLength()
        {
            return Length;
        }

        public int SetLength(int length)
        {
            Length = length;
            return Length;
        }

        public int GetWidth()
        {
            return Length;
        }

        public int SetWidth(int width)
        {
            Width = width;
            return Width;
        }

        public int GetPerimeter()
        {
            return Perimeter;
        }

        public int GetArea()
        {
            return Area;
        }
    }
}