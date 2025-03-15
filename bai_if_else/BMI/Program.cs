namespace can_nang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cao, kg;
            Console.Write("cao: ");
            cao = double.Parse(Console.ReadLine());
            Console.Write("kg: ");
            kg = double.Parse(Console.ReadLine());
            double bmi = kg / Math.Pow(cao, 2); // cân nặng / bình phương của chiều cao 
            bmi = Math.Round(bmi, 1); // làm trò chỉ số đến 1 số sau dấu phẩy
            Console.Write("BMI: " + bmi);

            if (bmi < 18)
            {
                Console.WriteLine(" coi");
            }
            else if (bmi < 25.0)
            {
                Console.WriteLine(" bth");
            }
            else if (bmi < 30.0)
            {
                Console.WriteLine(" thua can");
            }
            else
            {
                Console.WriteLine(" Beo");
            }
        }
    }
}
