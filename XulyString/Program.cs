using System;
using System.Text;

namespace XulyString
{
    /*
     * Chuỗi - string là một tập hợp các kí tự liên tiếp.
     * Chuỗi không có độ dài xác định và độ dài tối thiểu là 0
     * chuỗi rỗng khác với null.
     * Chuỗi là readonly - chỉ đọc. Tức là ta không thể thay
     * đổi các kí tự, độ dài trong 1 chuỗi 1 cách trực tiếp.
     * Chuỗi có thể truy xuất đến các kí tự như một mảng.
     * Lớp string có hỗ trợ nhiều phương thức để xử lý chuỗi.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Khởi tạo 1 chuỗi: 
            //string s = "Xin chào iem";
            //Console.WriteLine(s);
            // Truy xuất đến phần tử
            //Console.WriteLine(s[5]);
            //Console.WriteLine(s.Length); // Độ dài
            // Các phương thức xử lý string
            //Các phương thức kiểm tra
            //1. Kiểm tra string Rỗng hoặc null hay không
            //Console.WriteLine(string.IsNullOrEmpty(s));
            //2. Kiểm tra vị trí đầu tiên của một thành phần
            //Console.WriteLine(s.IndexOf("i"));
            //Console.WriteLine(s.LastIndexOf("i")); // Cuối cùng
            // Kiểm tra xem chuỗi s có chứa 1 kí tự a hay không?
            // => Kiểm tra xem indexof có = lastindexof không
            // Các phương thức xử lý
            // Xóa khoảng trắng thừa ở các vị trí đầu cuối
            //string x = "    abc 123 asdjasdhja    ";
            //Console.WriteLine(x);
            //Console.WriteLine(x.Trim());
            // x.TrimEnd(); x.TrimStart(); xóa dấu cách ở cuối và đầu
            // Hàm substring - cắt chuỗi
            //string a = "123456789";
            //Console.WriteLine(a.Substring(1, 5)); // Cắt từ 1, 5 kí tự
            //Console.WriteLine(a.Substring(5)); // cắt từ kí tự thứ 5 đến cuối
            // chuyển thành viết Hoa - viết thường
            //string b = "abcDgTHaNkao";
            //Console.WriteLine(b);
            //Console.WriteLine(b.ToLower()); Console.WriteLine(b.ToUpper());
            // Hàm thay thế chuỗi trong chuỗi bằng chuỗi khác
            //Console.WriteLine(b.Replace("a", "111"));
            // Xóa tất cả khoảng trắng của 1 chuỗi
            //string c = "Xin chào các pé";
            //Console.WriteLine(c.Replace(" ", ""));
            // Cắt chuỗi thành một mảng chứa các chuỗi con
            //string[] arr = c.Split(' ');
            //foreach (var word in arr)
            //{
            //    Console.WriteLine(word);
            //}
            //// in một tập hợp với string.Join
            //Console.WriteLine(string.Join("😊😊", arr));// windows ;
            // Các hàm kiểm tra đặc biệt
            string d = "ABCDEFG134";
            Console.WriteLine(d.StartsWith("A")); // Kiểm tra xem có bắt đầu bởi A hay không
            Console.WriteLine(d.StartsWith("B"));
            // Tương tự StartsWith chúng ta có EndWith
            // Kiểm tra chứa hay không
            Console.WriteLine(d.Contains("DEF"));
        }
    }
}
