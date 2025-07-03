using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARESH_TANNA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NumberFormatInfo OF ROW
            for(int i =0;i < 5; i++)
            {
                //NumberFormatInfo of COLUMNS
                for(int j =0 ;j <= i; j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
