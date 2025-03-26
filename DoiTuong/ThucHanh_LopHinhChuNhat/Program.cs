//[Thực hành] Lớp hình chữ nhật

using System.Drawing;

namespace ThucHanh_LopHinhChuNhat
{
    //Bước 1: Tạo lớp Rectangle, khai báo các thuộc tính (properties),
    //định nghĩa các phương thức khởi tạo (contructors).
    public class HCN
    {
        double rong, cao;

        public HCN() 
        { }
        public HCN(double rong, double cao)
        {
            this.rong = rong;
            this.cao = cao;

        }
        //Bước 2: Định nghĩa các phương thức GetArea(), GetPerimeter(), Display()
        public double GetDienTich()
        {
            return this.rong * this.cao;
        }
        public double GetChuVi()
        {
            return (this.rong + this.cao) * 2;
        }
        public string Display()
        {
            return "HCN{" + "rong = " + rong + ", cao = " + cao + "}";
        }
    }
    
     //Bước 3: Tạo class chứa phương thức main để thực thi chương trình
     public class Program
    {
        public static void Main(string[] args)
        {
            //Bước 4: Khai báo các biến lưu kích thước hình chữ nhật và gán giá trị
            Console.WriteLine("Nhap rong: ");
            double rong = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap cao: ");
            //Bước 5: Khởi tạo một đối tượng thuộc lớp Rectangle với phương thức khởi tạo chứa 2 tham số width, height
            double cao = Double.Parse(Console.ReadLine());
            HCN hcn = new HCN(rong, cao);
            //Bước 6: Gọi các phương thức của lớp Rectangle thông qua đối tượng rectangle
            //đã tạo để hiển thị các thông số của hình chữ nhật
            Console.WriteLine("Hinh Chu nhat \n" + hcn.Display());
            Console.WriteLine("Chu vi hinh chu nhat: " + hcn.GetChuVi());
            Console.WriteLine("Dien tich hinh chu nhat: " + hcn.GetDienTich());
        }
    }
    


}
