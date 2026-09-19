using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapBuoi02
{
    class BieuThucNhanh1
    {
         public void Bai3()
        {
            double x,f; 
            // Nhập dữ liệu
            Console.Write("Moi ban nhap hai so thuc x: ");     
              x = double.Parse(Console.ReadLine());  
            f = 1 + x*(2+3*x-4*x*x);
            Console.Write("f({0}) = {1} ", x, f);
        }
    }
}
