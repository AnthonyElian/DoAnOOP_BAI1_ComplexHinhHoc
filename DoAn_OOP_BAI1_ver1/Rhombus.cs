﻿using System;
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
            Console.WriteLine("|1_None | 2_Hidden | 3_Dotted | 4_Dashed | 5_Solid | 6_Double | 7_Groove | 8_Ridge | 9_Inset | 10_Outset |");
            Console.Write("Your choice => ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Khong Ve Khung");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Khung An");
                        this.DKVe();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Khung Cham");
                        this.DKVe();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Khung Gach");
                        this.DKVe();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Khung Solid");
                        this.DKVe();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Khung Double");
                        this.DKVe();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Khung Groove");
                        this.DKVe();
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Khung Ridge");
                        this.DKVe();
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Khung Inset");
                        this.DKVe();
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Khung Outset");
                        this.DKVe();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ban Nhap Sai!!! Vui long nhap lai ~~ ");
                        break;
                    }
            }
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

        public new void Move(Point p1)
        {
            base.Move(p1);
        }
        public override void PhongTo()
        {
            base.PhongTo();
        }

        public override void ThuNho()
        {
            base.ThuNho();
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
