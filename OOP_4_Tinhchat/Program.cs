
using OOP;
using System;
using System.Text;

namespace OOP_4_Tinhchat
{
    internal class Program
    {
        /*
         * Trong lập trình hướng đối tượng chúng ta có 4 tính chất
         * căn bản nhất:
         * 1. Tính bao đóng - đóng gói: Thể hiện khả năng truy cập
         * của các thành phần trong Class. Tính bao đóng này được thể
         * hiện thông qua Access Modifier
         * Có 5 loại Access Modifier.
         * Public: Có thể truy cập được ở mọi nơi
         * Internal: Khả năng truy cập trong cùng Assembly (Project)
         * Private: Chỉ có thể truy cập được trong class chứa nó
         * Protected: Chỉ có thể truy cập trong class chứa nó hoặc class
         * kế thừa từ nó
         * Protected Internal = Protected + Internal
         * => Tính bao đóng đảm bảo sự bảo mật, tăng tính liên kết và giúp
         * cho chương trình giảm thiểu tài nguyên tiêu hao
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //Nguoiyeucu nyc = new Nguoiyeucu();
            //nyc.Ten = "Khánh";
            //Console.WriteLine("Tên người yêu cũ là "+ nyc.Ten);
            //nyc.Tuoi = 15;
            //Console.WriteLine("Tuổi người yêu cũ là " + nyc.Tuoi);
            //// nyc.Gioitinh = "Nam"; // Không trỏ tới được vì Gioitinh đang là Protected
            //nyc.Thoigianyeu = 100;
            //Console.WriteLine("Thời gian yêu là " + nyc.Thoigianyeu);
            //nyc.Sodo3vong = "90-60-90";
            //Console.WriteLine("Số đo 3 vòng là " + nyc.Sodo3vong);
            //nyc.InThongTin();
            //// Nếu để Private hoặc Protected sẽ không gọi được
            //Nguoi nguoi = new Nguoi(); 
            // Tạo đối tượng mà Class thuộc từ Project khác khi class là Public
            // Bài tập: Tạo Class Cho với mô tả sau:
            // ten : string public, giongcho string private, tuoi int internal
            // Sau đó viết phương thức MoTa để hiển thị thông tin của Chú Chó
            // MoTa có AC = protected internal sau đó thử thay thế = các AC khác
            // => Rút ra nhận xét
            Mu mu = new Mu("Nón sơn", "Da bò", "Nón Sơn", 500000);
            mu.ThongTin();
            //MuCoi mc = new Mu(); // Không thể tạo đối tượng của lớp con
                                 // = constructor của lớp cha
            Mu mu2 = new MuCoi("Nón Cối", "Da ngựa", "Thống nhất", 500000, "Vàng", "Vằn vện");
            // CÓ thể tạo đối tượng của lớp cha
            // = constructor của lớp con
            mu2.ThongTin();
            MuCoi mc2 = new MuCoi("Nón Cối xay", "Da dê", "Thống nhất", 500000, "Vàng", "Vằn vện");
            mc2.ThongTin();
            Mu mu3 = mc2; // Gán 1 giá trị của đối tượng con cho cha
            mu3.ThongTin();
        }
    }
}
