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

                Console.Write("\nnhap x vao vi tri can chen: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("\nnhap vao vi tri index: ");
                int  index= int.Parse(Console.ReadLine());

                if (index<0 || index > num.Length)
            {
                Console.WriteLine("Loi ko chen vao dc!!!");

            }
                else
            {
                int[] NewNum = new int[num.Length + 1];

                for (int i = 0 , j = 0; i < NewNum.Length; i++)
                {
                    if (i == index)
                    {
                        NewNum[i] = x;
                    }
                    else
                    {
                        NewNum[i] = num[j];
                        j++;
                    }
                }
                Console.WriteLine("man sau khi chen:");
                foreach (int at in NewNum)
                {
                    Console.Write(at + " ");
                }
            }
            Console.ReadKey();

        }

        }
}
