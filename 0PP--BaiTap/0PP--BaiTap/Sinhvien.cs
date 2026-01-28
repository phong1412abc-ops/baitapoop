using System;

namespace OOP_BaiTap
{
    class SinhVien : Nguoi
    {
        public string MaSV { get; set; }
        public string Nganh { get; set; }

        public void NhapSV()
        {
            Nhap();
            Console.Write("Nhập mã SV: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhập ngành: ");
            Nganh = Console.ReadLine();
        }

        public void HienThiSV()
        {
            HienThi();
            Console.WriteLine($"Mã SV: {MaSV}, Ngành: {Nganh}");
        }
    }
}
