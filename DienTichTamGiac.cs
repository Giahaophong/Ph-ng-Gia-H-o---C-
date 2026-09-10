using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNLTCSharp.Buoi01
{
    internal class DienTichTamGiac
    {
        public void Bai5()
        {
            double a, b, c; //Độ dài ba cạnh
            Console.Write("Nhap do dai canh a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap do dai canh b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhap do dai canh c: ");
            c = double.Parse(Console.ReadLine());
            double p = (a + b + c) / 2; //Tính nửa chu vi
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); //Tính diện tích tam giác
            Console.Write("Dien tich tam giac S={0: #.00}", S); //Tìm kết quả

        }


    }
}
