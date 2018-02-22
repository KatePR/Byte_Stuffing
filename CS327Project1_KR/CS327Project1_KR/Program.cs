using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS327Project1_KR
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter an input sequence with spaces in between characters:");
            string input = Console.ReadLine();
            string[] chars = input.Split(' ');
            string byteStuffing = "";
            string byteCount = "";

            foreach (string c in chars)
            {
                switch (c)
                {
                    case "A":
                        byteStuffing += " 01000111";
                        byteCount += " 01000111";
                        break;
                    case "B":
                        byteStuffing += " 11100011";
                        byteCount += " 11100011";
                        break;
                    case "C":
                        byteStuffing += " 11000001";
                        byteCount += " 11000001";
                        break;
                    case "ESC":
                        byteStuffing += " 11100000 11100000";
                        byteCount += " 11100000";
                        break;
                    case "FLAG":
                        byteStuffing += " 11100000 01111110";
                        byteCount += " 11100000";
                        break;
                    default:
                        Console.WriteLine("Input Un-recognized: " + c);
                        break;
                }
            }

            int numBytes = byteCount.Split(' ').Length;

            System.Console.WriteLine("Byte Count: " + PadInt(Convert.ToString(numBytes, 2), 8) + " " + byteCount);
            System.Console.WriteLine("Flag bytes with byte stuffing: 01111110 " + byteStuffing + " 01111110");
            Console.ReadLine();
        }

        static string PadInt(string str, int length) {
            for (var i = str.Length; i < length; i++)
            {
                str = "0" + str;
            }
            return str;
        }
    }
}