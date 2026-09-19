using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BaitapBuoi02
{
    internal class LuyThuaNhanh1
    {
        public void Bai2()
        {
            double a1, a2, a4, a5, a8, a9, a17;
            // Nhập dữ liệu
            Console.Write("Moi ban nhap so thuc a: "); 
            a1 = double.Parse(Console.ReadLine());
            // Xử lý (trong 6 phép toán)
            a2 = a1 * a1;
            a4 = a2 * a2;
            a5 = a1 * a4;   
            a8 = a4 * a4;
            a9 = a4 * a5;
            a17 = a8 * a9;
            // Xuất dữ liệu
            Console.WriteLine("Ket qua: {0}^2 = {1}, {0}^5 = {2}, {0}^17 = {3}.", a1, a2, a5, a17);

        }
    }
}
