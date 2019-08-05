/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 2018-10-09
 * Time: 2:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace PusatData
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new MainForm());
			Application.Run(new MdiForm());
		}
		
		/*EventManager.RegisterClassHandler(typeof(Window),Keyboard.KeyUpEvent,new KeyEventHandler(keyUp), true);

		private void keyUp(object sender, KeyEventArgs e)
		{
		      //Your code...
		}	*/				
	}
	
	
}
