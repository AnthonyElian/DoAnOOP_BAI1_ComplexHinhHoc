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
                            //ComplexObject A;
                            //Program.MenuCO(ref A);
                            break;
                        }
                    case 9:
                        {
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

        static public void MenuCO(ref ComplexObject Temp)
        {
            int flag = 1;
            ComplexObject CO = new ComplexObject();
            //ComplexObject Temp;
            CO.Nhap();
            while (flag == 1)
            {
                Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                Console.WriteLine("\t\t\t\t***           1. Merge                                     ***");
                Console.WriteLine("\t\t\t\t***           2. Devided                                   ***");
                Console.WriteLine("\t\t\t\t***           3. Ve Complex Object                         ***");
                Console.WriteLine("\t\t\t\t***           4. Dien Tich Complex Object                  ***");
                Console.WriteLine("\t\t\t\t***           5. Chu Vi Complex Object                     ***");
                Console.WriteLine("\t\t\t\t***           6. Thoat                                     ***");
                Console.WriteLine("\t\t\t\t**************************************************************");
                Console.Write("Moi nhap lua chon cua ban => Your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Temp = uGroup.Merge(CO.ListShape);
                            Temp.Xuat();
                            break;
                        }
                    case 2:
                        {
                            uGroup.Devided(ref Temp);
                            break;
                        }
                    case 3:
                        {
                            Temp.Ve();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Dien Tich Complex Object la: " + Temp.DienTich());
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Chu Vi Complex Object la: " + Temp.ChuVi());
                            break;
                        }
                    case 6:
                        {
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

        static public void MenuHNGD()
        {
            int flag = 1;
            Pentagon HNGD = new Pentagon();
            HNGD.Nhap();
            try
            {
                if (Math.Abs(HNGD.P1.x - HNGD.P2.x) == Math.Abs(HNGD.P1.y - HNGD.P2.y))
                {
                    while (flag == 1)
                    {
                        Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                        Console.WriteLine("\t\t\t\t***           1. Di Chuyen Hinh Ngu Giac den Vi Tri moi    ***");
                        Console.WriteLine("\t\t\t\t***           2. Doi Mau Hinh Ngu Giac                     ***");
                        Console.WriteLine("\t\t\t\t***           3. Ve Hinh Ngu Giac                          ***");
                        Console.WriteLine("\t\t\t\t***           4. Dien Tich Hinh Ngu Giac                   ***");
                        Console.WriteLine("\t\t\t\t***           5. Chu Vi Hinh Ngu Giac                      ***");
                        Console.WriteLine("\t\t\t\t***           6. Thoat                                     ***");
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
            Rhombus HT = new Rhombus();
            HT.Nhap();
            while (flag == 1)
            {
                Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                Console.WriteLine("\t\t\t\t***           1. Di Chuyen Hinh Thoi den Vi Tri moi        ***");
                Console.WriteLine("\t\t\t\t***           2. Doi Mau Hinh Thoi                         ***");
                Console.WriteLine("\t\t\t\t***           3. Ve Hinh Thoi                              ***");
                Console.WriteLine("\t\t\t\t***           4. Dien Tich Hinh Thoi                       ***");
                Console.WriteLine("\t\t\t\t***           5. Chu Vi Hinh Thoi                          ***");
                Console.WriteLine("\t\t\t\t***           6. Thoat                                     ***");
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

        static public void MenuHV()
        {
            int flag = 1;
            Square HV = new Square();
            HV.Nhap();
            try
            {
                if (Math.Abs(HV.P1.x - HV.P2.x) == Math.Abs(HV.P1.y - HV.P2.y))
                {
                    while (flag == 1)
                    {
                        Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                        Console.WriteLine("\t\t\t\t***           1. Di Chuyen Hinh Vuong den Vi Tri moi       ***");
                        Console.WriteLine("\t\t\t\t***           2. Doi Mau Hinh Vuong                        ***");
                        Console.WriteLine("\t\t\t\t***           3. Ve Hinh Vuong                             ***");
                        Console.WriteLine("\t\t\t\t***           4. Dien Tich Hinh Vuong                      ***");
                        Console.WriteLine("\t\t\t\t***           5. Chu Vi Hinh Vuong                         ***");
                        Console.WriteLine("\t\t\t\t***           6. Thoat                                     ***");
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
                else
                    throw new Exception("Khong the ve hinh vuong voi khung hinh chu nhat!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static public void MenuHTG()
        {
            int flag = 1;
            Triangle HTG = new Triangle();
            HTG.Nhap();
            while (flag == 1)
            {
                Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                Console.WriteLine("\t\t\t\t***           1. Di Chuyen Hinh Tam Giac den Vi Tri moi    ***");
                Console.WriteLine("\t\t\t\t***           2. Doi Mau Hinh Tam Giac                     ***");
                Console.WriteLine("\t\t\t\t***           3. Ve Hinh Tam Giac                          ***");
                Console.WriteLine("\t\t\t\t***           4. Dien Tich Hinh Tam Giac                   ***");
                Console.WriteLine("\t\t\t\t***           5. Chu Vi Hinh Tam Giac                      ***");
                Console.WriteLine("\t\t\t\t***           6. Thoat                                     ***");
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

        static public void MenuHTron()
        {
            int flag = 1;
            Circle HTron = new Circle();
            HTron.Nhap();
            try
            {
                if (Math.Abs(HTron.P1.x - HTron.P2.x) == Math.Abs(HTron.P1.y - HTron.P2.y))
                {
                    while (flag == 1)
                    {
                        Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                        Console.WriteLine("\t\t\t\t***           1. Di Chuyen Hinh Tron den Vi Tri moi        ***");
                        Console.WriteLine("\t\t\t\t***           2. Doi Mau Hinh Tron                         ***");
                        Console.WriteLine("\t\t\t\t***           3. Ve Hinh Tron                              ***");
                        Console.WriteLine("\t\t\t\t***           4. Dien Tich Hinh Tron                       ***");
                        Console.WriteLine("\t\t\t\t***           5. Chu Vi Hinh Tron                          ***");
                        Console.WriteLine("\t\t\t\t***           6. Thoat                                     ***");
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
                else
                    throw new Exception("Khong the ve hinh tron voi khung hinh chu nhat!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static public void MenuDoanThang()
        {
            int flag = 1;
            Line DT = new Line();
            DT.Nhap();
            while (flag == 1)
            {
                Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                Console.WriteLine("\t\t\t\t***           1. Di Chuyen Doan Thang den Vi Tri moi       ***");
                Console.WriteLine("\t\t\t\t***           2. Doi Mau Doan Thang                        ***");
                Console.WriteLine("\t\t\t\t***           3. Ve Doan Thang                             ***");
                Console.WriteLine("\t\t\t\t***           4. Thoat                                     ***");
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

         static public void MenuHCN()
         {
            int flag = 1;
            Rectangle HCN = new Rectangle();
            HCN.Nhap();
            while (flag == 1)
            {
                Console.WriteLine("\t\t\t\t*****************************MENU*****************************");
                Console.WriteLine("\t\t\t\t***           1. Di Chuyen Hinh Chu Nhat den Vi Tri moi    ***");
                Console.WriteLine("\t\t\t\t***           2. Doi Mau Hinh Chu Nhat                     ***");
                Console.WriteLine("\t\t\t\t***           3. Ve Hinh Chu Nhat                          ***");
                Console.WriteLine("\t\t\t\t***           4. Dien Tich Hinh Chu Nhat                   ***");
                Console.WriteLine("\t\t\t\t***           5. Chu Vi Hinh Chu Nhat                      ***");
                Console.WriteLine("\t\t\t\t***           6. Thoat                                     ***");
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
    }
}
