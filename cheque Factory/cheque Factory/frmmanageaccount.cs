using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cheque_Factory
{
    public partial class frmmanageaccount : Form
    {
        public frmmanageaccount()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        SqlConnection mycom;
        SqlCommand mycmd;
        private void loadincombobox()
        {
            mycom = new SqlConnection(connecteiondatabase.passconnection());
            mycom.Open();
            mycmd = new SqlCommand("Selectprocedure", mycom);
            mycmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader da = mycmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("namepattern", typeof(string));
            while (da.Read())
            {
                DataRow dr1 = dt.NewRow();
                dr1[0] = da.GetInt32(da.GetOrdinal("id"));
                dr1[1] = da.GetString(da.GetOrdinal("namepattern"));
                dt.Rows.Add(dr1);
            }
            da.Close();
            mycom.Close();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "namepattern";
            comboBox1.ValueMember = "id";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void loadingrid()
        {
            mycom = new SqlConnection(connecteiondatabase.passconnection());
            mycom.Open();
            mycmd = new SqlCommand("Selectbank", mycom);
            mycmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = mycmd;
            da.Fill(dt);
            mycom.Close();
            dataGridView1.DataSource = dt;
            
        }

       
        private void frmmanageaccount_Load(object sender, EventArgs e)
        {
            loadingrid();
            loadincombobox();
            
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mycom = new SqlConnection(connecteiondatabase.passconnection());
            mycom.Open();
            mycmd = new SqlCommand("editbank", mycom);
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.Add("@namebank", SqlDbType.NVarChar).Value = textBox1.Text.Trim();
            mycmd.Parameters.Add("@code", SqlDbType.NVarChar).Value = textBox2.Text.Trim();
            mycmd.Parameters.Add("@numaccount", SqlDbType.NVarChar).Value = textBox3.Text.Trim();
            mycmd.Parameters.Add("@namepattern", SqlDbType.NVarChar).Value = comboBox1.Text;
            mycmd.ExecuteNonQuery();
            mycom.Close();
            MessageBox.Show("بانک مورد نظر ویرایش شد");
            
            loadingrid();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            mycom = new SqlConnection(connecteiondatabase.passconnection());
            mycom.Open();
            mycmd = new SqlCommand("deletebank", mycom);
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.Add("@namebank", SqlDbType.NVarChar).Value = textBox1.Text.Trim();
            mycmd.ExecuteNonQuery();
            mycom.Close();
            MessageBox.Show("بانک مورد نظر حذف شد");

            loadingrid();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}
