using System;
using System.Text;

namespace OOP
{
    internal class Program
    {
        /*
         * OOP - Object Oriented Programing - Lập trình hướng đối
         * tượng là phương pháp lập trình cho phép ta tạo ra và
         * thao tác trên các đối tượng cụ thể vd như: con người,
         * động vật, nhà cửa,... 
         * Đối tượng - object: Bất kì sự vật, hiện tượng nào sở 
         * hữu các thuộc tính (đặc điểm), có thể hành động và có
         * thể được quản lý thì đều là đối tượng
         * Chúng ta không trực tiếp tạo ra các đối tượng đơn lẻ
         * mà sử dụng 1 thành phần là Class (lớp) để tạo ra đối
         * tượng. Mỗi class là một nguyên mẫu của đối tượng, mỗi
         * đối tượng được gọi là 1 thể hiện của class (instance)
         * Trong OOP có 4 tính chất cơ bản mà chúng ta cần nắm được
         * + Tính bao đóng (đóng gói): Thể hiện khả năng truy cập
         * + Tính kế thừa: Thể hiện khả năng kế thừa
         * + Tính trừu tượng: Trừu tượng hóa một loại đối tượng
         * + Tính đa hình: Thể hiện các mặt khác nhau trong cùng 1
         * hành vi của các đối tượng
         */
        // Tạo class Chuột phải vào project -> New items
        // -> Class -> Đặt tên -> Add
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Nguoi nguoi = new Nguoi(); // Khởi tạo 1 đối tượng với ctr không tham số
            nguoi.InThongTin(); // Gọi phương thức từ lớp Nguoi
            Nguoi nguoi2 = new Nguoi("Khánh", 19, "123", 120, 100); // có tham số
            nguoi2.InThongTin();
     
        }
    }
}
