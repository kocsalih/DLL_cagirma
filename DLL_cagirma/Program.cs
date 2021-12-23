using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_cagirma
{
    class Program
    {
        static void Main(string[] args)
        {
            DLL_Kullanimi.Class1 matematikislemler = new DLL_Kullanimi.Class1();
            int topla = matematikislemler.toplama(4, 6);
            Console.WriteLine("sonuc: "+topla);
            Console.ReadLine();
        }
    }
}
