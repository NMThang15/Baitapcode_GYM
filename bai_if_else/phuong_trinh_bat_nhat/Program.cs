//[Thực hành] Giải phương trình bậc nhất
using System;

namespace phuong_trinh_bat_nhat
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("trinh giai phuong trinh");
            Console.WriteLine("cho nhuong trinh 'a*x +b =0', vui long nhap so: ");
            Console.WriteLine("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if ( a != 0 )
            {
                Console.WriteLine("ket qua: " + (-b / a));
            }
            else
            {
                if(b ==0)
                {
                    Console.WriteLine("phuong trinh vo so nghiem");
                }
                else
                {
                    Console.WriteLine("phuong trinh vo nghiem");
                }
            }
        }
    }
}