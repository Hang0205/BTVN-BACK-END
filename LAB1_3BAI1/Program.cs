using System;
using LAB1_3BAI1;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            QLCB qlcb = new QLCB();
            int chon;

            do
            {
                Console.WriteLine("\n=== MENU QUẢN LÝ CÁN BỘ ===");
                Console.WriteLine("1. Thêm cán bộ");
                Console.WriteLine("2. Tìm kiếm theo tên");
                Console.WriteLine("3. Hiển thị danh sách cán bộ");
                Console.WriteLine("4. Thoát");
                Console.Write("Mời chọn: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        qlcb.ThemCanBo();
                        break;
                    case 2:
                        qlcb.TimKiemTheoTen();
                        break;
                    case 3:
                        qlcb.HienThiDanhSach();
                        break;
                    case 4:
                        Console.WriteLine("Đang thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            } while (chon != 4);

            Console.WriteLine("== Kết thúc ==");
        }
    }
}

