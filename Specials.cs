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
    public partial class Specials : Form
    {
        //spcials from the file
        private SpcList CurSpc = new SpcList();
        //order file list
        public SpcList OrdSpc = new SpcList();
        
        private bool Admin = false;
        private string tableNum = null;


        public Specials(bool isAdmin, string TabNum)
        {
            InitializeComponent();
            Admin = isAdmin;
            tableNum = TabNum;
        }
             
        //public Specials()
        //{
         //   InitializeComponent();
        //}

        //read the specals file and add populate the array
        private void Specials_Load(object sender, EventArgs e)
        {
            //if it is ordering time resize the from and add controls
            if (!Admin) 
            {
                this.Size = new System.Drawing.Size(319+40, 265+70);
            }
            
            //get desktop path 
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Specials";

            //ensure directory exists, if not create it
            if (!(Directory.Exists(path)))
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
            }
            path += "\\Specials.txt";

            // Determine whether the File exists.
            if (!(File.Exists(path)))
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                fs.Close();
                //                    DialogResult Message = MessageBox.Show(this, "There are no Specials at this time", "Sorry");
            }

            CurSpc = CurSpc.FileToList(path);
            boxSpcList.DataSource = CurSpc.toStringList();
            if (CurSpc.Count != 0)
            {
                boxSpcList.SetSelected(0, false);
            }
            boxSpcList.Refresh();
        }

        private void boxSpcList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Admin == false)
            {
                return;
            }
            //DialogResult adf = MessageBox.Show(this, "Checkpoint");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (boxSpcList.SelectedIndex == -1)
            {
                return;
            }
            OrdSpc.Add(CurSpc[boxSpcList.SelectedIndex]);
            boxOrders.DataSource = OrdSpc.toStringList();
            if (OrdSpc.Count != 0)
            {
                boxOrders.SetSelected(0, false);
                boxSpcList.SetSelected(0, false);
            }
            boxOrders.Refresh();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (boxOrders.SelectedIndex == -1)
            {
                return;
            }
            OrdSpc.RemoveAt(boxOrders.SelectedIndex);
            boxOrders.DataSource = OrdSpc.toStringList();
            if (OrdSpc.Count != 0)
            {
                boxOrders.SetSelected(0, false);
                boxSpcList.SetSelected(0, false);
            }
            boxOrders.Refresh();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            //Write the the OrdSpc list to the Request file
            try
            {
                //get desktop path 
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Tables";

                if (!(Directory.Exists(path)))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }
                path += "\\Request.txt";

                // Create file if it is not there
                if (!File.Exists(path))
                {
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    fs.Close();
                }

                OrdSpc.ListToFile(path, tableNum, true);
                                
            }

            catch (Exception exc)
            {
                Console.WriteLine("The process failed: {0}", exc.ToString());
               // DialogResult result = MessageBox.Show(this, "The process failed: " + exc.ToString(), "Error");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

       
    }
}
