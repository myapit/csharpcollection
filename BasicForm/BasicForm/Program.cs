/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 2019-06-25
 * Time: 10:57 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace BasicForm
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
			/* Begin MessageBoxManager Setting */
			MessageBoxManager.OK = "Alright";
            MessageBoxManager.Cancel = "Noway";
           	MessageBoxManager.Register();
			/* End MessageBoxManager Setting */
			Application.Run(new MainForm());
			MessageBoxManager.Unregister();
			
		}
		
	}
}
