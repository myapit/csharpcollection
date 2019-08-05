/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 2018-10-29
 * Time: 3:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;


namespace PusatData
{
	/// <summary>
	/// Description of JoomlaMigrate.
	/// </summary>
	public partial class JoomlaMigrate : Form
	{
		private System.Windows.Forms.OpenFileDialog openFileDialog1;  
		private string DBName;
		private SQLiteConnection sqlcon;
		
		public JoomlaMigrate()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			 int size = -1;
			 this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog(); 
			    DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
			    if (result == DialogResult.OK) // Test result.
			    {
			       string file = openFileDialog1.FileName;
			       try
			       {
			          string text = File.ReadAllText(file);
			          size = text.Length;
			          label1.Text = openFileDialog1.FileName;
			          DBName = openFileDialog1.FileName;
			       }
			       catch (IOException)
			       {
			       }
			    }
			    Console.WriteLine(size); // <-- Shows file size in debugging mode.
			    Console.WriteLine(result); // <-- For debugging use.
		}
		void DataGrid1Navigate(object sender, NavigateEventArgs ne)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			sqlcon = new SQLiteConnection("Data Source=" + DBName +";Version=3;");
			sqlcon.Open();
			
			string query = "select urlserver from DataServer where urlserver IN (select url from DataAzrul)";
			SQLiteCommand cmdSQL = new SQLiteCommand(query, sqlcon);
			SQLiteDataReader readSQL = cmdSQL.ExecuteReader();
			int kira = 0;
			while (readSQL.Read())
			{
				dataGridView1.Rows.Add( new object[] {
				                       	readSQL.GetValue(readSQL.GetOrdinal("urlserver"))
				                       });
				++kira;
			}
			label2.Text = "Jumlah rekod : " + kira;
		}
	}
}
