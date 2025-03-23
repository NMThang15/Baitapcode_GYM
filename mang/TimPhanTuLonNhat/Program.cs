//[Bài tập] Tìm phần tử lớn nhất trong mảng hai chiều
namespace TimPhanTuLonNhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Hang, Cot;
            Console.Write("Nhap so hang: ");
            Hang = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            Cot = int.Parse(Console.ReadLine());

            int[,] arrayA = new int[Hang, Cot];

            for (int i = 0; i < arrayA.GetLength(0); i++)// hang
            {
                for(int j = 0; j < arrayA.GetLength(1) ; j++)// cot
                {
                    Console.Write("Nhap gia tri phan tu [{0},{1}]: ", i, j);
                    arrayA[i, j] = int.Parse(Console.ReadLine()); 
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nMang 2 chieu da nhap: ");
            for (int i = 0; i < Hang; i++)
            {
                for (int j = 0; j < Cot; j++)
                {
                    Console.Write(arrayA[i, j]+"\t");

                }
                Console.WriteLine();
            }
            //tim phan tu lon nhat vaf vi tri
            int maxValue = arrayA[0, 0];
            int maxRow = 0, maxCol = 0;

            for (int i = 0; i < Hang; i++)
            {
                for (int j = 0; j < Cot; j++)
                {
                    if (arrayA[i, j] > maxValue)
                    {
                        maxValue = arrayA[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            // Hiển thị kết quả
            Console.WriteLine($"\nPhan tu lon nhat: {maxValue} tai vi tri [{maxRow}, {maxCol}]");


            Console.ReadKey();
            

        }
    }
}
