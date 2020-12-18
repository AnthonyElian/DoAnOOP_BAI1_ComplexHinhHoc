using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_BAI1_ver1
{
    class Triangle : Shape
    {
        public Triangle() : base() { }

        public Triangle(Point p1, Point p2, int color) : base(p1, p2, color) { }

        ~Triangle() { }

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
            Console.WriteLine("Ve Hinh Tam Giac");
            Console.WriteLine("Ve khung Hinh Tam Giac");
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

        public double ChieuCao()
        {
            double ChieuCao = Math.Abs(this.P1.y - this.P2.y);
            return ChieuCao;
        }

        public double DoDaiDay()
        {
            double DoDaiDay = Math.Abs(this.P1.x - this.P2.x);
            return DoDaiDay;
        }

        public override double DienTich()
        {
            double DienTich = this.ChieuCao() * this.DoDaiDay() * 1 / 2;
            return DienTich;
        }

        public override double ChuVi()
        {
            //throw new NotImplementedException();
            return 0;
        }

        public override void Xuat()
        {
            Console.WriteLine("Thong tin Toa Do thu nhat cua khung Hinh Tam Giac la: ");
            this.P1.Xuat();

            Console.WriteLine("Thong tin Toa Do thu hai cua khung Hinh Tam Giac la: ");
            this.P2.Xuat();

            //this.LoaiTamGiac();

            Console.WriteLine("Thong tin Mau Sac cua Hinh Tam Giac la: " + this.Color);

            Console.WriteLine("Chieu Cao Hinh Tam Giac la: " + this.ChieuCao());
            Console.WriteLine("Do Dai Day Hinh Tam Giac la: " + this.DoDaiDay());

            //Console.WriteLine("Dien Tich Hinh Tam Giac la: " + this.DienTich());
        }
    }
}
