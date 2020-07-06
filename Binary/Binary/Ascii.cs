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
    public partial class Ascii : Form
    {
        int dtotal = 0;
        public Ascii()
        {
            InitializeComponent();
        }

        
    

        private void b1_Click(object sender, EventArgs e)
        {
            this.Hide();
            G.M.Show();

        }

        private void help1_Click(object sender, EventArgs e)
        {

        }

        private void convert_Click(object sender, EventArgs e)
        {
            help1.Visible = false;
            help2.Visible = false;
            help3.Visible = false;
            help4.Visible = false;
            help5.Visible = false;
            help6.Visible = false;
            {
                #region variabels 
                int r;
                char[] L = input.Text.ToCharArray();
                Byte[] d = Encoding.ASCII.GetBytes(L);
                int[] B8 = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
                int Len = d.Length;
                String B = String.Empty;
                #endregion
                #region Ascii t binary 
                if (input.Text == "")
                {
                    MessageBox.Show("PLease enter a character");
                }
                //while 'i' is less than the length of Dec Array, increase 'i' variable by 1
                for (int i = 0; i < Len; i++)
                {
                    while (d[i] > 0)
                    {
                        r = d[i] % 2;
                        d[i] /= 2;
                        B = r.ToString() + B;
                    }
                }
                BinaryOutput.Text = "0" + B;
                #endregion
                //found binary and are using it to find the rest 
                #region Binary to decimal    
                bool T = true;
                string bin = BinaryOutput.Text;
                int l = bin.Length;
                char[] nums = bin.ToCharArray();
                int DI = 0;
                String DOut = BinaryOutput.Text;
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
                xx.Text = Convert.ToString(dtotal);
                #endregion
                #region hexadecimal
                zz.Text = Convert.ToString(DI, 16);
                #endregion
                #region Octa
                octaoutput.Text = Convert.ToString(DI, 8);
                #endregion


            }
        }

        private void b1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            G.M.Show();
          
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void help3_Click(object sender, EventArgs e)
        {

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
