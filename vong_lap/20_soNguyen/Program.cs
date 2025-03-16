namespace n_so_nguyen_to_dau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            HienThiKq(n);

        }
        static void HienThiKq(int n)
        {
            int count = 0;
            int i = 2;
            while(count< n)
            {
                if(ktNgTo(i))
                {
                    count++;
                    Console.Write(i + " ");
                }
                i++;
            }
        }
        static bool ktNgTo(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
