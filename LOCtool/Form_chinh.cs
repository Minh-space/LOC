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
    public partial class Form_chinh : Form
    {
        public Form_chinh()
        {
            InitializeComponent();
        }

        private void BT_thanhviennhom_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form_Member"] == null)
            {
                Form_Member fm = new Form_Member();
                fm.Show();
            }
            else
            {
                Application.OpenForms["Form_Member"].Activate();
            }
        }

        private void bt_Loctool_Click(object sender, EventArgs e)
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

        private void bt_history_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form_History"] == null)
            {
                Form_History fh = new Form_History();
                fh.Show();
            }
            else
            {
                Application.OpenForms["Form_History"].Activate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Are you sure about that ?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
