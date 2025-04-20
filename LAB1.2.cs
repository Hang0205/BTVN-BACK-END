/*
//Bài 1: Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng.
using System;
namespace LAB1_2
{
    class Program
    {
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public static int TongSoChan(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    tong += a[i];
                }
            }
            return tong;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Khai báo biến n
            int n;
            // Nhập giá trị cho biến n
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            // Khai báo và khởi tạo mảng số nguyên có n phần tử
            int[] a = new int[n];
            // Gọi hàm nhập mảng
            NhapMang(a, n);
            // Gọi hàm Tính Tổng các số chẵn và hiển thị kết quả
            Console.WriteLine($"Tổng các số chẵn = {TongSoChan(a, n)}");
        }
    }
}


*/




/*
//bài 2: Viết chương trình nhập vào mảng gồm n phần tử nhập từ bàn phím. Viết hàm để kiểm
//tra xem một số có phải là số nguyên tố hay không, hiển thị chỉ số và giá trị của những phần tử
//là số nguyên tố trong mảng.
using System;
namespace LAB1_2
{
    class Program
    {
        // Hàm nhập mảng
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        // Hàm kiểm tra số nguyên tố
        public static bool LaSoNguyenTo(int x)
        {
            if (x < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        // Hàm hiển thị chỉ số và giá trị các phần tử là số nguyên tố
        public static void HienThiSoNguyenTo(int[] a, int n)
        {
            Console.WriteLine("Các phần tử là số nguyên tố trong mảng:");
            for (int i = 0; i < n; i++)
            {
                if (LaSoNguyenTo(a[i]))
                {
                    Console.WriteLine($"a[{i}] = {a[i]}");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Khai báo biến n
            int n;
// Nhập giá trị cho biến n
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            // Khai báo và khởi tạo mảng số nguyên có n phần tử
            int[] a = new int[n];
            // Gọi hàm nhập mảng
            NhapMang(a, n);
            // Gọi hàm hiển thị các số nguyên tố trong mảng
            HienThiSoNguyenTo(a, n);
        }
    }
}
*/



/*
//bài 3: Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập  từ bàn phím
using System;
namespace LAB1_2
{
    class Program
    {
        // Hàm nhập mảng
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        // Hàm đếm số âm
        public static int DemSoAm(int[] a, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0)
                    dem++;
            }
            return dem;
        }
        // Hàm đếm số dương
        public static int DemSoDuong(int[] a, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0)
                    dem++;
            }
            return dem;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Khai báo biến n
            int n;
            // Nhập giá trị cho biến n
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            // Khai báo và khởi tạo mảng số nguyên có n phần tử
            int[] a = new int[n];
            // Gọi hàm nhập mảng
            NhapMang(a, n);
            // Gọi hàm đếm số âm và dương, hiển thị kết quả
            Console.WriteLine($"Số lượng số âm = {DemSoAm(a, n)}");
            Console.WriteLine($"Số lượng số dương = {DemSoDuong(a, n)}");
        }
    }
}
*/
