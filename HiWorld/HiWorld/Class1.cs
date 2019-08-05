/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 2018-09-14
 * Time: 3:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Data.SQLite;
using System;
using System.Windows.Forms;

namespace HiWorld
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Class1
	{
		public Class1()
		{
		}
		
		public static void createDB()
		{
			if (System.IO.File.Exists("pb") == false )
			{
			 SQLiteConnection.CreateFile("pb");

			SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=pb;Version=3;");
			m_dbConnection.Open();
			
			string sql = "create table highscores (name varchar(20), score int)";
			
			SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
			command.ExecuteNonQuery();
			
			sql = "insert into highscores (name, score) values ('Mexx', 9001)";
			
			command = new SQLiteCommand(sql, m_dbConnection);
			command.ExecuteNonQuery();
			
			m_dbConnection.Close();                  	
			}
			
		}
		
		public static void barGen()
		{
			string barcode = Application.OpenForms["MainForm"].Controls["textBox1"].Text;
				//Program.MainForm.textBox1.Text;
			
			MessageBox.Show(barcode.ToString(), "barcode");
			
			////MessageBox.Show(barcode,"hi",MessageBoxButtons.OK);
			//Bitmap bitmap = new b
		}
	}
}
