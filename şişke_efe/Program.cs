using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selahaddin
{
   
internal class Program
    {
        static void Main(string[] args)
        {
        Ucgen ucgen = new Ucgen();
            ucgen.A = 5;
            ucgen.B = 4;
            ucgen.C = -3;
            Console.WriteLine("Ücgenin a={0}", ucgen.A);
            Console.WriteLine("Ücgenin b={0}", ucgen.B);
            Console.WriteLine("Ücgenin c={0}", ucgen.C);
        }
    }
 public class Ucgen
    {
        int a;
        int b;
        int c;
        public int A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("A HATALI GİRİLDİ");
                else
                    a = value;
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("B HATALI GİRİLDİ");
                else
                    b = value;
            }
        }
        public int C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("C HATALI GİRİLDİ");
                else
                    c = value;
            }
        }
    }
}
