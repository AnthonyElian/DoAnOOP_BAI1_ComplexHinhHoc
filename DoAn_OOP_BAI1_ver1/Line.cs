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

        //public override void DKVe()
        //{
        //    base.DKVe();
        //}

        public override void Ve()
        {
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)this.Color;
            Console.WriteLine("Ve Doan Thang");
            Console.ResetColor();
            Console.WriteLine("Ve Khung Doan Thang: ");
            Console.WriteLine("| 1_None | 2_Hidden | 3_Dotted | 4_Dashed | 5_Solid | 6_Double | 7_Groove | 8_Ridge | 9_Inset | 10_Outset |");
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
            Console.WriteLine("Thong tin Mau Sac cua Doan Thang da duoc thay doi! ");
            base.changeColor(color);
        }

        public override double DienTich()
        {
            return 0;
        }

        public override double ChuVi()
        {
            return 0;
        }

        public override void Move()
        {
            base.Move();
        }

        public new void Move(Point p1)
        {
            Console.WriteLine("Doan Thang da duoc di chuyen den vi tri moi! ");
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

        public override void Xuat()
        {
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)this.Color;
            Console.WriteLine("Thong tin Toa Do thu nhat cua khung Doan Thang la: ");
            this.P1.Xuat();

            Console.WriteLine("Thong tin Toa Do thu hai cua khung Doan Thang la: ");
            this.P2.Xuat();

            Console.WriteLine("Thong tin Mau Sac cua Doan Thang la: " + this.Color + " " + Console.ForegroundColor);
            Console.ResetColor();
        }

        public override void Menu()
        {
            int flag = 1;
            try
            {
                //Line this = new Line();
                //this.Nhap();
                if (this.P1.x != this.P2.x || this.P1.y != this.P2.y)
                {
                    while (flag == 1)
                    {
                        Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                        Console.WriteLine("\t\t\t\t***           1. Di Chuyen Doan Thang den Vi Tri moi       ***");
                        Console.WriteLine("\t\t\t\t***           2. Doi Mau Doan Thang                        ***");
                        Console.WriteLine("\t\t\t\t***           3. Ve Doan Thang                             ***");
                        Console.WriteLine("\t\t\t\t***           4. Phong To                                  ***");
                        Console.WriteLine("\t\t\t\t***           5. Thu Nho                                   ***");
                        Console.WriteLine("\t\t\t\t***           6. Thoat                                     ***");
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
                                    this.PhongTo();
                                    this.Xuat();
                                    break;
                                }
                            case 5:
                                {
                                    this.ThuNho();
                                    this.Xuat();
                                    break;
                                }
                            case 6:
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
