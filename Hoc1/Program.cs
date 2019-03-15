using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoc1
{
    class Program
    {
        static void Main(string[] args)
        {
            int namHTai = DateTime.Now.Year;
            int namSinh = 0;

            int tuoi = 0;

            Console.WriteLine("Ngày đầu tiên ra đời :");
            namSinh = int.Parse(Console.ReadLine());
            if (namSinh > 0 && namSinh == namHTai)
            {
                tuoi = namHTai - namSinh;
                Console.WriteLine("Tuổi của bạn là :{0}",tuoi);
            }
            else
            {
                Console.WriteLine("Xem lại");
            }
            Console.ReadLine();
        }
    }
}
