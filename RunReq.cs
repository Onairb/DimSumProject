using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace COMPortTerminal
{
    public partial class RunReq : Form
    {
        private string tableNum = null;
        private SpcList Reqs = new SpcList();
        public int indexDone = -1;

        public RunReq(string TabNum)
        {
            InitializeComponent();
            tableNum = TabNum;
                        
        }

        private void RunReq_Load(object sender, EventArgs e)
        {
            //get desktop path 
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Tables";

            //ensure directory exists, if not create it
            if (!(Directory.Exists(path)))
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
            }
            path += "\\Request.txt";

            // Determine whether the File exists.
            if (!(File.Exists(path)))
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                fs.Close();
                //                    DialogResult Message = MessageBox.Show(this, "There are no Specials at this time", "Sorry");
            }

            Reqs = Reqs.FileToOrders(path);
            boxRunReq.DataSource = Reqs.toStringList();
            if (Reqs.Count != 0)
            {
                boxRunReq.SetSelected(0, false);
            }
            boxRunReq.Refresh();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void boxRunReq_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexDone = boxRunReq.SelectedIndex;
        }

        private void butBeep_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        
    }
}
