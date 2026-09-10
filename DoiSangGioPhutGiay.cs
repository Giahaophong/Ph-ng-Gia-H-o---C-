using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNLTCSharp.Buoi01
{
    internal class DoiSangGioPhutGiay
    {
        public void Bai3()
        {
            int t; //t giây
            Console.Write("Nhap vao tong so giay: ");
            t = int.Parse(Console.ReadLine());
            int h = t / 3600;     //Quy đổi về giờ   
            int m = (t % 3600) / 60;   //Quy đổi về phút   
            int s = t % 60; //Quy đổi về số giây còn lại

            Console.Write("{0} giay co dang {1}:{2}:{3}", t, h, m, s);
        }

    }
}
