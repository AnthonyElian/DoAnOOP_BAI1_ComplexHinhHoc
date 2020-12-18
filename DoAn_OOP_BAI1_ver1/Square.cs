using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_BAI1_ver1
{
    class Square : Shape
    {
        public Square() : base() { }

        public Square(Point p1, Point p2, int color) : base(p1, p2, color) { }

        ~Square() { }
        public override void Nhap()
        {
            base.Nhap();
        }

        public new void Nhap(Point p1, Point p2, int color)
        {
            base.Nhap(p1, p2, color);
        }

        public override void Ve()
        {
            //Console.WriteLine();
            Console.WriteLine("Ve Hinh Vuong");
            Console.WriteLine("Ve Khung Hinh Vuong");
        }

        public override void changeColor()
        {
            base.changeColor();
        }

        public new void changeColor(int color)
        {
            base.changeColor(color);
        }

        public override void Move()
        {
            base.Move();
        }

        public new void Move(Point p1, Point p2)
        {
            base.Move(p1, p2);
        }

        public double Canh()
        {
            double Canh = Math.Abs(this.P1.x - this.P2.x);
            return Canh;
        }

        public override double DienTich()
        {
            double DienTich = this.Canh() * this.Canh();
            return DienTich;
        }

        public override double ChuVi()
        {
            return this.Canh() * 4;
        }

        public override void Xuat()
        {
            Console.WriteLine("Thong tin Toa Do thu nhat cua khung Hinh Vuong la: ");
            this.P1.Xuat();

            Console.WriteLine("Thong tin Toa Do thu hai cua khung Hinh Vuong la: ");
            this.P2.Xuat();

            Console.WriteLine("Thong tin Mau Sac cua Hinh Vuong la: " + this.Color);

            Console.WriteLine("Canh Hinh Vuong la: " + this.Canh());

            //Console.WriteLine("Dien Tich Hinh Vuong la: " + this.DienTich());
        }
    }
}
