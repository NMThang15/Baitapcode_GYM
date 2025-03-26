/*
 [Thực hành] Xây dựng class Animal
Mục tiêu
Luyện tập định nghĩa lớp, tạo đối tượng, kế thừa sử dụng các phương thức của đối tượng và phạm vi truy cập.

Điều kiện
– Biết cách khai báo lớp (thuộc tính, phương thức)

– Biết cách khởi tạo đối tượng

– Biết cách sử dụng các phương thức của đối tượng
 */

using System.Reflection.Metadata;

namespace ThucHanh_XayDungClassAnimal
{

    //Bước 1: Tạo class Animal, khai báo thuộc tính (properties) ,
    //định nghĩa hàm khởi tạo (contructor),
    //và hàm PrintInfo là 1 abtract method hàm này sẽ được lớp con triển khai (implement)
    public abstract class Animal
    {
        protected string Weight { get; set; }
        protected string Height { get; set; }
        public Animal(string weight, string height)
        {
            this.Weight = weight;
            this.Height = height;
        }
        public abstract void PrintInfo();
    }
    //Bước 2: Tạo class Cat kế thừa từ lớp Animal, khai báo thuộc tính,
    //định nghĩa hàm khởi tạo, và override hàm PrintInfo
    class Cat : Animal
    {
        private string Name { get; set; }
        public Cat(string weight, string height, string name) : base(weight, height)
        {
            this.Name = name;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Weight : {0}" + '\n' + "Height: {1}" + '\n' + "Name: {2}", this.Weight, this.Height, this.Name);
        }
    }
        //Bước 3 : Tạo class Program, Tại hàm Main khởi tạo đối tượng Cat
        //và triệu gọi phương thức PrintInfo
       class Progarm
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("20kg", "1.5", "kitty");
            cat.PrintInfo();
        }
    }
  
}
