/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 2018-09-19
 * Time: 12:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Text;


namespace HiWorld
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//this.textEditorControl1
		}
		void Form2Load(object sender, EventArgs e)
		{
			txtAutoEnter.Focus();
		}
		
		void TxtAutoEnterTextChanged(object sender, EventArgs e)
		{
			// if (e.KeyCode == Keys.Enter)
			//    {
				 	if( txtAutoEnter.Text.Length == 12)
				 	{
				 		lblOutput.Text = txtAutoEnter.Text;
				 	}
			 //   }
		}
		
		
		private void txtAutoEnter_KeyDown(object sender, KeyEventArgs e)
        {
			//MessageBox.Show(e.KeyCode.ToString());
            if(e.KeyCode ==  Keys.Enter)
            {
            	MessageBox.Show("KeyDown: " + e.KeyData.ToString());
            	lblOutput.Text = txtAutoEnter.Text;
            	txtAutoEnter.Clear();
            }
        }
        
        private void txtAutoEnter_KeyUp(object sender, KeyEventArgs e)
        {
            System.Diagnostics.Debug.Print("KeyDown: " + e.Modifiers.ToString());
           // if(e.KeyCode ==  Keys.Enter)
            //{
            //	MessageBox.Show("KeyDown: " + e.KeyData.ToString());
           // }
        }
        
        private void txtAutoEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Diagnostics.Debug.Print("KeyDown: " + e.KeyChar.ToString());
            e.Handled = !char.IsDigit(e.KeyChar);
            //if(e.KeyChar == "A")
            //{
            //	MessageBox.Show("KeyDown: " + e.KeyChar.ToString());
            //}
           
        }
		void Button1Click(object sender, EventArgs e)
		{
	
		}

	}
}
