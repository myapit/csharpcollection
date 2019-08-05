/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 2018-10-29
 * Time: 4:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PusatData
{
	/// <summary>
	/// Description of MdiForm.
	/// </summary>
	public partial class MdiForm : Form
	{
		public MdiForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void JoomlaMigrateToolStripMenuItemClick(object sender, EventArgs e)
		{
			JoomlaMigrate jmForm = new JoomlaMigrate();
			jmForm.MdiParent = this;
			jmForm.Show();
		}
		void MainFormToolStripMenuItemClick(object sender, EventArgs e)
		{
			MainForm mnForm = new MainForm();
			mnForm.MdiParent = this;
			mnForm.Show();
		}
	}
}
