/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 2019-06-25
 * Time: 10:57 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BasicForm
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button3 = new System.Windows.Forms.Button();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCheck = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(25, 21);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(25, 65);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(157, 20);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(101, 20);
			this.dateTimePicker1.TabIndex = 2;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(25, 117);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(90, 36);
			this.button3.TabIndex = 3;
			this.button3.Text = "Read Txt File";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(388, 15);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(100, 20);
			this.txtUser.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(310, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "user";
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(388, 42);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '#';
			this.txtPass.Size = new System.Drawing.Size(100, 20);
			this.txtPass.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(310, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "pass";
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(413, 68);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(75, 23);
			this.btnCheck.TabIndex = 8;
			this.btnCheck.Text = "check";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.BtnCheckClick);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(404, 117);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 9;
			this.button4.Text = "load COnfig";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(404, 166);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 10;
			this.button5.Text = "write config";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 321);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.btnCheck);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "BasicForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
	}
}
