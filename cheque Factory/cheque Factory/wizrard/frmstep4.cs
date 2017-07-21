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
using System.IO;


namespace cheque_Factory.wizrard
{

    public partial class frmstep4 : Form
    {
        public frmstep4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("آیا مطمئن هستید ؟","هشدار",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            if (dr==DialogResult.Yes)
	            {
		            this.Close();
	            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                btnsave.Enabled = true;
            }
            else
            {
                btnsave.Enabled = false;

            }
            
        }
        SqlConnection mycom;
        SqlCommand mycmd;
        SqlDataAdapter myda;
        private void savepattenrn()
        {

            myda = new SqlDataAdapter();
            mycom = new SqlConnection(connecteiondatabase.passconnection());
            mycom.Open();
            /////1
            mycmd = new SqlCommand("insertinfo", mycom);
            mycmd.CommandType = CommandType.StoredProcedure;
                mycmd.Parameters.Add("@n_pattern", SqlDbType.NVarChar).Value = textBox1.Text.Trim();
                mycmd.Parameters.Add("@Tabid", SqlDbType.NVarChar).Value = "1";
                mycmd.Parameters.Add("@namefont", SqlDbType.NVarChar).Value =passdate.font1 ;
                mycmd.Parameters.Add("@stylefont", SqlDbType.NVarChar).Value = passdate.style1;
                mycmd.Parameters.Add("@sizefont", SqlDbType.NVarChar).Value = passdate.size1;
                mycmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = passdate.color1;
                mycmd.Parameters.Add("@Rright", SqlDbType.Int).Value = passdate.numdigitx1;
                mycmd.Parameters.Add("@locx", SqlDbType.Int).Value = passdate.locx;
                mycmd.Parameters.Add("@locy", SqlDbType.Int).Value = passdate.locy;
                mycmd.Parameters.Add("@Bbottom", SqlDbType.Int).Value = passdate.numdigity1;
                mycmd.Parameters.Add("@show", SqlDbType.Bit).Value = 1;
                mycmd.ExecuteNonQuery();
           /////2
                mycmd = new SqlCommand("insertinfo", mycom);
                mycmd.CommandType = CommandType.StoredProcedure;
                mycmd.Parameters.Add("@n_pattern", SqlDbType.NVarChar).Value = textBox1.Text.Trim();
                mycmd.Parameters.Add("@Tabid", SqlDbType.NVarChar).Value = "2";
                mycmd.Parameters.Add("@namefont", SqlDbType.NVarChar).Value = passdate.font2;
                mycmd.Parameters.Add("@stylefont", SqlDbType.NVarChar).Value = passdate.style2;
                mycmd.Parameters.Add("@sizefont", SqlDbType.NVarChar).Value = passdate.size2;
                mycmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = passdate.color2;
                mycmd.Parameters.Add("@Rright", SqlDbType.Int).Value = passdate.numdigitx2;

                mycmd.Parameters.Add("@locx", SqlDbType.Int).Value = passdate.locx2;
                mycmd.Parameters.Add("@locy", SqlDbType.Int).Value = passdate.locy2;

                mycmd.Parameters.Add("@Bbottom", SqlDbType.Int).Value = passdate.numdigity2;
                mycmd.Parameters.Add("@show", SqlDbType.Bit).Value = 1;
                mycmd.ExecuteNonQuery();
            //////3
                mycmd = new SqlCommand("insertinfo", mycom);
                mycmd.CommandType = CommandType.StoredProcedure;
                mycmd.Parameters.Add("@n_pattern", SqlDbType.NVarChar).Value = textBox1.Text.Trim();
                mycmd.Parameters.Add("@Tabid", SqlDbType.NVarChar).Value = "3";
                mycmd.Parameters.Add("@namefont", SqlDbType.NVarChar).Value = passdate.font3;
                mycmd.Parameters.Add("@stylefont", SqlDbType.NVarChar).Value = passdate.style3;
                mycmd.Parameters.Add("@sizefont", SqlDbType.NVarChar).Value = passdate.size3;
                mycmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = passdate.color3;
                mycmd.Parameters.Add("@Rright", SqlDbType.Int).Value = passdate.numdigitx3;

                mycmd.Parameters.Add("@locx", SqlDbType.Int).Value = passdate.locx3;
                mycmd.Parameters.Add("@locy", SqlDbType.Int).Value = passdate.locy3;

                mycmd.Parameters.Add("@Bbottom", SqlDbType.Int).Value = passdate.numdigity3;
                mycmd.Parameters.Add("@show", SqlDbType.Bit).Value = 1;
                mycmd.ExecuteNonQuery();
              /////4
                mycmd = new SqlCommand("insertinfo", mycom);
                mycmd.CommandType = CommandType.StoredProcedure;
                mycmd.Parameters.Add("@n_pattern", SqlDbType.NVarChar).Value = textBox1.Text.Trim();
                mycmd.Parameters.Add("@Tabid", SqlDbType.NVarChar).Value = "4";
                mycmd.Parameters.Add("@namefont", SqlDbType.NVarChar).Value = passdate.font4;
                mycmd.Parameters.Add("@stylefont", SqlDbType.NVarChar).Value = passdate.style4;
                mycmd.Parameters.Add("@sizefont", SqlDbType.NVarChar).Value = passdate.size4;
                mycmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = passdate.color4;

                mycmd.Parameters.Add("@locx", SqlDbType.Int).Value = passdate.locx4;
                mycmd.Parameters.Add("@locy", SqlDbType.Int).Value = passdate.locy4;


                mycmd.Parameters.Add("@Rright", SqlDbType.Int).Value = passdate.numdigitx4;
                mycmd.Parameters.Add("@Bbottom", SqlDbType.Int).Value = passdate.numdigity4;
                mycmd.Parameters.Add("@show", SqlDbType.Bit).Value = 1;
                mycmd.ExecuteNonQuery();
            /////5
                mycmd = new SqlCommand("insertinfo", mycom);
                mycmd.CommandType = CommandType.StoredProcedure;
                mycmd.Parameters.Add("@n_pattern", SqlDbType.NVarChar).Value = textBox1.Text.Trim();
                mycmd.Parameters.Add("@Tabid", SqlDbType.NVarChar).Value = "5";
                mycmd.Parameters.Add("@namefont", SqlDbType.NVarChar).Value = passdate.font5;
                mycmd.Parameters.Add("@stylefont", SqlDbType.NVarChar).Value = passdate.style5;
                mycmd.Parameters.Add("@sizefont", SqlDbType.NVarChar).Value = passdate.size5;
                mycmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = passdate.color5;
                mycmd.Parameters.Add("@Rright", SqlDbType.Int).Value = passdate.numdigitx5;

                mycmd.Parameters.Add("@locx", SqlDbType.Int).Value = passdate.locx5;
                mycmd.Parameters.Add("@locy", SqlDbType.Int).Value = passdate.locy5;

                mycmd.Parameters.Add("@Bbottom", SqlDbType.Int).Value = passdate.numdigity5;
                mycmd.Parameters.Add("@show", SqlDbType.Bit).Value = 1;
                mycmd.ExecuteNonQuery();
             /////6
                mycmd = new SqlCommand("insertinfo", mycom);
                mycmd.CommandType = CommandType.StoredProcedure;
                mycmd.Parameters.Add("@n_pattern", SqlDbType.NVarChar).Value = textBox1.Text.Trim();
                mycmd.Parameters.Add("@Tabid", SqlDbType.NVarChar).Value = "6";
                mycmd.Parameters.Add("@namefont", SqlDbType.NVarChar).Value = passdate.font6;
                mycmd.Parameters.Add("@stylefont", SqlDbType.NVarChar).Value = passdate.style6;
                mycmd.Parameters.Add("@sizefont", SqlDbType.NVarChar).Value = passdate.size6;
                mycmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = passdate.color6;

                mycmd.Parameters.Add("@locx", SqlDbType.Int).Value = passdate.locx6;
                mycmd.Parameters.Add("@locy", SqlDbType.Int).Value = passdate.locy6;


                mycmd.Parameters.Add("@Rright", SqlDbType.Int).Value = passdate.numdigitx6;
                mycmd.Parameters.Add("@Bbottom", SqlDbType.Int).Value = passdate.numdigity6;
                mycmd.Parameters.Add("@show", SqlDbType.Bit).Value = 1;
                mycmd.ExecuteNonQuery();
             /////7
                mycmd = new SqlCommand("insertinfo", mycom);
                mycmd.CommandType = CommandType.StoredProcedure;
                mycmd.Parameters.Add("@n_pattern", SqlDbType.NVarChar).Value = textBox1.Text.Trim();
                mycmd.Parameters.Add("@Tabid", SqlDbType.NVarChar).Value = "7";
                mycmd.Parameters.Add("@namefont", SqlDbType.NVarChar).Value = passdate.font7;
                mycmd.Parameters.Add("@stylefont", SqlDbType.NVarChar).Value = passdate.style7;
                mycmd.Parameters.Add("@sizefont", SqlDbType.NVarChar).Value = passdate.size7;
                mycmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = passdate.color7;
                mycmd.Parameters.Add("@Rright", SqlDbType.Int).Value = passdate.numdigitx7;

                mycmd.Parameters.Add("@locx", SqlDbType.Int).Value = passdate.locx7;
                mycmd.Parameters.Add("@locy", SqlDbType.Int).Value = passdate.locy7;


                mycmd.Parameters.Add("@Bbottom", SqlDbType.Int).Value = passdate.numdigity7;
                mycmd.Parameters.Add("@show", SqlDbType.Bit).Value = 1;
                mycmd.ExecuteNonQuery();
                /////8
                mycmd = new SqlCommand("insertinfo", mycom);
                mycmd.CommandType = CommandType.StoredProcedure;
                mycmd.Parameters.Add("@n_pattern", SqlDbType.NVarChar).Value = textBox1.Text.Trim();
                mycmd.Parameters.Add("@Tabid", SqlDbType.NVarChar).Value = "8";
                mycmd.Parameters.Add("@namefont", SqlDbType.NVarChar).Value = passdate.font8;
                mycmd.Parameters.Add("@stylefont", SqlDbType.NVarChar).Value = passdate.style8;
                mycmd.Parameters.Add("@sizefont", SqlDbType.NVarChar).Value = passdate.size8;
                mycmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = passdate.color8;
                mycmd.Parameters.Add("@Rright", SqlDbType.Int).Value = passdate.numdigitx8;

                mycmd.Parameters.Add("@locx", SqlDbType.Int).Value = passdate.locx8;
                mycmd.Parameters.Add("@locy", SqlDbType.Int).Value = passdate.locy8;

                mycmd.Parameters.Add("@Bbottom", SqlDbType.Int).Value = passdate.numdigity8;
                mycmd.Parameters.Add("@show", SqlDbType.Bit).Value = 1;
                mycmd.ExecuteNonQuery();

            mycom.Close();
            MessageBox.Show("الگو با موفقیت ذخیره شد");
            this.Close();
        }

        private void savenameimagepattern()
        {
            myda = new SqlDataAdapter();
            mycom = new SqlConnection(connecteiondatabase.passconnection());

            mycmd = new SqlCommand();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] a = ms.GetBuffer();
            ms.Close();
           
            mycmd.Parameters.Clear();
            mycmd.Parameters.AddWithValue("@picture", a);
            mycmd.CommandText = "insert into pnamepimage(namepattern,image) values ('" + textBox1.Text + "',@picture)";
             mycom.Open();
            mycmd.Connection = mycom;
            mycmd.ExecuteNonQuery();
            mycom.Close();
        }

       
        private void btnsave_Click(object sender, EventArgs e)
        {
            savenameimagepattern();
            savepattenrn();
        }
               
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(textBox1.Text))
            {
                btnsave_Click(null, null);
            }
        }

        private void frmstep4_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = passdate.SelectImage;
        }

        
    }
}
