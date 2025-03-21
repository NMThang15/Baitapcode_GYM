namespace ThemPhanTuVaoMang
{

        public class Program
        {
            public static void Main(string[] args)
            {
                int[] num = new int[] { 10, 4, 6, 7, 8 };
                foreach (int bf in num)
                {
                    Console.Write(bf + " ");
                }
                Console.Write("\nnhap X: ");
                int x = int.Parse(Console.ReadLine());
                num = new int[] { 10, 4, 6, x, 7, 8 };
                foreach (int at in num)
                {
                    Console.Write(at + " ");
                }
                Console.ReadKey();



            }

        }
}
