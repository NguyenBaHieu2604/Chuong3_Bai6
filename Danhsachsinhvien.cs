using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_bai6
{
    class Danhsachsinhvien
    {
        private int n;
        private SinhVien[] DS;
        public void Nhap()
        {
            Console.WriteLine("Hay nhap so sinh vien trong danh sach: ");
            n = Convert.ToInt32(Console.ReadLine());
            DS = new SinhVien[n];
            for
                (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hay nhap thong tin cho sinh vien thu " + i);
                DS[i] = new SinhVien();
                DS[i].Nhap();

            }
        }
        public void Xuat()
        {
            if (DS != null && n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    DS[i].Xuat();
                }
            }
        }
        public void Sapxep()
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (string.Compare(DS[i].masv, DS[j].masv) > 0)
                    {
                        SinhVien tg = new SinhVien();
                        tg = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tg;
                    }
                } }

        public void xuatsvtren8()
        {
            Console.WriteLine("\nnhung sinh vien tren 8.0:");
            for (int i = 0; i < n; i++)
            {
                if (DS[i].DiemTB >= 8)
                {
                    Console.WriteLine("\nsinh vien {0} co diem trung binh tren 8", i + 1);
                }

            }
        }
    } 
}
