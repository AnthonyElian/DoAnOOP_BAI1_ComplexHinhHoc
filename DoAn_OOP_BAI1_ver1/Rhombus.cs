using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_BAI1_ver1
{
    class Rhombus : Shape
    {
        public Rhombus() : base() { }

        public Rhombus(Point p1, Point p2, int color) : base(p1, p2, color) { }

        ~Rhombus() { }

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
            Console.WriteLine("Ve Hinh Thoi");
            Console.WriteLine("Ve khung Hinh Thoi");
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

        //Hinh Thoi nam ngang
        public double DuongCheoThuNhat()
        {
            double DC1 = Math.Abs(this.P1.x - this.P2.x);
            return DC1;
        }

        public double DuongCheoThuHai()
        {
            double DC2 = Math.Abs(this.P1.y - this.P2.y);
            return DC2;
        }

        public double Canh()
        {
            return Math.Sqrt(Math.Pow(this.DuongCheoThuNhat() / 2, 2) + Math.Pow(this.DuongCheoThuHai() / 2, 2));
        }

        public override double DienTich()
        {
            double DienTich = this.DuongCheoThuHai() * this.DuongCheoThuNhat();
            return DienTich;
        }

        public override double ChuVi()
        {
            return 4 * this.Canh();
        }

        public override void Xuat()
        {
            Console.WriteLine("Thong tin Toa Do thu nhat cua khung Hinh Thoi la: ");
            this.P1.Xuat();

            Console.WriteLine("Thong tin Toa Do thu hai cua khung Hinh Thoi la: ");
            this.P2.Xuat();

            Console.WriteLine("Thong tin Mau Sac cua Hinh Thoi la: " + this.Color);

            Console.WriteLine("Duong Cheo Thu Nhat cua Hinh Thoi la: " + this.DuongCheoThuNhat());
            Console.WriteLine("Duong Cheo Thu Hai cua Hinh Thoi la: " + this.DuongCheoThuHai());

            //Console.WriteLine("Dien Tich Hinh Thoi la: " + this.DienTich());
        }
    }
}
