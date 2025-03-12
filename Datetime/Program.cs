//[Thực hành] Hiển thị thời gian của hệ thống
using System;

namespace Systemtime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            System.Console.WriteLine("Datetime now is : " + localDate);
        }
    }
}