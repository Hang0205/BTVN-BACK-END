using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_3BAI1
{
    class CanBo
    {
            public string HoTen { get; set; }
            public int NamSinh { get; set; }
            public string GioiTinh { get; set; }
            public string DiaChi { get; set; }

            public virtual void Nhap()
            {
                Console.Write("Nhập họ tên: ");
                HoTen = Console.ReadLine();

                Console.Write("Nhập năm sinh: ");
                NamSinh = int.Parse(Console.ReadLine());

                Console.Write("Nhập giới tính: ");
                GioiTinh = Console.ReadLine();

                Console.Write("Nhập địa chỉ: ");
                DiaChi = Console.ReadLine();
            }

            public virtual void Xuat()
            {
                Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Giới tính: {GioiTinh}, Địa chỉ: {DiaChi}");
            }
        }

        class CongNhan : CanBo
        {
            public int Bac { get; set; }

            public override void Nhap()
            {
                base.Nhap();
                Console.Write("Nhập bậc (VD: 3 cho bậc 3/7): ");
                Bac = int.Parse(Console.ReadLine());
            }

            public override void Xuat()
            {
                base.Xuat();
                Console.WriteLine($"Bậc: {Bac}/7");
            }
        }

        class KySu : CanBo
        {
            public string NganhDaoTao { get; set; }

            public override void Nhap()
            {
                base.Nhap();
                Console.Write("Nhập ngành đào tạo: ");
                NganhDaoTao = Console.ReadLine();
            }

            public override void Xuat()
            {
                base.Xuat();
                Console.WriteLine($"Ngành đào tạo: {NganhDaoTao}");
            }
        }

        class NhanVien : CanBo
        {
            public string CongViec { get; set; }

            public override void Nhap()
            {
                base.Nhap();
                Console.Write("Nhập công việc: ");
                CongViec = Console.ReadLine();
            }

            public override void Xuat()
            {
                base.Xuat();
                Console.WriteLine($"Công việc: {CongViec}");
            }
        }
    }

