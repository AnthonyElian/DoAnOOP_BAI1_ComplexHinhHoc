using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_BAI1_ver1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int flag = 1;
             
            while (flag == 1)
            {
                Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                Console.WriteLine("\t\t\t\t***           1. Thao Tac Voi Hinh Chu Nhat                ***");
                Console.WriteLine("\t\t\t\t***           2. Thao Tac Voi Doan Thang                   ***");
                Console.WriteLine("\t\t\t\t***           3. Thao Tac Voi Hinh Tron                    ***");
                Console.WriteLine("\t\t\t\t***           4. Thao Tac Voi Hinh Tam Giac                ***");
                Console.WriteLine("\t\t\t\t***           5. Thao Tac Voi Hinh Vuong                   ***");
                Console.WriteLine("\t\t\t\t***           6. Thao Tac Voi Hinh Thoi                    ***");
                Console.WriteLine("\t\t\t\t***           7. Thao Tac Voi Hinh Ngu Giac Deu            ***");
                Console.WriteLine("\t\t\t\t***           8. Thao Tac Voi Tat Ca Ca Hinh               ***");
                Console.WriteLine("\t\t\t\t***           9. Thoat                                     ***");
                Console.WriteLine("\t\t\t\t**************************************************************");
                Console.Write("Moi nhap lua chon cua ban => Your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Program.MenuHCN();
                            break;
                        }
                    case 2:
                        {
                            Program.MenuDoanThang();
                            break;
                        }
                    case 3:
                        {
                            Program.MenuHTron();
                            break;
                        }
                    case 4:
                        {
                            Program.MenuHTG();
                            break;
                        }
                    case 5:
                        {
                            Program.MenuHV();
                            break;
                        }
                    case 6:
                        {
                            Program.MenuHT();
                            break;
                        }
                    case 7:
                        {
                            Program.MenuHNGD();
                            break;
                        }
                    case 8:
                        {
                            ComplexObject A;
                            A = new ComplexObject();
                            Program.MenuCO(ref A);
                            break;
                        }
                    case 9:
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

        static public void MenuTemp(ComplexObject CO, ref ComplexObject Temp)
        {
            int flag = 1;
            while (flag == 1)
            {
                Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                Console.WriteLine("\t\t\t\t***           1. Merge                                     ***");
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
                            CO.Xuat();
                            Console.WriteLine("Tong so Hinh o tren la: " + CO.ListShape.Count);
                            Temp = uGroup.Merge(CO.ListShape);
                            Temp.Xuat();
                            break;
                        }
                    case 2:
                        {
                            uGroup.Devided(ref Temp);
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

        static public void MenuCO(ref ComplexObject Temp)
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
                        Console.WriteLine("\t\t\t\t***           5. Thoat                                     ***");
                        Console.WriteLine("\t\t\t\t**************************************************************");
                        Console.Write("Moi nhap lua chon cua ban => Your choice: ");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                {
                                    Program.MenuTemp(CO, ref Temp);
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

        static public void MenuHNGD()
        {
            int flag = 1;
            Pentagon HNGD = new Pentagon();
            HNGD.Nhap();
            try
            {
                if (Math.Abs(HNGD.P1.x - HNGD.P2.x) == Math.Abs(HNGD.P1.y - HNGD.P2.y) && (HNGD.P1.x != HNGD.P2.x && HNGD.P1.y != HNGD.P2.y))
                {
                    while (flag == 1)
                    {
                        Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                        Console.WriteLine("\t\t\t\t***           1. Di Chuyen Hinh Ngu Giac den Vi Tri moi    ***");
                        Console.WriteLine("\t\t\t\t***           2. Doi Mau Hinh Ngu Giac                     ***");
                        Console.WriteLine("\t\t\t\t***           3. Ve Hinh Ngu Giac                          ***");
                        Console.WriteLine("\t\t\t\t***           4. Dien Tich Hinh Ngu Giac                   ***");
                        Console.WriteLine("\t\t\t\t***           5. Chu Vi Hinh Ngu Giac                      ***");
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
                                        HNGD.Move();
                                    }
                                    while (Math.Abs(HNGD.P1.x - HNGD.P2.x) != Math.Abs(HNGD.P1.y - HNGD.P2.y));
                                    break;
                                }
                            case 2:
                                {
                                    HNGD.changeColor();
                                    HNGD.Xuat();
                                    break;
                                }
                            case 3:
                                {
                                    HNGD.Ve();
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Dien Tich Hinh Ngu Giac Deu la: " + HNGD.DienTich());
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Chu Vi Hinh Tron la: " + HNGD.ChuVi());
                                    break;
                                }
                            case 6:
                                {
                                    HNGD.PhongTo();
                                    HNGD.Xuat();
                                    break;
                                }
                            case 7:
                                {
                                    HNGD.ThuNho();
                                    HNGD.Xuat();
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
                    throw new Exception("Khong the ve hinh ngu giac deu voi khung hinh chu nhat!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static public void MenuHT()
        {
            int flag = 1;           
            try
            {
                Rhombus HT = new Rhombus();
                HT.Nhap();
                if (HT.P1.x != HT.P2.x && HT.P2.y != HT.P1.y)
                {
                    while (flag == 1)
                    {
                        Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                        Console.WriteLine("\t\t\t\t***           1. Di Chuyen Hinh Thoi den Vi Tri moi        ***");
                        Console.WriteLine("\t\t\t\t***           2. Doi Mau Hinh Thoi                         ***");
                        Console.WriteLine("\t\t\t\t***           3. Ve Hinh Thoi                              ***");
                        Console.WriteLine("\t\t\t\t***           4. Dien Tich Hinh Thoi                       ***");
                        Console.WriteLine("\t\t\t\t***           5. Chu Vi Hinh Thoi                          ***");
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
                                    HT.Move();
                                    HT.Xuat();
                                    break;
                                }
                            case 2:
                                {
                                    HT.changeColor();
                                    HT.Xuat();
                                    break;
                                }
                            case 3:
                                {
                                    HT.Ve();
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Dien Tich Hinh Thoi la: " + HT.DienTich());
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Chu Vi Hinh Thoi la: " + HT.ChuVi());
                                    break;
                                }
                            case 6:
                                {
                                    HT.PhongTo();
                                    HT.Xuat();
                                    break;
                                }
                            case 7:
                                {
                                    HT.ThuNho();
                                    HT.Xuat();
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

        static public void MenuHV()
        {
            int flag = 1;
            Square HV = new Square();
            HV.Nhap();
            try
            {
                if (Math.Abs(HV.P1.x - HV.P2.x) == Math.Abs(HV.P1.y - HV.P2.y) && ((HV.P1.x != HV.P2.x) && (HV.P1.y != HV.P2.y)))
                {
                    while (flag == 1)
                    {
                        Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                        Console.WriteLine("\t\t\t\t***           1. Di Chuyen Hinh Vuong den Vi Tri moi       ***");
                        Console.WriteLine("\t\t\t\t***           2. Doi Mau Hinh Vuong                        ***");
                        Console.WriteLine("\t\t\t\t***           3. Ve Hinh Vuong                             ***");
                        Console.WriteLine("\t\t\t\t***           4. Dien Tich Hinh Vuong                      ***");
                        Console.WriteLine("\t\t\t\t***           5. Chu Vi Hinh Vuong                         ***");
                        Console.WriteLine("\t\t\t\t***           7. Phong To                                  ***");
                        Console.WriteLine("\t\t\t\t***           6. Thu Nho                                   ***");
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
                                        HV.Move();
                                    }
                                    while (Math.Abs(HV.P1.x - HV.P2.x) != Math.Abs(HV.P1.y - HV.P2.y));
                                    break;
                                }
                            case 2:
                                {
                                    HV.changeColor();
                                    HV.Xuat();
                                    break;
                                }
                            case 3:
                                {
                                    HV.Ve();
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Dien Tich Hinh Vuong la: " + HV.DienTich());
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Chu Vi Hinh Vuong la: " + HV.ChuVi());
                                    break;
                                }
                            case 6:
                                {
                                    HV.PhongTo();
                                    HV.Xuat();
                                    break;
                                }
                            case 7:
                                {
                                    HV.ThuNho();
                                    HV.Xuat();
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
                    throw new Exception("Khong the ve hinh vuong voi khung hinh chu nhat! | Hoac ban nhap 2 diem trung nhau! ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static public void MenuHTG()
        {
            int flag = 1;            
            try
            {
                Triangle HTG = new Triangle();
                HTG.Nhap();
                if (HTG.P1.x != HTG.P2.x && HTG.P2.y != HTG.P1.y)
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
                                    HTG.Move();
                                    HTG.Xuat();
                                    break;
                                }
                            case 2:
                                {
                                    HTG.changeColor();
                                    HTG.Xuat();
                                    break;
                                }
                            case 3:
                                {
                                    HTG.Ve();
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Dien Tich Hinh Tam Giac la: " + HTG.DienTich());
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Chu Vi Hinh Tam Giac la: " + HTG.ChuVi());
                                    break;
                                }
                            case 6:
                                {
                                    HTG.PhongTo();
                                    HTG.Xuat();
                                    break;
                                }
                            case 7:
                                {
                                    HTG.ThuNho();
                                    HTG.Xuat();
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

        static public void MenuHTron()
        {
            int flag = 1;
            Circle HTron = new Circle();
            HTron.Nhap();
            try
            {
                if (Math.Abs(HTron.P1.x - HTron.P2.x) == Math.Abs(HTron.P1.y - HTron.P2.y) && ((HTron.P1.x != HTron.P2.x) && (HTron.P1.y != HTron.P2.y)))
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
                                        HTron.Move();
                                    }
                                    while (Math.Abs(HTron.P1.x - HTron.P2.x) != Math.Abs(HTron.P1.y - HTron.P2.y));
                                    break;
                                }
                            case 2:
                                {
                                    HTron.changeColor();
                                    HTron.Xuat();
                                    break;
                                }
                            case 3:
                                {
                                    HTron.Ve();
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Dien Tich Hinh Tron la: " + HTron.DienTich());
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Chu Vi Hinh Tron la: " + HTron.ChuVi());
                                    break;
                                }
                            case 6:
                                {
                                    HTron.PhongTo();
                                    HTron.Xuat();
                                    break;
                                }
                            case 7:
                                {
                                    HTron.ThuNho();
                                    HTron.Xuat();
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

        static public void MenuDoanThang()
        {
            int flag = 1;
            try
            {
                Line DT = new Line();
                DT.Nhap();
                if (DT.P1.x != DT.P2.x && DT.P1.y != DT.P2.y)
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
                                    DT.Move();
                                    DT.Xuat();
                                    break;
                                }
                            case 2:
                                {
                                    DT.changeColor();
                                    DT.Xuat();
                                    break;
                                }
                            case 3:
                                {
                                    DT.Ve();
                                    break;
                                }
                            case 4:
                                {
                                    DT.PhongTo();
                                    DT.Xuat();
                                    break;
                                }
                            case 5:
                                {
                                    DT.ThuNho();
                                    DT.Xuat();
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

         static public void MenuHCN()
         {
            int flag = 1;           
            try
            {
                Rectangle HCN = new Rectangle();
                HCN.Nhap();
                if (HCN.P1.x != HCN.P2.x && HCN.P2.y != HCN.P1.y)
                {
                    while (flag == 1)
                    {
                        Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                        Console.WriteLine("\t\t\t\t***           1. Di Chuyen Hinh Chu Nhat den Vi Tri moi    ***");
                        Console.WriteLine("\t\t\t\t***           2. Doi Mau Hinh Chu Nhat                     ***");
                        Console.WriteLine("\t\t\t\t***           3. Ve Hinh Chu Nhat                          ***");
                        Console.WriteLine("\t\t\t\t***           4. Dien Tich Hinh Chu Nhat                   ***");
                        Console.WriteLine("\t\t\t\t***           5. Chu Vi Hinh Chu Nhat                      ***");
                        Console.WriteLine("\t\t\t\t***           6. Phong To Hinh Chu Nhat                    ***");
                        Console.WriteLine("\t\t\t\t***           7. Thu Nho Hinh Chu Nhat                     ***");
                        Console.WriteLine("\t\t\t\t***           8. Thoat                                     ***");
                        Console.WriteLine("\t\t\t\t**************************************************************");
                        Console.Write("Moi nhap lua chon cua ban => Your choice: ");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                {
                                    HCN.Move();
                                    HCN.Xuat();
                                    break;
                                }
                            case 2:
                                {
                                    HCN.changeColor();
                                    HCN.Xuat();
                                    break;
                                }
                            case 3:
                                {
                                    HCN.Ve();
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Dien Tich Hinh Chu Nhat la: " + HCN.DienTich());
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Chu Vi Hinh Chu Nhat la: " + HCN.ChuVi());
                                    break;
                                }
                            case 6:
                                {
                                    HCN.PhongTo();
                                    HCN.Xuat();
                                    break;
                                }
                            case 7:
                                {
                                    HCN.ThuNho();
                                    HCN.Xuat();
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
