/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 2018-09-14
 * Time: 3:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.IO;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Reflection;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Net.WebSockets;
using System.Net;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Diagnostics;

namespace HiWorld
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
			// /Version versionInfo = Assembly.GetExecutingAssembly().GetName().Version;
			
			//statusStrip1.Items[0].Alignment = Right;
			///statusStrip1.Items[0].Text = "ver:"+Application.ProductVersion;
			////statusStrip1.Items[2].Text = DateTime.Today.ToString();
			 
		}
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show(textBox1.Text,"hi",MessageBoxButtons.OK);
			label1.Text = textBox1.Text;
			Class1.createDB();
			Class1.barGen();
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void StatusStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			// BEGIN
			
			const string filename = "HelloWorld.pdf";
     	 if (File.Exists(filename))
     	 {
     	 	File.Delete(filename);
     	 }
		
	     	 // Create a new PDF document
	      PdfDocument document = new PdfDocument();
	      document.Info.Title = "Created with PDFsharp";
	 
	      // Create an empty page
	      PdfPage page = document.AddPage();
	 
	      // Get an XGraphics object for drawing
	      XGraphics gfx = XGraphics.FromPdfPage(page);
	      page.Size = PageSize.A4;
	      page.Orientation = PageOrientation.Portrait;
	      //A4 pixel 72dpi 595 x 842
	      // A4 mm 210x297
	      
	      // Create a font
	      XFont font = new XFont("Verdana", 11, XFontStyle.BoldItalic);
	 
	      // Draw the text
	      gfx.DrawString("Hello, World!", font, XBrushes.Black, 
	                     new XRect(0, 0, page.Width, page.Height), 
	                     XStringFormats.Center);
	      
	      font = new XFont("Verdana", 11, XFontStyle.Regular);
	      
	      Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
          
	     const int  barWidth = 120, barHeight = 50;
	      
	      /*
          gfx.DrawImage(barcode.Draw(textBox1.Text, 100), 25, 20, barWidth, barHeight);
          gfx.DrawString(textBox1.Text, font, XBrushes.Black, 20, 100);
          
          gfx.DrawImage(barcode.Draw(textBox1.Text, 100), 165, 20, barWidth, barHeight);
          gfx.DrawString(textBox1.Text, font, XBrushes.Black, 140, 100);
          
          
          gfx.DrawImage(barcode.Draw(textBox1.Text, 100), 305, 20, barWidth, barHeight);
          gfx.DrawString(textBox1.Text, font, XBrushes.Black, 240, 100);
          
          gfx.DrawImage(barcode.Draw(textBox1.Text, 100), 445, 20, barWidth, barHeight);
          
          */
          
         /* Begin Working Example */
          
         /*
          int[] barX = new int[4];
          barX[0]=25; barX[1]=165; barX[2]=305; barX[3]=445;
          
          int rowBarY =10;
          int rowTextY = 70;
          
          gfx.DrawImage(barcode.Draw(textBox1.Text, 50), barX[0], rowBarY, barWidth, barHeight);
          gfx.DrawString("*   " + textBox1.Text + "   *", font, XBrushes.Black, barX[0], rowTextY ); // y+60
          
          gfx.DrawImage(barcode.Draw(textBox1.Text, 50), barX[1], rowBarY, barWidth, barHeight);
          gfx.DrawString("*   " + textBox1.Text + "   *", font, XBrushes.Black, barX[1], rowTextY );
          
          gfx.DrawImage(barcode.Draw(textBox1.Text, 50), barX[2], rowBarY, barWidth, barHeight);
          gfx.DrawString("*   " + textBox1.Text + "   *", font, XBrushes.Black, barX[2], rowTextY );
          
          gfx.DrawImage(barcode.Draw(textBox1.Text, 50), barX[3], rowBarY, barWidth, barHeight);
          gfx.DrawString("*   " + textBox1.Text + "   *", font, XBrushes.Black, barX[3], rowTextY );
          
          
          
          
          rowBarY = rowBarY + 80;
          rowTextY = rowTextY + 90;
          
          gfx.DrawImage(barcode.Draw(textBox1.Text, 50), barX[0], rowBarY, barWidth, barHeight);
          gfx.DrawString("*   " + textBox1.Text + "   *", font, XBrushes.Black, barX[0], rowTextY ); // y+60
          
          gfx.DrawImage(barcode.Draw(textBox1.Text, 50), barX[1], rowBarY, barWidth, barHeight);
          gfx.DrawString("*   " + textBox1.Text + "   *", font, XBrushes.Black, barX[1], rowTextY );
          
          gfx.DrawImage(barcode.Draw(textBox1.Text, 50), barX[2], rowBarY, barWidth, barHeight);
          gfx.DrawString("*   " + textBox1.Text + "   *", font, XBrushes.Black, barX[2], rowTextY );
          
          gfx.DrawImage(barcode.Draw(textBox1.Text, 50), barX[3], rowBarY, barWidth, barHeight);
          gfx.DrawString("*   " + textBox1.Text + "   *", font, XBrushes.Black, barX[3], rowTextY );
          
          */
          /* Ending Working Example */
          
          
      	  int[] barX = new int[4];
          barX[0]=25; barX[1]=165; barX[2]=305; barX[3]=445;
          
          int indexPrint = 0;
          
          int currentPage = 0 ;
          int currentRow = 0;
			
          int rowBarY =10;
          int rowTextY = 70;
          string tmpData;
          
          for(indexPrint =0; indexPrint < 15; ++indexPrint)
          {
	        
          	if (currentRow != 0) 
          	{
          		rowBarY = rowBarY + 80;
          		rowTextY = rowTextY + 80;
          	}
          	
          	
          	tmpData = "";
          	tmpData =  randomNumber().ToString();			          	
          	gfx.DrawImage(barcode.Draw(tmpData, 50), barX[0], rowBarY, barWidth, barHeight);
	        gfx.DrawString("*   " + tmpData + "   *", font, XBrushes.Black, barX[0], rowTextY ); // y+60
	         
			tmpData = "";
	        tmpData =  randomNumber().ToString();
	        gfx.DrawImage(barcode.Draw(tmpData, 50), barX[1], rowBarY, barWidth, barHeight);
	        gfx.DrawString("*   " + tmpData + "   *", font, XBrushes.Black, barX[1], rowTextY );
	        
	        tmpData = "";
	        tmpData =  randomNumber().ToString();
	        gfx.DrawImage(barcode.Draw(tmpData, 50), barX[2], rowBarY, barWidth, barHeight);
	        gfx.DrawString("*   " + tmpData + "   *", font, XBrushes.Black, barX[2], rowTextY );
	        

	        tmpData = "";
	        tmpData =  randomNumber().ToString();
	        gfx.DrawImage(barcode.Draw(tmpData, 50), barX[3], rowBarY, barWidth, barHeight);
	        gfx.DrawString("*   " + tmpData + "   *", font, XBrushes.Black, barX[3], rowTextY );
	          
	        ++currentRow;
	        ++currentPage;
	        
	        if (indexPrint == 9)
	        {	        	
		      currentPage = 0 ;
	          currentRow = 0;
				
	          rowBarY = 10;
	          rowTextY = 70;
	          // Create an empty page
		      page = document.AddPage();
		 
		      // Get an XGraphics object for drawing
		      gfx = XGraphics.FromPdfPage(page);
		      page.Size = PageSize.A4;
		      page.Orientation = PageOrientation.Portrait;
	        }
          }
                  
	      // Save the document...
	      
	      document.Save(filename);
	      // ...and start a viewer.
	      Process.Start(filename);

	      
			//END
		}
		
		
		public long randomNumber()
		{
 			Random rand = new Random();
 			System.Threading.Thread.Sleep(10);
  			long randnum2 = (long)(rand.NextDouble() * 900000000000) + 100000000000;
  			return randnum2; //.ToString();
  			
  			/*
  			Random RndNum = new Random();   
  			long RnNum = RndNum.Next(100000000000,999999999999);
			return RnNum.ToString();
			*/
			/*Random r = new Random();

            int number = r.Next(999999999);
            int number2 = r.Next(99999);

            return ((long)number2 * (long)100000000000) + (long)number;*/
		}
		
	}
}
