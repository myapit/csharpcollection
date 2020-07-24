using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

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
            OpenFileDialog myfile = new OpenFileDialog();
            myfile.Filter = "SQLite Database |*.db; *.db3";

            if (myfile.ShowDialog() == DialogResult.OK)
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

            //myconn.ChangePassword();
            /// sqlite password tak support dah laaaa

            //    var connectionString = new SqliteConnectionStringBuilder("Data Source=" + textBox1.Text + ";Version=3")
            //    {
            //        Mode = SqliteOpenMode.ReadWriteCreate,
            //        Password = password
            //    }.ToString();
            //    //To change the password you would do the following:

            //var command = connection.CreateCommand();
            //    command.CommandText = "SELECT quote($newPassword);";
            //    command.Parameters.AddWithValue("$newPassword", newPassword);
            //    var quotedNewPassword = (string)command.ExecuteScalar();

            //    command.CommandText = "PRAGMA rekey = " + quotedNewPassword;
            //    command.Parameters.Clear();
            //    command.ExecuteNonQuery();
        }
    }
}
