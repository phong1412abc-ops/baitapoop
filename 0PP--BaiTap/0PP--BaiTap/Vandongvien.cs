using System;

namespace OOP_BaiTap
{
    class VanDongVien
    {
        public string Ten { get; set; }
        public string MonThiDau { get; set; }

        public void ThiDau()
        {
            Console.WriteLine($"{Ten} đang thi đấu môn {MonThiDau}");
        }
    }
}
