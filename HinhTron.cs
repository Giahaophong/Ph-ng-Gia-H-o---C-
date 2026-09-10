using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNLTCSharp.Buoi01
{
    internal class HinhTron
    {
        public void Bai2()
        {
            double r, s, p; //Bán kính, chu vi và diện tích     
            Console.Write("Nhap ban kinh R: ");
            r = double.Parse(Console.ReadLine());

            s = Math.PI * r * r;
            p = 2 * Math.PI * r;

            Console.WriteLine("Diện tích S = {0: #.0}", s);
            Console.Write("Chu vi P = {0: #.0}", p);
        }

    }
}
