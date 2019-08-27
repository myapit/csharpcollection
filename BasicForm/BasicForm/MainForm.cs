/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 2019-06-25
 * Time: 10:57 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Security.Cryptography;  
using System.Configuration;

namespace BasicForm
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
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
			MessageBox.Show("Owh, hi, am i running on Arch Linux ? if yes, i'm very happy");
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
			MessageBox.Show("This is a message...", "Test", MessageBoxButtons.OKCancel);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			//static readonly 
				string textFile = @"auth.db";
			
			if (!File.Exists(textFile))
			{
				string createText = "admin" + Environment.NewLine +"8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918";
				File.WriteAllText(textFile, createText);
								
			}else{
				string[] lines = File.ReadAllLines(textFile);
				foreach (string line in lines)  
				System.Diagnostics.Debug.WriteLine(line);
			}
			/*
			 * using(StreamWriter writetext = new StreamWriter("write.txt"))
			{
			writetext.WriteLine("writing in text file");
			}
			Reading a text file:
			
			using(StreamReader readtext = new StreamReader("readme.txt"))
			{
			string readMeText = readtext.ReadLine();
			}
			*/
		}//end btn

 		static string ComputeSha256Hash(string rawData)  
        {  
              byte[] bytes = Encoding.UTF8.GetBytes(rawData);
		        SHA256Managed hashstring = new SHA256Managed();
		        byte[] hash = hashstring.ComputeHash(bytes);
		        string hashString = string.Empty;
		        foreach (byte x in hash)
		        {
		            hashString += String.Format("{0:x2}", x);
		        }
		        return hashString;
 		}


		
		void BtnCheckClick(object sender, EventArgs e)
		{
			//static readonly 
				string textFile = @"auth.db";

				string[] lines = File.ReadAllLines(textFile);
				//foreach (string line in lines)  
				System.Diagnostics.Debug.WriteLine(ComputeSha256Hash(txtPass.Text));
				System.Diagnostics.Debug.WriteLine(lines[1]);
				
				if ( txtUser.Text == lines[0] && ComputeSha256Hash(txtPass.Text) == lines[1])
				{
					MessageBox.Show("correct");
				}else{
					MessageBox.Show(" in Correct");
				}
				if (Control.IsKeyLocked(Keys.CapsLock)) {  
				    MessageBox.Show("The Caps Lock key is ON.");  
				} 
		}
		
		
		void Button4Click(object sender, EventArgs e)
		{
		    // Load application configuration file so we can update it
		   // var configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
		
		   // configuration.AppSettings.Settings["username"].Value = EncryptString("new username", configPassword);
		   // configuration.AppSettings.Settings["password"].Value = EncryptString("new password", configPassword);
		   // configuration.Save();
		
		    // Reload app config file
		   // ConfigurationManager.RefreshSection("appSettings");
		   
		   string msg = Settings1.Default.DBName;
		   MessageBox.Show(msg);
		}//end button config
		
		
		void Button5Click(object sender, EventArgs e)
		{
				System.Diagnostics.Debug.WriteLine(Settings1.Default.DBName);
				System.Diagnostics.Debug.WriteLine(ConfigurationSettings.AppSettings["DBName"]);
				//System.Diagnostics.Debug.WriteLine(System.Configuration.);
			
		} //end button config
	}
	
}
