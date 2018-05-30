using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHang
{
    class Sach : SanPham.SanPhamm
    {
        private string TenTacGia;
        private int SoTrang;

        public Sach(string maSo, string tuaDe, string nhaSanXuat, double gia,string tenTacGia, int soTrang )
            : base(maSo, tuaDe, nhaSanXuat, gia)
        {
            TenTacGia = tenTacGia;
            SoTrang = soTrang;
        }

        public Sach()
        {
        }

        
        public string gsTenTacGia
        {
            get { return TenTacGia; }
            set { TenTacGia = value; }
        }
    }
}
