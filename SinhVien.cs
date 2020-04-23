using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_bai6
{
    class SinhVien
    {
        public string masv;
        private string Hoten;
        private int namsinh;
        private double DiemLT, DiemCSDL;
        public double DiemTB;
        public SinhVien()
        {
            masv = "";
            Hoten = "";
            namsinh = 2000;
            DiemLT = DiemCSDL = DiemTB = 0;

        }
        public SinhVien(string masv, string Hoten, int namsinh, double DiemLT, double DiemCSDL)
        {
            this.masv = masv;
            this.Hoten = Hoten;
            this.namsinh = namsinh;
            this.DiemLT = DiemLT;
            this.DiemCSDL = DiemCSDL;
            this.DiemTB = (DiemLT + DiemCSDL) * 0.5;
        }
        public void Nhap()
        {
            Console.WriteLine("Ban dang goi ham nhap tt");
            Console.WriteLine("Hay nhap ma cua sinh vien");
            masv = Console.ReadLine();
            Console.WriteLine("Hay nhap ho ten cua sinh vien");
            Hoten = Console.ReadLine();
            Console.WriteLine("Hay nhap nam sinh cua sinh vien");
            namsinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hay nhap diem lap trinh cua sinh vien");
            DiemLT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hay nhap vao diem co so du lieu cua sinh vien");
            DiemCSDL = Convert.ToInt32(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Ban dang goi ham nhap tt");
            Console.WriteLine("Ma cua sinh vien la: " + masv);
            Console.WriteLine("ho ten cua sinh vien la: " + Hoten);
            Console.WriteLine("nam sinh cua sinh vien la: " + namsinh);
            Console.WriteLine("Diem lap trinh cua sinh vien la: " + DiemLT);
            Console.WriteLine("Diem co so du lieu cua sinh vien la: " + DiemCSDL);
            DiemTB = 0.5 * (DiemLT + DiemCSDL);
            Console.WriteLine("Diem trung binh cua sinh vien la: " + DiemTB);

        }


    }
}
