using System;

namespace OOP_BaiTap
{
    class PhanSo
    {
        public int Tu { get; set; }
        public int Mau { get; set; }

        public PhanSo(int tu, int mau)
        {
            Tu = tu;
            Mau = mau;
        }

        int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        public void RutGon()
        {
            int u = UCLN(Tu, Mau);
            Tu /= u;
            Mau /= u;
        }

        public void HienThi()
        {
            Console.WriteLine($"Phân số: {Tu}/{Mau}");
        }
    }
}
