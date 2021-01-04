using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Restaurant
{
    public class Nhanvien{

        protected string sHoTen;
        protected DateTime NgaySinh;
        protected string Quequan;
        protected int MSNV;
        protected NgayNghi nNgayNghi;
    }
    public class NgayNghi{

        private List<DateTime> LsCoPhep;
        private List<DateTime> LsKhongPhep;

        public List<DateTime> ListCoPhep { get => LsCoPhep; set => LsCoPhep = value; }
        public List<DateTime> ListKhongPhep { get => LsKhongPhep; set => LsKhongPhep = value; }

        public NgayNghi(List<DateTime> lsCoPhep, List<DateTime> lsKhongPhep){

            this.LsCoPhep = lsCoPhep;
            this.LsKhongPhep = lsKhongPhep;
        }
        public NgayNghi(){

            this.LsCoPhep = new List<DateTime>();
            this.LsKhongPhep = new List<DateTime>();
        }

        public void ThemCoPhep(){

            int day, month, year;
            string temp;
            Console.Write("Nhap ngay nghi phep dinh dang dd/mm/yyyy: ");
            temp = Console.ReadLine();
            day = Convert.ToInt32(temp.Substring(0, 2));
            month = Convert.ToInt32(temp.Substring(3, 2));
            year = Convert.ToInt32(temp.Substring(6, 4));

            this.ListCoPhep.Add(new DateTime(day, month, year, 0, 0, 0));
        }

        public void ThemKhongPhep(){

            int day, month, year;
            string temp;
            Console.Write("Nhap ngay nghi khong phep dinh dang dd/mm/yyyy: ");
            temp = Console.ReadLine();
            day = Convert.ToInt32(temp.Substring(0, 2));
            month = Convert.ToInt32(temp.Substring(3, 2));
            year = Convert.ToInt32(temp.Substring(6, 4));

            this.ListKhongPhep.Add(new DateTime(day, month, year, 0, 0, 0));
        }

        public void XuatDSPhep(){

            if (this.ListCoPhep.Count == 0){
                
            }
        }
    }
}
