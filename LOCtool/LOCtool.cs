using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LOCtool
{
    public partial class LOCtool : Form
    {
        
        public LOCtool()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
        }

        Form_History fh = new Form_History();
        LopDungChung lopchung;

        private void bt_chonfile_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            //string fileName = openFileDialog1.FileName;
            //txt_tenfile.Text = fileName.ToString();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Hộp thoại chọn file";
            ofd.Filter = "File Code C++ |*.cpp; |File Code Java |*.java*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txt_linkfile.Text = ofd.FileName;
                txt_tenfile.Text = ofd.SafeFileName;
            }
        }

        // COMMENT
        public bool IsComment(string comment)
        {
            if (comment.Contains("//") || comment.Contains("/*") || comment.Contains("/*")) return true;
            else { return false; }
        }

        public int CountLineofComment(string Comment, string[] data)
        {
            int count = 0;
            int start = 0, end = 0;

            foreach(var c in data)
            {
                if(c == Comment)
                {
                    count ++;
                    continue;
                }
                if(count > 0)
                {
                    if(c.Contains("/*"))
                    {
                        start++;
                        count++;
                    }
                    if(c.Contains("/*"))
                    {
                        end++;
                        count++;
                    } 
                    if(start == end) break;
                    if (c != null) count++;
                }
            }
            return count;
        }
        // END COMMENT
        public bool IsFunction(string line)
        {
            if (line.Contains("//") || line.Contains("/*") || line.Contains("*/")) return false;

            var lines = line.Split(' ');
            var types = new List<string>
            {
                "void", "int", "long", "float", "short", "char", "double", "bool",
                "public", "private", "static", "internal", "protected", "protected internal"
            };

            if (lines.Any(l => types.Contains(l)) && line.EndsWith(")"))
            {
                if (!line.Contains(";"))
                {
                    return true;
                }
            }
            return false;
        } // end bool isfunction

        public int CountLineOfCodeFunction(string functionName, string[] data)
        {
            int count = 0;
            int start = 0, end = 0;

            foreach (var d in data)
            {
                if (d == functionName)
                {
                    count++;
                    continue;
                }
                if (count > 0)
                {
                    if (d.Contains("{"))
                    {
                        start++;
                        count++;
                        continue;
                    }
                    if (d.Contains("}"))
                    {
                        end++;
                        count++;
                        continue;
                    }
                    if (start == end) break;
                    if (d != null)
                        count++;
                }
            }
            return count;
        }

        private void bt_tinhtoan_Click(object sender, EventArgs e)
        {
            var path = txt_linkfile.Text; // Get duong dan file

            double numberOfComment = 0;
            int lineOfComment = 0;
            int numberOfFunction = 0; 
            int lineOfCode = 0;
            double ratio = 0;
            

            var data = File.ReadAllLines(path); // doc toan bo file return stirng

            foreach (var line in data)
            {
                if (IsFunction(line)) // == true 
                {
                    //numberOfFunction++; 
                    int lineCode = CountLineOfCodeFunction(line, data); // dem dong code co trong function
                }
                lineOfCode++;
                if (IsComment(line))
                {
                    numberOfComment++;
                    int lineComment = CountLineofComment(line, data);
                    lineOfCode--;
                }
                
            }
            txt_CLOC.Text = numberOfComment.ToString();
            txt_NCLOC.Text = lineOfCode.ToString();
            double tong = numberOfComment + lineOfCode;
            txt_totallength.Text = tong.ToString();
            ratio = numberOfComment / tong;
            txt_density.Text = Math.Round(ratio,5).ToString();
        }

        private void historyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form_History"] == null)
            {
                Form_History h = new Form_History();
                h.Show();
            }
            else
            {
                Application.OpenForms["Form_History"].Activate();
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            txt_linkfile.ResetText();
            txt_NCLOC.ResetText();
            txt_NCLOC.Text = "0";
            txt_CLOC.ResetText();
            txt_CLOC.Text = "0";
            txt_totallength.ResetText();
            txt_totallength.Text = "0";
            txt_density.ResetText();
            txt_density.Text = "0";
            textBox1.ResetText();
        }

        private void txt_luu_Click(object sender, EventArgs e)
        {
            string sqlLuu = "insert into DATA values ('" + txt_tenfile.Text + "', N'" + txt_NCLOC.Text + "', N'" + txt_CLOC.Text + "', N'" + txt_totallength.Text + "', N'" + txt_density.Text + "')";
            lopchung.Nonquery(sqlLuu);
            fh.LoadData();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_tenfile.ResetText();
            txt_linkfile.ResetText();
            txt_NCLOC.ResetText();
            txt_NCLOC.Text = "0";
            txt_CLOC.ResetText();
            txt_CLOC.Text = "0";
            txt_totallength.ResetText();
            txt_totallength.Text = "0";
            txt_density.ResetText();
            txt_density.Text = "0";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqlLuu = "insert into DATA values ('" + txt_tenfile.Text + "', N'" + txt_NCLOC.Text + "', N'" + txt_CLOC.Text + "', N'" + txt_totallength.Text + "', N'" + txt_density.Text + "')";
            lopchung.Nonquery(sqlLuu);
            fh.LoadData();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_xemfile_Click(object sender, EventArgs e)
        {
            string path = txt_linkfile.Text;
            using (StreamReader sr = new StreamReader(path))
            {
                textBox1.Text = sr.ReadToEnd();
            }
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
