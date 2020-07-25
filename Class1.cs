using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCTDL_GT
{
    class Class1
    {
        public static void Chose()
        {
            int nChon;
            int.TryParse(Console.ReadLine(), out nChon);
            if (nChon == 1 || nChon == 2)
            {
                switch (nChon)
                {
                    case 1:
                        Console.Write("\n\t\t\t\t1.Quan Li Sach ", nChon);
                        int nLuaChon1 = 0;
                        if (nLuaChon1 >= 1 || nLuaChon1 <= 3)
                        {
                            // menu quan li sach 

                            int.TryParse(Console.ReadLine(), out nLuaChon1);
                            switch (nLuaChon1)
                            {
                                case 1:
                                    Console.Write("\t\t\t\t a", nLuaChon1);
                                    break;
                                case 2:
                                    Console.Write("\t\t\t\t b", nLuaChon1);
                                    break;
                                case 3:
                                    Console.Write("\t\t\t\t c", nLuaChon1);
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.Write("\n\t\t\t\t2.Quan Li Phieu Muon ", nChon);

                        int nLuaChon2 = 0;
                        if (nLuaChon2 >= 1 || nLuaChon2 <= 3)
                        {

                            //menu quan li phieu muon

                            int.TryParse(Console.ReadLine(), out nLuaChon2);
                            switch (nLuaChon2)
                            {
                                case 1:
                                    Console.Write("\t\t\t\t 1", nLuaChon2);
                                    break;
                                case 2:
                                    Console.Write("\t\t\t\t 2", nLuaChon2);
                                    break;
                                case 3:
                                    Console.Write("\t\t\t\t 3", nLuaChon2);
                                    break;
                            }
                        }
                        break;
                }



            }


        }

        public static void Menu()
        {
            Console.Write("\n\t\t\tChao Mung Ban Den Voi Thu Vien Sach");
            Console.Write("\n\t \t \t1.Quan Li Sach");
            Console.Write("\n\t \t \t2.Quan Li Phieu Muon\n");
            Console.Write("\n\t \t \t3.Thoat Chuong Trinh\n");
            Console.Write("\n\t\t\tMoi Ban Nhap Lua Chon:");
        }
        public static void MenuSach()
        {
            Console.Write("\n\t\t\t\t\t1.Hien Thi Thong Tin Sach");
            Console.Write("\n\t\t\t\t\t2.Them Sach");
            Console.Write("\n\t\t\t\t\t3.Xoa Sach\n");
            Console.Write("\n\t\t\t\t\tMoi Ban Nhap Lua Chon Tiep Theo:");
        }

        public static void MenuPhieuMuon()
        {
            Console.Write("\n\t\t\t\t\t1.Hien Thi Thong Tin Phieu Muon");
            Console.Write("\n\t\t\t\t\t2.Muon Sach");
            Console.Write("\n\t\t\t\t\t3.Tra Sach");
            Console.Write("\n\t \t \t3.Thoat Chuong Trinh\n");
            Console.Write("\n\t\t\t\t\tMoi Ban Nhap Lua Chon Tiep Theo:");
        }
    }
}
