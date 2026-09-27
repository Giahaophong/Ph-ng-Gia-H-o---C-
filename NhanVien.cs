using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Thuchanh02
{
    internal class NhanVien
    {
        // =========================
        // FIELD
        // =========================
        private string hoTen;
        private double mucLuong;
        private int soNgayVang;

        // =========================
        // CONSTRUCTOR
        // =========================
        public NhanVien()
        {
            hoTen = "";
            mucLuong = 0;
            soNgayVang = 0;
        }

        public NhanVien(string hoTen, double mucLuong, int soNgayVang)
        {
            this.hoTen = hoTen;
            this.mucLuong = mucLuong;
            this.soNgayVang = soNgayVang;
        }

        // =========================
        // PROPERTY
        // =========================
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public double MucLuong
        {
            get { return mucLuong; }
            set { mucLuong = value; }
        }

        public int SoNgayVang
        {
            get { return soNgayVang; }
            set { soNgayVang = value; }
        }

        // =========================
        // METHOD TÍNH LƯƠNG
        // =========================
        public double TinhLuong()
        {
            return mucLuong - soNgayVang * 100000;
        }

        // =========================
        // METHOD NHẬP
        // =========================
        public void Input()
        {
            Console.Write("Họ tên: ");
            hoTen = Console.ReadLine();

            Console.Write("Mức lương: ");
            mucLuong = double.Parse(Console.ReadLine());

            Console.Write("Số ngày vắng: ");
            soNgayVang = int.Parse(Console.ReadLine());
        }

        // =========================
        // METHOD XUẤT
        // =========================
        public void Output()
        {
            Console.WriteLine(
                "Họ tên: " + hoTen +
                " | Mức lương: " + mucLuong.ToString("N0") +
                " | Ngày vắng: " + soNgayVang +
                " | Lương thực nhận: " + TinhLuong().ToString("N0")
            );
        }
    }


    // ==========================================
    // CLASS PHONGBAN
    // ==========================================

    class PhongBan
    {
        // Field
        private List<NhanVien> danhSachNhanVien;

        // Constructor
        public PhongBan()
        {
            danhSachNhanVien = new List<NhanVien>();
        }

        // Property
        public List<NhanVien> DanhSachNhanVien
        {
            get { return danhSachNhanVien; }
            set { danhSachNhanVien = value; }
        }

        // Thêm nhân viên
        public void ThemNhanVien(NhanVien nv)
        {
            danhSachNhanVien.Add(nv);
        }

        // Tính tổng lương phòng ban
        public double TongLuong()
        {
            double tong = 0;

            foreach (NhanVien nv in danhSachNhanVien)
            {
                tong += nv.TinhLuong();
            }

            return tong;
        }

        // Xuất danh sách nhân viên
        public void Output()
        {
            foreach (NhanVien nv in danhSachNhanVien)
            {
                nv.Output();
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(
                "TỔNG LƯƠNG PHÒNG BAN: " +
                TongLuong().ToString("N0") + " VNĐ"
            );
        }   
        private void Bai3()
        {
            Console.Write("Nhập số lượng nhân viên: ");
            int n = int.Parse(Console.ReadLine());

            PhongBan phongBan = new PhongBan();

            // Nhập danh sách nhân viên
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n--- NHÂN VIÊN " + (i + 1) + " ---");

                NhanVien nv = new NhanVien();
                nv.Input();

                phongBan.ThemNhanVien(nv);
            }

            // Xuất kết quả
            Console.WriteLine("\n========== DANH SÁCH NHÂN VIÊN ==========");
            phongBan.Output();

            Console.ReadKey();
        }
    }
}
