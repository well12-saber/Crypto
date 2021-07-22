using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto
{
    class Moorse
    {
        static Dictionary<char, String> morse = new Dictionary<char, String>()
        {
            {'a' , ".-"},
            {'b' , "-..."},
            {'c' , "-.-."},
            {'d' , "-.."},
            {'e' , "."},
            {'f' , "..-."},
            {'g' , "--."},
            {'h' , "...."},
            {'i' , ".."},
            {'j' , ".---"},
            {'k' , "-.-"},
            {'l' , ".-.."},
            {'m' , "--"},
            {'n' , "-."},
            {'o' , "---"},
            {'p' , ".--."},
            {'q' , "--.-"},
            {'r' , ".-."},
            {'s' , "..."},
            {'t' , "-"},
            {'u' , "..-"},
            {'v' , "...-"},
            {'w' , ".--"},
            {'x' , "-..-"},
            {'y' , "-.--"},
            {'z' , "--.."},
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
            String res = "";
            String[] value = input.Split();
            foreach (string word in value)
            {
                foreach (char c in word)
                {
                    res += morse[c] + " ";
                }
            }
            return res.Substring(0, res.Length - 1);
        }
        public static string Decode(string input)
        {
            if (input.Length == 0)
                return "";
            String res = "";
            String[] value = input.Split();
            foreach (string word in value)
            {
                if (morse.ContainsValue(word))
                    res += morse.Where(a => a.Value == word).First().Key;
                else
                    res += word;
            }
            return res;
        }
    }
}
