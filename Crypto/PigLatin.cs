using System;
using System.Collections.Generic;
using System.Text;

namespace Crypto
{
    class PigLatin
    {
        public static bool ContainsAny(string haystack, params string[] needles)
        {
            foreach (string needle in needles)
            {
                if (haystack.Contains(needle))
                    return true;
            }

            return false;
        }
        public static int indexOfFirstVowel(String word)
        {
            for (int index = 0; index < word.Length; index++)
            {
                if ("aeiouy".Contains(word[index]))
                    return index;
            }

            // handle cases where a vowel is not found
            return -1;
        }
        public static string Encrypt(string input)
        {
            string res = "";
            String[] str = input.Split();
            foreach (string word in str)
            {
                if (word.Length == 0)
                    return "";
                if ("aeiouy".Contains(word[0]))
                {
                    res += word + "ay ";
                }
                else
                {
                    if (ContainsAny(word,"a","e","i","o","u","y"))
                        res += word.Substring(indexOfFirstVowel(word)) + word.Substring(0, indexOfFirstVowel(word))
                        + "ay ";
                    else
                        res += word + "ay ";
                }
            }
            return res.Substring(0, res.Length - 1);
        }

        public static string Decrypt(string input)//unsure about how to make it right
                                                  //definitely get rid of AY
                                                  //struggle with consonant at the end
        {
            string res = "";
            String[] str = input.Split();
            foreach (string word in str)
            {
                if (word.Length == 0)
                    return "";
                if (word.Substring(word.Length - 2) == "ay")
                {
                    if ("aeiouy".Contains(word[word.Length - 3]))
                        res += word.Substring(0, word.Length - 2) + " ";
                    else
                        res += word[word.Length - 3] + word.Substring(0, word.Length - 3) + " ";
                }
                else
                    res += word + " ";
            }
            return res.Substring(0,res.Length-1);
        }
    }
}
