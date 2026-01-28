using System;

namespace OOP_BaiTap
{
    class HinhChuNhat : HinhVe
    {
        public double Dai { get; set; }
        public double Rong { get; set; }

        public override double DienTich()
        {
            return Dai * Rong;
        }
    }
}
