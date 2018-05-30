using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHang
{
    class Dia : SanPham.SanPhamm
    {
        private int ThoiGian;

        public Dia(string maSo, string tuaDe, string nhaSanXuat, double gia,int thoiGian)
            : base ( maSo, tuaDe, nhaSanXuat,  gia)
        {
            ThoiGian = thoiGian;
        }
        public int gsThoiGian
        {
            get { return ThoiGian; }
            set { ThoiGian = value; }
        }

        public Dia()
        {
        }
    }
}
