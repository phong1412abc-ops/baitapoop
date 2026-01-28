using System;

namespace OOP_BaiTap
{
    class HanhKhach
    {
        public string Ten { get; set; }
        public string SoVe { get; set; }

        public void LenXe()
        {
            Console.WriteLine($"{Ten} lên xe với vé số {SoVe}");
        }
    }
}
