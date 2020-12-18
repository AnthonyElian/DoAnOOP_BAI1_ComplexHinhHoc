using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_BAI1_ver1
{
    class ComplexObject : Shape
    {
        private List<Shape> lShape;

        public List<Shape> ListShape
        {
            get { return this.lShape; }
            set { this.lShape = value; }
        }
        public ComplexObject() : base() 
        {
            this.lShape = new List<Shape>();
        }

        public ComplexObject(Point p1, Point p2, int color, List<Shape> listshape) : base(p1, p2, color) 
        {
            this.lShape = listshape;
        }

        public ComplexObject(List<Shape> lshape)
        {
            this.lShape = lshape;
        }

        ~ComplexObject() { }

        public override void Nhap()
        {
            Console.Write("Vui long nhap so luong Doan Thang: ");
            int DT = int.Parse(Console.ReadLine());
            for (int i = 0; i < DT; i++)
            {
                Line a = new Line();
                a.Nhap();
                this.lShape.Add(a);
            }

            Console.Write("Vui long nhap so luong Hinh Tron: ");
            int HT = int.Parse(Console.ReadLine());
            for (int i = 0; i < HT; i++)
            {
                Circle a = new Circle();
                a.Nhap();
                try
                {
                    if (Math.Abs(a.P1.x - a.P2.x) == Math.Abs(a.P1.y - a.P2.y))
                    {
                        this.lShape.Add(a);
                    }
                    else
                        throw new Exception("Khong the ve hinh vuong voi khung hinh chu nhat!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.Write("Vui long nhap so luong Hinh Chu Nhat: ");
            int HCN = int.Parse(Console.ReadLine());
            for (int i = 0; i < HCN; i++)
            {
                Rectangle a = new Rectangle();
                a.Nhap();
                this.lShape.Add(a);
            }

            Console.Write("Vui long nhap so luong Hinh Tam Giac: ");
            int TG = int.Parse(Console.ReadLine());
            for (int i = 0; i < TG; i++)
            {
                Triangle a = new Triangle();
                a.Nhap();
                this.lShape.Add(a);
            }

            Console.Write("Vui long nhap so luong Hinh Vuong: ");
            int HV = int.Parse(Console.ReadLine());
            for (int i = 0; i < HV; i++)
            {
                Square a = new Square();
                a.Nhap();
                try
                {
                    if (Math.Abs(a.P1.x - a.P2.x) == Math.Abs(a.P1.y - a.P2.y))
                    {
                        this.lShape.Add(a);
                    }
                    else
                        throw new Exception("Khong the ve hinh vuong voi khung hinh chu nhat!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.Write("Vui long nhap so luong Hinh Thoi: ");
            int HTh = int.Parse(Console.ReadLine());
            for (int i = 0; i < HTh; i++)
            {
                Rhombus a = new Rhombus();
                a.Nhap();
                this.lShape.Add(a);
            }

            Console.Write("Vui long nhap so luong Hinh Ngu Giac Deu: ");
            int HNGD = int.Parse(Console.ReadLine());
            for (int i = 0; i < HNGD; i++)
            {
                Pentagon a = new Pentagon();
                a.Nhap();
                try
                {
                    if (Math.Abs(a.P1.x - a.P2.x) == Math.Abs(a.P1.y - a.P2.y))
                    {
                        this.lShape.Add(a);
                    }
                    else
                        throw new Exception("Khong the ve hinh Ngu Giac Deu voi khung hinh chu nhat!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            //Console.Write("Moi nhap Mau cua Complex Object: ");
            //this.Color = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            foreach (Shape item in this.lShape)
            {
                item.Xuat();
                //item.Ve();
            }
            //Console.WriteLine("Dien tich complex object la: " + this.DienTich());
        }

        public override void Ve()
        {
            Console.WriteLine("Ve Complex");
            Console.WriteLine("Ve Khung Lon cua Complex");
        }

        public override double DienTich()
        {
            double DienTich = 0;
            foreach (Shape item in this.lShape)
            {
                DienTich = DienTich + item.DienTich();
            }
            return DienTich;
        }

        public override double ChuVi()
        {
            double ChuVi = 0;
            foreach (Shape item in this.lShape)
            {
                ChuVi = ChuVi + item.ChuVi();
            }
            return ChuVi;
        }
    }
}
