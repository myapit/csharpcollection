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
	}
	
	



}
