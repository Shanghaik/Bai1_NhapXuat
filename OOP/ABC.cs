using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class ABC
    {
        int tuoi;
        string ten;
        string ma;
        string mota;
        public ABC()
        {

        }
        public ABC(int tuoi, string ten, string ma, string mota)
        {
            this.Tuoi = tuoi;
            this.Ten = ten;
            this.Ma = ma;
            this.Mota = mota;
        }

        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Ma { get => ma; set => ma = value; }
        public string Mota { get => mota; set => mota = value; }

        public void InThongTin()
        {
            Console.WriteLine($"Tên:{ten} tuổi: {tuoi}, mã: {ma}, mô tả: {mota}");
        }
    }
}
