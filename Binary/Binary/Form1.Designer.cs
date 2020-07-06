namespace Binary
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.input = new System.Windows.Forms.TextBox();
            this.convert = new System.Windows.Forms.Button();
            this.backborder = new System.Windows.Forms.Panel();
            this.help4 = new System.Windows.Forms.Label();
            this.help3 = new System.Windows.Forms.Label();
            this.help2 = new System.Windows.Forms.Label();
            this.help1 = new System.Windows.Forms.Label();
            this.Binarytitle = new System.Windows.Forms.Label();
            this.decimaltitle = new System.Windows.Forms.Label();
            this.Asciititle = new System.Windows.Forms.Label();
            this.octtitle = new System.Windows.Forms.Label();
            this.xx = new System.Windows.Forms.Label();
            this.vv = new System.Windows.Forms.Label();
            this.zz = new System.Windows.Forms.Label();
            this.cc = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.bintitle = new System.Windows.Forms.Label();
            this.help5 = new System.Windows.Forms.Label();
            this.help6 = new System.Windows.Forms.Label();
            this.allbox = new System.Windows.Forms.Panel();
            this.backborder.SuspendLayout();
            this.allbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(202, 53);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(193, 20);
            this.input.TabIndex = 0;
            // 
            // convert
            // 
            this.convert.BackColor = System.Drawing.Color.Black;
            this.convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convert.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert.ForeColor = System.Drawing.Color.Red;
            this.convert.Location = new System.Drawing.Point(202, 79);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(193, 73);
            this.convert.TabIndex = 14;
            this.convert.Text = "Convert my input!";
            this.convert.UseVisualStyleBackColor = false;
            this.convert.Click += new System.EventHandler(this.convert_Click_1);
            // 
            // backborder
            // 
            this.backborder.BackColor = System.Drawing.Color.Black;
            this.backborder.Controls.Add(this.help4);
            this.backborder.Controls.Add(this.help3);
            this.backborder.Controls.Add(this.help2);
            this.backborder.Controls.Add(this.help1);
            this.backborder.Controls.Add(this.Binarytitle);
            this.backborder.Controls.Add(this.decimaltitle);
            this.backborder.Controls.Add(this.Asciititle);
            this.backborder.Controls.Add(this.octtitle);
            this.backborder.Controls.Add(this.xx);
            this.backborder.Controls.Add(this.vv);
            this.backborder.Controls.Add(this.zz);
            this.backborder.Controls.Add(this.cc);
            this.backborder.Location = new System.Drawing.Point(75, 163);
            this.backborder.Name = "backborder";
            this.backborder.Size = new System.Drawing.Size(481, 249);
            this.backborder.TabIndex = 33;
            // 
            // help4
            // 
            this.help4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.help4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help4.Location = new System.Drawing.Point(256, 174);
            this.help4.Name = "help4";
            this.help4.Size = new System.Drawing.Size(196, 60);
            this.help4.TabIndex = 29;
            this.help4.Text = "An ASCII output will appear here after inputting Binary and pressing the \"Convert" +
    " my input button\".";
            this.help4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.help4.Visible = false;
            // 
            // help3
            // 
            this.help3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.help3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help3.Location = new System.Drawing.Point(42, 174);
            this.help3.Name = "help3";
            this.help3.Size = new System.Drawing.Size(196, 60);
            this.help3.TabIndex = 28;
            this.help3.Text = "A Octal output will appear here after inputting Binary and pressing the \"Convert " +
    "my input button\".";
            this.help3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.help3.Visible = false;
            // 
            // help2
            // 
            this.help2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.help2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help2.Location = new System.Drawing.Point(256, 70);
            this.help2.Name = "help2";
            this.help2.Size = new System.Drawing.Size(196, 60);
            this.help2.TabIndex = 27;
            this.help2.Text = "A Hexacimal output will appear here after inputting Binary and pressing the \"Conv" +
    "ert my input button\".";
            this.help2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.help2.Visible = false;
            // 
            // help1
            // 
            this.help1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.help1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help1.Location = new System.Drawing.Point(42, 70);
            this.help1.Name = "help1";
            this.help1.Size = new System.Drawing.Size(196, 60);
            this.help1.TabIndex = 26;
            this.help1.Text = "A Decimal output will appear here after inputting Binary and pressing the \"Conver" +
    "t my input button\".";
            this.help1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.help1.Visible = false;
            // 
            // Binarytitle
            // 
            this.Binarytitle.BackColor = System.Drawing.Color.Black;
            this.Binarytitle.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Binarytitle.ForeColor = System.Drawing.Color.Red;
            this.Binarytitle.Location = new System.Drawing.Point(51, 19);
            this.Binarytitle.Name = "Binarytitle";
            this.Binarytitle.Size = new System.Drawing.Size(176, 33);
            this.Binarytitle.TabIndex = 24;
            this.Binarytitle.Text = "Decimal";
            this.Binarytitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decimaltitle
            // 
            this.decimaltitle.BackColor = System.Drawing.Color.Black;
            this.decimaltitle.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimaltitle.ForeColor = System.Drawing.Color.Red;
            this.decimaltitle.Location = new System.Drawing.Point(262, 19);
            this.decimaltitle.Name = "decimaltitle";
            this.decimaltitle.Size = new System.Drawing.Size(176, 33);
            this.decimaltitle.TabIndex = 23;
            this.decimaltitle.Text = "Hexadecimal";
            this.decimaltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Asciititle
            // 
            this.Asciititle.BackColor = System.Drawing.Color.Black;
            this.Asciititle.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Asciititle.ForeColor = System.Drawing.Color.Red;
            this.Asciititle.Location = new System.Drawing.Point(262, 130);
            this.Asciititle.Name = "Asciititle";
            this.Asciititle.Size = new System.Drawing.Size(176, 39);
            this.Asciititle.TabIndex = 22;
            this.Asciititle.Text = "ASCII";
            this.Asciititle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // octtitle
            // 
            this.octtitle.BackColor = System.Drawing.Color.Black;
            this.octtitle.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octtitle.ForeColor = System.Drawing.Color.Red;
            this.octtitle.Location = new System.Drawing.Point(51, 130);
            this.octtitle.Name = "octtitle";
            this.octtitle.Size = new System.Drawing.Size(176, 39);
            this.octtitle.TabIndex = 21;
            this.octtitle.Text = "Octal";
            this.octtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xx
            // 
            this.xx.BackColor = System.Drawing.Color.Red;
            this.xx.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xx.Location = new System.Drawing.Point(256, 174);
            this.xx.Name = "xx";
            this.xx.Size = new System.Drawing.Size(196, 60);
            this.xx.TabIndex = 16;
            this.xx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vv
            // 
            this.vv.BackColor = System.Drawing.Color.Red;
            this.vv.Font = new System.Drawing.Font("Cooper Black", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vv.Location = new System.Drawing.Point(42, 174);
            this.vv.Name = "vv";
            this.vv.Size = new System.Drawing.Size(196, 60);
            this.vv.TabIndex = 15;
            this.vv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zz
            // 
            this.zz.BackColor = System.Drawing.Color.Red;
            this.zz.Font = new System.Drawing.Font("Cooper Black", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zz.Location = new System.Drawing.Point(256, 70);
            this.zz.Name = "zz";
            this.zz.Size = new System.Drawing.Size(196, 60);
            this.zz.TabIndex = 14;
            this.zz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cc
            // 
            this.cc.BackColor = System.Drawing.Color.Red;
            this.cc.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cc.Location = new System.Drawing.Point(42, 70);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(196, 60);
            this.cc.TabIndex = 12;
            this.cc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Black;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(589, 10);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(42, 48);
            this.Exit.TabIndex = 34;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Black;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.ForeColor = System.Drawing.Color.Red;
            this.b1.Location = new System.Drawing.Point(500, 10);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(83, 48);
            this.b1.TabIndex = 35;
            this.b1.Text = "Back";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click_1);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Black;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.ForeColor = System.Drawing.Color.Red;
            this.help.Location = new System.Drawing.Point(411, 10);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(83, 48);
            this.help.TabIndex = 36;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.button1_Click);
            // 
            // bintitle
            // 
            this.bintitle.BackColor = System.Drawing.Color.Transparent;
            this.bintitle.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bintitle.ForeColor = System.Drawing.Color.Black;
            this.bintitle.Location = new System.Drawing.Point(169, 11);
            this.bintitle.Name = "bintitle";
            this.bintitle.Size = new System.Drawing.Size(265, 39);
            this.bintitle.TabIndex = 37;
            this.bintitle.Text = "Binary Input";
            this.bintitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // help5
            // 
            this.help5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.help5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help5.Location = new System.Drawing.Point(10, 11);
            this.help5.Name = "help5";
            this.help5.Size = new System.Drawing.Size(186, 140);
            this.help5.TabIndex = 38;
            this.help5.Text = resources.GetString("help5.Text");
            this.help5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.help5.Visible = false;
            // 
            // help6
            // 
            this.help6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.help6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help6.Location = new System.Drawing.Point(420, 74);
            this.help6.Name = "help6";
            this.help6.Size = new System.Drawing.Size(214, 77);
            this.help6.TabIndex = 39;
            this.help6.Text = "Note: You must have a Binary input for this part of the program to work! Press \"H" +
    "elp\" to toggle help, \"Back\" to return to main menu and \"X\" to exit program!\r\n";
            this.help6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.help6.Visible = false;
            // 
            // allbox
            // 
            this.allbox.BackColor = System.Drawing.Color.Transparent;
            this.allbox.Controls.Add(this.help6);
            this.allbox.Controls.Add(this.help5);
            this.allbox.Controls.Add(this.help);
            this.allbox.Controls.Add(this.b1);
            this.allbox.Controls.Add(this.Exit);
            this.allbox.Controls.Add(this.backborder);
            this.allbox.Controls.Add(this.convert);
            this.allbox.Controls.Add(this.input);
            this.allbox.Controls.Add(this.bintitle);
            this.allbox.Location = new System.Drawing.Point(2, 2);
            this.allbox.Name = "allbox";
            this.allbox.Size = new System.Drawing.Size(642, 429);
            this.allbox.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Binary.Properties.Resources.binary;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 438);
            this.Controls.Add(this.allbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.backborder.ResumeLayout(false);
            this.allbox.ResumeLayout(false);
            this.allbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Panel backborder;
        private System.Windows.Forms.Label help4;
        private System.Windows.Forms.Label help3;
        private System.Windows.Forms.Label help2;
        private System.Windows.Forms.Label help1;
        private System.Windows.Forms.Label Binarytitle;
        private System.Windows.Forms.Label decimaltitle;
        private System.Windows.Forms.Label Asciititle;
        private System.Windows.Forms.Label octtitle;
        private System.Windows.Forms.Label xx;
        private System.Windows.Forms.Label vv;
        private System.Windows.Forms.Label zz;
        private System.Windows.Forms.Label cc;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Label bintitle;
        private System.Windows.Forms.Label help5;
        private System.Windows.Forms.Label help6;
        private System.Windows.Forms.Panel allbox;
    }
}

