//[Thực hành] Sử dụng toán tử
using System;

namespace dientich
{
    class program
    {
        static void Main(string[] args)
        {
            float width;
            float height;
            Console.Write("Enter Width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter Height: ");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Area is: " + (width * height));
        }
    }
}