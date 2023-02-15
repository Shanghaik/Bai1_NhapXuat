using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4_Tinhchat
{
    internal class Mu
    {
        string ten;
        string chatlieu;
        string nhasanxuat;
        int gia;
        public Mu()
        {

        }
        public Mu(string ten, string chatlieu, string nhasanxuat, int gia)
        {
            this.Ten = ten;
            this.Chatlieu = chatlieu;
            this.Nhasanxuat = nhasanxuat;
            this.Gia = gia;
        }

        public string Ten { get => ten; set => ten = value; }
        public string Chatlieu { get => chatlieu; set => chatlieu = value; }
        public string Nhasanxuat { get => nhasanxuat; set => nhasanxuat = value; }
        public int Gia { get => gia; set => gia = value; }
        public void ThongTin()
        {
            Console.WriteLine($"{Ten} của nhà sản xuất {Nhasanxuat} " +
                $"được làm từ {chatlieu} có giá: {gia} ");
        }

        // Tính đa hình 
        // Thể hiện các trạng thái khác nhau của cùng 1 hành động
        // hàng động đó thể hiện qua các hàm, phương thức
        // có 2 loại đa hình là overload - nạp chồng
        // và override - ghi đè
        // overload có đặc điểm là: các phương thức được nạp chồng
        // có cùng tên và kiểu trả về, khác tham số truyền vào
        // override là khi lớp con thực hiện việc viết lại phương
        // thức mà nó kế thừa từ lớp cha (cùng tên, tham số, trả về)
        public void CachLam()
        {
            Console.WriteLine("Làm thủ công");
        }
        public virtual void CachLam(string vatlieu)
        {
            Console.WriteLine("Làm bằng cách kết hợp các "+vatlieu);
        }
        // 2 hàm trên là overload của nhau
        // Khi sử dụng, dựa vào cách truyền tham số mà chương
        // trình sẽ biết cần gọi phương thức nào
    }
}
