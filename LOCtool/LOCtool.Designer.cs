namespace LOCtool
{
    partial class LOCtool
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_chonfile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_linkfile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NCLOC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CLOC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_totallength = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_density = new System.Windows.Forms.TextBox();
            this.bt_tinhtoan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.historyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_luu = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tenfile = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_xemfile = new System.Windows.Forms.Button();
            this.bt_backtomain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOC TOOL";
            // 
            // bt_chonfile
            // 
            this.bt_chonfile.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_chonfile.Location = new System.Drawing.Point(616, 143);
            this.bt_chonfile.Name = "bt_chonfile";
            this.bt_chonfile.Size = new System.Drawing.Size(90, 46);
            this.bt_chonfile.TabIndex = 1;
            this.bt_chonfile.Text = "Select file";
            this.bt_chonfile.UseVisualStyleBackColor = false;
            this.bt_chonfile.Click += new System.EventHandler(this.bt_chonfile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_linkfile
            // 
            this.txt_linkfile.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_linkfile.Location = new System.Drawing.Point(178, 155);
            this.txt_linkfile.Name = "txt_linkfile";
            this.txt_linkfile.Size = new System.Drawing.Size(411, 22);
            this.txt_linkfile.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Link file :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(271, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "(non-commented source line of code or effective)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(271, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "(Commented source line of code)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(55, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "NCLOC :";
            // 
            // txt_NCLOC
            // 
            this.txt_NCLOC.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_NCLOC.Location = new System.Drawing.Point(119, 347);
            this.txt_NCLOC.Name = "txt_NCLOC";
            this.txt_NCLOC.Size = new System.Drawing.Size(146, 22);
            this.txt_NCLOC.TabIndex = 10;
            this.txt_NCLOC.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(55, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "CLOC :";
            // 
            // txt_CLOC
            // 
            this.txt_CLOC.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_CLOC.Location = new System.Drawing.Point(119, 383);
            this.txt_CLOC.Name = "txt_CLOC";
            this.txt_CLOC.Size = new System.Drawing.Size(146, 22);
            this.txt_CLOC.TabIndex = 12;
            this.txt_CLOC.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(55, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "=> Total length :";
            // 
            // txt_totallength
            // 
            this.txt_totallength.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_totallength.Location = new System.Drawing.Point(161, 422);
            this.txt_totallength.Name = "txt_totallength";
            this.txt_totallength.Size = new System.Drawing.Size(146, 22);
            this.txt_totallength.TabIndex = 14;
            this.txt_totallength.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(55, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "=> The density of comments in a file code :";
            // 
            // txt_density
            // 
            this.txt_density.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_density.Location = new System.Drawing.Point(331, 461);
            this.txt_density.Name = "txt_density";
            this.txt_density.Size = new System.Drawing.Size(258, 22);
            this.txt_density.TabIndex = 16;
            this.txt_density.Text = "0";
            // 
            // bt_tinhtoan
            // 
            this.bt_tinhtoan.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_tinhtoan.Location = new System.Drawing.Point(55, 253);
            this.bt_tinhtoan.Name = "bt_tinhtoan";
            this.bt_tinhtoan.Size = new System.Drawing.Size(155, 38);
            this.bt_tinhtoan.TabIndex = 17;
            this.bt_tinhtoan.Text = "Calculate";
            this.bt_tinhtoan.UseVisualStyleBackColor = false;
            this.bt_tinhtoan.Click += new System.EventHandler(this.bt_tinhtoan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "PARAMETERS :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.historyToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1443, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.historyToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 6);
            // 
            // historyToolStripMenuItem1
            // 
            this.historyToolStripMenuItem1.Name = "historyToolStripMenuItem1";
            this.historyToolStripMenuItem1.Size = new System.Drawing.Size(70, 24);
            this.historyToolStripMenuItem1.Text = "History";
            this.historyToolStripMenuItem1.Click += new System.EventHandler(this.historyToolStripMenuItem1_Click);
            // 
            // txt_luu
            // 
            this.txt_luu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_luu.Location = new System.Drawing.Point(50, 540);
            this.txt_luu.Name = "txt_luu";
            this.txt_luu.Size = new System.Drawing.Size(139, 62);
            this.txt_luu.TabIndex = 20;
            this.txt_luu.Text = "Save";
            this.txt_luu.UseVisualStyleBackColor = false;
            this.txt_luu.Click += new System.EventHandler(this.txt_luu_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_reset.Location = new System.Drawing.Point(217, 540);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(140, 62);
            this.bt_reset.TabIndex = 21;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Name File :";
            // 
            // txt_tenfile
            // 
            this.txt_tenfile.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_tenfile.Location = new System.Drawing.Point(178, 201);
            this.txt_tenfile.Name = "txt_tenfile";
            this.txt_tenfile.Size = new System.Drawing.Size(411, 22);
            this.txt_tenfile.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(782, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(649, 919);
            this.textBox1.TabIndex = 33;
            // 
            // bt_xemfile
            // 
            this.bt_xemfile.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_xemfile.Location = new System.Drawing.Point(237, 253);
            this.bt_xemfile.Name = "bt_xemfile";
            this.bt_xemfile.Size = new System.Drawing.Size(155, 38);
            this.bt_xemfile.TabIndex = 32;
            this.bt_xemfile.Text = "View File :";
            this.bt_xemfile.UseVisualStyleBackColor = false;
            this.bt_xemfile.Click += new System.EventHandler(this.bt_xemfile_Click);
            // 
            // bt_backtomain
            // 
            this.bt_backtomain.Location = new System.Drawing.Point(50, 637);
            this.bt_backtomain.Name = "bt_backtomain";
            this.bt_backtomain.Size = new System.Drawing.Size(175, 27);
            this.bt_backtomain.TabIndex = 35;
            this.bt_backtomain.Text = "Back to Main Windown";
            this.bt_backtomain.UseVisualStyleBackColor = true;
            this.bt_backtomain.Click += new System.EventHandler(this.bt_backtomain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOCtool.Properties.Resources.logo_duy_tan_vn;
            this.pictureBox1.Location = new System.Drawing.Point(0, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LOCtool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 1055);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_backtomain);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_xemfile);
            this.Controls.Add(this.txt_tenfile);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.txt_luu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_tinhtoan);
            this.Controls.Add(this.txt_density);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_totallength);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_CLOC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_NCLOC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_linkfile);
            this.Controls.Add(this.bt_chonfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LOCtool";
            this.Text = "LOCtool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_chonfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_linkfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_NCLOC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_CLOC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_totallength;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_density;
        private System.Windows.Forms.Button bt_tinhtoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button txt_luu;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tenfile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_xemfile;
        private System.Windows.Forms.Button bt_backtomain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}