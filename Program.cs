using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DenaryToAnybase;
namespace ProgrammingWeek_lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a denary number");
            uint number = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Please enter the base you want to convert");
            uint baseNum = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(anyBase(number, baseNum));
            Console.ReadLine();
        }



        static string anyBase(uint denary , uint baseNum)
        {
            //Add to the end of this for gretaer base numbers
            char[] characters = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            //The base cant be greater than maximum symbols for representation
            if (baseNum > characters.Length)
            {
                return "Invalid input";
            }
            string final = "";
            while (denary > 0)
            {
                final =characters[denary % baseNum] + final;
                denary /= baseNum;
            }
            return final;
        }

        static string DenaryToUnsigned(uint deanry)
        {
            string final = "";
            while (deanry > 0)
            {
                final = deanry % 2 + final;
                deanry /= 2;
            }
            return final;
        }

        static int UnsighedToDenary(string binary)
        {
            int final = 0;

            for (int i = binary.Length-1; i>=0;i--)
            {
                final += Convert.ToInt32(binary[i]-'0') * Convert.ToInt32(Math.Pow(2, binary.Length - (i + 1)));
                 
            }
            return final;
        }

    }
}
