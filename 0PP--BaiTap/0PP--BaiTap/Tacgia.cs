using System;

namespace OOP_BaiTap
{
    class TacGia
    {
        public string Ten { get; set; }
        public int NamSinh { get; set; }

        public void HienThi()
        {
            Console.WriteLine($"Tác giả: {Ten}, Năm sinh: {NamSinh}");
        }
    }
}
