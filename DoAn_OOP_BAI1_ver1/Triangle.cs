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

        public override void Menu()
        {
            int flag = 1;
            try
            {
                //Triangle this = new Triangle();
                //this.Nhap();
                if (this.P1.x != this.P2.x && this.P2.y != this.P1.y)
                {
                    while (flag == 1)
                    {
                        Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                        Console.WriteLine("\t\t\t\t***           1. Di Chuyen Hinh Tam Giac den Vi Tri moi    ***");
                        Console.WriteLine("\t\t\t\t***           2. Doi Mau Hinh Tam Giac                     ***");
                        Console.WriteLine("\t\t\t\t***           3. Ve Hinh Tam Giac                          ***");
                        Console.WriteLine("\t\t\t\t***           4. Dien Tich Hinh Tam Giac                   ***");
                        Console.WriteLine("\t\t\t\t***           5. Chu Vi Hinh Tam Giac                      ***");
                        Console.WriteLine("\t\t\t\t***           6. Phong To                                  ***");
                        Console.WriteLine("\t\t\t\t***           7. Thu Nho                                   ***");
                        Console.WriteLine("\t\t\t\t***           8. Thoat                                     ***");
                        Console.WriteLine("\t\t\t\t**************************************************************");
                        Console.Write("Moi nhap lua chon cua ban => Your choice: ");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                {
                                    this.Move();
                                    this.Xuat();
                                    break;
                                }
                            case 2:
                                {
                                    this.changeColor();
                                    this.Xuat();
                                    break;
                                }
                            case 3:
                                {
                                    this.Ve();
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Dien Tich Hinh Tam Giac la: " + this.DienTich());
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Chu Vi Hinh Tam Giac la: " + this.ChuVi());
                                    break;
                                }
                            case 6:
                                {
                                    this.PhongTo();
                                    this.Xuat();
                                    break;
                                }
                            case 7:
                                {
                                    this.ThuNho();
                                    this.Xuat();
                                    break;
                                }
                            case 8:
                                {
                                    flag = 0;
                                    Console.Clear();
                                    break;
                                }
                            default:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Ban Nhap Sai!!! Vui long nhap lai ~~ ");
                                    break;
                                }
                        }
                    }
                }
                else
                    throw new Exception("Khong the nhap 2 diem trung nhau!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
