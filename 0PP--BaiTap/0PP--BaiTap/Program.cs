using System;

namespace OOP_BaiTap
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            sv.NhapSV();
            sv.HienThiSV();

            PhanSo ps = new PhanSo(6, 8);
            ps.RutGon();
            ps.HienThi();

            VanDongVien vdv = new VanDongVien { Ten = "Nam", MonThiDau = "Bóng đá" };
            vdv.ThiDau();

            HinhChuNhat hcn = new HinhChuNhat { Dai = 5, Rong = 3 };
            Console.WriteLine("Diện tích HCN: " + hcn.DienTich());

            Cho cho = new Cho();
            cho.Keu();

            Console.ReadLine();
        }
    }
}
