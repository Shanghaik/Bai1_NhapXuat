using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4_Tinhchat
{
    // Tính trừu tượng: Tạo ra những class chung mang nghĩa
    // trừu tượng để các class khác có thể kế thừa, những class con
    // đó gọi là các class dẫn xuất và không mang tính trừu tượng
    internal abstract class Ca // Từ khóa abstract để xác định đó
        // là lớp trừu tượng
    {
        string ten;
        string noisong;
        string chungloai;
        int tuoithotrungbinh;
        public Ca()
        {
        }
        protected Ca(string ten, string noisong, string chungloai, int tuoithotrungbinh)
        {
            this.Ten = ten;
            this.Noisong = noisong;
            this.Chungloai = chungloai;
            this.Tuoithotrungbinh = tuoithotrungbinh;
        }
        public string Ten { get => ten; set => ten = value; }
        public string Noisong { get => noisong; set => noisong = value; }
        public string Chungloai { get => chungloai; set => chungloai = value; }
        public int Tuoithotrungbinh { get => tuoithotrungbinh; set => tuoithotrungbinh = value; }
    
        // Các phương thức trong class trừu tượng
        /*
         * Trong class abstract có thể có phương thức thông thường
         * và phương thức abstract, phương thức abstract là phương thức
         * chỉ có tên, kiểu trả về, tham số và không có phần thân
         */
        public void HienThi()
        {
            Console.WriteLine($"Loại cá này có tên là: {ten}" +
                $"thuộc chủng loại: {chungloai}");
        }
        public abstract void Boi(); // Phương thức abstract
    }
}
