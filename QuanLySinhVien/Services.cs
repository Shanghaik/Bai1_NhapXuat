using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLySinhVien
{
    /*
     * List<T> - Danh sách trong C# là một lớp được xây dựng 
     * để giúp chúng ta quản lý được nhiều kiểu dữ liệu khác nhau
     * dưới dạng các danh sách trong đó T là kiểu dữ liệu mà ta 
     * cần quản lý. T có thể là bất kì kiểu dữ liệu nào.
     * List khá giống với array - mảng nhưng nó có thể thay đổi
     * kích thước tùy ý. List có nhiều phương thức hỗ trợ cho việc
     * quản lý và truy xuất dữ liệu
     */
    internal class Services
    {
        // Khai báo 1 list - là thuộc tính của class
        private List<Sinhvien> sinhviens;
        public Services()
        {
            Sinhviens = new List<Sinhvien>();
        }
        public Services(List<Sinhvien> sinhviens)
        {
            this.Sinhviens = sinhviens;
        }
        internal List<Sinhvien> Sinhviens { get => sinhviens; set => sinhviens = value; }
        // Các phương thức quản lý danh sách sinh viên
        // 1. Tạo - nhập sinh viên - Trả về một sinh viên 
        public Sinhvien CreateSinhvien()
        {
            Sinhvien sinhvien = new Sinhvien();
            Console.WriteLine("Nhập thông tinh của sinh viên");
            Console.WriteLine("Nhập mã"); sinhvien.Code = Console.ReadLine();
            Console.WriteLine("Nhập tên"); sinhvien.Ten = Console.ReadLine();
            Console.WriteLine("Nhập tuổi"); sinhvien.Tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập ngành"); sinhvien.Nganh = Console.ReadLine();   
            return sinhvien; // Trả về sinh viên khi đã được nhập đầy đủ giá trị
        }
        public void NhapDanhSachSV() // Danh sách đã được tạo ở trên
        {
            Console.WriteLine("Nhập số lượng sinh viên mà bạn muốn thêm: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Sinhvien sv = CreateSinhvien(); // Mỗi lần lặp nhập thông tin của 1 sv mới
                sinhviens.Add(sv); // Phuong thức Add cho phép thêm mới sv vào List
            }
        }
        public void XuatDanhSach()
        {
            Console.WriteLine("Danh sách sinh viên là: \n");
            foreach (var item in sinhviens) // Mỗi sv được lặp sẽ hiển thị thông tin
            {
                item.InThongTin();
            }
        }
        // Sửa sinh viên
        public void SuaSinhvien()
        {
            Console.WriteLine("Nhập vị trí mà bạn muốn sửa: ");
            int pos = int.Parse(Console.ReadLine());
            sinhviens[pos] = CreateSinhvien();
        }
        // Xóa sinh viên 
        // Xóa sinh viên theo vị trí
        public void XoaSinhvien()
        {
            Console.WriteLine("Nhập vị trí mà bạn muốn xóa: ");
            int pos = int.Parse(Console.ReadLine());
            sinhviens.RemoveAt(pos); // Hàm RemoveAt dùng để bỏ 1 phần tử ở
            // Một vị trí nào đó khỏi List
        }
        public void XoaTheoGiaTri() // Xóa những SV mà tuổi < 18
        {
            for (int i = 0; i < sinhviens.Count; i++)
            {
                if (sinhviens[i].Tuoi < 18)
                {
                    sinhviens.RemoveAt(i); // Xóa theo vị trí
                    //sinhviens.Remove(sinhviens[i]); // Xóa theo giá trị
                    i--; // Khi bị xóa phải update vị trí
                }
            }
        }
        public void TimKiemTheoMa()
        {
            Console.WriteLine("Nhập mã mà bạn muốn tìm kiếm");
            string ma = Console.ReadLine();
            foreach (var item in sinhviens)
            {
                if (item.Code.Contains(ma)) // Contains - chứa chuỗi
                {
                    item.InThongTin();
                }
            }
        }
        // Sắp xếp
        public void SapXepTheoTuoi()
        {
            sinhviens = sinhviens.OrderBy(p => p.Tuoi).ToList();
            XuatDanhSach();
        }

    }
}
