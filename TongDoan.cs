using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapBuoi02
{
    internal class TongDoan
    {
        public void Bai1()
        {
            int a, b;
            Console.Write("Moi ban nhap so a,b:");
            string[] s = Console.ReadLine().Split();

            a = int.Parse(s[0]);
            b = int.Parse(s[1]);

            int tong = (b * (b + 1) / 2) - (a - 1) * a / 2;
            Console.Write("Tong cua cac so trong doan [{0},{1}] la {2}", a,b, tong);

        }
    }
}
