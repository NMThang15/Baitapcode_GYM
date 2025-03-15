//[Thực hành] Tính số ngày trong tháng
using System;
using static System.Net.Mime.MediaTypeNames;

namespace tinh_so_ngay_trongthang
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("muon dem ngay thang nao? ");
            int thang = Int32.Parse(Console.ReadLine());
            switch (thang)
            {
                case 2:
                    Console.WriteLine("thang 2 co 29 ngay! ");
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("thang '" + thang + "' co 31 ngay");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("thang '" + thang + "' co 30");
                    break;
                default:
                    Console.WriteLine("ko hop le");
                    break;

            }
        }
    }
}