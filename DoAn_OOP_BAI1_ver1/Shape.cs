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

        public void DKVe()
        {           
            int flag = 1;
            int dem = 0;
            while (flag == 1)
            {
                Console.WriteLine("|1_Tat ca | 2_Canh Tren | 3_Canh Duoi | 4_Canh Trai | 5_Canh Phai | 6_Thoat |");
                Console.Write("Your choice => ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Dong Khung Tat Ca");
                            flag = 0;
                            break;
                        }
                    case 2:
                        {
                            dem = dem + 1;
                            Console.WriteLine("Dong Khung Canh Tren");
                            if (dem == 4)
                                flag = 0;
                            break;
                        }
                    case 3:
                        {
                            dem = dem + 1;
                            Console.WriteLine("Dong Khung Canh Duoi");
                            if (dem == 4)
                                flag = 0;
                            break;
                        }
                    case 4:
                        {
                            dem = dem + 1;
                            Console.WriteLine("Dong Khung Canh Trai");
                            if (dem == 4)
                                flag = 0;
                            break;
                        }
                    case 5:
                        {
                            dem = dem + 1;
                            Console.WriteLine("Dong Khung Canh Phai");
                            if (dem == 4)
                                flag = 0;
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Nguyen Hieu Dan");
                            flag = 0;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ban Nhap Sai!!! Vui long nhap lai ~~ ");
                            break;
                        }
                }
            }
        }

        public abstract void Ve();

        public virtual void Move()
        {
            Console.WriteLine("Vecto Tinh Tien V(a, b)");
            Console.Write("Hoanh Do vecto V: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Tung Do vecto V: ");
            int b = int.Parse(Console.ReadLine());
            this.p1.x = this.p1.x + a;
            this.p2.x = this.p2.x + a;
            this.p1.y = this.p1.y + b;
            this.p2.y = this.p2.y + b;
        }

        public virtual void PhongTo()
        {
            Console.Write("Moi nhap n de Hinh To ra (Moi canh tang n/2 don vi!): ");
            int n = int.Parse(Console.ReadLine());
            double temp = n / 2;
            this.p1.y = this.p1.y - temp;
            this.p1.x = this.p1.x - temp;
            this.p2.x = this.p2.x + temp;
            this.p2.y = this.p2.y + temp;       
        }

        public virtual void ThuNho()
        {
            Console.Write("Moi nhap n de Hinh be lai (Moi canh giam n/2 don vi!):  ");
            int n = int.Parse(Console.ReadLine());
            double temp = n / 2;
            this.p1.y = this.p1.y + temp;
            this.p1.x = this.p1.x + temp;
            this.p2.x = this.p2.x - temp;
            this.p2.y = this.p2.y - temp;
        }

        public void Move(Point P1)
        {
            this.p1.x = this.p1.x + P1.x;
            this.p1.y = this.p2.y + P1.y;
            this.p2.x = this.p2.x + P1.x;
            this.p2.y = this.p2.y + P1.y;
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

        public abstract void Menu();
    }
}
