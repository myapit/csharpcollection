/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 08/11/2019
 * Time: 11:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BasicSQLiteCRUD
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvPerson;
		private System.Windows.Forms.Button btnSimpan;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNama;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAlamat;
		private System.Windows.Forms.Button btnHapus;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alamat;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn number;
		
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
			this.dgvPerson = new System.Windows.Forms.DataGridView();
			this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSimpan = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNama = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAlamat = new System.Windows.Forms.TextBox();
			this.btnHapus = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvPerson
			// 
			this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.number,
			this.ID,
			this.Nama,
			this.Alamat});
			this.dgvPerson.Location = new System.Drawing.Point(362, 82);
			this.dgvPerson.Name = "dgvPerson";
			this.dgvPerson.Size = new System.Drawing.Size(390, 143);
			this.dgvPerson.TabIndex = 6;
			this.dgvPerson.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPersonCellContentDoubleClick);
			this.dgvPerson.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvPersonCellMouseDoubleClick);
			// 
			// number
			// 
			this.number.HeaderText = "No.";
			this.number.Name = "number";
			// 
			// ID
			// 
			this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 43;
			// 
			// Nama
			// 
			this.Nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nama.HeaderText = "Nama";
			this.Nama.Name = "Nama";
			this.Nama.ReadOnly = true;
			// 
			// Alamat
			// 
			this.Alamat.HeaderText = "Alamat";
			this.Alamat.Name = "Alamat";
			this.Alamat.ReadOnly = true;
			// 
			// btnSimpan
			// 
			this.btnSimpan.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSimpan.Location = new System.Drawing.Point(86, 219);
			this.btnSimpan.Name = "btnSimpan";
			this.btnSimpan.Size = new System.Drawing.Size(80, 36);
			this.btnSimpan.TabIndex = 3;
			this.btnSimpan.Text = "Simpan";
			this.btnSimpan.UseVisualStyleBackColor = false;
			this.btnSimpan.Click += new System.EventHandler(this.BtnSimpanClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(47, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nama";
			// 
			// txtNama
			// 
			this.txtNama.Location = new System.Drawing.Point(113, 82);
			this.txtNama.Name = "txtNama";
			this.txtNama.Size = new System.Drawing.Size(225, 20);
			this.txtNama.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(47, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Alamat";
			// 
			// txtAlamat
			// 
			this.txtAlamat.Location = new System.Drawing.Point(113, 118);
			this.txtAlamat.Multiline = true;
			this.txtAlamat.Name = "txtAlamat";
			this.txtAlamat.Size = new System.Drawing.Size(225, 81);
			this.txtAlamat.TabIndex = 2;
			// 
			// btnHapus
			// 
			this.btnHapus.BackColor = System.Drawing.Color.LightSalmon;
			this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHapus.Location = new System.Drawing.Point(172, 219);
			this.btnHapus.Name = "btnHapus";
			this.btnHapus.Size = new System.Drawing.Size(80, 36);
			this.btnHapus.TabIndex = 4;
			this.btnHapus.Text = "Hapus";
			this.btnHapus.UseVisualStyleBackColor = false;
			this.btnHapus.Click += new System.EventHandler(this.BtnHapusClick);
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.Color.Wheat;
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(258, 219);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(80, 36);
			this.btnReset.TabIndex = 5;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(56, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(594, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Basic Create, Read, Update and Delete (CRUD) with SQLITE";
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(362, 235);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(288, 22);
			this.txtSearch.TabIndex = 8;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.Wheat;
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(672, 231);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(80, 29);
			this.btnSearch.TabIndex = 9;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.BtnSearchClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(798, 334);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnHapus);
			this.Controls.Add(this.txtAlamat);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNama);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSimpan);
			this.Controls.Add(this.dgvPerson);
			this.Name = "MainForm";
			this.Text = "BasicSQLiteCRUD";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
