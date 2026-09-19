using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapBuoi02
{
    internal class TimQuy
    {
        private void Bai4()
        {
            int thang;
            Console.Write("Moi ban nhap thang: ");
            thang = int.Parse(Console.ReadLine());
            
            switch (thang)
            {
                case 1:
                case 2:
                case 3:
                    Console.Write("Thang {0} thuoc quy 1", thang);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.Write("Thang {0} thuoc quy 2", thang);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.Write("Thang {0} thuoc quy 3", thang);
                    break;
                case 10:
                case 11:
                case 12:
                    Console.Write("Thang {0} thuoc quy 4", thang);
                    break;
                default:
                    
                    break;
                    
            }
            
        }
    }
}
