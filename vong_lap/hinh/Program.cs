//[Bài tập] Hiển thị các loại hình
namespace hinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isvalid = false;
            while (!isvalid)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1.Print the rectangle\r\n2.Print the square triangle\r\n3.Print isosceles triangle\r\n4.Exit");
                Console.Write("Enter your choice: ");

                string? input = Console.ReadLine();
                string str = input ?? string.Empty;

                if (int.TryParse(str, out int num ))
                {
                    switch(num)
                    {
                        case 1: PrintRectangle(); break;
                        case 2: PrintSquareTriangle(); break;
                        case 3: PrintIsoscelesTriangle(); break;
                        case 4: isvalid = true; break;
                        default:
                            Console.WriteLine("invalid choice!!! PL select a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("False!!!");
                }
            }
            
        }
        static void PrintRectangle()
        {
            Console.Write("Enter width: ");
            int width = int.Parse(Console.ReadLine()!);
            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void PrintSquareTriangle()
        {
            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine()!);

            Console.WriteLine("1. Bottom-left");
            Console.WriteLine("2. Top-left");
            Console.WriteLine("3. Bottom-right");
            Console.WriteLine("4. Top-right");
            Console.Write("Choose type: ");
            int type = int.Parse(Console.ReadLine()!);

            if (type == 1)
            {
                for (int i = 1; i <= height; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else if (type == 2)
            {
                for (int i = height; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else if (type == 3)
            {
                for (int i = 1; i <= height; i++)
                {
                    for (int j = 1; j <= height - i; j++)
                    {
                        Console.Write("  ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else if (type == 4)
            {
                for (int i = height; i >= 1; i--)
                {
                    for (int j = 1; j <= height - i; j++)
                    {
                        Console.Write("  ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid option!");
            }
        }

        static void PrintIsoscelesTriangle()
        {
            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

    }

        
}

