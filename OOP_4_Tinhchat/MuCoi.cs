using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4_Tinhchat
{
    /*
     * Kế thừa là một class được khai báo kế thừa 1 class khác
     * Sau khi kế thừa, class con sẽ có mọi thành phần của class cha
     * Class con có thể chứa nhiều thuộc tính hơn class cha
     * 1 Class con chỉ có thể kế thừa 1 class cha tuy nhiên 1 class cha lại có
     * thể được kế thừa bởi nhiều class con
     * Khi khởi tạo, ta có thể khởi tạo đối tượng của Cha thông qua constructor
     * của Class con tuy nhiên điều ngược lại là không được
     */
    internal class MuCoi : Mu // Sử dụng : để thể hiên sự kế thừa
    {
        string mausac;
        string hoavan;
        public MuCoi()
        {
        }

        public MuCoi(string mausac, string hoavan)
        {
            this.Mausac = mausac;
            this.Hoavan = hoavan;
        }
        public MuCoi(string ten, string chatlieu, string nhasanxuat, int gia, string mausac, string hoavan) : base(ten, chatlieu, nhasanxuat, gia)
        {
            // : base: Kế thừa constructor của lớp cha
            this.Mausac = mausac;
            this.Hoavan = hoavan;
        }
        // Ctrl ., Generate constructor -> Generate all
        // sau đó add parameter cho các thuộc tính mới
        public string Mausac { get => mausac; set => mausac = value; }
        public string Hoavan { get => hoavan; set => hoavan = value; }
        /*
         *  Bước 1:
            tạo thuộc tính mới cho lớp con 
            Bước 2: 
            tạo constructor không tham số
            Bước 3: Chuột phải vào lớp kế thừa => Quick action 
            => Tạo constructor có đử tham số như lớp cha
            Bước 4: bôi đen các thuộc tính mới -> chuột phải 
            => Quick action => add parameter to Constructor 
            => Chọn cái vừa tạo ở bước 3
         */
        public void ThongTin()
        {
            base.ThongTin(); // Gọi phương thức mà nó kế thừa từ lớp cha
            Console.WriteLine($"Đặc biệt chiếc mũ này còn có hoa văn {hoavan} " +
                $"và màu {mausac}");
        }

    }
}
