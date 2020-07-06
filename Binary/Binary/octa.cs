using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary
{
    public partial class octa : Form
    {
        public octa()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {

        }
       

        private void b1_Click(object sender, EventArgs e)
        {
            this.Hide();
            G.M.Show();

        }

        private void convert_Click_1(object sender, EventArgs e)
        {
            help1.Visible = false;
            help2.Visible = false;
            help3.Visible = false;
            help4.Visible = false;
            help5.Visible = false;
            help6.Visible = false;

            {
                #region octa to decimal
                //make a string based on user input

                String Octal = input.Text;
                int octLength = Octal.Length;
                double dec = 0;

                for (int i = 0; i < octLength; ++i)
                {
                    dec += ((byte)Octal[i] - 48) * Math.Pow(8, ((octLength - i) - 1));
                }

                string ans = Convert.ToString(dec);
                Decimal.Text = ans;
                #endregion
                // ans is decimal number use this to calculate the rest
                //found decimal and use previous code to calculate the rest 
                #region Decimal to Hexa
                int Y;
                bool numcheck = int.TryParse(input.Text, out Y);
                zz.Text = Convert.ToString(Y, 16);
                #endregion
                #region decimal to binary
                int x;
                int RU;
                int RO;
                bool Numcheck = int.TryParse(input.Text, out x);



                if (input.Text == "")
                {
                    MessageBox.Show("Please enter integers");
                }
                else
                {
                    int[] BinUnder255 = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

                    if (Numcheck)
                    {
                        if (x <= 255)
                        {
                            for (int i = 0; i < 8; i++)
                            {
                                RU = x % 2;
                                x /= 2;
                                BinUnder255[i] = RU;
                            }
                        }
                        Array.Reverse(BinUnder255);
                        BinaryOutput.Text = Convert.ToString(BinUnder255[0]) + Convert.ToString(BinUnder255[1]) + Convert.ToString(BinUnder255[2])
                                          + Convert.ToString(BinUnder255[3]) + Convert.ToString(BinUnder255[4]) + Convert.ToString(BinUnder255[5])
                                          + Convert.ToString(BinUnder255[6]) + Convert.ToString(BinUnder255[7]);
                    }
                    else if (x > 255)
                    {
                        String Binover255 = string.Empty;
                        while (x > 0)
                        {
                            RO = x % 2;
                            x /= 2;
                            Binover255 = RO.ToString() + Binover255;
                        }
                        BinaryOutput.Text = Binover255;
                    }
                }
                #endregion
                #region decimal to text
                {
                    {
                        {

                            string tempString = "";
                            string Character = System.Text.RegularExpressions.Regex.Replace(BinaryOutput.Text, "[^01]", "");
                            byte[] Bytes = new byte[(Character.Length / 8) - 1 + 1];
                            for (int Index = 0; Index <= Bytes.Length - 1; Index++)
                            {
                                Bytes[Index] = Convert.ToByte(Character.Substring(Index * 8, 8), 2);
                            }
                            tempString = (string)(System.Text.ASCIIEncoding.ASCII.GetString(Bytes));
                            xx.Text = tempString;
                        }
                    }
                }
                #endregion

            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void b1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            G.M.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (help1.Visible == true)
            {
                help1.Visible = false;
                help2.Visible = false;
                help3.Visible = false;
                help4.Visible = false;
                help5.Visible = false;
                help6.Visible = false;

            }
            else if (help1.Visible != true)
            {
                help1.Visible = true;
                help2.Visible = true;
                help3.Visible = true;
                help4.Visible = true;
                help5.Visible = true;
                help6.Visible = true;
            }
        }

        private void xx_Click(object sender, EventArgs e)
        {

        }
    }
}
