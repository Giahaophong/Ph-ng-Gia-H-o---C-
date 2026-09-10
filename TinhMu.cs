using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNLTCSharp.Buoi01
{
    internal class TinhMu
    {   
        public void Bai6()
        {
            double a;
            int n;
            Console.Write("Nhap so thuc a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so mu n: ");
            n = int.Parse(Console.ReadLine());
            double x = Math.Pow(a, n);
            Console.Write("Ket qua {0}^{1} = {2}", a,n,x);

        }
    }
}
