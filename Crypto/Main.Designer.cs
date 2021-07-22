
namespace Crypto
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Input_encode = new System.Windows.Forms.TextBox();
            this.textBox_Input_decode = new System.Windows.Forms.TextBox();
            this.button_Encode = new System.Windows.Forms.Button();
            this.button_Decode = new System.Windows.Forms.Button();
            this.textBox_Output_encode = new System.Windows.Forms.TextBox();
            this.textBox_Output_decode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Cipher = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_Parameter = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // textBox_Input_encode
            // 
            this.textBox_Input_encode.Location = new System.Drawing.Point(164, 282);
            this.textBox_Input_encode.Name = "textBox_Input_encode";
            this.textBox_Input_encode.Size = new System.Drawing.Size(189, 23);
            this.textBox_Input_encode.TabIndex = 0;
            // 
            // textBox_Input_decode
            // 
            this.textBox_Input_decode.Location = new System.Drawing.Point(164, 368);
            this.textBox_Input_decode.Name = "textBox_Input_decode";
            this.textBox_Input_decode.Size = new System.Drawing.Size(189, 23);
            this.textBox_Input_decode.TabIndex = 1;
            // 
            // button_Encode
            // 
            this.button_Encode.Location = new System.Drawing.Point(32, 282);
            this.button_Encode.Name = "button_Encode";
            this.button_Encode.Size = new System.Drawing.Size(95, 23);
            this.button_Encode.TabIndex = 2;
            this.button_Encode.Text = "Encode";
            this.button_Encode.UseVisualStyleBackColor = true;
            this.button_Encode.Click += new System.EventHandler(this.button_Encode_Click);
            // 
            // button_Decode
            // 
            this.button_Decode.Location = new System.Drawing.Point(32, 368);
            this.button_Decode.Name = "button_Decode";
            this.button_Decode.Size = new System.Drawing.Size(95, 23);
            this.button_Decode.TabIndex = 3;
            this.button_Decode.Text = "Decode";
            this.button_Decode.UseVisualStyleBackColor = true;
            this.button_Decode.Click += new System.EventHandler(this.button_Decode_Click);
            // 
            // textBox_Output_encode
            // 
            this.textBox_Output_encode.Location = new System.Drawing.Point(394, 283);
            this.textBox_Output_encode.Name = "textBox_Output_encode";
            this.textBox_Output_encode.ReadOnly = true;
            this.textBox_Output_encode.Size = new System.Drawing.Size(189, 23);
            this.textBox_Output_encode.TabIndex = 4;
            // 
            // textBox_Output_decode
            // 
            this.textBox_Output_decode.Location = new System.Drawing.Point(394, 368);
            this.textBox_Output_decode.Name = "textBox_Output_decode";
            this.textBox_Output_decode.ReadOnly = true;
            this.textBox_Output_decode.Size = new System.Drawing.Size(189, 23);
            this.textBox_Output_decode.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Output";
            // 
            // comboBox_Cipher
            // 
            this.comboBox_Cipher.FormattingEnabled = true;
            this.comboBox_Cipher.Location = new System.Drawing.Point(648, 46);
            this.comboBox_Cipher.Name = "comboBox_Cipher";
            this.comboBox_Cipher.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Cipher.TabIndex = 10;
            this.comboBox_Cipher.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(648, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cipher choice";
            // 
            // groupBox_Parameter
            // 
            this.groupBox_Parameter.Location = new System.Drawing.Point(32, 19);
            this.groupBox_Parameter.Name = "groupBox_Parameter";
            this.groupBox_Parameter.Size = new System.Drawing.Size(551, 216);
            this.groupBox_Parameter.TabIndex = 12;
            this.groupBox_Parameter.TabStop = false;
            this.groupBox_Parameter.Text = "Cipher parameters";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_Parameter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Cipher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Output_decode);
            this.Controls.Add(this.textBox_Output_encode);
            this.Controls.Add(this.button_Decode);
            this.Controls.Add(this.button_Encode);
            this.Controls.Add(this.textBox_Input_decode);
            this.Controls.Add(this.textBox_Input_encode);
            this.Name = "Form";
            this.Text = "Crypto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Input_encode;
        private System.Windows.Forms.TextBox textBox_Input_decode;
        private System.Windows.Forms.Button button_Encode;
        private System.Windows.Forms.Button button_Decode;
        private System.Windows.Forms.TextBox textBox_Output_encode;
        private System.Windows.Forms.TextBox textBox_Output_decode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Cipher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox_Parameter;
    }
}

