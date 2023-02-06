using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4_Tinhchat
{
    internal class Nguoiyeucu
    {
        // thuoctinh
        string ten; // Mặc định Access Modifier sẽ là private
        private int tuoi;
        private string gioitinh;
        private int thoigianyeu;
        private string sodo3vong;
        // Property là đại diện cho các thuộc tính
        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        protected string Gioitinh { get => gioitinh; set => gioitinh = value; }
        internal int Thoigianyeu { get => thoigianyeu; set => thoigianyeu = value; }
        protected internal string Sodo3vong { get => sodo3vong; set => sodo3vong = value; }

        public Nguoiyeucu()
        {
        }
        public Nguoiyeucu(string ten, int tuoi, string gioitinh, int thoigianyeu, string sodo3vong)
        {
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.Gioitinh = gioitinh;
            this.Thoigianyeu = thoigianyeu;
            this.Sodo3vong = sodo3vong;
        }

        protected internal void InThongTin()
        {
            Console.WriteLine($"Tôi từng yêu {ten} được {thoigianyeu} ngày");
            Console.WriteLine($"Là {gioitinh} " +
                $"nên số đo 3 vòng là: {sodo3vong}");
        }
    }
}
