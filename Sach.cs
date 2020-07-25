using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCTDL_GT
{

    /*Thực hiện chức năng Quản lý sách: 
     *  Hiển thị thông tin sách: 
     * hiển thị thông tin chi tiết của tất cả sách đang có trong thư viện gồm: 
     * Mã sách, Tên sách, Tác giả, Nhà xuất bản, Giá bán, Năm phát hành, Số trang , Ngày nhập kho, Tình trạng sách.
     *  Thêm sách: Thêm vào sách mới, nếu mã sách trùng thì thông báo sách đã tồn tại và không thêm. 
     * Sau khi thêm sách thành công, ghi nối thêm sách vừa thêm vào cuối file Sach.txt  Xóa sách: Nhập mã sách để xóa 1 cuốn sách, điều kiện xóa sách là tình trạng sách phải bằng 0 và có sách đó trong danh sách. 
     * Nếu tình trạng khác 0 thì thông báo không thể xóa sách do sách đang được mượn. 
     * Sau khi xóa thành công, ghi đè lại toàn bộ danh sách sách vào file Sach.txt 
* 
     */
    class Sach
    {
        public string MaSach;
        public string TenSach;
        public string TacGia;
        public string NhaXuatBan;
        public double GiaBan;
        public int NamPhatHanh;
        public int SoTrang;
        public DateTime NgayNhapKho;
        public int TinhTrangSach;
        

        public void Read(StreamReader sR)
        {
            string line = sR.ReadLine();
            string[] arr1 = new string[] { "#" };
            string[] arr2 = line.Split(arr1, StringSplitOptions.RemoveEmptyEntries);

            MaSach = arr2[0];
            TenSach = arr2[1];
            TacGia = arr2[2];
            NhaXuatBan = arr2[3];
            double.TryParse(arr2[4], out GiaBan);
            int.TryParse(arr2[5], out NamPhatHanh );
            int.TryParse(arr2[6], out SoTrang);
            DateTime.TryParse(arr2[7], out NgayNhapKho);
            int.TryParse(arr2[8], out TinhTrangSach);
            
            
        }
        public void Write(StreamWriter sW)
        {
            sW.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}#{7}#{8}", MaSach, TenSach, TacGia, NhaXuatBan,
                GiaBan, NamPhatHanh, SoTrang, NgayNhapKho, TinhTrangSach);

        }
        public void Print()
        {
            Console.WriteLine("{0,-20}{1,-20}", "Ma sach", MaSach);
            Console.WriteLine("{0,-20}{1,-20}", "Ten sach", TenSach);
            Console.WriteLine("{0,-20}{1,-20}", "Ten tac gia", TacGia);
            Console.WriteLine("{0,-20}{1,-20}", "Nha xua ban", NhaXuatBan);
            Console.WriteLine("{0,-20}{1,-20}", "Gia ban", GiaBan);
            Console.WriteLine("{0,-20}{1,-20}", "Nam phat hanh", NamPhatHanh);
            Console.WriteLine("{0,-20}{1,-20}", "So trang", SoTrang);
            Console.WriteLine("{0,-20}{1,-20}", "Ngay nhap kho", NgayNhapKho);
            Console.WriteLine("{0,-20}{1,-20}", "Tinh trang", TinhTrangSach);
            Console.WriteLine("---------------------");

        }


    }
}
