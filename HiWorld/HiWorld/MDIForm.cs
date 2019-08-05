/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 2018-09-19
 * Time: 1:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;

namespace HiWorld
{
	/// <summary>
	/// Description of MDIForm.
	/// </summary>
	public partial class MDIForm : Form
	{
		public MDIForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			//Image mybg = Resources.beskat;
			
			//Bitmap mybg = new Bitmap(
			//	System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream("HiWorld.Resources1.beskat")
			//);
				
//			string[] all = System.Reflection.Assembly.GetEntryAssembly().
//				  GetManifestResourceNames();
//				
//				foreach (string one in all) {
//				    MessageBox.Show(one);
//				}
//			
//			Object rm = global::Properties.Resources.ResourceManager.GetObject("beskat");
//			Bitmap myImage = (Bitmap)rm;
//			Image image = myImage;
							
//			foreach (Control cntrl in this.Controls)
//            {
//                if (cntrl is MdiClient)
//                {
//                    cntrl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
//                   // cntrl.BackgroundImage = Properties.Resources.Apartment_Rentals_For_Families;
//                }
//            }
//						
			
			statusStrip1.Items[0].Text = "ver:"+Application.ProductVersion;
			statusStrip1.Items[2].Text = DateTime.Today.ToString();
			
		}
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			//DialogResult confirm = MessageBox.Show("Are you sure to close this application ?","Exit App", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			//if (confirm == DialogResult.Yes)
			//{
				System.Windows.Forms.Application.Exit();
			//}
		}
		void OpenMainFormToolStripMenuItemClick(object sender, EventArgs e)
		{
			bool isOpenForm = false;
			
			foreach( Form f in Application.OpenForms)
			{
				if (f.Name == "MainForm") 
				{
					isOpenForm = true;
					f.BringToFront();
					break;
				}
			}
			
			if (isOpenForm == false) 
			{
				Form MForm = new MainForm();
				MForm.MdiParent = this;
				MForm.Show();
			}
			
			//menuStrip1.Items.Find("processFormToolStripMenuItem",true) = false;
			
		}
		
		void OpenForm2ToolStripMenuItemClick(object sender, EventArgs e)
		{
			bool isOpenForm = false;
			
			foreach( Form f in Application.OpenForms)
			{
				if (f.Name == "Form2") 
				{
					isOpenForm = true;
					f.BringToFront();
					break;
				}
			}
			
			if (isOpenForm == false)
			{
				Form frm1 = new Form2();
				frm1.MdiParent = this;
				frm1.Show();
			}
			
			
		}
		
		
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if ( MessageBox.Show("Are you sure to close this application ?", "Close Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				e.Cancel = true;
			}
		}
		void NewToolStripButtonClick(object sender, EventArgs e)
		{
			MessageBox.Show("New ?");
		}
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
	}
}
