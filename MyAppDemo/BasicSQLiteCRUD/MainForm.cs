/*
 * Created by SharpDevelop.
 * User: domokun
 * Date: 08/11/2019
 * Time: 11:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;

namespace BasicSQLiteCRUD
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private SQLiteConnection sqlCon;// = new SQLiteConnection("Data Source=MyBasicCrud.db3;Version=3;");
		private string IDPerson;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			sqlCon = new SQLiteConnection("Data Source=MyBasicCrud.db3;Version=3;");
			sqlCon.Open();
			
			// Formating Data Grid View
			dgvPerson.AllowUserToAddRows = false; // disable extra empty row
			dgvPerson.RowHeadersVisible = false; // hide header column
		}
		
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			resetForm();
			loadDataSQL();
		}
		
		void BtnSimpanClick(object sender, EventArgs e)
		{
			if (btnSimpan.Text == "Simpan")
			{
				SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO Person (Nama, Alamat) VALUES ($nama, $alamat)", sqlCon);
				insertSQL.Parameters.Add("$nama", System.Data.DbType.String).Value = txtNama.Text.Trim();
				insertSQL.Parameters.Add("$alamat", System.Data.DbType.String).Value =txtAlamat.Text.Trim();
	
			    try {
			        insertSQL.ExecuteNonQuery();
			    }
			    catch (Exception ex) {
			        throw new Exception(ex.Message);
			    }
				
			    resetForm();
				loadDataSQL();
			}
			
			if (btnSimpan.Text == "Kemaskini")
			{
				SQLiteCommand insertSQL = new SQLiteCommand("UPDATE Person Set Nama=$nama, Alamat=$alamat WHERE id=$id", sqlCon);
				insertSQL.Parameters.Add("$nama", System.Data.DbType.String).Value = txtNama.Text.Trim();
				insertSQL.Parameters.Add("$alamat", System.Data.DbType.String).Value =txtAlamat.Text.Trim();
				insertSQL.Parameters.Add("$id", System.Data.DbType.String).Value = IDPerson;
				insertSQL.ExecuteNonQuery();
				resetForm();
				loadDataSQL();
			}
					    
		}
		
		void BtnResetClick(object sender, EventArgs e)
		{
			resetForm();
		}
		void DgvPersonCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//string ID = dgvPerson.Rows[e.RowIndex].Cells[0].Value.ToString(); //- also work
			IDPerson = dgvPerson.CurrentRow.Cells[1].Value.ToString();
			txtNama.Text = dgvPerson.CurrentRow.Cells[2].Value.ToString();
			txtAlamat.Text = dgvPerson.CurrentRow.Cells[3].Value.ToString();
			btnSimpan.Text = "Kemaskini";
			btnHapus.Enabled = true;
		}
		
		void BtnHapusClick(object sender, EventArgs e)
		{
			SQLiteCommand insertSQL = new SQLiteCommand("DELETE FROM Person WHERE id=$id", sqlCon);
			//insertSQL.Parameters.Add("$id", System.Data.DbType.String).Value = IDPerson;
			insertSQL.Parameters.AddWithValue("$id",IDPerson.ToString());
			insertSQL.ExecuteNonQuery();
			resetForm();
			loadDataSQL();
		}
		
		void BtnSearchClick(object sender, EventArgs e)
		{
			if (txtSearch.Text.Trim() != "") {
				loadDataSQL(txtSearch.Text.Trim());
				Debug.WriteLine(txtSearch.Text.Trim());
			} else {
				MessageBox.Show("Please enter text to search.","Search",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				txtSearch.Focus();
			}
		}  
		
		
		void DgvPersonCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
		}
		
		/******************************** Custom Function ***************************/
		
		private void resetForm()
		{
			
			txtNama.Text = "";
			txtAlamat.Text ="";
			btnSimpan.Text = "Simpan";
			//btnReset.Enabled = false;
			btnHapus.Enabled = false;
		}
		
		private void loadDataSQL(string searchKeyword = "")
		{

    		/* // -Also Work
    		do
			{
			   foreach (DataGridViewRow row in dgvPerson.Rows)
			   {
			      try
			      {
			        dgvPerson.Rows.Remove(row);
			      }
			      catch (Exception) { }
			   }
			} while (dgvPerson.Rows.Count > 1);
			*/
			int countRow = 1;
			string sqlQuery = "";
			
			dgvPerson.Rows.Clear();
			dgvPerson.Refresh();
			
			if (searchKeyword.Trim() == "")
				sqlQuery = "SELECT * FROM person ORDER BY id ASC";
			else
				sqlQuery = "SELECT * FROM person WHERE nama LIKE '%" + searchKeyword + "%' OR alamat LIKE '%" + searchKeyword + "%' ORDER BY id ASC";
			
    		
			SQLiteCommand cmdSQL = new SQLiteCommand(sqlQuery, sqlCon);
			
			using( SQLiteDataReader readData =  cmdSQL.ExecuteReader())
			{
				while (readData.Read())
				{
					dgvPerson.Rows.Add(
						new object[] {
							countRow++,
							readData.GetValue(0),  // using column index
							readData.GetValue(readData.GetOrdinal("nama")), // using column name
							readData.GetValue(2)
						}
					);
				}
				
			} //End Using
		}
		
	    // TODO: load data using DataTable style	
	    private void DisplayData()  
        {  
            /* con.Open();
            DataTable dt=new DataTable();  
            adapt=new SqlDataAdapter("select * from tbl_Record",con);  
            adapt.Fill(dt);  
            dataGridView1.DataSource = dt;  
            con.Close();  */
        }
		
		
	} //END MainFOrm
}//END NAMESPACE
