/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 2018-09-19
 * Time: 12:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HiWorld
{
	partial class Form2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAutoEnter;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.Button button1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtAutoEnter = new System.Windows.Forms.TextBox();
			this.lblOutput = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(42, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter Number :";
			// 
			// txtAutoEnter
			// 
			this.txtAutoEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAutoEnter.Location = new System.Drawing.Point(153, 38);
			this.txtAutoEnter.MaxLength = 12;
			this.txtAutoEnter.Name = "txtAutoEnter";
			this.txtAutoEnter.Size = new System.Drawing.Size(213, 31);
			this.txtAutoEnter.TabIndex = 1;
			this.txtAutoEnter.TextChanged += new System.EventHandler(this.TxtAutoEnterTextChanged);
			this.txtAutoEnter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAutoEnter_KeyDown);
			this.txtAutoEnter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAutoEnter_KeyPress);
			// 
			// lblOutput
			// 
			this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOutput.Location = new System.Drawing.Point(42, 111);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(326, 128);
			this.lblOutput.TabIndex = 2;
			this.lblOutput.Text = "output here";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(437, 38);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(83, 31);
			this.button1.TabIndex = 3;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(681, 336);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.txtAutoEnter);
			this.Controls.Add(this.label1);
			this.Icon = global::HiWorld.Resource1.document;
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
