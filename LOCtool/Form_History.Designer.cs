namespace LOCtool
{
    partial class Form_History
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_linkfile_his = new System.Windows.Forms.TextBox();
            this.bt_deleteALL = new System.Windows.Forms.Button();
            this.bt_backtomain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "HISTORY :";
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(236, 12);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(197, 36);
            this.bt_back.TabIndex = 2;
            this.bt_back.Text = "Back to LOC tool";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(973, 109);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(106, 36);
            this.bt_delete.TabIndex = 3;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Link File :";
            // 
            // txt_linkfile_his
            // 
            this.txt_linkfile_his.Location = new System.Drawing.Point(88, 123);
            this.txt_linkfile_his.Name = "txt_linkfile_his";
            this.txt_linkfile_his.Size = new System.Drawing.Size(530, 22);
            this.txt_linkfile_his.TabIndex = 5;
            // 
            // bt_deleteALL
            // 
            this.bt_deleteALL.Location = new System.Drawing.Point(837, 109);
            this.bt_deleteALL.Name = "bt_deleteALL";
            this.bt_deleteALL.Size = new System.Drawing.Size(106, 36);
            this.bt_deleteALL.TabIndex = 6;
            this.bt_deleteALL.Text = "Delete All";
            this.bt_deleteALL.UseVisualStyleBackColor = true;
            this.bt_deleteALL.Click += new System.EventHandler(this.bt_deleteALL_Click);
            // 
            // bt_backtomain
            // 
            this.bt_backtomain.Location = new System.Drawing.Point(23, 12);
            this.bt_backtomain.Name = "bt_backtomain";
            this.bt_backtomain.Size = new System.Drawing.Size(192, 36);
            this.bt_backtomain.TabIndex = 7;
            this.bt_backtomain.Text = "Back to Main Windown";
            this.bt_backtomain.UseVisualStyleBackColor = true;
            this.bt_backtomain.Click += new System.EventHandler(this.bt_backtomain_Click);
            // 
            // Form_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 550);
            this.Controls.Add(this.bt_backtomain);
            this.Controls.Add(this.bt_deleteALL);
            this.Controls.Add(this.txt_linkfile_his);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_History";
            this.Text = "Form_History";
            this.Load += new System.EventHandler(this.Form_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_linkfile_his;
        private System.Windows.Forms.Button bt_deleteALL;
        private System.Windows.Forms.Button bt_backtomain;
    }
}