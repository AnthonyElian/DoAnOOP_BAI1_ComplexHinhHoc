using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_BAI1_ver1
{
    public class ComplexObject : Shape
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
            this.P1 = new Point(0, 0);
            this.P2 = new Point(0, 0);
        }

        public ComplexObject(Point p1, Point p2, int color, List<Shape> listshape) : base(p1, p2, color) 
        {
            this.lShape = listshape;
            this.SetDiem(); ;
        }

        public ComplexObject(List<Shape> lshape)
        {
            this.lShape = lshape;
            this.SetDiem();
        }

        ~ComplexObject() { }
        public void add(Shape X)
        {
            this.lShape.Add(X);
        }
        public void SetDiem()
        {
            double xmax = double.MinValue, ymax = double.MinValue, xmin = double.MaxValue, ymin = double.MaxValue;
            foreach (var item in this.lShape)
            {
                if (item.P1.x > xmax)
                    xmax = item.P1.x;
                if (item.P1.y > ymax)
                    ymax = item.P1.y;
                if (item.P2.x > xmax)
                    xmax = item.P2.x;
                if (item.P2.y > ymax)
                    ymax = item.P2.y;

                if (item.P1.x < xmin)
                    xmin = item.P1.x;
                if (item.P1.y < ymin)
                    ymin = item.P1.y;
                if (item.P2.x < xmin)
                    xmin = item.P2.x;
                if (item.P2.y < ymin)
                    ymin = item.P2.y;
            }
            this.P1.x = xmin;
            this.P1.y = ymin;
            this.P2.x = xmax;
            this.P2.y = ymax;
        }
        public override void changeColor()
        {
            base.changeColor();
        }
        public override void Nhap()
        {
            Console.Write("Vui long nhap so luong Doan Thang: ");
            int DT = int.Parse(Console.ReadLine());
            for (int i = 0; i < DT; i++)
            {
                try
                {
                    Line a = new Line();
                    a.Nhap();
                    if (a.P1.x != a.P2.x || a.P2.y != a.P1.y)
                    {
                        this.lShape.Add(a);
                    }
                    else
                        throw new Exception("Khong the nhap 2 diem trung nhau!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.Write("Vui long nhap so luong Hinh Tron: ");
            int HT = int.Parse(Console.ReadLine());
            for (int i = 0; i < HT; i++)
            {
                Circle a = new Circle();
                a.Nhap();
                try
                {
                    if (Math.Abs(a.P1.x - a.P2.x) == Math.Abs(a.P1.y - a.P2.y) && (a.P1.x != a.P2.x && a.P2.y != a.P1.y))
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
                try
                {
                    Rectangle a = new Rectangle();
                    a.Nhap();
                    if (a.P1.x != a.P2.x && a.P2.y != a.P1.y)
                    {
                        this.lShape.Add(a);
                    }
                    else
                        throw new Exception("Khong the nhap 2 diem trung nhau!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.Write("Vui long nhap so luong Hinh Tam Giac: ");
            int TG = int.Parse(Console.ReadLine());
            for (int i = 0; i < TG; i++)
            {
                try
                {
                    Triangle a = new Triangle();
                    a.Nhap();
                    if (a.P1.x != a.P2.x && a.P2.y != a.P1.y)
                    {
                        this.lShape.Add(a);
                    }
                    else
                        throw new Exception("Khong the nhap 2 diem trung nhau!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.Write("Vui long nhap so luong Hinh Vuong: ");
            int HV = int.Parse(Console.ReadLine());
            for (int i = 0; i < HV; i++)
            {
                Square a = new Square();
                a.Nhap();
                try
                {
                    if (Math.Abs(a.P1.x - a.P2.x) == Math.Abs(a.P1.y - a.P2.y) && (a.P1.x != a.P2.x && a.P2.y != a.P1.y))
                    {
                        this.lShape.Add(a);
                    }
                    else
                        throw new Exception("Khong the ve hinh vuong voi khung hinh chu nhat! Hoac ban nhap 2 diem trung nhau!");
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
                try
                {
                    Rhombus a = new Rhombus();
                    a.Nhap();
                    if (a.P1.x != a.P2.x && a.P2.y != a.P1.y)
                    {
                        this.lShape.Add(a);
                    }
                    else
                        throw new Exception("Khong the nhap 2 diem trung nhau!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.Write("Vui long nhap so luong Hinh Ngu Giac Deu: ");
            int HNGD = int.Parse(Console.ReadLine());
            for (int i = 0; i < HNGD; i++)
            {
                Pentagon a = new Pentagon();
                a.Nhap();
                try
                {
                    if (Math.Abs(a.P1.x - a.P2.x) == Math.Abs(a.P1.y - a.P2.y) && (a.P1.x != a.P2.x && a.P2.y != a.P1.y))
                    {
                        this.lShape.Add(a);
                    }
                    else
                        throw new Exception("Khong the ve hinh Ngu Giac Deu voi khung hinh chu nhat! Hoac ban dang nhap 2 diem trung nhau");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.Write("Moi nhap Mau cua Complex Object: ");
            this.Color = int.Parse(Console.ReadLine());
            this.SetDiem();
        }

        public override void Xuat()
        {
            Console.WriteLine("Thong tin Toa Do thu nhat cua khung Complex la: ");
            this.P1.Xuat();

            Console.WriteLine("Thong tin Toa Do thu hai cua khung Complex la: ");
            this.P2.Xuat();

            Console.WriteLine("Thong tin Mau Sac cua Complex la: " + this.Color);
            foreach (Shape item in this.lShape)
            {
                item.Xuat();
                //item.Ve();
            }
            Console.WriteLine("Mau cua complexobject la: ");
            this.changeColor();
        }

        public override void Ve()
        {
            Console.WriteLine("Ve Complex");
            Console.WriteLine("Ve Khung Lon cua Complex");
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

        public override void Move()
        {
            base.Move();
        }

        //public override void changeColor()
        //{
        //    base.changeColor();
        //}

        //public override void PhongTo()
        //{
        //    base.PhongTo();
        //}

        //public override void ThuNho()
        //{
        //    base.ThuNho();
        //}

        public override void Menu()
        {
            throw new NotImplementedException();
        }
        public void MenuTemp()
        {
            int flag = 1;
            ComplexObject Temp = new ComplexObject();
            this.Xuat();
            Console.WriteLine("Tong so Hinh o tren la: " + this.ListShape.Count);
            Temp = uGroup.Merge(this.ListShape);
            Temp.SetDiem();
            Console.WriteLine("Da merge: " + Temp.lShape.Count);
            while (flag == 1)
            {
                
                Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                Console.WriteLine("\t\t\t\t***           1. Add                                       ***");
                Console.WriteLine("\t\t\t\t***           2. Devided                                   ***");
                Console.WriteLine("\t\t\t\t***           3. Dien Tich                                 ***");
                Console.WriteLine("\t\t\t\t***           4. Chu Vi                                    ***");
                Console.WriteLine("\t\t\t\t***           5. Ve                                        ***");
                Console.WriteLine("\t\t\t\t***           6. Thoat                                     ***");
                Console.WriteLine("\t\t\t\t**************************************************************");
                Console.Write("Moi nhap lua chon cua ban => Your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            //this.Xuat();
                            Console.WriteLine("Ban muon them hinh thu may");
                            int key = int.Parse(Console.ReadLine());
                            Temp.add(this.lShape[key]);
                            Console.WriteLine("Tong so Hinh o tren la: " + Temp.ListShape.Count);
                            Temp.SetDiem();
                            break;
                        }
                    case 2:
                        {
                            uGroup.Devided(ref Temp);
                            Temp.SetDiem(); 
                            Temp.Xuat();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Dien Tich la: " + Temp.DienTich());
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Chu Vi la: " + Temp.ChuVi());
                            break;
                        }
                    case 5:
                        {
                            Temp.Ve();
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
                            // Console.Clear();
                        }
                }
            }
        }

        public void MenuCO()
        {
            int flag = 1;
            ComplexObject CO = new ComplexObject();
            //ComplexObject Temp;
            CO.Nhap();
            try
            {
                if (CO.ListShape.Count != 0)
                {
                    while (flag == 1)
                    {
                        Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                        Console.WriteLine("\t\t\t\t***           1. Thao tac tren hinh da merge hoac devide   ***");
                        Console.WriteLine("\t\t\t\t***           2. Ve Complex Object                         ***");
                        Console.WriteLine("\t\t\t\t***           3. Dien Tich Complex Object                  ***");
                        Console.WriteLine("\t\t\t\t***           4. Chu Vi Complex Object                     ***");
                        Console.WriteLine("\t\t\t\t***           5. Move                                     ***");
                        Console.WriteLine("\t\t\t\t***           6. Thoat                                     ***");
                        Console.WriteLine("\t\t\t\t**************************************************************");
                        Console.Write("Moi nhap lua chon cua ban => Your choice: ");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                {
                                    CO.MenuTemp();
                                    break;
                                }
                            case 2:
                                {
                                    CO.Ve();
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("Dien Tich Complex Object la: " + CO.DienTich());
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Chu Vi Complex Object la: " + CO.ChuVi());
                                    break;
                                }
                            case 5:
                                {

                                    CO.Move();
                                    CO.Xuat();
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
                    throw new Exception("Khong Toan Tai Danh Sach Hinh!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
