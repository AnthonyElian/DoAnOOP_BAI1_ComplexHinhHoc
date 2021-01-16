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
            do {
                base.Nhap(); 
            }
            while(Math.Abs(this.P1.x - this.P2.x) != Math.Abs(this.P1.y - this.P2.y));
        }

        public new void Nhap(Point p1, Point p2, int color)
        {
            base.Nhap(p1, p2, color);
        }

        public override void Ve()
        {
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)this.Color;
            Console.WriteLine("Ve Hinh Tron");
            Console.ResetColor();
            Console.WriteLine("Ve Khung Hinh Tron: ");
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
            double DienTich = Math.PI * this.DuongKinh() / 2 * this.DuongKinh() / 2;
            return DienTich;
        }

        public override double ChuVi()
        {
            return Math.PI * this.DuongKinh();
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
            Console.WriteLine("Thong tin Toa Do thu nhat cua khung Hinh Tron la: ");
            this.P1.Xuat();

            Console.WriteLine("Thong tin Toa Do thu hai cua khung Hinh Tron la: ");
            this.P2.Xuat();

            Console.WriteLine("Thong tin Mau Sac cua Hinh Tron la: " + this.Color);
            Console.ResetColor();
            Console.WriteLine("Ban Kinh cua Hinh Tron la: " + this.DuongKinh() / 2);

            //Console.WriteLine("Dien Tich Hinh Tron la: " + this.DienTich());
        }

        public override void Menu()
        {
            int flag = 1;
            //Circle this = new Circle();
            //this.Nhap();
            try
            {
                if (Math.Abs(this.P1.x - this.P2.x) == Math.Abs(this.P1.y - this.P2.y) && ((this.P1.x != this.P2.x) && (this.P1.y != this.P2.y)))
                {
                    while (flag == 1)
                    {
                        Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                        Console.WriteLine("\t\t\t\t***           1. Di Chuyen Hinh Tron den Vi Tri moi        ***");
                        Console.WriteLine("\t\t\t\t***           2. Doi Mau Hinh Tron                         ***");
                        Console.WriteLine("\t\t\t\t***           3. Ve Hinh Tron                              ***");
                        Console.WriteLine("\t\t\t\t***           4. Dien Tich Hinh Tron                       ***");
                        Console.WriteLine("\t\t\t\t***           5. Chu Vi Hinh Tron                          ***");
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
                                    do
                                    {
                                        this.Move();
                                    }
                                    while (Math.Abs(this.P1.x - this.P2.x) != Math.Abs(this.P1.y - this.P2.y));
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
                                    Console.WriteLine("Dien Tich Hinh Tron la: " + this.DienTich());
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Chu Vi Hinh Tron la: " + this.ChuVi());
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
                    throw new Exception("Khong the ve hinh tron voi khung hinh chu nhat! Hoac Ban nhap duoc 2 diem trung nhau!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
