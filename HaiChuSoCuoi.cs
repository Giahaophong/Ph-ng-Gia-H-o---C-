using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapBuoi02
{
    internal class HaiChuSoCuoi
    {
        public void Bai5()
        {
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            int kq = 1;
            for (int i = 1; i <= 278; i++)
            {
                kq = (kq * n) % 100;
            }
            Console.WriteLine("Hai chu so cuoi cua n^278 la: {0:D2}", kq);
            Console.ReadKey();

        }
    }
}
