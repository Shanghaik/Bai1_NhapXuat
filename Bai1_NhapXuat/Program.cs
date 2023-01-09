using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
            //Console.WriteLine("Hãy nhập tên của bạn");
            //string ten = Console.ReadLine();
            //Console.WriteLine("Hãy nhập tuoi của bạn");
            //int tuoi = int.Parse(Console.ReadLine());
            //Console.WriteLine("Hãy nhập dịa chỉ của bạn");
            //string diachi = Console.ReadLine();
            // In thông tin tích hợp
            //Console.WriteLine("Tên của tôi là: " + ten);
            //Console.WriteLine("Tuổi của tôi là: " + tuoi);
            //Console.WriteLine("Địa chỉ của tôi là: " + diachi);
            //Console.WriteLine($"Tên tôi là: {ten}, tôi {tuoi} tuổi, tôi ở {diachi}");

            /*
             * Ép kiểu: Là hành động chuyển đổi từ kiểu dữ liệu này
             * sang kiểu dữ liệu khác để phù hợp cho quá trình code
             * Có 2 loại ép kiểu chính:
             * + Ép kiểu tường minh: Là ép kiểu có sử dụng code nhằm
             * chủ đích ép kiểu. Ép kiểu Tường minh vẫn có thể xảy ra
             * lỗi nếu kiểu dữ liệu muốn ép không phù hợp
             * + Ép kiểu ngầm định: Là quá trình ép kiểu tự động khi
             * chạy chương trình và thường là ép kiểu từ kiểu dữ liệu
             * có phạm vi biểu diễn nhỏ hơn sang lớn hơn
             */
            int a = 10;
            Console.WriteLine("Số a có giá trị là: " + a);
            long b = 100;
            int c = a + (int)b;
            // Các toán tử
            /*
             * Toán tử số học
             * Toán tử so sánh - quan hệ
             * Toán tử logic ( &&, ||, !)
             * Toán tử gán (=, +=, -=, *=, /=, %=)
             * Toán tử bit
             */
            // Nhập vào ngày tháng năm sinh của bạn sau đó in ra
            // Tôi ? tuổi, đã đủ tuổi lấy vợ hay chưa?
            //Console.WriteLine("Hãy nhập ngày sinh");
            //int ngay = int.Parse(Console.ReadLine());
            //Console.WriteLine("Hãy nhập ngày sinh");
            //int thang = int.Parse(Console.ReadLine());
            //Console.WriteLine("Hãy nhập ngày sinh");
            //int nam = int.Parse(Console.ReadLine());
            //if (2023 - nam > 20) {Console.WriteLine("Đã đủ tuổi lấy vợ"); }
            //else if (2023 - nam == 20)
            //{
            //    if (thang < 1){Console.WriteLine("Đã đủ tuổi lấy vợ");}
            //    else if (thang == 1 && ngay <= 9) { Console.WriteLine("Đã đủ tuổi lấy vợ"); }
            //    else { Console.WriteLine("Chưa đủ tuổi lấy vợ"); }
            //}
            //else { Console.WriteLine("Chưa đủ tuổi lấy vợ"); }
            // Nhập vào 3 số nguyên, tìm ra số lớn nhất và nhỏ nhất trong 3 số đó và in ra
            Console.WriteLine("Hãy số đầu tiên");
            int number_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hãy số thứ 2");
            int number_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hãy số thứ 3");
            int number_3 = int.Parse(Console.ReadLine());
            int max = number_1; int min = number_1;
            if (max < number_2 && number_2 > number_3) max = number_2;
            if (max < number_3 && number_2 < number_3) max = number_3;
            Console.WriteLine($"Số lớn nhất là: {max}");
            // Tìm ra số lớn thứ 2 trong 3 số
            if ((number_1-number_2)*(number_1-number_3) <= 0)
            {
                Console.WriteLine($"Số lớn thứ 2 là: {number_1}");
            }else if((number_2 - number_3) * (number_2 - number_1) <= 0)
            {
                Console.WriteLine($"Số lớn thứ 2 là: {number_2}");
            }else Console.WriteLine($"Số lớn thứ 2 là: {number_3}");
            Console.ReadKey();
        }
    }
}
