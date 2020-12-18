using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_BAI1_ver1
{
    class Rectangle : Shape
    {
        public Rectangle() : base() { }

        public Rectangle(Point p1, Point p2, int color) : base(p1, p2, color) { }

        ~Rectangle() { }

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
            Console.WriteLine();
            Console.WriteLine("Ve Hinh Chu Nhat");
            Console.WriteLine("Ve khung Hinh Chu Nhat");
        }

        public override void changeColor()
        {
            base.changeColor();
        }

        public void changeColor(int color)
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

        public double ChieuDai()
        {
            double ChieuDai = Math.Abs(this.P1.x - this.P2.x);
            return ChieuDai;
        }

        public double ChieuRong()
        {
            double ChieuRong = Math.Abs(this.P1.y - this.P2.y);
            return ChieuRong;
        }

        public override double DienTich()
        {
            double DienTich = this.ChieuRong() * this.ChieuDai();
            return DienTich;
        }

        public override void Xuat()
        {
            Console.WriteLine("Thong tin Toa Do thu nhat cua khung Hinh Chu Nhat la: ");
            this.P1.Xuat();

            Console.WriteLine("Thong tin Toa Do thu hai cua khung Hinh Chu Nhat la: ");
            this.P2.Xuat();

            Console.WriteLine("Thong tin Mau Sac cua Hinh Chu Nhat la: " + this.Color);

            Console.WriteLine("Chieu Dai Hinh Chu Nhat la: " + this.ChieuDai());
            Console.WriteLine("Chieu Rong Hinh Chu Nhat la: " + this.ChieuRong());

            Console.WriteLine("Dien Tich Hinh Chu Nhat la: " + this.DienTich());
        }
    }
}
