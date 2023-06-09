﻿using System;
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
            button16.Enabled = true;
            if (equation)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                equation = false;
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "";
                    textBox1.Text = textBox1.Text + (sender as System.Windows.Forms.Button).Text;
                }
                else
                {
                    textBox1.Text = textBox1.Text + (sender as System.Windows.Forms.Button).Text;
                }
                
            }
            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "";
                    textBox1.Text = textBox1.Text + (sender as System.Windows.Forms.Button).Text;
                }
                else
                {
                    textBox1.Text = textBox1.Text + (sender as System.Windows.Forms.Button).Text;
                }
            }
            
        }

        //button 0
        private void button0_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
            if (equation)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                equation = false;
                if (textBox1.Text != "0" && textBox1.Text != "0.")
                {
                    textBox1.Text = textBox1.Text + (sender as System.Windows.Forms.Button).Text;
                }               
            }
            else
            {
                if (textBox1.Text != "0" && textBox1.Text != "0.")
                {
                    textBox1.Text = textBox1.Text + (sender as System.Windows.Forms.Button).Text;
                }
            }
        }

        //dot
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

        //clear all
        private void button11_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
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

        //plus
        private void button12_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
            if (textBox1.Text != "")
            {
                equation = false;
                oparand1 = Convert.ToDouble(textBox1.Text);
                opr = "+";
                textBox2.Text = textBox1.Text + " " + opr;
                textBox1.Clear();
            }            
        }

        //multiply
        private void button13_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
            if (textBox1.Text != "")
            {
                equation = false;
                oparand1 = Convert.ToDouble(textBox1.Text);
                opr = "*";
                textBox2.Text = textBox1.Text + " " + opr;
                textBox1.Clear();
            }  
        }

        //minus
        private void button14_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
            if (textBox1.Text != "")
            {
                equation = false;
                oparand1 = Convert.ToDouble(textBox1.Text);
                opr = "-";
                textBox2.Text = textBox1.Text + " " + opr;
                textBox1.Clear();
            } 
        }

        //divide
        private void button15_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
            if (textBox1.Text != "")
            {
                equation = false;
                oparand1 = Convert.ToDouble(textBox1.Text);
                opr = "/";
                textBox2.Text = textBox1.Text + " " + opr;
                textBox1.Clear();
            }       
        }

        //change to the opposite sign
        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != "")
            {
                textBox2.Text = "";
                double nice = Convert.ToDouble(textBox1.Text) * -1;
                textBox1.Text = Convert.ToString(nice);
            }
        }

        //cut off last char
        private void button17_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
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

        //equal
        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (!equation)
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
                    if (equation == true)
                    {
                        button16.Enabled = false;
                    }
                    else
                    {
                        button16.Enabled = true;
                    }
                }
            }
        }
    }
}