using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Crypto.Parameter;

namespace Crypto
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            this.Text = "Crypto";//form name assign                              
            this.BackColor = Color.PaleTurquoise;//form color assign
            groupBox_Parameter.BackColor = Color.LemonChiffon;//parameter container color assign
            comboBox_Cipher.Items.AddRange(new string[] { "Ceasar", "Transpon"
                , "Igpay Atinlay", "Bakon"
                , "Vigener", "Moorse", "Combo", "Vakse"});//cipher type pool
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//describe's work
                                                                               //of parameters container
        {     
            groupBox_Parameter.Controls.Clear();//cleansing of parameters container
                                       //needed to dynamicaly remove pervious parameters
                                       //and add new, responding to ComboBox choice

            if (comboBox_Cipher.SelectedItem.ToString() == "Ceasar")//adding parameters for Ceasar
            {
                groupBox_Parameter.Controls.Add(rot);
                rot.Location = new Point(30, 50);
                rot.Maximum = 26;
                rot.Value = 0;
                rot.Minimum = -26;
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Transpon")//adding parameters for Transposition
            {
                groupBox_Parameter.Controls.Add(keyTranspon);
                keyTranspon.Location = new Point(30, 50);
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Vigener")//adding parameters for Vigener
            {
                groupBox_Parameter.Controls.Add(keyVig);
                keyVig.Location = new Point(30, 50);
            }
        }

        private void button_Encode_Click(object sender, EventArgs e)//describe's work of
                                                                    //encode button
        {
            String input = textBox_Input_encode.Text.ToLower();//getting input
            String output = "";
            if (comboBox_Cipher.SelectedItem == null)//if no cipher selected
            { 
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Ceasar")//if selected Ceasar cipher
            {
                output = Ceasar.Encipher(input, ((int)rot.Value));//see Ceasar class
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Transpon")//if selected Transposition cipher
            {                
                output = Transposition.Encipher(input, keyTranspon.Text,' ');//see Transposition class
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Igpay Atinlay")//if selected PigLatin cipher
            {
                output = PigLatin.Encrypt(input);//see PigLatin class
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Bakon")//if selected Bakon cipher
            {
                output = Bakon.Encode(input);//see Bakon class
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Vigener")//if selected Vigener cipher
            {
                output = Vigener.convertText(input, keyVig.Text, true);//see Vigener class
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Moorse")//if selected Moorse cipher
            {
                output = Moorse.Encode(input);//see Moorse class
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Combo")//if selected Combo cipher
            {
                String VigSt = Vigener.convertText(input, "Sonic", true);
                String TransSt = Transposition.Encipher(VigSt, "31 10", ' ');
                String CeasarSt = Ceasar.Encipher(TransSt,8);
                output = CeasarSt;
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Vakse")//if selected Vakse cipher
            {
                output = Vakse.Encode(input);//see Vakse class
            }
            else 
            {
            }
            textBox_Output_encode.Text = output;//assigning result
        }

        private void button_Decode_Click(object sender, EventArgs e)//describe's work of
                                                                    //decode button
        {
            String input = textBox_Input_decode.Text.ToLower();
            String output = "";
            if (comboBox_Cipher.SelectedItem == null)
            {
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Ceasar")
            {
                output = Ceasar.Decipher(input, ((int)rot.Value));//see Ceasar class
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Transpon")
            {
                output = Transposition.Decipher(input,keyTranspon.Text);//see Transposition class
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Igpay Atinlay")//if selected PigLatin cipher
            {
                output = PigLatin.Decrypt(input);//see PigLatin class
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Bakon")//if selected Bakon cipher
            {
                output = Bakon.Decode(input);//see Bakon class
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Vigener")//if selected Vigener cipher
            {
                output = Vigener.convertText(input,keyVig.Text,false);//see Vigener class
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Moorse")//if selected Moorse cipher
            {
                output = Moorse.Decode(input);//see Moorse class
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Combo")//if selected Combo cipher
            {
                String CeasarSt = Ceasar.Decipher(input, 8);
                String TransSt = Transposition.Decipher(CeasarSt, "31 10");
                String VigSt = Vigener.convertText(TransSt, "Sonic", false);
                output = VigSt;
            }
            else if (comboBox_Cipher.SelectedItem.ToString() == "Vakse")//if selected Vakse cipher
            {
                output = Vakse.Decode(input);//see Vakse class
            }
            else
            {
            }
            textBox_Output_decode.Text = output;
        }
    }
}
