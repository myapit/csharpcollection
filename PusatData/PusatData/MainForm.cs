/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 2018-10-09
 * Time: 2:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Input;


namespace PusatData
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
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

		
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			label1.Text = "Code:" + e.KeyChar;
			textBox1.Text="";
			textBox1.Focus();
		}

		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			///EventManager.RegisterClassHandler(typeof(Window),Keyboard.KeyUpEvent,new KeyEventHandler(keyUp), true);
			label1.Text = "Code:" + e.KeyCode.ToString();
			textBox1.Text="";
			textBox1.Focus();
		}
		
		
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			//handle your keys here
			return false;
		}
		void Button1Click(object sender, EventArgs e)
		{
			JoomlaMigrate jmFRM = new JoomlaMigrate();
			jmFRM.Show();
			//this.Close();
		}
				
		
	}
}
