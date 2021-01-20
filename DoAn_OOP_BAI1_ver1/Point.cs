using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_BAI1_ver1
{
    public class Point
    {
        private double dx;
        private double dy;
        public double x
        {
            get { return this.dx; }
            set { this.dx = value; }    
        }

        public double y
        {
            get { return this.dy; }
            set { this.dy = value; }
        }

        public Point() { }

        public Point(double x, double y)
        {
            this.dx = x;
            this.dy = y;
        }

        ~Point() { }

        public void Nhap()
        {
            Console.Write("Moi nhap Hoanh Do: ");
            this.dx = double.Parse(Console.ReadLine());

            Console.Write("Moi nhap Tung Do: ");
            this.dy = double.Parse(Console.ReadLine());
        }

        public void Nhap(double x, double y)
        {
            this.dx = x;
            this.dy = y;
        }
        
        public void Xuat()
        {
            Console.Write("( " + Math.Round(this.dx,3) + ", " + Math.Round(this.dy, 3) +" )");
        }
    }
}
