//[Bài tập] Hiển thị các số nguyên tố nhỏ hơn 100
namespace so_nguyen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("danh sach so nguyen < 100");
            for (int i = 2; i < 100; i++)
            {
                if (LaSoNguyenTo(i))
                {
                    Console.Write(i + " ");

                }
            }
        }
        static bool LaSoNguyenTo(int n)
        {
            if ( n < 2)
                return false;
            for (int i = 2; i * i <= n; i++)// chi kt den sqrt(n)
            {
                if (n % i == 0)
                    return false;

            }
            return true;
        }
    }
}
