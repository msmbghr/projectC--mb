using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cheque_Factory
{
    public partial class frmbankaccount : Form
    {
        public frmbankaccount()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void insertbank()
        {
            mycom = new SqlConnection(connecteiondatabase.passconnection());
            mycom.Open();
            /////1
            mycmd = new SqlCommand("Insertbank", mycom);
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.Add("@namebank", SqlDbType.NVarChar).Value = textBox1.Text.Trim();
            mycmd.Parameters.Add("@code", SqlDbType.NVarChar).Value = textBox2.Text.Trim();
            mycmd.Parameters.Add("@numaccount", SqlDbType.NVarChar).Value = textBox3.Text.Trim();
            mycmd.Parameters.Add("@namepattern", SqlDbType.NVarChar).Value = comboBox1.Text;
            mycmd.ExecuteNonQuery();
            mycom.Close();
            MessageBox.Show("بانک مورد نظر ذخیره شد");
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                insertbank();     
            }
           
           
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
        }
        private void frmbankaccount_Load(object sender, EventArgs e)
        {
           
            loadincombobox();
        }
    }
}
