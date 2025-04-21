using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_5BAI2
{
    using System;

    namespace HinhHoc
    {
        public class HinhChuNhat : Hinh
        {
            public double ChieuDai { get; set; }
            public double ChieuRong { get; set; }

            public HinhChuNhat(double dai, double rong)
            {
                ChieuDai = dai;
                ChieuRong = rong;
            }

            public override double TinhChuVi()
            {
                return 2 * (ChieuDai + ChieuRong);
            }

            public override double TinhDienTich()
            {
                return ChieuDai * ChieuRong;
            }
        }
    }

}

