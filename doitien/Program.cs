//[Bài tập] Ứng dụng chuyển đổi tiền tệ  23000 VND/USD
using System;

namespace doitien
{
    class program
    {
        static void Main(string[] args)
        {
            int usd;
            Console.WriteLine("Nhap USD: ");
            usd = int.Parse(Console.ReadLine());
            Console.WriteLine("=> VND: "+ (usd * 23000));
        }
    }
}