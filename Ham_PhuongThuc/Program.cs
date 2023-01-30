using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ham_PhuongThuc
{
    /*
     * Các loại hàm cơ bản
     * Xét về kiểu trả về: trả về - không trả về (void)
     * Xét về tham số truyền vào: - Có tham số - không tham số
     * Chữ ký hàm => kiểu trả về + tham số
     */
    // Cú pháp viết hàm
    /*
        phạm_vi_truy_cập kiểu_trả_về Tên_Hàm(danh_sách_tham_số){
            thân hàm...
        }
     */
    internal class Program
    {
        static void NhapXuat()    // Không trả về - không truyền vào
        {
            Console.WriteLine("Nhập số tiền được mừng tuổi:");
            int mungtuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Bạn được mừng tuổi: " + mungtuoi);
        }
        static void SoSanh(int a, int b) // không trả về - có truyền vào
        {
            if (a > b)
            {
                Console.WriteLine($"{a} lớn hơn {b}");
            }
            else if (b > a)
            {
                Console.WriteLine($"{b} lớn hơn {a}");
            }
            else Console.WriteLine("Hai số bằng nhau");
        }
        static void LuyThua(int a, int b)
        {
            int ketqua = 1;
            if (b < 0)
            {
                for (int i = 0; i > b; i--) { ketqua *= a; }
                Console.WriteLine($"{a} ^ {b} = {1.0 / ketqua}");
            }
            else if (b > 0)
            {
                for (int i = 0; i < b; i++) { ketqua *= a; }
                Console.WriteLine($"{a} ^ {b} = {ketqua}");
            }
            else Console.WriteLine($"{a} ^ {b} = 1");
        }
        // Hàm trả về không tham số => Khi gọi hàm, nó được sử dụng như 1 giá trị
        static int TinhTuoi()
        {
            Console.WriteLine("Nhập năm sinh của bạn để tính tuổi:");
            int namsinh = int.Parse(Console.ReadLine());
            return 2023 - namsinh;
        }
        // Truyền vào + trả về
        // Viết hàm truyền vào cân nặng và chiều cao của bạn trả về chỉ số BMI
        // + trạng thái cơ thể
        static string BMI(double cao, double nang)
        {
            double bmi = nang / cao / cao;
            if (bmi < 18.5) return $"Bạn có BMI là: {bmi}, bạn hơi gầy";
            if (bmi >= 18.5 && bmi <= 25)
            {
                return $"Bạn có BMI là: {bmi}, bạn cân đối";
            }
            return $"Bạn có BMI là: {bmi}, bạn hơi thừa cân";
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Gọi hàm
            Console.WriteLine(BMI(1.9, 100));
            // LuyThua(2, -3);
            // NhapXuat();
            // SoSanh(3, 5); 
            // BT: Viết và gọi hàm truyền vào 2 số a, b, in ra a^b
            // BTVN: 
            // 1. Viết hàm yêu cầu nhập tên + tuổi => in ra tên + năm sinh (3 điểm)
            // 2. Viết hàm truyền vào Số tiền của bạn, nhập giá tiền cho mỗi trái bóng và
            // hiển thị ra xem bạn có thể mua được bao nhiêu trái bóng (3 điểm)
            // 3. Viết hàm truyền vào số nguyên a, trả về true nếu đó là số nguyên tố, false
            // nếu không phải (3 điểm)
            // 4. Sử dụng Menu lặp với switch-case (1 điểm)
            // Console.WriteLine(TinhTuoi());
            Console.ReadKey();
        }
    }
}
