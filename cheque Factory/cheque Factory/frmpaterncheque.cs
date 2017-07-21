using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cheque_Factory
{
    public partial class frmpaterncheque : Form
    {
        public frmpaterncheque()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                lbldatedigit.Visible = true;

            }
            else
            {
                lbldatedigit.Visible = false;

            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                lbldatelet.Visible = true;

            }
            else
            {
                lbldatelet.Visible = false;

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                pricelet.Visible = true;

            }
            else
            {
                pricelet.Visible = false;

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
                if (checkBox4.Checked)
            {
                pricedigit.Visible = true;

            }
            else
            {
                pricedigit.Visible = false;

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox5.Checked)
            {
                recive.Visible = true;

            }
            else
            {
                recive.Visible = false;

            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox6.Checked)
            {
                description.Visible = true;

            }
            else
            {
                description.Visible = false;

            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                letters.Visible = true;

            }
            else
            {
                letters.Visible = false;

            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                fieldmore.Visible = true;

            }
            else
            {
                fieldmore.Visible = false;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbldatedigit.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lbldatelet.Text = textBox2.Text;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            pricelet.Text = textBox3.Text;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            pricedigit.Text = textBox4.Text;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            recive.Text = textBox5.Text;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            description.Text = textBox6.Text;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            letters.Text = textBox7.Text;

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            fieldmore.Text = textBox8.Text;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection mycon;
        SqlCommand mycmd;
        private void loadincombobox()
        {
            mycon = new SqlConnection(connecteiondatabase.passconnection());
            mycon.Open();
            mycmd = new SqlCommand("Selectprocedure", mycon);
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
            mycon.Close();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "namepattern";
            comboBox1.ValueMember = "id";
        }
        private void frmpaterncheque_Load(object sender, EventArgs e)
        {
            loadincombobox();
        }

        private void loaddata1()
        {
            int counts = 0;
            string query = "SELECT * from savepattern where n_pattern='" + comboBox1.Text + "'";
            mycon = new SqlConnection(connecteiondatabase.passconnection());
            mycon.Open();
            mycmd = new SqlCommand(query, mycon);
            SqlDataReader dr = mycmd.ExecuteReader();
            while (dr.HasRows)
            {

                if (dr.Read())
                {
                    if (dr["tabid"].ToString() == "1")
                    {
                        counts++;
                        FontStyle n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Bold")
                            n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Italic")
                            n = FontStyle.Italic;
                        if (dr["stylefont"].ToString() == "Regular")
                            n = FontStyle.Regular;
                        if (dr["stylefont"].ToString() == "Strikeout")
                            n = FontStyle.Strikeout;
                        if (dr["stylefont"].ToString() == "Underline")
                            n = FontStyle.Underline;

                        int size = int.Parse(dr["sizefont"].ToString());
                        lbldatedigit.Font = new System.Drawing.Font(dr["namefont"].ToString(), size, n);
                        /////
                      
                        lbldatedigit.ForeColor = Color.FromName(dr["color"].ToString());
                        
                        lbldatedigit.Location = new Point(int.Parse(dr["locx"].ToString()), int.Parse(dr["locy"].ToString()));
                        //    break;
                    }
                    if (dr["tabid"].ToString() == "2")
                    {
                        counts++;

                        #region style
                        FontStyle n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Bold")
                            n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Italic")
                            n = FontStyle.Italic;
                        if (dr["stylefont"].ToString() == "Regular")
                            n = FontStyle.Regular;
                        if (dr["stylefont"].ToString() == "Strikeout")
                            n = FontStyle.Strikeout;
                        if (dr["stylefont"].ToString() == "Underline")
                            n = FontStyle.Underline;
                        #endregion

                        int size = int.Parse(dr["sizefont"].ToString());
                        lbldatelet.Font = new System.Drawing.Font(dr["namefont"].ToString(), size, n);
                        /////
                     
                        lbldatelet.ForeColor = Color.FromName(dr["color"].ToString());

                      
                        lbldatelet.Location = new Point(int.Parse(dr["locx"].ToString()), int.Parse(dr["locy"].ToString()));

                    }
                    ///////////////////////
                    if (dr["tabid"].ToString() == "3")
                    {
                        counts++;

                        #region style
                        FontStyle n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Bold")
                            n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Italic")
                            n = FontStyle.Italic;
                        if (dr["stylefont"].ToString() == "Regular")
                            n = FontStyle.Regular;
                        if (dr["stylefont"].ToString() == "Strikeout")
                            n = FontStyle.Strikeout;
                        if (dr["stylefont"].ToString() == "Underline")
                            n = FontStyle.Underline;
                        #endregion

                        int size = int.Parse(dr["sizefont"].ToString());
                        pricelet.Font = new System.Drawing.Font(dr["namefont"].ToString(), size, n);
                        /////
                        pricelet.ForeColor = Color.FromName(dr["color"].ToString());
                      
                        pricelet.Location = new Point(int.Parse(dr["locx"].ToString()), int.Parse(dr["locy"].ToString()));

                    }
                    ///////////////////////
                    if (dr["tabid"].ToString() == "4")
                    {
                        counts++;

                        #region style
                        FontStyle n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Bold")
                            n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Italic")
                            n = FontStyle.Italic;
                        if (dr["stylefont"].ToString() == "Regular")
                            n = FontStyle.Regular;
                        if (dr["stylefont"].ToString() == "Strikeout")
                            n = FontStyle.Strikeout;
                        if (dr["stylefont"].ToString() == "Underline")
                            n = FontStyle.Underline;
                        #endregion

                        int size = int.Parse(dr["sizefont"].ToString());
                        recive.Font = new System.Drawing.Font(dr["namefont"].ToString(), size, n);
                        /////
                        recive.ForeColor = Color.FromName(dr["color"].ToString());


                       
                        recive.Location = new Point(int.Parse(dr["locx"].ToString()), int.Parse(dr["locy"].ToString()));

                    }
                    ///////////////////////
                    if (dr["tabid"].ToString() == "5")
                    {
                        counts++;

                        #region style
                        FontStyle n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Bold")
                            n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Italic")
                            n = FontStyle.Italic;
                        if (dr["stylefont"].ToString() == "Regular")
                            n = FontStyle.Regular;
                        if (dr["stylefont"].ToString() == "Strikeout")
                            n = FontStyle.Strikeout;
                        if (dr["stylefont"].ToString() == "Underline")
                            n = FontStyle.Underline;
                        #endregion
                        pricedigit.ForeColor = Color.FromName(dr["color"].ToString());

                        int size = int.Parse(dr["sizefont"].ToString());
                        pricedigit.Font = new System.Drawing.Font(dr["namefont"].ToString(), size, n);
                   
                        pricedigit.Location = new Point(int.Parse(dr["locx"].ToString()), int.Parse(dr["locy"].ToString()));

                    }
                    ///////////////////////
                    if (dr["tabid"].ToString() == "6")
                    {
                        counts++;

                        #region style
                        FontStyle n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Bold")
                            n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Italic")
                            n = FontStyle.Italic;
                        if (dr["stylefont"].ToString() == "Regular")
                            n = FontStyle.Regular;
                        if (dr["stylefont"].ToString() == "Strikeout")
                            n = FontStyle.Strikeout;
                        if (dr["stylefont"].ToString() == "Underline")
                            n = FontStyle.Underline;
                        #endregion
                        description.ForeColor = Color.FromName(dr["color"].ToString());

                        int size = int.Parse(dr["sizefont"].ToString());
                        description.Font = new System.Drawing.Font(dr["namefont"].ToString(), size, n);
                        /////
                      
                        description.Location = new Point(int.Parse(dr["locx"].ToString()), int.Parse(dr["locy"].ToString()));

                    }
                    ///////////////////////
                    if (dr["tabid"].ToString() == "7")
                    {
                        counts++;

                        #region style
                        FontStyle n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Bold")
                            n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Italic")
                            n = FontStyle.Italic;
                        if (dr["stylefont"].ToString() == "Regular")
                            n = FontStyle.Regular;
                        if (dr["stylefont"].ToString() == "Strikeout")
                            n = FontStyle.Strikeout;
                        if (dr["stylefont"].ToString() == "Underline")
                            n = FontStyle.Underline;
                        #endregion
                        letters.ForeColor = Color.FromName(dr["color"].ToString());

                        int size = int.Parse(dr["sizefont"].ToString());
                        letters.Font = new System.Drawing.Font(dr["namefont"].ToString(), size, n);
                        /////
                      
                        letters.Location = new Point(int.Parse(dr["locx"].ToString()), int.Parse(dr["locy"].ToString()));

                    }
                    if (dr["tabid"].ToString() == "8")
                    {
                        counts++;

                        #region style
                        FontStyle n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Bold")
                            n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Italic")
                            n = FontStyle.Italic;
                        if (dr["stylefont"].ToString() == "Regular")
                            n = FontStyle.Regular;
                        if (dr["stylefont"].ToString() == "Strikeout")
                            n = FontStyle.Strikeout;
                        if (dr["stylefont"].ToString() == "Underline")
                            n = FontStyle.Underline;
                        #endregion

                        int size = int.Parse(dr["sizefont"].ToString());
                        fieldmore.Font = new System.Drawing.Font(dr["namefont"].ToString(), size, n);
                        /////
                        fieldmore.ForeColor = Color.FromName(dr["color"].ToString());
                      
                        fieldmore.Location = new Point(int.Parse(dr["locx"].ToString()), int.Parse(dr["locy"].ToString()));

                    }
                    if (counts >= 8)
                    {
                        break;
                    }

                }

            }

            mycon.Close();

        }
        private void loadimage1()
        {
            mycon = new SqlConnection(connecteiondatabase.passconnection());
            mycon.Open();
            string query = "select image from pnamepimage where namepattern='" + comboBox1.Text.Trim() + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, mycon);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            mycon.Close();
            byte[] ap = (byte[])(ds.Tables[0].Rows[0]["image"]);
            MemoryStream ms = new MemoryStream(ap);
            pictureBox1.Image = Image.FromStream(ms);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            ms.Close();
            //  Image i = Image.FromFile(pictureBox1.Name);
            pictureBox1.Width = pictureBox1.Image.Width;
            pictureBox1.Height = pictureBox1.Image.Height;
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadimage();
            loaddata();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }


        private void loadimage()
        {
            mycon = new SqlConnection(connecteiondatabase.passconnection());
            mycon.Open();
            string query = "select image from pnamepimage where namepattern='" + comboBox1.Text.Trim() + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, mycon);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            mycon.Close();
            byte[] ap = (byte[])(ds.Tables[0].Rows[0]["image"]);
            MemoryStream ms = new MemoryStream(ap);
            pictureBox1.Image = Image.FromStream(ms);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            ms.Close();
            //  Image i = Image.FromFile(pictureBox1.Name);
            pictureBox1.Width = pictureBox1.Image.Width;
            pictureBox1.Height = pictureBox1.Image.Height;
            rulerControl1.Width = pictureBox1.Image.Width + 5;
            rulerControl2.Height = pictureBox1.Image.Height + 5;
        }

        private void loaddata()
        {
            int counts = 0;
            string query = "SELECT * from savepattern where n_pattern='" + comboBox1.Text + "'";
            mycon = new SqlConnection(connecteiondatabase.passconnection());
            mycon.Open();
            mycmd = new SqlCommand(query, mycon);
            SqlDataReader dr = mycmd.ExecuteReader();
            while (dr.HasRows)
            {

                if (dr.Read())
                {
                    if (dr["tabid"].ToString() == "1")
                    {
                        counts++;
                        FontStyle n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Bold")
                            n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Italic")
                            n = FontStyle.Italic;
                        if (dr["stylefont"].ToString() == "Regular")
                            n = FontStyle.Regular;
                        if (dr["stylefont"].ToString() == "Strikeout")
                            n = FontStyle.Strikeout;
                        if (dr["stylefont"].ToString() == "Underline")
                            n = FontStyle.Underline;

                        int size = int.Parse(dr["sizefont"].ToString());
                        lbldatedigit.Font = new System.Drawing.Font(dr["namefont"].ToString(), size, n);
                        /////
                      
                        lbldatedigit.ForeColor = Color.FromName(dr["color"].ToString());
                      
                        lbldatedigit.Location = new Point(int.Parse(dr["locx"].ToString()), int.Parse(dr["locy"].ToString()));
                        //    break;
                    }
                    if (dr["tabid"].ToString() == "2")
                    {
                        counts++;

                        #region style
                        FontStyle n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Bold")
                            n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Italic")
                            n = FontStyle.Italic;
                        if (dr["stylefont"].ToString() == "Regular")
                            n = FontStyle.Regular;
                        if (dr["stylefont"].ToString() == "Strikeout")
                            n = FontStyle.Strikeout;
                        if (dr["stylefont"].ToString() == "Underline")
                            n = FontStyle.Underline;
                        #endregion

                        int size = int.Parse(dr["sizefont"].ToString());
                        lbldatelet.Font = new System.Drawing.Font(dr["namefont"].ToString(), size, n);
                        /////
                      
                        lbldatelet.ForeColor = Color.FromName(dr["color"].ToString());

          
                        lbldatelet.Location = new Point(int.Parse(dr["locx"].ToString()), int.Parse(dr["locy"].ToString()));

                    }
                    ///////////////////////
                    if (dr["tabid"].ToString() == "3")
                    {
                        counts++;

                        #region style
                        FontStyle n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Bold")
                            n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Italic")
                            n = FontStyle.Italic;
                        if (dr["stylefont"].ToString() == "Regular")
                            n = FontStyle.Regular;
                        if (dr["stylefont"].ToString() == "Strikeout")
                            n = FontStyle.Strikeout;
                        if (dr["stylefont"].ToString() == "Underline")
                            n = FontStyle.Underline;
                        #endregion

                        int size = int.Parse(dr["sizefont"].ToString());
                        pricelet.Font = new System.Drawing.Font(dr["namefont"].ToString(), size, n);
                        /////
                        pricelet.ForeColor = Color.FromName(dr["color"].ToString());
                      
                        pricelet.Location = new Point(int.Parse(dr["locx"].ToString()), int.Parse(dr["locy"].ToString()));

                    }
                    ///////////////////////
                    if (dr["tabid"].ToString() == "4")
                    {
                        counts++;

                        #region style
                        FontStyle n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Bold")
                            n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Italic")
                            n = FontStyle.Italic;
                        if (dr["stylefont"].ToString() == "Regular")
                            n = FontStyle.Regular;
                        if (dr["stylefont"].ToString() == "Strikeout")
                            n = FontStyle.Strikeout;
                        if (dr["stylefont"].ToString() == "Underline")
                            n = FontStyle.Underline;
                        #endregion

                        int size = int.Parse(dr["sizefont"].ToString());
                        recive.Font = new System.Drawing.Font(dr["namefont"].ToString(), size, n);
                        /////
                        recive.ForeColor = Color.FromName(dr["color"].ToString());


                      
                        recive.Location = new Point(int.Parse(dr["locx"].ToString()), int.Parse(dr["locy"].ToString()));

                    }
                    ///////////////////////
                    if (dr["tabid"].ToString() == "5")
                    {
                        counts++;

                        #region style
                        FontStyle n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Bold")
                            n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Italic")
                            n = FontStyle.Italic;
                        if (dr["stylefont"].ToString() == "Regular")
                            n = FontStyle.Regular;
                        if (dr["stylefont"].ToString() == "Strikeout")
                            n = FontStyle.Strikeout;
                        if (dr["stylefont"].ToString() == "Underline")
                            n = FontStyle.Underline;
                        #endregion
                        pricedigit.ForeColor = Color.FromName(dr["color"].ToString());

                        int size = int.Parse(dr["sizefont"].ToString());
                        pricedigit.Font = new System.Drawing.Font(dr["namefont"].ToString(), size, n);
                        /////
                     
                        pricedigit.Location = new Point(int.Parse(dr["locx"].ToString()), int.Parse(dr["locy"].ToString()));

                    }
                    ///////////////////////
                    if (dr["tabid"].ToString() == "6")
                    {
                        counts++;

                        #region style
                        FontStyle n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Bold")
                            n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Italic")
                            n = FontStyle.Italic;
                        if (dr["stylefont"].ToString() == "Regular")
                            n = FontStyle.Regular;
                        if (dr["stylefont"].ToString() == "Strikeout")
                            n = FontStyle.Strikeout;
                        if (dr["stylefont"].ToString() == "Underline")
                            n = FontStyle.Underline;
                        #endregion
                        description.ForeColor = Color.FromName(dr["color"].ToString());

                        int size = int.Parse(dr["sizefont"].ToString());
                        description.Font = new System.Drawing.Font(dr["namefont"].ToString(), size, n);
                        /////
                      
                        description.Location = new Point(int.Parse(dr["locx"].ToString()), int.Parse(dr["locy"].ToString()));

                    }
                    ///////////////////////
                    if (dr["tabid"].ToString() == "7")
                    {
                        counts++;

                        #region style
                        FontStyle n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Bold")
                            n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Italic")
                            n = FontStyle.Italic;
                        if (dr["stylefont"].ToString() == "Regular")
                            n = FontStyle.Regular;
                        if (dr["stylefont"].ToString() == "Strikeout")
                            n = FontStyle.Strikeout;
                        if (dr["stylefont"].ToString() == "Underline")
                            n = FontStyle.Underline;
                        #endregion
                        letters.ForeColor = Color.FromName(dr["color"].ToString());

                        int size = int.Parse(dr["sizefont"].ToString());
                        letters.Font = new System.Drawing.Font(dr["namefont"].ToString(), size, n);
                        /////
                       
                        letters.Location = new Point(int.Parse(dr["locx"].ToString()), int.Parse(dr["locy"].ToString()));

                    }
                    if (dr["tabid"].ToString() == "8")
                    {
                        counts++;

                        #region style
                        FontStyle n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Bold")
                            n = FontStyle.Bold;
                        if (dr["stylefont"].ToString() == "Italic")
                            n = FontStyle.Italic;
                        if (dr["stylefont"].ToString() == "Regular")
                            n = FontStyle.Regular;
                        if (dr["stylefont"].ToString() == "Strikeout")
                            n = FontStyle.Strikeout;
                        if (dr["stylefont"].ToString() == "Underline")
                            n = FontStyle.Underline;
                        #endregion

                        int size = int.Parse(dr["sizefont"].ToString());
                        fieldmore.Font = new System.Drawing.Font(dr["namefont"].ToString(), size, n);
                        /////
                        fieldmore.ForeColor = Color.FromName(dr["color"].ToString());
                      
                        fieldmore.Location = new Point(int.Parse(dr["locx"].ToString()), int.Parse(dr["locy"].ToString()));

                    }
                    if (counts >= 8)
                    {
                        break;
                    }

                }

            }

            mycon.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printfont = new Font("Arial", 10F);
            Point p = new Point(100, 100);
            e.Graphics.DrawString("sakmdfaslm ", printfont, Brushes.Black, 100, 100);
            //  e.Graphics.DrawString(lblcorner.Text, printfont, Brushes.Black, lblcorner.Location.X, lblcorner.Location.Y);

        }
    }
}
