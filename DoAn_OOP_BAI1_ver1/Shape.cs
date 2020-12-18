using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_BAI1_ver1
{
    public abstract class Shape
    {
        private Point p1;
        private Point p2;
        private int iColor;

        public Point P1
        {
            get { return this.p1; }
            set { this.p1 = value; }
        }

        public Point P2
        {
            get { return this.p2; }
            set { this.p2 = value; }
        }

        public int Color
        {
            get { return this.iColor; }
            set { this.iColor = value; }
        }

        public Shape() 
        {
            this.p1 = new Point();
            this.p2 = new Point();
        }

        public Shape(Point P1, Point P2, int color)
        {
            this.p1 = P1;
            this.p2 = P2;
            this.iColor = color;
        }
        ~Shape() { }

        public virtual void Nhap()
        {
            Console.WriteLine("Moi nhap thong tin toa do Diem Thu Nhat: ");
            this.p1.Nhap();

            Console.WriteLine("Moi nhap thong tin toa do Diem Thu Hai: ");
            this.p2.Nhap();

            Console.Write("Moi nhap thong tin Mau Sac: ");
            this.iColor = int.Parse(Console.ReadLine());
        }

        public void Nhap(Point P1, Point P2, int color)
        {
            this.p1 = P1;
            this.p2 = P2;
            this.iColor = color;
        }

        public abstract double DienTich();

        public abstract double ChuVi();

        public abstract void Xuat();

        public abstract void Ve();

        public virtual void Move()
        {
            Console.WriteLine("Moi nhap thong tin toa do Diem Thu Nhat muon thay doi! ");
            this.p1.Nhap();

            Console.WriteLine("Moi nhap thong tin toa do Diem Thu Hai muon thay doi! ");
            this.p2.Nhap();
        }

        public void Move(Point P1, Point P2)
        {
            this.p1 = P1;
            this.p2 = P2;
        }

        public virtual void changeColor()
        {
            Console.Write("Moi nhap thong tin Mau muon thay doi: ");
            this.iColor = int.Parse(Console.ReadLine());
        }

        public void changeColor(int color)
        {
            this.iColor = color;
        }
    }
}
