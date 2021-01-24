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
        private List<ComplexObject> lCo;
        private int iFloor;

        public List<Shape> ListShape
        {
            get { return this.lShape; }
            set { this.lShape = value; }
        }
        public List<ComplexObject> LCO
        {
            get { return this.lCo; }
            set { this.lCo = value; }
        }
        public int floor
        {
            get { return this.iFloor; }
            set { this.iFloor = value; }
        }

        public ComplexObject(int floor) : base()
        {
            this.lShape = new List<Shape>();
            this.lCo = new List<ComplexObject>();
            this.P1 = new Point(0, 0);
            this.P2 = new Point(0, 0);
            this.iFloor = floor;
        }

        public ComplexObject(Point p1, Point p2, int color, List<Shape> listshape) : base(p1, p2, color)
        {
            this.lCo = new List<ComplexObject>();
            this.lShape = listshape;
            this.SetDiem();
        }

        public ComplexObject(List<Shape> lshape, int floor)
        {
            this.lCo = new List<ComplexObject>();
            this.lShape = lshape;
            this.iFloor = floor;
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
            int i = 0;
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)this.Color;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~COMPLEX OBJECT~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("      Toa Do 1: "); this.P1.Xuat(); Console.Write("             Toa Do 2: "); this.P2.Xuat(); Console.WriteLine("             Mau sac: " + Console.ForegroundColor);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ResetColor();
            foreach (Shape item in this.lShape)
            {
                Console.WriteLine("+ STT: " + i++);
                item.Xuat();
                //item.Ve();
            }
        }

        public override void Ve()
        {
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)this.Color;
            Console.WriteLine("Ve Complex");
            Console.ResetColor();
            Console.WriteLine("Ve Khung Lon cua Complex");
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

        public override double DienTich()
        {
            double DienTich = 0;
            foreach (var item in this.lShape)
            {
                DienTich = item + DienTich;
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
            Console.WriteLine("Vecto Tinh Tien V(a, b)");
            Console.Write("Hoanh Do vecto V: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Tung Do vecto V: ");
            int b = int.Parse(Console.ReadLine());
            base.Move(a, b);
            foreach (var item in this.ListShape)
                item.Move(a, b);
        }

        public int Compare(Shape a, Shape b)
        {
            // 1 lon // 2 be // 3 bang
            if (a > b)
                return 1;
            else
            {
                if (a < b)
                    return 2;
                else
                    return 3;
            }    
        }

        public override void changeColor()
        {
            base.changeColor();
        }

        public override void PhongTo()
        {
            Console.Write("Moi nhap n (n nguyen) de Hinh To ra (Moi canh tang n/2 don vi!): ");
            double n = double.Parse(Console.ReadLine());
            base.PhongTo(n);
            foreach (var item in this.ListShape)
                item.PhongTo(n);

        }

        public override void ThuNho()
        {
            Console.Write("Moi nhap n (n nguyen) de Hinh be lai (Moi canh giam n/2 don vi!):  ");
            double n = double.Parse(Console.ReadLine());
            base.ThuNho(n);
            foreach (var item in this.ListShape)
                item.ThuNho(n);
        }
        public void MenuTemp(int x)
        {
            int florida = this.lCo[x].iFloor;
            int flag = 1;
            try
            {
                if (this.lCo[x].lShape.Count != 0)
                {
                    this.lCo[x].SetDiem();
                    Console.WriteLine("Cac hinh cua CO: " + this.lCo[x].lShape.Count);
                    while (flag == 1)
                    {
                        Console.WriteLine("\t\t\t\tDAY LA TANG: " + florida);
                        Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                        Console.WriteLine("\t\t\t\t***           1. Add                                       ***");
                        Console.WriteLine("\t\t\t\t***           2. Divide                                    ***");
                        Console.WriteLine("\t\t\t\t***           3. Xuat thong tin                            ***");
                        Console.WriteLine("\t\t\t\t***           4. Thao tac khac                             ***");
                        Console.WriteLine("\t\t\t\t***           5. Ve                                        ***");
                        Console.WriteLine("\t\t\t\t***           6. Thoat ra                                  ***");
                        Console.WriteLine("\t\t\t\t**************************************************************");
                        Console.Write("Moi nhap lua chon cua ban => Your choice: ");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                {
                                    this.Xuat();
                                    Console.WriteLine("Ban muon them hinh thu may");
                                    int key = int.Parse(Console.ReadLine());
                                    this.lCo[x].add(this.lShape[key]);
                                    Console.WriteLine("Tong so Hinh o tren la: " + this.lCo[x].ListShape.Count);
                                    this.lCo[x].SetDiem();
                                    break;
                                }
                            case 2:
                                {
                                    ComplexObject temp = this.lCo[x];
                                    uGroup.Divided(ref temp);
                                    this.lCo[x] = temp;
                                    this.lCo[x].SetDiem();
                                    Console.WriteLine("Da unGroup");
                                    break;
                                }
                            case 3:
                                {
                                    //Console.WriteLine(this.iFloor);
                                    //Console.WriteLine(Temp.iFloor);
                                    Console.WriteLine("BAN DANG O TANG THU: " + florida);
                                    this.lCo[x].Xuat();
                                    break;
                                }
                            case 4:
                                {
                                    this.lCo[x].Menu();
                                    break;
                                }
                            case 5:
                                {
                                    this.lCo[x].Ve();
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
                else
                    throw new Exception("Khong Ton Tai Danh Sach Hinh!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void QLCO(int a)
        {
            int flag = 1;
            while (flag == 1)
            {
                Console.WriteLine("\t\t\t\tDAY LA TANG: " + a);
                Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                Console.WriteLine("\t\t\t\t***           1. Xuat DS CO                                ***");
                Console.WriteLine("\t\t\t\t***           2. Thao tac voi CO                           ***");
                Console.WriteLine("\t\t\t\t***           3. Xoa CO                                    ***");
                Console.WriteLine("\t\t\t\t***           4. Gop 2 CO                                  ***");
                Console.WriteLine("\t\t\t\t***           5. Thoat                                     ***");
                Console.WriteLine("\t\t\t\t**************************************************************");
                Console.Write("Moi nhap lua chon cua ban => Your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            foreach (var item in this.lCo)
                                item.Xuat();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Ban muon thao tac Co thu may: ");
                            int x = int.Parse(Console.ReadLine());
                            this.MenuTemp(x);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Ban muon xoa Co nao");
                            int x = int.Parse(Console.ReadLine());
                            this.lCo.RemoveAt(x);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Ban muon gop C0_1 nao vao CO_2 nao: ");
                            Console.Write("Moi nhap thu tu C0 thu nhat: ");int stt1 = int.Parse(Console.ReadLine());
                            Console.Write("Moi nhap thu tu CO thu hai: ");int stt2 = int.Parse(Console.ReadLine());
                            var result = this.lCo[stt1].lShape.Union(this.lCo[stt1].lShape);
                            ComplexObject temp = new ComplexObject(this.lCo[stt1].iFloor);
                            int mau = this.lCo[stt2].Color;
                            this.lCo.RemoveAt(stt2); this.lCo.RemoveAt(stt1);
                            foreach (var item in result)
                            {
                                temp.lShape.Add(item);
                            }
                            this.lCo.Add(temp);
                            Console.WriteLine(this.lCo.Count);
                            this.lCo[this.lCo.Count - 1].Color = mau;
                            this.lCo[this.lCo.Count - 1].SetDiem();
                            break;
                        }
                    case 5:
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
        public override void Menu()
        {
            int flag = 1;
            if (this.ListShape.Count == 0)
                this.Nhap();
            try
            {
                if (this.ListShape.Count != 0)
                {
                    while (flag == 1)
                    {
                        //int floor = this.iFloor + 1;
                        //this.iFloor = floor;
                        Console.WriteLine("\t\t\t\tDAY LA TANG: " + (this.iFloor+1));
                        Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                        Console.WriteLine("\t\t\t\t***           1. Thao tac tren hinh Group/UnGroup          ***");
                        Console.WriteLine("\t\t\t\t***           2. Ve Complex Object                         ***");
                        Console.WriteLine("\t\t\t\t***           3. Dien Tich Complex Object                  ***");
                        Console.WriteLine("\t\t\t\t***           4. Chu Vi Complex Object                     ***");
                        Console.WriteLine("\t\t\t\t***           5. Move                                      ***");
                        Console.WriteLine("\t\t\t\t***           6. Phong to                                  ***");
                        Console.WriteLine("\t\t\t\t***           7. thu nho                                   ***");
                        Console.WriteLine("\t\t\t\t***           8. doi mau                                   ***");
                        Console.WriteLine("\t\t\t\t***           9. Xuat thong tin CO                         ***");
                        Console.WriteLine("\t\t\t\t***          10. Quan Ly Danh sach CO                      ***");
                        Console.WriteLine("\t\t\t\t***          11. So Sanh 2 hinh da nhap                    ***");
                        Console.WriteLine("\t\t\t\t***          12. Thoat                                     ***");
                        Console.WriteLine("\t\t\t\t**************************************************************");
                        Console.Write("Moi nhap lua chon cua ban => Your choice: ");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                {

                                    int x = this.lCo.Count;
                                    //x++;
                                    ComplexObject Temp = new ComplexObject(this.iFloor+1);
                                    this.lCo.Add(Temp);
                                    this.Xuat();
                                    Console.WriteLine("Tong so Hinh o tren la: " + this.ListShape.Count);
                                    this.lCo[x] = uGroup.Merge(this.ListShape, this.iFloor + 1);
                                    Console.Write("Nhap mau cua complex da merge: ");
                                    this.lCo[x].Color = int.Parse(Console.ReadLine());
                                    this.MenuTemp(x);
                                    break;
                                }
                            case 2:
                                {
                                    this.Ve();
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("Dien Tich Complex Object la: " + this.DienTich());
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Chu Vi Complex Object la: " + this.ChuVi());
                                    break;
                                }
                            case 5:
                                {

                                    this.Move();
                                    Console.WriteLine("Da di chuyen");
                                    break;
                                }
                            case 6:
                                {

                                    this.PhongTo();
                                    Console.WriteLine("Da phong to");
                                    break;
                                }
                            case 7:
                                {

                                    this.ThuNho();
                                    Console.WriteLine("Da thu nho");
                                    break;
                                }
                            case 8:
                                {

                                    this.changeColor();
                                    Console.WriteLine("Da doi mau");
                                    break;
                                }
                            case 9:
                                {
                                    Console.WriteLine("BAN DANG O TANG THU: " + (this.iFloor+1)) ;
                                    this.Xuat();
                                    break;
                                }
                            case 10:
                                {
                                    this.QLCO(this.iFloor + 1);
                                    break;
                                }
                            case 11:
                                {
                                    this.Xuat();
                                    Console.Write("Chon hinh thu nhat co stt la: "); int stt1 = int.Parse(Console.ReadLine());
                                    Console.Write("Chon hinh thu hai co stt la: "); int stt2 = int.Parse(Console.ReadLine());
                                    if (this.Compare(this.lShape[stt1], this.lShape[stt2]) == 1)
                                    { 
                                        Console.WriteLine("Chu vi hinh 1: " + this.lShape[stt1].ChuVi() + " lon hon hinh hai: " + this.lShape[stt2].ChuVi()); 
                                    }    
                                    else
                                    {
                                        if (this.Compare(this.lShape[stt1], this.lShape[stt2]) == 2)
                                        {
                                            Console.WriteLine("Chu vi hinh 1: " + this.lShape[stt1].ChuVi() + " be hon hinh hai: " + this.lShape[stt2].ChuVi());
                                        }
                                        else
                                            Console.WriteLine("Chu vi hinh 1: " + this.lShape[stt1].ChuVi() + " bang hinh hai: " + this.lShape[stt2].ChuVi());
                                    }
                                    break;
                                }
                            case 12:
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
                    throw new Exception("Khong Ton Tai Danh Sach Hinh!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
