using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien
{
    internal class Sinhvien
    {
        string code;
        int tuoi;
        string ten;
        string nganh;

        public Sinhvien()
        {
        }

        public Sinhvien(string code, int tuoi, string ten, string nganh)
        {
            this.Code = code;
            this.Tuoi = tuoi;
            this.Ten = ten;
            this.Nganh = nganh;
        }

        public string Code { get => code; set => code = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Nganh { get => nganh; set => nganh = value; }
        public void InThongTin()
        {
            Console.WriteLine($"Tên: {ten}, tuổi: {tuoi}," +
                $" mã: {code}, ngành {nganh}");
        }
    }
}
