using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap1_5Bai1
{
     class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo{ get; set; }

        public PhanSo()
        { 
            TuSo = 0;
            MauSo = 1;
        }
        public PhanSo(int TuSo, int MauSo)
        {
            TuSo = MauSo;
            MauSo = (MauSo ==0) ? 1 : MauSo;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());
            if (TuSo == 0)
            {
                Console.WriteLine("Mẫu số không được bằng 0. Gán mẫu số bằng 1. ");
                MauSo = 1;
            }
        }
        public static PhanSo Cong(PhanSo a, PhanSo b)

        {
            int tuMoi = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            int mauMoi = a.MauSo * b.MauSo;
            return RutGon(new PhanSo(tuMoi, mauMoi));
        }

        public static PhanSo RutGon(PhanSo ps)
        {
            int ucln = UCLN(Math.Abs(ps.TuSo), Math.Abs(ps.MauSo));
            return new PhanSo(ps.TuSo / ucln, ps.MauSo / ucln);
        }

        private static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            return $"{TuSo}/{MauSo}";
        }
    }
}
    