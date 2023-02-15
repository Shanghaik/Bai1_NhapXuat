using System;
using System.Text;

namespace QuanLySinhVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Services services= new Services();
            services.NhapDanhSachSV();
            services.XuatDanhSach();
            //services.SuaSinhvien();
            //services.XuatDanhSach();
            //services.XoaSinhvien();
            //services.XoaTheoGiaTri();
            //services.XuatDanhSach();
            //services.TimKiemTheoMa();
            services.SapXepTheoTuoi();
        }
    }
}
