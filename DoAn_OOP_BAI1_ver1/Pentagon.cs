using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_BAI1_ver1
{
    public class Pentagon : Shape
    {
        public Pentagon() : base() { }

        public Pentagon(Point p1, Point p2, int color) : base(p1, p2, color) { }

        ~Pentagon() { }

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
            Console.WriteLine("Ve Hinh Ngu Giac Deu");
            Console.WriteLine("Ve khung Hinh Ngu Giac Deu");
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

        public double BanKinhKhungTronNgoaiTiep()
        {
            double temp = this.P1.x - this.P2.x;
            return temp / 2;
        }

        public double CanhNguGiacDeu()
        {
            double tmp = 50 + 10 * Math.Sqrt(5);
            double temp = Math.Sqrt(tmp) / 10;
            return this.BanKinhKhungTronNgoaiTiep() / temp;
        }

        public override double DienTich()
        {
            double temp = 25 + (10 * Math.Sqrt(5));
            double DienTich = (Math.Sqrt(temp) / 4) * Math.Pow(this.CanhNguGiacDeu(), 2);
            return DienTich;
        }

        public override void Xuat()
        {
            Console.WriteLine("Thong tin Toa Do thu nhat cua khung Hinh Ngu Giac Deu la: ");
            this.P1.Xuat();

            Console.WriteLine("Thong tin Toa Do thu hai cua khung Hinh Ngu Giac Deu la: ");
            this.P2.Xuat();

            Console.WriteLine("Thong tin Mau Sac cua Hinh Ngu Giac Deu la: " + this.Color);

            Console.WriteLine("Canh cua Hinh Ngu Giac Deu la: " + this.CanhNguGiacDeu());

            Console.WriteLine("Dien Tich Hinh Ngu Giac Deu la: " + this.DienTich());
        }
    }
}
