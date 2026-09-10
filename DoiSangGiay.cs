using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNLTCSharp.Buoi01
{
    internal class DoiSangGiay
    {
        public void Bai4()
        {
            int h, m, s, tong; //Nhập giờ, phút, giây
            Console.Write("Nhap so gio: ");
            h = int.Parse(Console.ReadLine());
            Console.Write("Nhap so phut: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Nhap so giay: ");
            s = int.Parse(Console.ReadLine());
            tong = h * 3600 + m * 60 + s;//Tính tổng
            Console.Write("Tong so giay cua {0}:{1}:{2} la {3} giay ", h, m, s, tong); 
        }

    }
}
