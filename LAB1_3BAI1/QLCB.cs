using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_3BAI1
{
    class QLCB
    {
        private List<CanBo> danhSachCanBo = new List<CanBo>();

        public void ThemCanBo()
        {
            Console.WriteLine("Chọn loại cán bộ muốn thêm:");
            Console.WriteLine("1. Công nhân");
            Console.WriteLine("2. Kỹ sư");
            Console.WriteLine("3. Nhân viên");
            Console.Write("- Nhập lựa chọn: ");
            int loai = int.Parse(Console.ReadLine());

            CanBo cb = null;
            switch (loai)
            {
                case 1:
                    cb = new CongNhan();
                    break;
                case 2:
                    cb = new KySu();
                    break;
                case 3:
                    cb = new NhanVien();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    return;
            }

            cb.Nhap();
            danhSachCanBo.Add(cb);
            Console.WriteLine("=> Thêm cán bộ thành công!\n");
        }

        public void TimKiemTheoTen()
        {
            Console.Write("Nhập tên cần tìm: ");
            string ten = Console.ReadLine();

            var ketQua = danhSachCanBo.Where(cb => cb.HoTen.Contains(ten, StringComparison.OrdinalIgnoreCase)).ToList();

            if (ketQua.Count > 0)
            {
                Console.WriteLine("== Kết quả tìm thấy ==");
                foreach (var cb in ketQua)
                {
                    cb.Xuat();
                    Console.WriteLine("--------------------------");
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy cán bộ nào với tên này.");
            }
        }

        public void HienThiDanhSach()
        {
            Console.WriteLine("== Danh sách cán bộ ==");
            foreach (var cb in danhSachCanBo)
            {
                cb.Xuat();
                Console.WriteLine("--------------------------");
            }
        }
    }
}

