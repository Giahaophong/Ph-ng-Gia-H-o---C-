using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Thuchanh02
{
    class Sinhvien
    {
        //1 field
        private string hoTen;
        private int namSinh;

        // 2. Constructor
        public Sinhvien(string hoTen, int namSinh)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
        }

        // 3. Property
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public int NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }

        // 4. Method
        public int TinhTuoi()
        {
            return DateTime.Now.Year - namSinh;

        }
    

    
        public void Bai1()
        {
            // Nhập thông tin
            Console.Write("Nhap ho ten sinh vien: ");
            string hoTen = Console.ReadLine();

            Console.Write("Nhap nam sinh: ");
            int namSinh = int.Parse(Console.ReadLine());

            // Tạo đối tượng SinhVien
            Sinhvien sv = new Sinhvien(hoTen, namSinh);

            // Xuất thông tin
            Console.WriteLine("\n--- THÔNG TIN SINH VIÊN ---");
            Console.WriteLine("Ho ten: " + sv.HoTen);
            Console.WriteLine("Nam sinh: " + sv.NamSinh);
            Console.WriteLine("Tuoi: " + sv.TinhTuoi());

            Console.ReadKey();
        }
    }
}
