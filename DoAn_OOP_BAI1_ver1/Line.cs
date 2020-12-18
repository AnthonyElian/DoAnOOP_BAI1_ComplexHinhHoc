using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_BAI1_ver1
{
    class Line : Shape
    {
        public Line() : base() { }

        public Line(Point p1, Point p2, int color) : base(p1, p2, color) { }

        ~Line() { }

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
            //throw new NotImplementedException();
            Console.WriteLine();
            Console.WriteLine("Ve Doan Thang");
            Console.WriteLine("Ve khung Doan Thang");
            
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

        public override double DienTich()
        {
            throw new NotImplementedException();
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
            Console.WriteLine("Thong tin Toa Do thu nhat cua khung Doan Thang la: ");
            this.P1.Xuat();

            Console.WriteLine("Thong tin Toa Do thu hai cua khung Doan Thang la: ");
            this.P2.Xuat();

            Console.WriteLine("Thong tin Mau Sac cua Doan Thang la: " + this.Color);
        }
    }
}
