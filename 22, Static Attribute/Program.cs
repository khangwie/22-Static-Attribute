using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22__Static_Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Songs holiday = new Songs("Holiday", "Green Day", 10);
            Songs kashmir = new Songs("karshmir", "Led Zeppelin", 15);

            Console.WriteLine(Songs.songcount);
            Console.ReadLine();
        }
    }
}
