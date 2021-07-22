using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Crypto
{
    class Parameter//class for storing parameters
    {
        public static NumericUpDown rot = new NumericUpDown();//parameter for Ceasar cipher
                                                              //    
        public static TextBox keyTranspon = new TextBox();//parameter for Transposition

        public static TextBox keyVig = new TextBox();//parameter for Vigener
    }
}
