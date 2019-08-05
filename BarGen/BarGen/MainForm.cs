/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 2018-09-14
 * Time: 5:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Drawing.Imaging;

namespace BarGen
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
			
			string barcode = textBox1.Text;
			Bitmap bitmap = new Bitmap(barcode.Length * 40 , 150);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				Font oFont = new System.Drawing.Font("IDAutomationHC39M", 20);
				PointF point = new PointF(2f, 2f);
				SolidBrush black = new SolidBrush(Color.Black);
				SolidBrush white = new SolidBrush(Color.White);
				graphics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
				graphics.DrawString("*" + barcode + "*", oFont, black, point);
			}
			using(MemoryStream ms = new MemoryStream())
			{
				bitmap.Save(ms, ImageFormat.Png);
				pictureBox1.Image = bitmap;
				pictureBox1.Height = bitmap.Height;
				pictureBox1.Width = bitmap.Width;
			}

		}
	}
}
