using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d=DateTime.Now;
            string[] t = d.ToString("HH:mm:ss").Split(':');
            int H=int.Parse(t[0]);
            int M=int.Parse(t[1]);
            int S=int.Parse(t[2]);
            int hu, hz, mu, mz, su, sz;
            hu = H % 10;
            hz = H / 10;
            mu = M % 10;
            mz = M / 10;
            su = S % 10;
            sz = S / 10;
            int bhu1=0, bhu2=0, bhu4=0, bhu8 = 0, bhz1 = 0, bhz2 = 0, bmu1 = 0, bmu2 = 0, bmu4 = 0, bmu8 = 0, bmz1 = 0, bmz2 = 0, bmz4 = 0, bsu1 = 0, bsu2=0, bsu4=0, bsu8=0, bsz1=0, bsz2=0, bsz4=0;
            switch (hu)
            {
                case 0: bhu1 = 0; bhu2 = 0; bhu4 = 0;bhu8 = 0;break;
                case 1: bhu1 = 1; bhu2 = 0; bhu4 = 0;bhu8 = 0;break;
                case 2: bhu1 = 0; bhu2 = 1; bhu4 = 0;bhu8 = 0;break;
                case 3: bhu1 = 1; bhu2 = 1; bhu4 = 0;bhu8 = 0;break;
                case 4: bhu1 = 0; bhu2 = 0; bhu4 = 1;bhu8 = 0;break;
                case 5: bhu1 = 1; bhu2 = 0; bhu4 = 1;bhu8 = 0;break;
                case 6: bhu1 = 0; bhu2 = 1; bhu4 = 1;bhu8 = 0;break;
                case 7: bhu1 = 1; bhu2 = 1; bhu4 = 1;bhu8 = 0;break;
                case 8: bhu1 = 0; bhu2 = 0; bhu4 = 0;bhu8 = 1;break;
                case 9: bhu1 = 1; bhu2 = 0; bhu4 = 0;bhu8 = 1;break;  
            }
            switch (hz)
            {   case 0:bhz1 = 0;bhz2 = 0;break;
                case 1:bhz1 = 1;bhz2 = 0;break;
                case 2:bhz1 = 0;bhz2 = 1;break;
            }
            switch (mu)
            {
                case 0: bmu1 = 0; bmu2 = 0; bmu4 = 0; bmu8 = 0; break;
                case 1: bmu1 = 1; bmu2 = 0; bmu4 = 0; bmu8 = 0; break;
                case 2: bmu1 = 0; bmu2 = 1; bmu4 = 0; bmu8 = 0; break;
                case 3: bmu1 = 1; bmu2 = 1; bmu4 = 0; bmu8 = 0; break;
                case 4: bmu1 = 0; bmu2 = 0; bmu4 = 1; bmu8 = 0; break;
                case 5: bmu1 = 1; bmu2 = 0; bmu4 = 1; bmu8 = 0; break;
                case 6: bmu1 = 0; bmu2 = 1; bmu4 = 1; bmu8 = 0; break;
                case 7: bmu1 = 1; bmu2 = 1; bmu4 = 1; bmu8 = 0; break;
                case 8: bmu1 = 0; bmu2 = 0; bmu4 = 0; bmu8 = 1; break;
                case 9: bmu1 = 1; bmu2 = 0; bmu4 = 0; bmu8 = 1; break;
            }
            switch (mz)
            {
                case 0: bmz1 = 0; bmz2 = 0; bmz4 = 0; break;
                case 1: bmz1 = 1; bmz2 = 0; bmz4 = 0; break;
                case 2: bmz1 = 0; bmz2 = 1; bmz4 = 0; break;
                case 3: bmz1 = 1; bmz2 = 1; bmz4 = 0; break;
                case 4: bmz1 = 0; bmz2 = 0; bmz4 = 1; break;
                case 5: bmz1 = 1; bmz2= 0 ; bmz4 = 1; break;   
            }
            switch (su)
            {
                case 0: bsu1 = 0; bsu2 = 0; bsu4 = 0; bsu8 = 0; break;
                case 1: bsu1 = 1; bsu2 = 0; bsu4 = 0; bsu8 = 0; break;
                case 2: bsu1 = 0; bsu2 = 1; bsu4 = 0; bsu8 = 0; break;
                case 3: bsu1 = 1; bsu2 = 1; bsu4 = 0; bsu8 = 0; break;
                case 4: bsu1 = 0; bsu2 = 0; bsu4 = 1; bsu8 = 0; break;
                case 5: bsu1 = 1; bsu2 = 0; bsu4 = 1; bsu8 = 0; break;
                case 6: bsu1 = 0; bsu2 = 1; bsu4 = 1; bsu8 = 0; break;
                case 7: bsu1 = 1; bsu2 = 1; bsu4 = 1; bsu8 = 0; break;
                case 8: bsu1 = 0; bsu2 = 0; bsu4 = 0; bsu8 = 1; break;
                case 9: bsu1 = 1; bsu2 = 0; bsu4 = 0; bsu8 = 1; break;
            }
            switch (sz)
            {
                case 0: bsz1 = 0; bsz2 = 0; bsz4 = 0; break;
                case 1: bsz1 = 1; bsz2 = 0; bsz4 = 0; break;
                case 2: bsz1 = 0; bsz2 = 1; bsz4 = 0; break;
                case 3: bsz1 = 1; bsz2 = 1; bsz4 = 0; break;
                case 4: bsz1 = 0; bsz2 = 0; bsz4 = 1; break;
                case 5: bsz1 = 1; bsz2 = 0; bsz4 = 1; break;
            }
            Console.WriteLine("   H  H   M  M   S  S ");
            Console.WriteLine();
            Console.Write("8 ( )");
            if (bhu8 == 1) Console.Write("(*) ( )");
            else Console.Write("( ) ( )");
            if (bmu8 == 1) Console.Write("(*) ( )");
            else Console.Write("( ) ( )");
            if (bsu8 == 1) Console.Write("(*)");
            else Console.Write("( )");
            Console.WriteLine();
            Console.Write("4 ( )");
            if (bhu4 == 1) Console.Write("(*) ");
            else Console.Write("( ) ");
            if (bmz4 == 1) Console.Write("(*)");
            else Console.Write("( )");
            if (bmu4 == 1) Console.Write("(*) ");
            else Console.Write("( ) ");
            if (bsz4 == 1) Console.Write("(*)");
            else Console.Write("( )");
            if (bsu4 == 1) Console.Write("(*) ");
            else Console.Write("( ) ");
            Console.WriteLine();
            Console.Write("2 ");
            if (bhz2 == 1) Console.Write("(*)");
            else Console.Write("( )");
            if (bhu2 == 1) Console.Write("(*) ");
            else Console.Write("( ) ");
            if (bmz2 == 1) Console.Write("(*)");
            else Console.Write("( )");
            if (bmu2 == 1) Console.Write("(*) ");
            else Console.Write("( ) ");
            if (bsz2 == 1) Console.Write("(*)");
            else Console.Write("( )");
            if (bsu2 == 1) Console.Write("(*) ");
            else Console.Write("( ) ");
            Console.WriteLine();
            Console.Write("1 ");
            if (bhz1 == 1) Console.Write("(*)");
            else Console.Write("( )");
            if (bhu1 == 1) Console.Write("(*) ");
            else Console.Write("( ) ");
            if (bmz1 == 1) Console.Write("(*)");
            else Console.Write("( )");
            if (bmu1 == 1) Console.Write("(*) ");
            else Console.Write("( ) ");
            if (bsz1 == 1) Console.Write("(*)");
            else Console.Write("( )");
            if (bsu1 == 1) Console.Write("(*) ");
            else Console.Write("( ) ");
            Console.ReadKey();
        }
    }
}
