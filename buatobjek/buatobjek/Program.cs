using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buatobjek
{
    class luas
    {
        private int panjang;
        public luas(int p) {
            panjang = p;
        }
        public void setLength(int len)
        {
            panjang = len;
        }
        public double getLength()
        {
            return panjang;
        }

        static void Main(string[] args)
        {
            luas aseli = new luas(10);
            Console.WriteLine("Isi luas adalah {0}", aseli.getLength());
            aseli.setLength(67);
            Console.WriteLine("Isi luas jadi {0}", aseli.getLength());
        }
    }
}
