using System;
using System.Collections.Generic;
using System.Text;
using LAB2;
using Lap1_5Bai1;

namespace LAB2
{
    class Program
    {
        public static List<PhanSo> danhSachPhanSo = new List<PhanSo>();

        static void Main(string[] args)
        {
            getMenu();
        }

        public static void getMenu()
        {
            int n;
            do
            {
                Console.Clear();
                Console.WriteLine("============== CHƯƠNG TRÌNH TÍNH TỔNG CÁC PHÂN SỐ ==============");
                Console.WriteLine("Danh sách phân số: ");
                HienThiDanhSach();
                Console.WriteLine("=================================================================");
                Console.WriteLine("1. Thêm phân số: ");
                Console.WriteLine("2. Tính tổng các phân số: ");
                Console.WriteLine("3. Thoát: ");

                do
                {
                    Console.Write(" Mời chọn chức năng: ");
                   
                } while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 3);

                switch (n)
                {
                    case 1:
                        {
                            PhanSo ps = new PhanSo();
                            ps.Nhap();
                            danhSachPhanSo.Add(ps);
                            Console.WriteLine("Đã thêm phân số thành công: ");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        {
                            var tong = TinhTong();
                            Console.WriteLine($"Tổng các phân số là: {tong}");
                            Console.ReadLine();
                        }
                        break;
                    default: break;
                }

            } while (n != 3);
        }

        public static void HienThiDanhSach()
        {
            if (danhSachPhanSo.Count == 0)
            {
                Console.WriteLine("Chưa có phân số nào: ");
                return;
            }

            for (int i = 0; i < danhSachPhanSo.Count; i++)
            {
                Console.WriteLine($"Phân số {i + 1}: {danhSachPhanSo[i]}");
            }
        }

        public static PhanSo TinhTong()
        {
            PhanSo tong = new PhanSo(0, 1);
            foreach (var ps in danhSachPhanSo)
            {
                tong = PhanSo.Cong(tong, ps);
            }
            return tong;
        }
    }
}
