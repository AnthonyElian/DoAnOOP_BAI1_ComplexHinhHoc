using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_BAI1_ver1
{
    class Circle : Shape
    {
        public Circle() : base(){ }
        public Circle(Point p1, Point p2, int color) : base(p1, p2, color) { }

        ~Circle() { }

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
            Console.WriteLine("Ve Hinh Tron");
            Console.WriteLine("Ve khung Hinh Tron");
        }

        public override void changeColor()
        {
            base.changeColor();
        }

        public new void changeColor(int color)
        {
            Console.WriteLine("Thong tin Mau Sac cua Doan Thang da duoc thay doi! ");
            base.changeColor(color);
        }

        public double DuongKinh()
        {
            double DuongKinh = Math.Abs(this.P1.x - this.P2.x);
            return DuongKinh;
        }

        public override double DienTich()
        {
            double DienTich = 3.14 * this.DuongKinh();
            return DienTich;
        }

        public override void Move()
        {
            base.Move();
        }

        public new void Move(Point p1, Point p2)
        {
            Console.WriteLine("Doan Thang da duoc di chuyen den vi tri moi! ");
            base.Move(p1, p2);
        }

        public override void Xuat()
        {
            Console.WriteLine("Thong tin Toa Do thu nhat cua khung Hinh Tron la: ");
            this.P1.Xuat();

            Console.WriteLine("Thong tin Toa Do thu hai cua khung Hinh Tron la: ");
            this.P2.Xuat();

            Console.WriteLine("Thong tin Mau Sac cua Hinh Tron la: " + this.Color);

            Console.WriteLine("Ban Kinh cua Hinh Tron la: " + this.DuongKinh() / 2);

            Console.WriteLine("Dien Tich Hinh Tron la: " + this.DienTich());
        }
    }
}
