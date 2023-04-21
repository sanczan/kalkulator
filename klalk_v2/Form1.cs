using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool equation = false;
        string opr;
        double  oparand1, oparand2, result;

        //button 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (equation)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                equation = false;
                textBox1.Text = textBox1.Text + 1;
            }
            else
            {
                textBox1.Text = textBox1.Text + 1;
            }
            
        }

        //button 2
        private void button2_Click(object sender, EventArgs e)
        {
            if (equation)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                equation = false;
                textBox1.Text = textBox1.Text + 2;
            }
            else
            {
                textBox1.Text = textBox1.Text + 2;
            }
        }

        //button 3
        private void button3_Click(object sender, EventArgs e)
        {
            if (equation)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                equation = false;
                textBox1.Text = textBox1.Text + 3;
            }
            else
            {
                textBox1.Text = textBox1.Text + 3;
            }
        }

        //button 4
        private void button4_Click(object sender, EventArgs e)
        {
            if (equation)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                equation = false;
                textBox1.Text = textBox1.Text + 4;
            }
            else
            {
                textBox1.Text = textBox1.Text + 4;
            }
        }

        //button 5
        private void button5_Click(object sender, EventArgs e)
        {
            if (equation)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                equation = false;
                textBox1.Text = textBox1.Text + 5;
            }
            else
            {
                textBox1.Text = textBox1.Text + 5;
            }
        }

        //button 6 
        private void button6_Click(object sender, EventArgs e)
        {
            if (equation)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                equation = false;
                textBox1.Text = textBox1.Text + 6;
            }
            else
            {
                textBox1.Text = textBox1.Text + 6;
            }
        }

        //button 7
        private void button7_Click(object sender, EventArgs e)
        {
            if (equation)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                equation = false;
                textBox1.Text = textBox1.Text + 7;
            }
            else
            {
                textBox1.Text = textBox1.Text + 7;
            }
        }

        //button 8
        private void button8_Click(object sender, EventArgs e)
        {
            if (equation)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                equation = false;
                textBox1.Text = textBox1.Text + 8;
            }
            else
            {
                textBox1.Text = textBox1.Text + 8;
            }
        }

        //button 9
        private void button9_Click(object sender, EventArgs e)
        {
            if (equation)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                equation = false;
                textBox1.Text = textBox1.Text + 9;
            }
            else
            {
                textBox1.Text = textBox1.Text + 9;
            }
        }

        //button 0
        private void button0_Click(object sender, EventArgs e)
        {
            if (equation)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                equation = false;
                textBox1.Text = textBox1.Text + 0;
            }
            else
            {
                textBox1.Text = textBox1.Text + 0;
            }
        }

        //dot button
        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                if (textBox1.Text != "")
                {
                    textBox1.Text = textBox1.Text + ",";
                }
            }
        }

        //clear all button
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.Button btn)
                {
                    btn.Enabled = true;
                }
            }
        }

        //plus button
        private void button12_Click(object sender, EventArgs e)
        {          
            if (textBox1.Text != "")
            {
                equation = false;
                oparand1 = Convert.ToDouble(textBox1.Text);
                opr = "+";
                textBox2.Text = textBox1.Text + " " + opr;
                textBox1.Clear();
            }            
        }

        //multiply button
        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                equation = false;
                oparand1 = Convert.ToDouble(textBox1.Text);
                opr = "*";
                textBox2.Text = textBox1.Text + " " + opr;
                textBox1.Clear();
            }  
        }

        //minus button
        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                equation = false;
                oparand1 = Convert.ToDouble(textBox1.Text);
                opr = "-";
                textBox2.Text = textBox1.Text + " " + opr;
                textBox1.Clear();
            } 
        }

        //divide button
        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                equation = false;
                oparand1 = Convert.ToDouble(textBox1.Text);
                opr = "/";
                textBox2.Text = textBox1.Text + " " + opr;
                textBox1.Clear();
            }       
        }

        //cut off last char
        private void button17_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;

            if (s.Length > 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text = "";
            }
        }

        //equal button
        private void button16_Click(object sender, EventArgs e)
        {
            oparand2 = Convert.ToDouble(textBox1.Text);
            equation = true;
            switch (opr)
            {
                case "+":
                    result = oparand1 + oparand2;
                    textBox2.Text = textBox2.Text + " " + textBox1.Text + " =";
                    textBox1.Text = Convert.ToString(result);

                    break;

                case "-":
                    result = oparand1 - oparand2;
                    textBox2.Text = textBox2.Text + " " + textBox1.Text + " =";
                    textBox1.Text = Convert.ToString(result);


                    break;

                case "*":
                    result = oparand1 * oparand2;
                    textBox2.Text = textBox2.Text + " " + textBox1.Text + " =";
                    textBox1.Text = Convert.ToString(result);

                    break;

                case "/":
                    if (oparand2 == 0)
                    {
                        textBox1.Text = "ty sie chyba boga nie boisz";
                        textBox2.Clear();
                        foreach (Control control in this.Controls)
                        {
                            if (control is System.Windows.Forms.Button btn)
                            {
                                btn.Enabled = false;
                            }
                        }
                        button11.Enabled = true;
                        break;
                    }
                    else
                    {
                        result = oparand1 / oparand2;
                        textBox2.Text = textBox2.Text + " " + textBox1.Text + " =";
                        textBox1.Text = Convert.ToString(result);

                        break;
                    }
            }
        }
    }
}