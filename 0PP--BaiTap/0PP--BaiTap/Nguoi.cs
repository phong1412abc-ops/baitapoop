using System;

namespace OOP_BaiTap
{
    class Nguoi
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            Tuoi = int.Parse(Console.ReadLine());
        }

        public void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Tuổi: {Tuoi}");
        }
    }
}
