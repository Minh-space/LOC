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
    public partial class Form_Member : Form
    {
        public Form_Member()
        {
            InitializeComponent();
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
