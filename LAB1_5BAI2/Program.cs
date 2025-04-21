using System;
using System.Collections.Generic;
using HinhHoc;
using LAB1_5BAI2.HinhHoc;

namespace HinhHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Hinh> danhSachHinh = new List<Hinh>()
            {
                new HinhTron(5),
                new HinhVuong(4),
                new HinhChuNhat(6, 3),
                new HinhTamGiac(3, 4, 5)
            };

            double tongChuVi = 0;
            double tongDienTich = 0;

            Console.WriteLine("Danh sách các hình và thông tin:");

            foreach (var hinh in danhSachHinh)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Chu vi: {hinh.TinhChuVi():F2}");
                Console.WriteLine($"Diện tích: {hinh.TinhDienTich():F2}");
                tongChuVi += hinh.TinhChuVi();
                tongDienTich += hinh.TinhDienTich();
            }

            Console.WriteLine("=======================================");
            Console.WriteLine($"Tổng chu vi các hình: {tongChuVi:F2}");
            Console.WriteLine($"Tổng diện tích các hình: {tongDienTich:F2}");
            Console.ReadLine();
        }
    }
}

