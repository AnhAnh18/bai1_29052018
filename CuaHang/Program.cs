using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHang
{
    class Program
    {
        static void Main(string[] args)
        {
            SanPham.SanPhamm[] lstBang = new Bang[5];
            SanPham.SanPhamm[] lstDia = new Dia[5];
            SanPham.SanPhamm[] lstSach = new Sach[5];

            List<HoaDon> list = new List<HoaDon>();

            List<double> tienBang = new List<double>();
            List<double> tienDia = new List<double>();
            List<double> tienSach = new List<double>();

            lstBang[0] = new Bang("B001", "Tua de 1", "Nha san xuat 1", 1000, 120);
            lstBang[1] = new Bang("B002", "Tua de 2", "Nha san xuat 2", 2000, 120);
            lstBang[2] = new Bang("B003", "Tua de 3", "Nha san xuat 3", 3000, 120);
            lstBang[3] = new Bang("B004", "Tua de 4", "Nha san xuat 4", 4000, 120);
            lstBang[4] = new Bang("B005", "Tua de 5", "Nha san xuat 5", 5000, 120);

            lstDia[0] = new Dia("D001", "Tua de 1", "Nha san xuat 1", 1000, 120);
            lstDia[1] = new Dia("D002", "Tua de 2", "Nha san xuat 2", 2000, 120);
            lstDia[2] = new Dia("D003", "Tua de 3", "Nha san xuat 3", 3000, 120);
            lstDia[3] = new Dia("D004", "Tua de 4", "Nha san xuat 4", 4000, 120);
            lstDia[4] = new Dia("D005", "Tua de 5", "Nha san xuat 5", 5000, 120);

            lstSach[0] = new Sach("S001", "Tua de 1", "Nha san xuat 1", 1000, "Tac gia 1", 10);
            lstSach[1] = new Sach("S002", "Tua de 2", "Nha san xuat 2", 1000, "Tac gia 2", 20);
            lstSach[2] = new Sach("S003", "Tua de 3", "Nha san xuat 3", 1000, "Tac gia 3", 30);
            lstSach[3] = new Sach("S004", "Tua de 4", "Nha san xuat 4", 1000, "Tac gia 4", 15);
            lstSach[4] = new Sach("S005", "Tua de 5", "Nha san xuat 5", 1000, "Tac gia 5", 25);

            

            while(true)
            {
                Console.WriteLine("1.Nhập danh sách hóa đơn.");

                Console.WriteLine("2.In danh sách hóa đơn.");

                Console.WriteLine("3.Khách hàng mua nhiều sản phẩm nhất");

                Console.WriteLine("4.Tổng giá trị từng loại");

                Console.WriteLine("0.Hoa don moi");
                Console.WriteLine("Nhap 1,2,3,4");
                int chon = int.Parse(Console.ReadLine());
                HoaDon hd = new HoaDon();
                switch (chon)
                {
                    case 1:
                        
                        hd.Nhap(lstBang, lstDia, lstSach);
                        list.Add(hd);
                        break;
                    case 2:
                        Console.WriteLine("Danh sach hoa don:");
                        for (int i=0;i<list.Count;i++)
                        {
                            list[i].Xuat();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Khach hang mua nhieu hang nhat");
                            hd.TongSoLuong(list);
                            break;
                        }
                    case 4:
                        {
                            list[0].TongTienTheoLoai();
                            break;
                        }
                    case 0:
                        
                        break;
                        
                }
                Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}
