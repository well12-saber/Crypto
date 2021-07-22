using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Crypto
{
    class Vigener
    {
        public static string getReducedText(string text, string key, out string expandedKey)
        {
            int countKey = key.Length;
            int countText = text.Length;
            string reducedText = "";
            int j = 0;
            expandedKey = "";
            if (key.Length == 0)
                return "";
            for (int i = 0; i < countText; i++)
            {
                if (j == countKey)
                {
                    j = 0;
                }

                if (!text.ElementAt(i).Equals(' '))
                {
                    expandedKey += key.ElementAt(j++).ToString();
                    reducedText += text.ElementAt(i).ToString();
                }
                else
                {
                }
            }
            return reducedText;

        }

        /// <summary>
        /// Convert the plain text to cipher or vice versa
        /// </summary>
        /// <param name="text">input text</param>
        /// <param name="key">input key</param>
        /// <param name="encrypt">encrypt the stirng if true</param>
        /// <returns>encrypted or decrypted string is returned</returns>
        public static string convertText(string text, string key, bool encrypt)
        {
            int countText = text.Length;
            int countKey = key.Length;
            string expandedKey = "";
            string reducedText = "";
            string cipherText = "";

            reducedText = getReducedText(text, key, out expandedKey);

            if (reducedText.Length == expandedKey.Length)
            {
                if (encrypt)
                {
                    for (int i = 0; i < reducedText.Length; i++)
                    {
                        cipherText += getCharacter((getLocation(reducedText.ElementAt(i)) + getLocation(expandedKey.ElementAt(i))) % 26).ToString();
                    }

                }
                else
                {
                    for (int i = 0; i < reducedText.Length; i++)
                    {
                        int value = getLocation(reducedText.ElementAt(i)) - getLocation(expandedKey.ElementAt(i));
                        if (value < 0)
                            value += 26; // otherwise when the value is negative reading the exact value is wrong if we just take the absolute value.
                        cipherText += (getCharacter(value % 26)).ToString();
                    }
                }
            }

            return cipherText;
        }

        /// <summary>
        /// used to get the interger for the character specified
        /// </summary>
        /// <param name="cp">the character which needed in getting the location. Currently it only supports the alphebatical character set only</param>
        /// <returns>the assigned integer value for the character is returned, (in the range of 0 -25)</returns>
        public static int getLocation(char cp)
        {
            switch (cp.ToString().ToUpper())
            {
                case "A": return 0;
                case "B": return 1;
                case "C": return 2;
                case "D": return 3;
                case "E": return 4;
                case "F": return 5;
                case "G": return 6;
                case "H": return 7;
                case "I": return 8;
                case "J": return 9;
                case "K": return 10;
                case "L": return 11;
                case "M": return 12;
                case "N": return 13;
                case "O": return 14;
                case "P": return 15;
                case "Q": return 16;
                case "R": return 17;
                case "S": return 18;
                case "T": return 19;
                case "U": return 20;
                case "V": return 21;
                case "W": return 22;
                case "X": return 23;
                case "Y": return 24;
                case "Z": return 25;
                default: return -1;
            }
        }

        /// <summary>
        /// used to get the character assigned to the integer specified
        /// </summary>
        /// <param name="val">integer value which represent a character(in the range of 0 - 25)</param>
        /// <returns>returns the character corresponding to the integer specified</returns>
        public static char getCharacter(int val)
        {
            switch (val)
            {
                case 0: return 'A';
                case 1: return 'B';
                case 2: return 'C';
                case 3: return 'D';
                case 4: return 'E';
                case 5: return 'F';
                case 6: return 'G';
                case 7: return 'H';
                case 8: return 'I';
                case 9: return 'J';
                case 10: return 'K';
                case 11: return 'L';
                case 12: return 'M';
                case 13: return 'N';
                case 14: return 'O';
                case 15: return 'P';
                case 16: return 'Q';
                case 17: return 'R';
                case 18: return 'S';
                case 19: return 'T';
                case 20: return 'U';
                case 21: return 'V';
                case 22: return 'W';
                case 23: return 'X';
                case 24: return 'Y';
                case 25: return 'Z';
                default: return '?';
            }
        }
    }
}
