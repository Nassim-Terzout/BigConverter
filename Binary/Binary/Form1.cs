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

    public partial class Form1 : Form
    {
        int dtotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            #region Binary to decimal    
            bool T = true;
            string bin = input.Text;
            int l = bin.Length;
            char[] nums = bin.ToCharArray();
            int DI = 0;
            String DOut = cc.Text;
            Array.Reverse(nums);

            for (int i = 0; i < l; i++)
            {
                if (Convert.ToString(nums[i]) != "1")
                {
                    if (Convert.ToString(nums[i]) != "0")
                    {
                        T = false;
                    }
                }
            }

            if (T == true)

            {
                for (int x = 0; x < l; x++)
                {
                    if (Convert.ToString(nums[x]) == "1")
                    {
                        //ask about character limit being 18 
                        DI += Convert.ToInt32(Math.Pow(2, x));

                    }
                }
            }
            else
            {
                MessageBox.Show("No Benuo, Please enter only 1 and 0's");
            }
            dtotal = DI;
            cc.Text = Convert.ToString(dtotal);
            #endregion

            #region hexadecimal
            zz.Text = Convert.ToString(DI, 16);
            #endregion

            #region Octa
            vv.Text = Convert.ToString(DI, 8);
            #endregion

            #region BinarytoAscii
            {
                {                  
                    {
                        string tempString = "";
                        string Character = System.Text.RegularExpressions.Regex.Replace(input.Text, "[^01]", "");
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

        private void Form1_Load(object sender, EventArgs e)
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
                #region Binary to decimal    
                bool T = true;
                string bin = input.Text;
                int l = bin.Length;
                char[] nums = bin.ToCharArray();
                int DI = 0;
                String DOut = cc.Text;
                Array.Reverse(nums);

                for (int i = 0; i < l; i++)
                {
                    if (Convert.ToString(nums[i]) != "1")
                    {
                        if (Convert.ToString(nums[i]) != "0")
                        {
                            T = false;
                        }
                    }
                }

                if (T == true)

                {
                    for (int x = 0; x < l; x++)
                    {
                        if (Convert.ToString(nums[x]) == "1")
                        {
                            //ask about character limit being 18 
                            DI += Convert.ToInt32(Math.Pow(2, x));

                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Benuo, Please enter only 1 and 0's");
                }
                dtotal = DI;
                cc.Text = Convert.ToString(dtotal);
                #endregion

                #region hexadecimal
                zz.Text = Convert.ToString(DI, 16);
                #endregion

                #region Octa
                vv.Text = Convert.ToString(DI, 8);
                #endregion

                #region BinarytoAscii
                {
                    {
                        {
                            string tempString = "";
                            string Character = System.Text.RegularExpressions.Regex.Replace(input.Text, "[^01]", "");
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

        private void Text_Click(object sender, EventArgs e)
        {

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
    }
}