using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHang
{
    class KhachHang
    {
        private String Ma;
        private String HoTen;
        private String SDT;

        public KhachHang()
        {

        }

        public KhachHang(string ma, string hoTen, string sDT)
        {
            Ma = ma;
            HoTen = hoTen;
            SDT = sDT;
        }
        public String gsMa {
            get { return Ma;}
            set { Ma = value;}
        }
        public String gsHoTen {
            get { return HoTen; }
            set { HoTen = value;}
        }
        public String gsSDT {
            get { return SDT; }
            set { SDT = value;}
        }
    }
}
