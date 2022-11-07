using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace SuperCalc
{
    public partial class Form1 : Form
    {
        string txtBoxVal = "";
        int lastOPloc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            int valA = 0;
            int valB = 0;
            int valC = 0;
            if (int.TryParse(ValueA.Text, out _))
            {
                valA = Int32.Parse(ValueA.Text);
                if (int.TryParse(ValueB.Text, out _))
                {
                    valB = Int32.Parse(ValueB.Text);
                    if (int.TryParse(ValueC.Text, out _))
                    {
                        valC = Int32.Parse(ValueC.Text);
                        double x1 = (-valB + Math.Sqrt(valB * valB - 4 * valA * valC)) / (2 * valA);
                        double x2 = (-valB - Math.Sqrt(valB * valB - 4 * valA * valC)) / (2 * valA);

                        if (double.IsNaN(x1) || double.IsNaN(x2))
                            textBox1.Text = "No Possible Answer";
                        else if (x1 == x2)
                            textBox1.Text = "x = " + x1;
                        else
                            textBox1.Text = "x = " + x1 + ", " + x2;
                    }
                    else
                        textBox1.Text = "Enter a number.";
                }
                else
                    textBox1.Text = "Enter a number.";
            }
            else
                textBox1.Text = "Enter a number.";
        }


        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            QuadEquation.Visible = false;
            HomeLbL.Visible = true;
            NormalCalc.Visible = true;
            MainQuad.Visible = true;
            panel2.Visible = false;
            DarkTheme.Visible = true;
            LightTheme.Visible = true;
            panel3.Visible = false;
            button1.Visible = true;

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            QuadEquation.Visible = true;
            DarkTheme.Visible = false;
            LightTheme.Visible = false;
            panel2.Visible = true;
            HomeLbL.Visible = false;
            equals.Visible = false;
            clear.Visible = false;
            num0.Visible = false;
            num1.Visible = false;
            num2.Visible = false;
            num3.Visible = false;
            num4.Visible = false;
            num5.Visible = false;
            num6.Visible = false;
            num7.Visible = false;
            num8.Visible = false;
            num9.Visible = false;
            addition.Visible = false;
            subtraction.Visible = false;
            multiplication.Visible = false;
            Division.Visible = false;
            percent.Visible = false;
            sqrt.Visible = false;
            square.Visible = false;
            backspace.Visible = false;
            ComplexNum2Imaginary.Visible = false;
            materialLabel10.Visible = false;
            materialLabel9.Visible = false;
            button1.Visible = false;
            panel3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuadEquation.Visible = true;
            DarkTheme.Visible = false;
            LightTheme.Visible = false;
            HomeLbL.Visible = false;
            NormalCalc.Visible = false;
            MainQuad.Visible = false;
            panel2.Visible = true;
            equals.Visible = false;
            clear.Visible = false;
            num0.Visible = false;
            num1.Visible = false;
            num2.Visible = false;
            num3.Visible = false;
            num4.Visible = false;
            num5.Visible = false;
            num6.Visible = false;
            num7.Visible = false;
            num8.Visible = false;
            num9.Visible = false;
            addition.Visible = false;
            subtraction.Visible = false;
            multiplication.Visible = false;
            Division.Visible = false;
            percent.Visible = false;
            sqrt.Visible = false;
            square.Visible = false;
            backspace.Visible = false;
            panel3.Visible = true;
            ComplexNum2Imaginary.Visible = false;
            materialLabel10.Visible = false;
            materialLabel9.Visible = false;
            button1.Visible = false;
        }
        private void num1_Click(object sender, EventArgs e)
        {
            txtBoxVal += 1;
            textBox2.Text = txtBoxVal;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            txtBoxVal += 2;
            textBox2.Text = txtBoxVal;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            txtBoxVal += 3;
            textBox2.Text = txtBoxVal;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            txtBoxVal += 4;
            textBox2.Text = txtBoxVal;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            txtBoxVal += 5;
            textBox2.Text = txtBoxVal;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            txtBoxVal += 6;
            textBox2.Text = txtBoxVal;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            txtBoxVal += 7;
            textBox2.Text = txtBoxVal;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            txtBoxVal += 8;
            textBox2.Text = txtBoxVal;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            txtBoxVal += 9;
            textBox2.Text = txtBoxVal;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            txtBoxVal += 0;
            textBox2.Text = txtBoxVal;
        }

        private void addition_Click(object sender, EventArgs e)
        {
            txtBoxVal += " + ";
            textBox2.Text = txtBoxVal;
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            txtBoxVal += " - ";
            textBox2.Text = txtBoxVal;
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            txtBoxVal += " * ";
            textBox2.Text = txtBoxVal;
        }

        private void Division_Click(object sender, EventArgs e)
        {
            txtBoxVal += " / ";
            textBox2.Text = txtBoxVal;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            bool istrue = false;
            for(int i = 0; i < textBox2.Text.Length; i++)
            {
                if((textBox2.Text[i] >= 'a' && textBox2.Text[i] <= 'z') || (textBox2.Text[i] >= 'A' && textBox2.Text[i] <= 'Z'))
                {
                    istrue = true;
                }
            }
            if (istrue)
            {
                textBox2.Text = "Don't Enter Letters";
            }
            else {
                DataTable dt = new DataTable();
                var ans = dt.Compute(textBox2.Text, "");
                textBox2.Text = "" + ans;
                txtBoxVal = textBox2.Text;
            }


            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtBoxVal = "";
            textBox2.Text = txtBoxVal;
        }

        private void square_Click(object sender, EventArgs e)
        {
            double val = Double.Parse(textBox2.Text);
            val = val * val;
            textBox2.Text = val.ToString();
            txtBoxVal = textBox2.Text;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            double val = Double.Parse(textBox2.Text);
            val = Math.Sqrt(val);
            textBox2.Text = val.ToString();
            txtBoxVal = textBox2.Text;
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            QuadEquation.Visible = false;
            DarkTheme.Visible = false;
            LightTheme.Visible = false;
            panel2.Visible = true;
            equals.Visible = true;
            clear.Visible = true;
            num0.Visible = true;
            num1.Visible = true;
            num2.Visible = true;
            num3.Visible = true;
            num4.Visible = true;
            num5.Visible = true;
            num6.Visible = true;
            num7.Visible = true;
            num8.Visible = true;
            num9.Visible = true;
            addition.Visible = true;
            subtraction.Visible = true;
            multiplication.Visible = true;
            Division.Visible = true;
            percent.Visible = true;
            sqrt.Visible = true;
            square.Visible = true;
            backspace.Visible = true;
            panel3.Visible = true;
            ComplexNum2Imaginary.Visible = false;
            materialLabel10.Visible = false;
            materialLabel9.Visible = false;
            button1.Visible = false;
        }

        private void NormalCalc_Click(object sender, EventArgs e)
        {
            QuadEquation.Visible = false;
            DarkTheme.Visible = false;
            LightTheme.Visible = false;
            panel2.Visible = true;
            equals.Visible = true;
            clear.Visible = true;
            num0.Visible = true;
            num1.Visible = true;
            num2.Visible = true;
            num3.Visible = true;
            num4.Visible = true;
            num5.Visible = true;
            num6.Visible = true;
            num7.Visible = true;
            num8.Visible = true;
            num9.Visible = true;
            addition.Visible = true;
            subtraction.Visible = true;
            multiplication.Visible = true;
            Division.Visible = true;
            percent.Visible = true;
            sqrt.Visible = true;
            square.Visible = true;
            backspace.Visible = true;
            panel3.Visible = true;
            ComplexNum2Imaginary.Visible = false;
            materialLabel10.Visible = false;
            materialLabel9.Visible = false;
            button1.Visible = false;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength != 0)
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.TextLength - 1, 1);
                txtBoxVal = textBox2.Text;
            }
        }

        private void percent_Click(object sender, EventArgs e)
        {
            txtBoxVal += " / 100 ";
            textBox2.Text = txtBoxVal;
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            panel2.BackColor = Color.Gray;
            panel3.BackColor = Color.Gray;
            QuadEquation.BackColor = Color.Gray;
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(224, 224, 224);
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            QuadEquation.BackColor = Color.FromArgb(224, 224, 224);
        }
        string ComplexOp;
        private void ComplexAdd_Click(object sender, EventArgs e)
        {
            ComplexOp = "+";
        }

        private void ComplexSub_Click(object sender, EventArgs e)
        {
            ComplexOp = "-";
        }
        private void ComplexMult_Click(object sender, EventArgs e)
        {
            ComplexOp = "*";
        }
        private void ComplexDiv_Click(object sender, EventArgs e)
        {
            ComplexOp = "/";
        }
        private void airButton1_Click(object sender, EventArgs e)
        {

            Complex complexNum1 = new Complex(Double.Parse(ComplexNum1Real.Text), Double.Parse(ComplexNum1Imaginary.Text));
            Complex complexNum2 = new Complex(Double.Parse(ComplexNum2Real.Text), Double.Parse(ComplexNum2Imaginary.Text));
            Complex answer = new Complex();
            if (ComplexOp == "+")
            {
                answer = complexNum1 + complexNum2;
            }
            else if (ComplexOp == "-")
            {
                answer = complexNum1 - complexNum2;
            }
            else if (ComplexOp == "*")
            {
                answer = complexNum1 * complexNum2;
            }
            else
                answer = complexNum1 / complexNum2;
            AnswerBox.Text = answer.Real + " + " + answer.Imaginary + "i";

        }

        private void materialRaisedButton5_Click_1(object sender, EventArgs e)
        {
            QuadEquation.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            ComplexNum2Imaginary.Visible = true;
            materialLabel10.Visible = true;
            materialLabel9.Visible = true;
            button1.Visible = false;
            DarkTheme.Visible = false;
            LightTheme.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
            QuadEquation.Visible = false;
            button1.Visible = false;
            DarkTheme.Visible = false;
            LightTheme.Visible = false;
        }
    }
}
