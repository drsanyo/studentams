using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_nd.caesar
{
    class Program
    {
        private static string CaesarEncode(string s, string key)
        {
            string result = "";
            int keyIndex = 0;
            foreach (var symbol in s)
            {
                result += (char)((byte)symbol + (byte)key[keyIndex]);
                if (keyIndex == key.Length - 1)
                {
                    keyIndex = 0;
                }
                else
                {
                    keyIndex++;
                }
            }
            return result;
        }

        private static string CaesarDecode(string s, string key)
        {
            string result = "";
            int keyIndex = 0;
            foreach (var symbol in s)
            {
                result += (char)((byte)symbol - (byte)key[keyIndex]);
                if (keyIndex == key.Length - 1)
                {
                    keyIndex = 0;
                }
                else
                {
                    keyIndex++;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            string originalTex = "TOP SECRET. Tai yra slaptas tekstas, kurio niekas neturi suprasti!";
            string password = "123456";
            string encodedText = CaesarEncode(originalTex, password);

            Console.WriteLine("Original string:{0}", originalTex);
            Console.WriteLine("");
            Console.WriteLine("Encoded string:{0}", encodedText);
            Console.WriteLine("");

            string decodedText = CaesarDecode(encodedText, password);
            Console.WriteLine("Decoded string:{0}", decodedText);
            Console.ReadLine();
        }
    }
}
