using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCTDL_GT
{
    class Program
    {
        static void Main(string[] args)
        {
            Login l = new Login();

            l.loginAccount();
            LinkedList<Sach> list = new LinkedList<Sach>();
            //ReadList(list);
            //PrintList(list);
            //WriteList(list);
            //PrintList(list);
            //AddBook(list);
            //WriteList(list);

            Console.ReadKey();

        }
        static void WriteList(LinkedList<Sach> l)
        {
            using (StreamWriter sW = new StreamWriter("Sach.txt"))
            {
                sW.WriteLine(l.Count);
                for (LinkedListNode<Sach> p = l.First; p != null; p = p.Next)
                {
                    p.Value.Write(sW);
                }
            }
        }
        static void PrintList(LinkedList<Sach> l)
        {
            for (LinkedListNode<Sach> p = l.First; p != null; p = p.Next)
            {
                p.Value.Print();
            }
            Console.WriteLine("Ds cp  {0} phan tu.", l.Count);
        }
        static void ReadList(LinkedList<Sach> l)
        {
            int n = 0;
            using (StreamReader sR = new StreamReader("Sach.txt"))
            {
                int.TryParse(sR.ReadLine(), out n);
                for (int i = 0; i < n; i++)
                {
                    Sach s = new Sach();
                    s.Read(sR);
                    l.AddLast(s);
                }
            }
        }
        static void AddBook(LinkedList<Sach> l)
        {
            string key = "";
            int nSoLuongSach = 0;
            int.TryParse(Console.ReadLine(), out nSoLuongSach);

            for (int i = 0; i < nSoLuongSach; i++)
            {
                    Sach s = new Sach();

                Console.Write("Nhap ma Sach");
                        s.MaSach = Console.ReadLine();

                Console.Write("Nhap ten Sach");
                s.TenSach = Console.ReadLine();
                Console.Write("Nhap ten tac gia");
                s.TacGia = Console.ReadLine();
                Console.Write("Nha xuat ban sach");
                s.NhaXuatBan = Console.ReadLine();
                Console.Write("Nhap gia ban");
                double.TryParse(Console.ReadLine(), out s.GiaBan);
                Console.Write("Nam phat hanh");
                int.TryParse(Console.ReadLine(), out s.NamPhatHanh);
                Console.Write("Nhap so trang sach");
                int.TryParse(Console.ReadLine(), out s.SoTrang);
                Console.Write("Ngay nhap kho");
                DateTime.TryParse(Console.ReadLine(), out s.NgayNhapKho);
                Console.Write("Tinh trang sach");
                int.TryParse(Console.ReadLine(), out s.TinhTrangSach);

                if (key == s.MaSach)
                {
                    Console.WriteLine("Sach da ton tai");
                }

            }
            }
        }
    }






