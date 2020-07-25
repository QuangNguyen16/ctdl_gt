                    /*
                       * NHÓM 12 : QUẢN LÍ THƯ VIỆN
                       * Tên các thành viên:
                       *      Văn Quang
                       *      Duy Huy
                       *      Nhật Huy
                       *      Cao Quốc
                       * 
                       */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCTDL_GT
{
    class Login
    {
        //Khai Bao Bien 
        string user;
        string sUser;
        string sPass;
        string pass;
        int ctr = 0;
        int nChon = 0;

        /*
         * Hàm Login
         * Kiểm tra đăng nhập
         * Hiển thị menu cho các chức năng
         */
        public void loginAccount()
        {
            
                /*
                 * Khai bao va su dung thu vien doc file
                 * File : Input.txt(user: Admin, pass: 1234567)
                 */

                using (StreamReader sr = new StreamReader("Input.txt"))
                {

                    Login arrTK = new Login();
                    string line = sr.ReadLine();
                    string[] sep = new string[] { "#" };
                    string[] arr = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    arrTK.sUser = arr[0];
                    arrTK.sPass = arr[1];

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t \t \t \t ************************************************\t");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t \t \t \t *\t\tDANG NHAP HE THONG\t\t*");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t \t \t \t ************************************************\t");
                    Console.ResetColor();
                    Console.Write("\t \t \t \t \tUser:\t \t");
                    user = Console.ReadLine();
                    Console.Write("\t \t \t \t \tPassword:\t");
                    pass = Console.ReadLine();

                    /*
                     * Kiểm tra đăng nhập theo kiểu chuỗi trong file txt
                     * Hiển thị menu của các chức năng còn lại
                     */
                    if (user == arr[0] && pass == arr[1])
                    {
                        ctr++;
                        Console.Write("\n \t\t\tBan da nhap mat khau dung!\n\n");
                        do
                        {

                            Console.Write("\n\t\t\tChao Mung Ban Den Voi Thu Vien Sach");
                            Console.Write("\n\t \t \t1.Quan Li Sach");
                            Console.Write("\n\t \t \t2.Quan Li Phieu Muon\n");
                            Console.Write("\n\t\t\tMoi Ban Nhap Lua Chon:");

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
                                            MenuSach();

                                            int.TryParse(Console.ReadLine(), out nLuaChon1);
                                            switch (nLuaChon1)
                                            {
                                                case 1:
                                                    Console.Write("\t\t\t\t a\n", nLuaChon1);
                                                    break;
                                                case 2:
                                                    Console.Write("\t\t\t\t b \n" /*Them danh sach*/, nLuaChon1);
                                                    break;
                                                case 3:
                                                    Console.Write("\t\t\t\t c \n" /*Xoa Sach*/, nLuaChon1);
                                                    break;
                                            }
                                        }
                                        break;
                                    case 2:
                                        Console.Write("\n\t\t\t\t2.Quan Li Phieu Muon ", nChon);

                                        int nLuaChon2 = 0;
                                        if (nLuaChon2 >= 1 || nLuaChon2 <= 3)
                                        {
                                            MenuPhieuMuon();

                                            int.TryParse(Console.ReadLine(), out nLuaChon2);
                                            switch (nLuaChon2)
                                            {
                                                case 1:
                                                    Console.Write("\t\t\t\t  1 \n", nLuaChon2);
                                                    break;
                                                case 2:
                                                    Console.Write("\t\t\t\t 2 \n", nLuaChon2);
                                                    break;
                                                case 3:
                                                    Console.Write("\t\t\t\t 3 \n", nLuaChon2);
                                                    break;
                                            }
                                        }
                                        break;
                                }
                                break;

                            }
                            else
                            {
                                Console.WriteLine("Moi Ban Chon lai menu");
                            }
                        } while (nChon == 1 || nChon == 2);
                    }
                    else if (ctr != 3)
                    {
                        Console.WriteLine("Tam dung");
                    }
                }

            





        }
        /*
         * Hien Thi Sach
         */
        
        public static void HienThiSach()
        {

        }

        /*
         * Them Sach 
         */
        public static void ThemSach()
        {

        }

        /*
         * Xoa Sach
         */
        public static void XoaSach()
        {

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
            Console.Write("\n\t\t\t\t\t3.Thoat Chuong Trinh\n");
            Console.Write("\n\t\t\t\t\tMoi Ban Nhap Lua Chon Tiep Theo:");
        }

    }
}

/*
public static string MD5Hash(string pass)
{
    StringBuilder hash = new StringBuilder();
    using (MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider())
    {
        byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(pass));

        for (int i = 0; i < bytes.Length; i++)
        {
            hash.Append(bytes[i].ToString("x2"));
        }
    }
    return hash.ToString();
}
*/

