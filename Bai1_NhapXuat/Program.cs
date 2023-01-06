using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_NhapXuat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất thông tin
            //Console.WriteLine("Hello world");// cw tab tab
            //Console.Write("Xin chào");// không xuống dòng
            //Console.Write("KhanhPG");
            // In ra thông tin của mình tên + tuổi + mã sv
            // Nhập thông tin
            /*
             * Biến và kiểu dữ liệu
             * Biến là gì? Được tạo ra để lưu trữ dữ liệu
             * Kiểu dữ liệu là cách mà ta xác định dữ liệu đó 
             * thuộc dạng dữ liệu nào: 
             * Ví dụ: int, long, char, float,... string, 
             * Một biến khi được khai báo phải có kiểu dữ liệu đi
             * kèm
             */
            Console.OutputEncoding = Encoding.Unicode; // Đổi chuẩn đầu ra
            Console.InputEncoding = Encoding.Unicode; // Đổi chuẩn đầu vào

            int x; // khai báo biến x với kiểu dữ liệu int
            int y = 10; // khởi tạo biến y kiểu int có giá trị bằng 10
            //Console.WriteLine(y); // in ra giá trị của biến y
            //string s = "Xin mời nhập thông tin"; // Khởi tạo 1 chuỗi kí tự
            //Console.WriteLine(s);
            //// Nhập dữ liệu từ bàn phím
            //string nhap = Console.ReadLine(); //Đọc 1 dòng từ Console
            //Console.WriteLine(nhap);
            //// Nhập số
            //Console.WriteLine("Hãy nhập tuổi của bạn:");
            //string tuoichu = Console.ReadLine(); // Nhập một chuỗi chứa toàn chữ số
            //int tuoiso = int.Parse(tuoichu); // Ép kiểu từ chuỗi sang int
            //int tuoiso2 = Convert.ToInt32(tuoichu);// Vẫn là ép kiểu
            //Console.WriteLine(tuoiso);
            // Nhập vào tên, tuổi, địa chỉ của mình sau đó in ra 
            Console.WriteLine("Hãy nhập tên của bạn");
            string ten = Console.ReadLine();
            Console.WriteLine("Hãy nhập tuoi của bạn");
            int tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Hãy nhập dịa chỉ của bạn");
            string diachi = Console.ReadLine();
            // In thông tin tích hợp
            Console.WriteLine("Tên của tôi là: " + ten);
            Console.WriteLine("Tuổi của tôi là: " + tuoi);
            Console.WriteLine("Địa chỉ của tôi là: " + diachi);
            Console.WriteLine($"Tên tôi là: {ten}, tôi {tuoi} tuổi, tôi ở {diachi}");
            Console.ReadKey();
        }
    }
}
