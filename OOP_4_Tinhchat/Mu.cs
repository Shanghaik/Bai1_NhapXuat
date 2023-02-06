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
    }
}
