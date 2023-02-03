using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class Nguoi
    {
        // Các thành phần chính trong 1 class
        // 1. Các thuộc tính
        string ten = "Lê văn A"; // giá trị mặc định ngoài constructor
        int tuoi = 10;
        string cccd = "Không có";
        double chieucao = 200;
        double cannang = 70;
        // 2. Constructor - Hàm tạo
        // - Tạo các thuộc tính cho đối tượng, Tạo đối tượng
        // Có 2 loại hàm tạo (không tham số - có tham số)
        public Nguoi() // ctor tab tab
        {
            // constructor không tham số
            // Tạo ra các đối tượng với các thuộc tính mang giá
            // trị mặc định
            ten = "Lê Văn B"; tuoi = 20; cccd = "1234"; // mặc định
        }
        public Nguoi(string ten, int tuoi, string cccd, double chieucao, double cannang)
        { // Tạo ra các đối tượng với các thuộc tính có giá trị được truyền vào
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.Cccd = cccd;
            this.Chieucao = chieucao;
            this.Cannang = cannang;
        }
        // 3. Property: Cho phép ta truy cập đến các thuộc tính của đối tượng một cách gián tiếp
        // Bôi đen thuộc tính muốn tạo -> chuột phải -> Quick action -> Encapsulate .. property
        // get: lấy giá trị, set: gán giá trị
        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public double Chieucao { get => chieucao; set => chieucao = value; }
        public double Cannang { get => cannang; set => cannang = value; }
        // 4. Các phương thức của class - Các hành vi của đối tượng
        public void InThongTin()
        {
            Console.WriteLine($"Tên: {ten}, tuổi: {tuoi}, CCCD: {cccd}");
        }
        // Viết phương thức kiểm tra xem người đó béo hay gầy
        // Cân nặng > Số lẻ chiều cao -> Béo
        // Cân nặng < Số lẻ chiều cao -> Gầy
        public void KiemTraGayBeo()
        {
            if(cannang < chieucao - 100)
            {
                Console.WriteLine("Bạn hơi gầy");
            }
            else Console.WriteLine("Bạn hơi béo");
        }
        // Tạo 1 Class Bò có các mô tả sau:
        /* Thuộc tính
         * Số hiệu (ID): int
         * Giống bò: string
         * Màu lông: string
         * Mô tả: string
         * Giới tính: bool (true-false)
         * 2 loại Constructor
         * 3 Property
         * 4 Phương thức
         * Ăn cỏ, InThongTin, Rống
         */
    }
}
