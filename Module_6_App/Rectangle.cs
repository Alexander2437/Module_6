using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6_App
{
    public class Rectangle
    {
        public int a;
        public int b;

        public int Area()
        {
            return a * b;
        }

        public Rectangle() { a = 6; b = 4; }
        public Rectangle(int a, int b) { this.a = a; this.b = b; }
        public Rectangle(int side) { a = b = side; }
    }
}
