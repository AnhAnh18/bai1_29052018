using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHang.SanPham
{
    class SanPhamm
    {
        private String MaSo;
        private String TuaDe;
        private String NhaSanXuat;
        private double Gia;

        public SanPhamm(string maSo, string tuaDe, string nhaSanXuat, double gia)
        {
            MaSo = maSo;
            TuaDe = tuaDe;
            NhaSanXuat = nhaSanXuat;
            Gia = gia;
        }

        public String gsMaSo
        {
            get { return MaSo; }
            set { MaSo = value; }
        }

        public String gsTuaDe
        {
            get { return TuaDe; }
            set { TuaDe = value; }
        }

        public String gsNhaSanXuat
        {
            get { return NhaSanXuat; }
            set { NhaSanXuat = value; }
        }

        public double gsGia
        {
            get { return Gia; }
            set { Gia = value; }
        }
        public SanPhamm()
        {
        }
    }
}
