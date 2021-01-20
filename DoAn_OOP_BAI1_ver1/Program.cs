using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_BAI1_ver1
{
    class Program
    {
       //sua ngu
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
                            Console.Beep();
                            Rectangle HCN = new Rectangle();
                            HCN.Nhap();
                            HCN.Menu();
                            break;
                        }
                    case 2:
                        {
                            Console.Beep();
                            Line DT = new Line();
                            DT.Nhap();
                            DT.Menu();
                            break;
                        }
                    case 3:
                        {
                            Console.Beep();
                            Circle HTron = new Circle();
                            HTron.Nhap();
                            HTron.Menu();
                            break;
                        }
                    case 4:
                        {
                            Console.Beep();
                            Triangle HTG = new Triangle();
                            HTG.Nhap();
                            HTG.Menu();
                            break;
                        }
                    case 5:
                        {
                            Console.Beep();
                            Square HV = new Square();
                            HV.Nhap();
                            HV.Menu();
                            break;
                        }
                    case 6:
                        {
                            Console.Beep();
                            Rhombus HT = new Rhombus();
                            HT.Nhap();
                            HT.Menu();
                            break;
                        }
                    case 7:
                        {
                            Console.Beep();
                            Pentagon HNGD = new Pentagon();
                            HNGD.Nhap();
                            HNGD.Menu();
                            break;
                        }
                    case 8:
                        {
                            Console.Beep();
                            int floor = 0;
                            ComplexObject cpO = new ComplexObject(floor);
                            cpO.Menu();
                            break;
                        }
                    case 9:
                        {
                            Console.Beep();
                            flag = 0;
                            Console.Clear();
                            break;
                        }
                    default:
                        {
                            Console.Beep();
                            Console.Clear();
                            Console.WriteLine("Ban Nhap Sai!!! Vui long nhap lai ~~ ");
                            break;
                        }
                }
            }
        }

           
    }
}
