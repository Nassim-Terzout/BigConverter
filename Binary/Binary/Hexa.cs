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
    public partial class Hexa : Form
    {
        public Hexa()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            help1.Visible = false;
            help2.Visible = false;
            help3.Visible = false;
            help4.Visible = false;
            help5.Visible = false;
            help6.Visible = false;
            #region hexa to decimal 
            int output = int.Parse(input.Text, System.Globalization.NumberStyles.HexNumber);
            String ans = Convert.ToString(output);
            Decimal.Text = ans;
            #endregion
            //use variable output as that is the decimal number easier to convet the rest
            #region found decimal and used it to convert to binary
            int x;
            int RU;
            int RO;
            bool Numcheck = Int32.TryParse(Decimal.Text, out x);



            if (Decimal.Text == "")
            {
                MessageBox.Show("PLease enter a integers");
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
                    String Binover255 = String.Empty;
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
            #region found Decimal and used it to convert to Octa
            octaoutput.Text = Convert.ToString(output, 8);
            #endregion
            #region found binary from decimal which was found and use it to convert to Text
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
                        Text.Text = tempString;
                    }
                }
            }
            #endregion
            //ask why f6 gives wrong text
        }

        private void b1_Click(object sender, EventArgs e)
        {
            this.Hide();
            G.M.Show();

        }

        private void BinaryOutput_Click(object sender, EventArgs e)
        {

        }

        private void Hexa_Load(object sender, EventArgs e)
        {

        }

        private void bintitle_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
            else if(help1.Visible != true)
            {
                help1.Visible = true;
                help2.Visible = true;
                help3.Visible = true;
                help4.Visible = true;
                help5.Visible = true;
                help6.Visible = true;
            }
        }

        private void help2_Click(object sender, EventArgs e)
        {

        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
