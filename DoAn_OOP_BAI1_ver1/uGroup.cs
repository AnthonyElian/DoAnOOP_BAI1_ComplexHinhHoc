using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_BAI1_ver1
{
    static public class uGroup
    {
        //private ComplexObject Group;
        //private List<Shape> listShape;

        //public List<Shape> lShape
        //{
        //    get { return this.listShape; }
        //    set { this.listShape = value; }
        //}
        //public ComplexObject group
        //{
        //    get { return this.Group; }
        //    set { this.Group = value; }
        //}
        //public uGroup() 
        //{
        //    this.listShape = new List<Shape>();
        //    this.Group = new ComplexObject();
        //}

        static public ComplexObject Merge(List<Shape> lShape, int floor)
        {
            List<Shape> DsShape = new List<Shape>();
            Console.Write("Moi nhap so luong hinh muon Group voi nhau: ");
            int temp = int.Parse(Console.ReadLine());
            for (int i = 0; i < temp; i++)
            {
                Console.Write("Ban muon Merge hinh nao trong danh sach da nhap ban dau: ");
                int tmp1 = int.Parse(Console.ReadLine());
                DsShape.Add(lShape[tmp1]);
            }
            ComplexObject Merge = new ComplexObject(DsShape, floor);
            LayDiem(ref Merge);
            return Merge;
        }

        static public void Divided(ref ComplexObject A)
        {
            Console.Write("Moi nhap so luong hinh muon Ungroup trong danh sach da Group: ");
            int temp = int.Parse(Console.ReadLine());
            for (int i = 0; i < temp; i++)
            {
                Console.WriteLine("//////////////////////////////////////////////////////////");
                A.Xuat();
                Console.Write("Ban muon Devided hinh nao trong danh sach Da Cap Nhap: ");
                int tmp = int.Parse(Console.ReadLine());
                A.ListShape.RemoveAt(tmp);
            }
            Console.WriteLine("//////////////////////////////////////////////////////////");
            A.Xuat();
            //ComplexObject Devided = new ComplexObject(A);
            LayDiem(ref A);
            //return Devided;
        }

        static void LayDiem(ref ComplexObject A)
        {
            List<Shape> DsShape = new List<Shape>();
            double maxX = double.MinValue, minX = double.MaxValue, maxY = double.MinValue, minY = double.MaxValue;
            foreach (var item in DsShape)
            {
                if (item.P1.x > maxX)
                    maxX = item.P1.x;
                if (item.P2.x > maxX)
                    maxX = item.P2.x;
                if (item.P1.y > maxY)
                    maxY = item.P1.y;
                if (item.P2.y > maxY)
                    maxY = item.P2.y;
                if (item.P1.x < minX)
                    minX = item.P1.x;
                if (item.P2.x < minX)
                    minX = item.P2.x;
                if (item.P1.y < minY)
                    minY = item.P1.y;
                if (item.P2.y < minY)
                    minY = item.P2.y;
            }
            A.P1.x = minX;
            A.P1.y = maxY;
            ////////////////
            A.P2.x = maxX;
            A.P2.y = minY;
        }
    }
}
