//[Thực hành] Kiểm tra năm nhuận
/*
Trong phần này, chúng ta sẽ phát triển một ứng dụng nhằm kiểm tra 
xem một năm có phải là năm nhuận hay không.

Ứng dụng cho phép người dùng nhập vào một năm, sau đó sẽ đưa ra thông báo
là năm đó là năm nhuận hay không phải là năm nhuận.
Cách xác định năm nhuận: Những năm chia hết cho 4 là năm nhuận, 
ngoại trừ những năm chia hết cho 100 mà không chia hết cho 400.
 */
using System;

namespace kiem_tra_nam_nhuan
{
    class program
    {
        static void Main(string[] args)
        {
            int nam;
            bool nam_nhuan = false;
            Console.Write("Nam: ");
            nam = Convert.ToInt32(Console.ReadLine());

            if (nam % 4 == 0)
            {
                if(nam % 100 == 0)
                {
                    if(nam % 400 == 0)
                    {
                        nam_nhuan = true;
                    }
                }
                else
                {
                    nam_nhuan = true;
                }
            }
            if(nam_nhuan)
            {
                Console.WriteLine("{0} la nam nhuan", nam);
            }
            else
            {
                Console.WriteLine("{0} ko phai nam nhuan", nam);
            }

        }
    }
}