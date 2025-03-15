//[Bài tập] Ứng dụng đọc số thành chữ
namespace docso_to_chu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;
            while (!isValid)
            {
                Console.Write("Number to words: ");
                string? input = Console.ReadLine();
                string strin = input ?? string.Empty;

                if (int.TryParse(strin, out int num))
                {

                    if (num >= 1000)
                    {
                        Console.WriteLine("out of ability");
                    }
                    else if (num >= 0 && num < 10)
                    {
                        Console.WriteLine(NumberToWords(num));
                        isValid = true;
                    }
                    else if (num >= 10 && num < 20)
                    {
                        Console.WriteLine(NumberToWords(num));
                        isValid = true;
                    }
                    else if (num >= 20 && num < 100)
                    {
                        Console.WriteLine(NumberToWords(num));
                        isValid = true;
                    }
                    else if (num >= 100 && num < 1000)
                    {
                        Console.WriteLine(NumberToWords(num));
                        isValid = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

            }

        }
        static string NumberToWords(int num)
        {
            if (num < 10)
            {
                switch (num)
                {
                    case 0: return "zero";
                    case 1: return "one";
                    case 2: return "two";
                    case 3: return "three";
                    case 4: return "four";
                    case 5: return "five";
                    case 6: return "six";
                    case 7: return "seven";
                    case 8: return "eight";
                    case 9: return "nine";
                }
            }
            else if (num < 20)
            {
                switch (num)
                {
                    case 10: return "ten";
                    case 11: return "eleven";
                    case 12: return "twelve";
                    case 13: return "thirteen";
                    case 14: return "fourteen";
                    case 15: return "fifteen";
                    case 16: return "sixteen";
                    case 17: return "seventeen";
                    case 18: return "eighteen";
                    case 19: return "nineteen";
                }
            }
            else if (num < 100)
            {
                int tensPlace = num / 10; // lấy hàng chục vd 61/ 10= 6
                int onesPlace = num % 10;// lấy hàng đơn vị vd 61 % 10 = 1
                string tensWord = "";

                switch (tensPlace)
                {
                    case 2: tensWord = "twenty"; break;
                    case 3: tensWord = "thirty"; break;
                    case 4: tensWord = "forty"; break;
                    case 5: tensWord = "fifty"; break;
                    case 6: tensWord = "sixty"; break;
                    case 7: tensWord = "seventy"; break;
                    case 8: tensWord = "eighty"; break;
                    case 9: tensWord = "ninety"; break;
                }

                if (onesPlace == 0)
                    return tensWord;
                else
                    return tensWord + " " + NumberToWords(onesPlace);
            }
            else if (num < 1000)
            {
                int hundredsPlace = num / 100;// Lấy hàng trăm (ví dụ: 461 / 100 = 4)
                int remainder = num % 100;//lấy phần còn lại (ví dụ: 461 % 100 = 61)
                string hundredsWord = NumberToWords(hundredsPlace) + " hundred";

                if (remainder == 0)
                    return hundredsWord;
                else
                    return hundredsWord + " and " + NumberToWords(remainder);
            }

            return "out of ability";
        }

    }
}