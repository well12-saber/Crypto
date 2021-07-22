using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto
{
    class Vakse
    {
        private static Dictionary<char, char> codes = new Dictionary<char, char> {
            {'.', 'a' }, {'-', 'b' }, {',', 'c' } //use ' ' to denote any non-letter
        };

        static Dictionary<char, String> morse = new Dictionary<char, String>()
        {
            {'a' , ".-,,,"},
            {'b' , "-...,"},
            {'c' , "-.-.,"},
            {'d' , "-..,,"},
            {'e' , ".,,,,"},
            {'f' , "..-.,"},
            {'g' , "--.,,"},
            {'h' , "....,"},
            {'i' , "..,,,"},
            {'j' , ".---,"},
            {'k' , "-.-,,"},
            {'l' , ".-..,"},
            {'m' , "--,,,"},
            {'n' , "-.,,,"},
            {'o' , "---,,"},
            {'p' , ".--.,"},
            {'q' , "--.-,"},
            {'r' , ".-.,,"},
            {'s' , "...,,"},
            {'t' , "-,,,,"},
            {'u' , "..-,,"},
            {'v' , "...-,"},
            {'w' , ".--,,"},
            {'x' , "-..-,"},
            {'y' , "-.--,"},
            {'z' , "--..,"},
            {'0' , "-----"},
            {'1' , ".----"},
            {'2' , "..---"},
            {'3' , "...--"},
            {'4' , "....-"},
            {'5' , "....."},
            {'6' , "-...."},
            {'7' , "--..."},
            {'8' , "---.."},
            {'9' , "----."},
        };

        public static string Encode(string input)
        {
            if (input.Length == 0)
                return "";
            String MoorseRes = "";
            String res = "";
            String[] value = input.Split();
            foreach (string word in value)
            {
                foreach (char c in word)
                {
                    MoorseRes += morse[c];
                }
            }
            foreach (char c in MoorseRes)
                res += codes[c];
            return res;
        }
        public static string Decode(string input)
        {
            if (input.Length == 0)
                return "";
            String BakonRes = "";
            foreach (char c in input)
                BakonRes += codes.FirstOrDefault(x => x.Value == c).Key;
            String res = "";
            for (int i = 0; i < BakonRes.Length; i += 5)
            {
                string quintet = BakonRes.Substring(i, 5);
                if (morse.ContainsValue(quintet))
                    res += morse.Where(a => a.Value == quintet).First().Key;
                else
                    res += quintet;
            }
            return res;
        }
    }
}
