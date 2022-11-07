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
using System.Threading;

namespace SuperCalc
{
    public partial class Form1 : Form
    {
        string txtBoxVal = "";
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
            panel4.Visible = false;
            button2.Visible = true;
            panel5.Visible = false;
            button3.Visible = true;

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            panel6.Visible = false;
            panel5.Visible = true;
            panel4.Visible = true;
            textBox3.Visible = false;
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
            button3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;

            panel4.Visible = true;
            button2.Visible = false;
            textBox3.Visible = false;
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
            button3.Visible = false;
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
            textBox3.Visible = false;
            panel5.Visible = true;
            button2.Visible = false;
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
            panel4.Visible = true;
            button3.Visible = false;
        }

        private void NormalCalc_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel4.Visible = true;
            button2.Visible = false;
            textBox3.Visible = false;
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
            button3.Visible = false;
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
            panel5.Visible = true;
            panel4.Visible = true;
            button2.Visible = false;
            textBox3.Visible = false;
            QuadEquation.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            ComplexNum2Imaginary.Visible = true;
            materialLabel10.Visible = true;
            materialLabel9.Visible = true;
            button1.Visible = false;
            DarkTheme.Visible = false;
            LightTheme.Visible = false;
            button3.Visible = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel4.Visible = true;
            button2.Visible = false;
            textBox3.Visible = false;
            panel3.Visible = true;
            panel2.Visible = false;
            QuadEquation.Visible = false;
            button1.Visible = false;
            DarkTheme.Visible = false;
            LightTheme.Visible = false;
            button3.Visible = false;
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(shapes.Text.Equals("Select a Shape"))
            {
                area1.Visible = false;
                area2.Visible = false;
                area3.Visible = false;
                sideLbl.Text = "";
            }
            else if (shapes.Text.Equals("Square") || shapes.Text.Equals("Pentagon") || shapes.Text.Equals("Hexagon") || shapes.Text.Equals("Octagon") || shapes.Text.Equals("Decagon"))
            {
                area1.Visible = true;
                area2.Visible = false;
                area3.Visible = false;
                sideLbl.Text = "Enter a side";
            }
            else if (shapes.Text.Equals("Circle"))
            {
                area1.Visible = true;
                area2.Visible = false;
                area3.Visible = false;
                sideLbl.Text = "Enter the radius";
            }
            else if (shapes.Text.Equals("Rectangle") || shapes.Text.Equals("Parallelogram") || shapes.Text.Equals("Triangle") || shapes.Text.Equals("Rhombus"))
            {
                sideLbl.Text = "Enter the base and height";
                area1.Visible = true;
                area2.Visible = true;
            }
            else if (shapes.Text.Equals("Trapezoid"))
            {
                sideLbl.Text = "Enter the two bases and the height";
                area1.Visible = true;
                area2.Visible = true;
                area3.Visible = true;
            }
            
        }
        double a, b, c, finalArea;

        private void materialRaisedButton6_Click_1(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel4.Visible = true;
            panel2.Visible = false;
            QuadEquation.Visible = false;
            panel3.Visible = false;
            button2.Visible = false;
            textBox3.Visible = true;
            button3.Visible = false;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel4.Visible = true;
            panel2.Visible = false;
            QuadEquation.Visible = false;
            panel3.Visible = false;
            textBox3.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void comboBoxEdit1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (binary.Text.Equals("Choose Something"))
            {
                binary1.Visible = false;
                binaryHead.Text = "";
                //binary2.Visible = false;
                //BinaryOPs.Visible = false;
            }
            else if (binary.Text.Equals("Normal Numbers to Binary"))
            {
                binary1.Visible = true;
               // binary2.Visible = false;
                binaryHead.Text = "Enter a number to convert to binary";
               // BinaryOPs.Visible = false;
            }
            else if (binary.Text.Equals("Binary to Normal Numbers"))
            {
                binary1.Visible = true;
                //binary2.Visible = false;
                binaryHead.Text = "Enter a binary number to convert to a normal number";
               // BinaryOPs.Visible = false;

            }
            else if (binary.Text.Equals("Binary Addition"))
            {
                binary1.Visible = true;
               // binary2.Visible = true;
                binaryHead.Text = "Enter two binary numbers to add";
               // BinaryOPs.Visible = true;
                //BinaryOPs.Text = "+";
            }
            else if (binary.Text.Equals("Binary Subtraction"))
            {
                binary1.Visible = true;
               // binary2.Visible = true;
                binaryHead.Text = "Enter two binary numbers to subtract";
                //BinaryOPs.Visible = true;
                //BinaryOPs.Text = "-";
            }
            else if (binary.Text.Equals("Binary Multiplication"))
            {
                binary1.Visible = true;
               // binary2.Visible = true;
                binaryHead.Text = "Enter two binary numbers to multiply";
                //BinaryOPs.Visible = true;
                //BinaryOPs.Text = "x";
            }
            else
            {
                binary1.Visible = true;
               // binary2.Visible = true;
                binaryHead.Text = "Enter two binary numbers to divide";
                //BinaryOPs.Visible = true;
                //BinaryOPs.Text = "-";
            }
        }
        int x, y;

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel4.Visible = false;
            QuadEquation.Visible = false;
            panel3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel4.Visible = false;
            QuadEquation.Visible = false;
            panel3.Visible = false;
            button3.Visible = false;
        }

        private void comboBoxEdit1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if(matrixDrop.Text.Equals("Choose Something"))
            {
                dimensions2.Visible = false;
                dimensions.Visible = false;
                dOP.Visible = false;
                dOP1.Visible = false;
                op.Visible = false;
                d1.Visible = false;
                d2.Visible = false;
                d3.Visible = false;
                d4.Visible = false;
                m1.Visible = false;
                m2.Visible = false;
                m3.Visible = false;
                m4.Visible = false;
                m5.Visible = false;
                m6.Visible = false;
                m7.Visible = false;
                m8.Visible = false;
                m9.Visible = false;
                m11.Visible = false;
                m12.Visible = false;
                m13.Visible = false;
                m14.Visible = false;
                m15.Visible = false;
                m16.Visible = false;
                m17.Visible = false;
                m18.Visible = false;
                m19.Visible = false;
            }
            else if(matrixDrop.Text.Equals("Matrix Addition"))
            {
                dimensions2.Visible = true;
                dimensions.Visible = true;
                dOP.Visible = true;
                dOP1.Visible = true;
                op.Visible = true;
                d1.Visible = true;
                d2.Visible = true;
                d3.Visible = true;
                d4.Visible = true;
                m1.Visible = true;
                m2.Visible = true;
                m3.Visible = true;
                m4.Visible = true;
                m5.Visible = true;
                m6.Visible = true;
                m7.Visible = true;
                m8.Visible = true;
                m9.Visible = true;
                m11.Visible = true;
                m12.Visible = true;
                m13.Visible = true;
                m14.Visible = true;
                m15.Visible = true;
                m16.Visible = true;
                m17.Visible = true;
                m18.Visible = true;
                m19.Visible = true;
                op.Text = "+";
            }
            else if(matrixDrop.Text.Equals("Matrix Multiplication"))
            {
                dimensions2.Visible = true;
                dimensions.Visible = true;
                dOP.Visible = true;
                dOP1.Visible = true;
                op.Visible = true;
                d1.Visible = true;
                d2.Visible = true;
                d3.Visible = true;
                d4.Visible = true;
                m1.Visible = true;
                m2.Visible = true;
                m3.Visible = true;
                m4.Visible = true;
                m5.Visible = true;
                m6.Visible = true;
                m7.Visible = true;
                m8.Visible = true;
                m9.Visible = true;
                m11.Visible = true;
                m12.Visible = true;
                m13.Visible = true;
                m14.Visible = true;
                m15.Visible = true;
                m16.Visible = true;
                m17.Visible = true;
                m18.Visible = true;
                m19.Visible = true;
                op.Text = "x";
            }
            else
            {
                dimensions.Visible = true;
                dOP.Visible = true;
                d1.Visible = true;
                d2.Visible = true;
                m1.Visible = true;
                m2.Visible = true;
                m3.Visible = true;
                m4.Visible = true;
                m5.Visible = true;
                m6.Visible = true;
                m7.Visible = true;
                m8.Visible = true;
                m9.Visible = true;
                m11.Visible = false;
                m12.Visible = false;
                m13.Visible = false;
                m14.Visible = false;
                m15.Visible = false;
                m16.Visible = false;
                m17.Visible = false;
                m18.Visible = false;
                m19.Visible = false;
                op.Visible = false;
                dimensions2.Visible = false;
                dOP1.Visible = true;
                d3.Visible = false;
                d4.Visible = false;
            }
        }
        int column, row, column1, row1;

        private void d4_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(d1.Text, out row1);
            if (row1 > 3 || row1 < 1)
            {
                d1.Text = "";
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            button4.Visible = false;
        }

        private void d2_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(d2.Text, out row);
            if (row > 3 || row < 1)
            {
                d2.Text = "";
            }
        }

        private void d3_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(d3.Text, out column1);
            if (column1 > 3 || column1 < 1)
            {
                d3.Text = "";
            }
        }

        private void d1_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(d1.Text, out column);
            if (column > 3 || column < 1)
            {
                d1.Text = "";
            }

        }

        private void binary1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(binary1.Text, out x);
            //int.TryParse(binary2.Text, out y);
            
            if (binary.Text.Equals("Normal Numbers to Binary"))
            {
                binaryAns.Text = Convert.ToString(x, 2);
                
            }
            else if(binary.Text.Equals("Binary to Normal Numbers"))
            {
                if (x.ToString().Contains("2") || x.ToString().Contains("3") || x.ToString().Contains("4") || x.ToString().Contains("5") || x.ToString().Contains("6") || x.ToString().Contains("7") || x.ToString().Contains("8") || x.ToString().Contains("9"))
                {
                    binaryAns.Text = "Enter Binary Numbers, not regular";
                }
                else
                {
                    Int64 output = Convert.ToInt32(x.ToString(), 2);
                    binaryAns.Text = output.ToString();
                }
            }
            else if(binary.Text.Equals("Binary Addition"))
            {
                if (x.ToString().Contains("2") || x.ToString().Contains("3") || x.ToString().Contains("4") || x.ToString().Contains("5") || x.ToString().Contains("6") || x.ToString().Contains("7") || x.ToString().Contains("8") || x.ToString().Contains("9"))
                {
                    binaryAns.Text = "Enter Binary Numbers, not regular";
                }
                else
                {
                    Int64 output = Convert.ToInt32(x.ToString(), 2);
                    binaryAns.Text = output.ToString();
                }
            }
        }
        

        private void area3_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(area1.Text, out a);
            double.TryParse(area2.Text, out b);
            double.TryParse(area3.Text, out c);
            
            if (!shapes.Text.Equals("Trapezoid") && !shapes.Text.Equals("Square"))
            {
                if (shapes.Text.Equals("Triangle"))
                {
                    finalArea = (a * b) / 2;
                    textBox3.Text = finalArea.ToString();
                }
                else
                {
                    finalArea = a * b;
                    textBox3.Text = finalArea.ToString();
                }
            }

            else if (shapes.Text.Equals("Square"))
            {
                finalArea = a * a;
                textBox3.Text = finalArea.ToString();
            }
            else if (shapes.Text.Equals("Trapezoid"))
            {
                finalArea = (a + b) / 2 * c;
                textBox3.Text = finalArea.ToString();
            }
        }

        private void area2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(area1.Text, out a);
            double.TryParse(area2.Text, out b);
            double.TryParse(area3.Text, out c);
            if (!shapes.Text.Equals("Trapezoid") && !shapes.Text.Equals("Square"))
            {
                if (shapes.Text.Equals("Triangle"))
                {
                    finalArea = (a * b) / 2;
                    textBox3.Text = finalArea.ToString();
                }
                else
                {
                    finalArea = a * b;
                    textBox3.Text = finalArea.ToString();
                }
            }
            else if (shapes.Text.Equals("Square"))
            {
                finalArea = a * a;
                textBox3.Text = finalArea.ToString();
            }
            else if (shapes.Text.Equals("Trapezoid"))
            {
                finalArea = (a + b) / 2 * c;
                textBox3.Text = finalArea.ToString();
            }
        }

        private void area1_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(area1.Text, out a);
            double.TryParse(area2.Text, out b);
            double.TryParse(area3.Text, out c);
            if (shapes.Text.Equals("Pentagon"))
            {
                finalArea = Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) / 4 * (a * a);
                textBox3.Text = finalArea.ToString();
            }
            else if (shapes.Text.Equals("Circle"))
            {
                finalArea = Math.PI * a * a;
                textBox3.Text = finalArea.ToString();
            }
            else if (shapes.Text.Equals("Hexagon"))
            {
                finalArea = 3 * Math.Sqrt(3) / 2 * a * a;
                textBox3.Text = finalArea.ToString();
            }
            
            else if (shapes.Text.Equals("Octagon"))
            {
                finalArea = 2 * (1 + Math.Sqrt(2)) * a * a;
                textBox3.Text = finalArea.ToString();
            }
            
            else if (shapes.Text.Equals("Decagon"))
            {
                finalArea = 5 / 2 * a * a * Math.Sqrt(5 + 2 * Math.Sqrt(5));
                textBox3.Text = finalArea.ToString();
            }
            else if (!shapes.Text.Equals("Trapezoid") && !shapes.Text.Equals("Square"))
            {
                if (shapes.Text.Equals("Triangle"))
                {
                    finalArea = (a * b) / 2;
                    textBox3.Text = finalArea.ToString();
                }
                else
                {
                    finalArea = a * b;
                    textBox3.Text = finalArea.ToString();
                }
            }
            else if (shapes.Text.Equals("Square"))
            {
                finalArea = a * a;
                textBox3.Text = finalArea.ToString();
            }
            else if (shapes.Text.Equals("Trapezoid"))
            {
                finalArea = (a + b) / 2 * c;
                textBox3.Text = finalArea.ToString();
            }
        }
    }
}
