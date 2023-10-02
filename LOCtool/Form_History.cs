using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOCtool
{
    public partial class Form_History : Form
    {
        public Form_History()
        {
            InitializeComponent();
            lopchung = new LopDungChung(); 
        }

        LopDungChung lopchung;

        private void Form_History_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            string sqlLoadData = "select * from DATA";
            dataGridView1.DataSource = lopchung.LoadDuLieu(sqlLoadData);
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["LOCtool"] == null)
            {
                LOCtool lt = new LOCtool();
                lt.Show();
            }
            else
            {
                Application.OpenForms["LOCtool"].Activate();
            }
            
        }



        private void bt_delete_Click(object sender, EventArgs e)
        {
            string sqlDelete = "delete from DATA where File = '" + txt_linkfile_his + "' ";
            lopchung.Nonquery(sqlDelete);
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_linkfile_his.Text = dataGridView1.CurrentRow.Cells["File"].Value.ToString();
        }

        private void bt_deleteALL_Click(object sender, EventArgs e)
        {
            string sqlDelete = "delete from DATA";
            MessageBox.Show("Are you sure you want to delete ALL?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            lopchung.Nonquery(sqlDelete);
            LoadData();
        }

        private void bt_backtomain_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form_chinh"] == null)
            {
                Form_chinh lt = new Form_chinh();
                lt.Show();
            }
            else
            {
                Application.OpenForms["Form_chinh"].Activate();
            }
            
        }
    }
}
