using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.Data.Common;

namespace SQLiteProtect
{
    public partial class MySQLITE : Form
    {
        public MySQLITE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog myfile  = new OpenFileDialog();
            myfile.Filter = "SQLite Database |*.db; *.db3";

            if ( myfile.ShowDialog() == DialogResult.OK)
            {
                string mypath = null;
                Path.GetExtension(myfile.FileName);
                mypath = myfile.FileName;
                textBox1.Text = mypath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection myconn = new SQLiteConnection("Data Source=" + textBox1.Text + ";Version=3");
            myconn.Open();
           /// sqlite password tak support dah laaaa

        }
    }
}
