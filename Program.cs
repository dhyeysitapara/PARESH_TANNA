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
            for(int i =1 ;i <=5; i++)
            {
                //NumberFormatInfo of COLUMNS
                for(int j =1; j<= 5-i; j++)
                {
                    Console.Write(" ");
                }
                    for( int j = 1; j <= i; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
