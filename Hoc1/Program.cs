using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoc1
{
    class Program
    {
        List<Student> listStudent = new List<Student>(){
            new Student(){
                ID = 1,
                Name = "Nguyễn Văn Cường",
                Class = "16T2",
                Address ="Thừa Thiên Huế"
            } 
        };
       
        static void Main(string[] args)
        {
            System.Console.WriteLine("Tình yêu đầu tiên");

        }
    }
}
