using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_CauDieuKien_VongLap
{
    #region
    /*
     * Câu lệnh điều kiện - câu lệnh rẽ nhánh
     * Là câu lệnh cho phép thực thi các tác vụ dựa trên
     * một hoặc nhiều điều kiện.
     * (Các loại CLDK: if-else, switch-case, toán tử 3 ngôi)
     */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; // Đổi chuẩn đầu ra
            Console.InputEncoding = Encoding.Unicode; // Đổi chuẩn đầu vào
            //Random random = new Random();
            //Console.WriteLine(random.Next(1, 38));
            // Câu lệnh if-else
            // Nhập vào tuổi của bạn
            // Nếu bạn >= 20 tuổi thì in ra bạn đã có thể kết hôn
            // Nếu không in ra là bạn còn quá trẻ
            //int tuoi = int.Parse(Console.ReadLine());
            //if (tuoi>=20)
            //{
            //    Console.WriteLine("Bạn đã đủ tuổi kết hôn");
            //}
            //else Console.WriteLine("Bạn còn quá trẻ");
            // Xếp loại học lực
            // Nếu điểm <=10 và >9 thì là SV Xuất sắc
            // <=9 và > 8 thì là sv giỏi
            // <=8 và > 6.5 là sv khá
            // <= 6.5 và >= 5 là SV Trung bình
            // > 0 và <5 là SV đúp
            // ngoài khoảng 0-10 là điểm lỗi
            //Console.WriteLine("Nhập điểm");
            //double diem = double.Parse(Console.ReadLine());
            //if (diem <= 10 && diem > 9) Console.WriteLine("Xuất sắc");
            //else if (diem <= 9 && diem > 8) Console.WriteLine("Giỏi");
            //else if (diem <= 8 && diem > 6.5) Console.WriteLine("Khá");
            //else if (diem <= 6.5 && diem >= 5) Console.WriteLine("TB");
            //else if (diem < 5 && diem > 0) Console.WriteLine("ĐÚp");
            //else Console.WriteLine("Điểm lỗi");
            // Sử dụng switch case in ra lịch tập thể dục như sau
            // thứ 2, thứ 4 => Chạy bộ
            // thứ 3, thứ 7 => Nhảy dây
            // Thứ 5 => Đạp xe
            // Thứ 6 => Bơi lội
            // Chủ nhật => Nghỉ
            //Console.WriteLine("Nhập thời gian");
            //string thu = Console.ReadLine();
            //switch (thu)
            //{
            //    case "thu 2":
            //    case "thu 4":
            //        Console.WriteLine("Chạy bộ");
            //        break;
            //    case "thu 3":
            //    case "thu 7":
            //        Console.WriteLine("Nhảy dây");
            //        break;
            //    case "thu 6":
            //        Console.WriteLine("Đạp xe");
            //        break;
            //    case "thu 5":
            //        Console.WriteLine("Bơi lội");
            //        break;
            //    default:
            //        Console.WriteLine("Nghỉ khỏe");
            //        break;
            //}
            // Toán tử 3 ngôi
            // Cách thức hoạt động tương tự như if-else
            // điều kiện ? lệnh nếu dk đúng : lệnh nếu dk sai
            //int x = 11;
            //string chanle = x % 2 == 0 ?  "Chẵn" : "Lẻ";
            //Console.WriteLine(chanle);
            // Nhập tiền thưởng tết của nhân viên
            // Nếu thưởng >= 5000000 => Tết ấm, ngược lại => Không ấm lắm
            //Console.WriteLine("Nhập tiền bạn được thưởng");
            //int thuong = int.Parse(Console.ReadLine());
            //string ketqua = thuong >= 5000000 ? "Tết ấm" : "Tết xa ngàn cây số";
            //Console.WriteLine(ketqua);
            // Vòng lặp : Thực hiện lặp đi lặp lại một công việc nhiều lần
            // mà chỉ cần viết 1 lần
            // cú pháp: 
            /*
             * for(biến chạy, điều kiện, update){
             *  câu lệnh;
             *  }
             *  tính tổng các số từ 1 đến 10
            */
            //int tong = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    tong += i;
            //}
            //Console.WriteLine("Tổng là: " + tong);
            //// Tính tổng các số lẻ từ 500 đến 1000
            //tong = 0;
            //for (int i = 500; i < 1000; i++)
            //{ // i ở 2 vòng for hoàn toàn khác nhau
            //    tong += (i % 2 != 0 ? i : 0);
            //}
            //Console.WriteLine("Tổng là "+tong);
            //
            // Sư dụng vòng lặp while, yêu cầu người dùng nhập đến khi
            // nào nhập một số chia hết cho 10
            //while (true)
            //{
            //    Console.WriteLine("Nhập 1 số bất kì: ");
            //    int so = int.Parse(Console.ReadLine());
            //    if(so % 10 == 0)
            //    {
            //        break; // Break dùng để thoát khỏi 1 cấu trúc code
            //    }
            //}
            //int x = 10;
            //do
            //{
            //    Console.WriteLine("Nhập 1 số bất kì: ");
            //    x = int.Parse(Console.ReadLine());
            //    if (x % 10 == 0)
            //    {
            //        break; // Break dùng để thoát khỏi 1 cấu trúc code
            //    }
            //} while (true);
            
            // vòng lặp foreach => chỉ sử dụng với các tập hợp
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            foreach (int item in arr)
            {
                if(item %2 == 0)
                {
                    Console.WriteLine(item);
                }              
            }
            int tich = 1;
            foreach (int item in arr)
            {
                if (item % 3 != 0) tich *= item;
            }
            Console.WriteLine("Tích là "+tich);
            // Dùng foreach, tính tích các số không chia hết cho 3 trong dãy arr
            Console.ReadKey();
        }
    }
}
