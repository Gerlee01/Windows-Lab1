using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gereltsetseg
{
    namespace Lab1
    {
        class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee();
                emp.subname = "Gerlee";
                emp.subage = 20;
                emp.subid = 1;
                emp.subrank = "Senior";
                Console.WriteLine("Hello world");
                Console.WriteLine("Id : " + emp.subid + " Name : " + emp.subname + " Age : " + emp.subage + " Rank : " + emp.subrank);
            }
        }
    }
}
