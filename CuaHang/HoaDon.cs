using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHang
{
    class HoaDon
    {
        private String MaHD;
        private String MaK;
        private String MaSP;
        private String NgayBan;
        private int SoLuong;

        Bang bang = new Bang();
        Dia dia = new Dia();
        Sach sach = new Sach();

        List<String> dsH = new List<String>();
        List<int> sl = new List<int>();
        List<int> Tongsl = new List<int>();
        List<double> tien = new List<double>();

        List<double> tienBang = new List<double>();
        List<double> tienDia = new List<double>();
        List<double> tienSach = new List<double>();
        double tongtien = 0;
        int tongsl = 0;
        public HoaDon(string maHD, string maK,string maSP, string ngayBan, List<string> dsH, List<int> sl, List<double> tien)
        {
            MaHD = maHD;
            MaK = maK;
            MaSP = maSP;
            NgayBan = ngayBan;
            this.dsH = dsH;
            this.sl = sl;
            this.tien = tien;
        }

        public HoaDon()
        {
        }
        

        public String gsMaHD
        {
            get { return MaHD; }
            set { MaHD = value; }
        }
        public String gsMaK
        {
            get { return MaK; }
            set { MaK = value; }
        }
        public String gsNgayBan
        {
            get { return NgayBan; }
            set { NgayBan = value; }
        }
        public int gsSoLuong
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }

        public void Nhap(SanPham.SanPhamm[] lstB, SanPham.SanPhamm[] lstD, SanPham.SanPhamm[] lstS)
        {
            Console.WriteLine("Nhap ma HD :");
            MaHD = Console.ReadLine();
            Console.WriteLine("Nhap ma khach");
            MaK = Console.ReadLine();
            Console.WriteLine("Nhap ngay ban");
            NgayBan = Console.ReadLine();
            int z = 0;
            int SoL = 0;
            while (z==0)
            {
                Console.WriteLine("Nhap hang can mua (1.Bang, 2.Dia, 3.Sach, 0.Exit) : ");
                int loai = int.Parse(Console.ReadLine());
                double tong1 = 0;
                double tong2 = 0;
                double tong3 = 0;
                switch (loai)
                {
                    case 1:
                        {
                            Console.WriteLine("Nhap ma Bang :");
                            bang.gsMaSo = Console.ReadLine();
                            dsH.Add(bang.gsMaSo);
                            Console.WriteLine("Nhap so luong :");
                            SoLuong = int.Parse(Console.ReadLine());
                            sl.Add(SoLuong);
                            
                            for(int i=0;i<dsH.Count;i++)
                            {
                                for(int j=0;j<lstB.Length;j++)
                                {
                                    if(lstB[j].gsMaSo.ToLower() == dsH[i].ToLower())
                                    {
                                        tong1 = sl[j] * lstB[i].gsGia;
                                    }
                                }
                            }
                            tien.Add(tong1);
                            tienBang.Add(tong1);
                            tongsl += SoLuong;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Nhap ma Dia :");
                            dia.gsMaSo = Console.ReadLine();
                            dsH.Add(dia.gsMaSo);
                            Console.WriteLine("Nhap so luong :");
                            SoLuong = int.Parse(Console.ReadLine());
                            sl.Add(SoLuong);
                            
                            for (int i = 0; i < dsH.Count; i++)
                            {
                                for (int j = 0; j < lstS.Length; j++)
                                {
                                    if (lstD[j].gsMaSo.ToLower() == dsH[i].ToLower())
                                    {
                                        tong2 = sl[j] * lstD[i].gsGia;
                                    }
                                }
                            }
                            tien.Add(tong2);
                            tienDia.Add(tong2);
                            tongsl += SoLuong;
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Nhap ma Sach :");
                            sach.gsMaSo = Console.ReadLine();
                            dsH.Add(sach.gsMaSo);
                            Console.WriteLine("Nhap so luong :");
                            SoLuong = int.Parse(Console.ReadLine());
                            sl.Add(SoLuong);
                            
                            for (int i = 0; i < dsH.Count; i++)
                            {
                                for (int j = 0; j < lstS.Length; j++)
                                {
                                    if (lstS[j].gsMaSo.ToLower() == dsH[i].ToLower())
                                    {
                                        tong3 = sl[j] * lstS[i].gsGia;
                                    }
                                }
                            }
                            tien.Add(tong3);
                            tienSach.Add(tong3);
                            tongsl += SoLuong;
                            break;
                        }
                    case 4:
                        {
                            double tienB = 0, tienD = 0, tienS = 0;
                            for (int i = 0; i < tienBang.Count; i++)
                            {
                                tienB += tienBang[i];
                            }
                            for (int i = 0; i < tienDia.Count; i++)
                            {
                                tienD += tienDia[i];
                            }
                            for (int i = 0; i < tienSach.Count; i++)
                            {
                                tienS += tienSach[i];
                            }
                            Console.WriteLine("Tong so tien Bang :" + tienB +
                                "\nTong so tien Dia :" + tienD +
                                "\nTong so tien Sach :" + tienS);
                            break;
                        }
                    case 0:
                        {
                            z = 1;
                            break;
                        }
                }
                tongtien = tong1 + tong2 + tong3;
                if(tongtien > 200000)
                {
                    tongtien *= 0.85;
                }
            }
            Tongsl.Add(SoL);
        }
        public void Xuat()
        {
            string output = "\nMaHD : " + MaHD +
                            "\nMaK : " + MaK +
                            "\nNgayBan : " + NgayBan;
            for(int i=0;i < dsH.Count;i++)
            {

                output += "\nLoai hang : " + dsH[i] + " So luong : " + sl[i] + " Thanh tien : " + tien[i];
            }
            double tong = 0;
            for(int i=0;i< tien.Count;i++)
            {
                tong += tien[i];
            }
            Console.WriteLine(output + "\nTong tien : "+ tong);
        }
        public void TongTienTheoLoai()
        {
            double tienB = 0, tienD = 0, tienS = 0;
            for(int i=0;i<tienBang.Count;i++)
            {
                tienB += tienBang[i];
            }
            for(int i=0;i<tienDia.Count;i++)
            {
                tienD += tienDia[i];
            }
            for(int i=0;i<tienSach.Count;i++)
            {
                tienS += tienSach[i];
            }
            Console.WriteLine("Tong so tien Bang :" + tienB +
                "\nTong so tien Dia :" + tienD +
                "\nTong so tien Sach :" + tienS);
        }
        public void TongSoLuong(List<HoaDon> lst)
        {
            List<HoaDon> temp = new List<HoaDon>();
            temp.Add(lst[0]);
            
            for(int i=0;i<lst.Count;i++)
            {
                int count = 0;
                for (int j = 0; j < temp.Count; j++)
                {

                    if (temp[j].MaK == lst[i].MaK)
                    {
                        count++;
                        temp[j].tongsl += lst[i].tongsl;
                    }
                }
                if(count ==0)
                {
                    temp.Add(lst[i]);
                }

            }
            int Max = temp[0].tongsl;
            for(int i=0;i<temp.Count;i++)
            {
                if (Max < temp[i].tongsl) Max = temp[i].tongsl;
            }
            for(int i=0;i<temp.Count;i++)
            {
                if(Max == temp[i].tongsl)
                {
                    Console.WriteLine("Khach " + temp[i].MaK + " voi " + temp[i].tongsl);
                }
            }

        }

    }
}
