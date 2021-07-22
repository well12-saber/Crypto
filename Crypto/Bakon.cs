using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto
{
    class Bakon
    {
        private static Dictionary<char, string> codes = new Dictionary<char, string> {
            {'a', "AAAAA" }, {'b', "AAAAB" }, {'c', "AAABA" }, {'d', "AAABB" }, {'e', "AABAA" },
            {'f', "AABAB" }, {'g', "AABBA" }, {'h', "AABBB" }, {'i', "ABAAA" }, {'j', "ABAAB" },
            {'k', "ABABA" }, {'l', "ABABB" }, {'m', "ABBAA" }, {'n', "ABBAB" }, {'o', "ABBBA" },
            {'p', "ABBBB" }, {'q', "BAAAA" }, {'r', "BAAAB" }, {'s', "BAABA" }, {'t', "BAABB" },
            {'u', "BABAA" }, {'v', "BABAB" }, {'w', "BABBA" }, {'x', "BABBB" }, {'y', "BBAAA" },
            {'z', "BBAAB" }, {' ', "BBBAA" }, //use ' ' to denote any non-letter
        };

        public static string Encode(string message)
        {
            StringBuilder sb = new StringBuilder();
            
            string et = sb.ToString();
            string [] mg = message.ToLower().Split();  //'A's to be in lower case, 'B's in upper case
            sb.Length = 0;
            int count = 0;
            foreach (string word in mg)
            {
                foreach (char c in word)
                {
                    sb.Append(codes[c]);           
                    count++;
                    if (count == et.Length) break;
                }
            }
            return sb.ToString();
        }

        public static string Decode(string message)
        {
            StringBuilder sb = new StringBuilder(String.Concat(message.ToUpper().Split()));
            string et = sb.ToString();
            sb.Length = 0;
            for (int i = 0; i < et.Length; i += 5)
            {
                if (et.Length % 5 != 0)
                    et = et.Substring(0, et.Length - et.Length % 5);
                string quintet = et.Substring(i, 5);
                if (codes.ContainsValue(quintet))
                {
                    char key = codes.Where(a => a.Value == quintet).First().Key;
                    sb.Append(key);
                }
                else
                    sb.Append(quintet);
            }
            return sb.ToString();
        }
    }
}
