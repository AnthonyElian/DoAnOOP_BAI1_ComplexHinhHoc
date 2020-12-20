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
                            Rectangle HCN = new Rectangle();
                            HCN.Nhap();
                            HCN.Menu();
                            break;
                        }
                    case 2:
                        {
                            Line DT = new Line();
                            DT.Nhap();
                            DT.Menu();
                            break;
                        }
                    case 3:
                        {
                            Circle HTron = new Circle();
                            HTron.Nhap();
                            HTron.Menu();
                            break;
                        }
                    case 4:
                        {
                            Triangle HTG = new Triangle();
                            HTG.Nhap();
                            HTG.Menu();
                            break;
                        }
                    case 5:
                        {
                            Square HV = new Square();
                            HV.Nhap();
                            HV.Menu();
                            break;
                        }
                    case 6:
                        {
                            Rhombus HT = new Rhombus();
                            HT.Nhap();
                            HT.Menu();
                            break;
                        }
                    case 7:
                        {
                            Pentagon HNGD = new Pentagon();
                            HNGD.Nhap();
                            HNGD.Menu();
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
    }
}
