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

namespace cheque_Factory
{
    public partial class frmmanagepattern1 : Form
    {
        public frmmanagepattern1()
        {
            InitializeComponent();
            lbldatedigit.Parent = pictureBox1;
            lbldatelet.Parent = pictureBox1;
            pricelet.Parent = pictureBox1;
            recive.Parent = pictureBox1;
            description.Parent = pictureBox1;
            letters.Parent = pictureBox1;
            pricedigit.Parent = pictureBox1;
            fieldmore.Parent = pictureBox1;

            #region myconnections

            #endregion

        }
        #region variable
        int oldvaluex1;
        int oldvaluey1;
        int oldvaluex2;
        int oldvaluey2;
        int oldvaluex3;
        int oldvaluey3;
        int oldvaluex4;
        int oldvaluey4;
        int oldvaluex5;
        int oldvaluey5;
        int oldvaluex6;
        int oldvaluey6;
        int oldvaluex7;
        int oldvaluey7;
        int oldvaluex8;
        int oldvaluey8;

        Point pontxy;
        Point pontxy2;
        Point pontxy3;
        Point pontxy4;
        Point pontxy5;
        Point pontxy6;
        Point pontxy7;
        Point pontxy8;

        #endregion
        public void loadbase()
        {
            int xlbl1;
            int ylbl1;
            int xlbl2;
            int ylbl2;
            int xlbl3;
            int ylbl3;
            int xlbl4;
            int ylbl4;
            int xlbl5;
            int ylbl5;
            int xlbl6;
            int ylbl6;
            int xlbl7;
            int ylbl7;
            int xlbl8;
            int ylbl8;
            xlbl1 = lbldatedigit.Right;
            ylbl1 = lbldatedigit.Bottom;
            xlbl2 = lbldatelet.Right;
            ylbl2 = lbldatelet.Bottom;
            xlbl3 = pricelet.Right;
            ylbl3 = pricelet.Bottom;
            xlbl4 = recive.Right;
            ylbl4 = recive.Bottom;
            xlbl5 = pricedigit.Right;
            ylbl5 = pricedigit.Bottom;
            xlbl6 = description.Right;
            ylbl6 = description.Bottom;

            xlbl7 = letters.Right;
            ylbl7 = letters.Bottom;

            xlbl8 = fieldmore.Right;
            ylbl8 = fieldmore.Bottom;

          

        }
        Graphics g;
        bool settings = false;
        Brush bb = new SolidBrush(Color.Red);
        private void frmmanagepattern_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnshowsetting_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
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
        SqlParameter picture;
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmmanagepattern_Load(object sender, EventArgs e)
        {
            
            comboBox1.SelectedIndex = -1;
            loadincombobox();
            comboBox1.Text = "";

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rulerControl1.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smMillimetres;
            rulerControl1.MajorInterval = 10;
            rulerControl2.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smMillimetres;
            rulerControl2.MajorInterval = 10;
            rulerControl1.Width = pictureBox1.Width + 5;
            rulerControl2.Height = pictureBox1.Height + 5;
            lblcorner.Text = "ML";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rulerControl1.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smCentimetres;
            rulerControl1.MajorInterval = 10;
            rulerControl2.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smCentimetres;
            rulerControl2.MajorInterval = 10;
            rulerControl1.Width = pictureBox1.Width + 5;
            rulerControl2.Height = pictureBox1.Height + 5;
            lblcorner.Text = "Cm";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            rulerControl1.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smPixels;
            rulerControl1.MajorInterval = 100;
            rulerControl2.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smPixels;
            rulerControl2.MajorInterval = 100;
            rulerControl1.Width = pictureBox1.Width + 5;
            rulerControl2.Height = pictureBox1.Height + 5;
            lblcorner.Text = "PX";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            rulerControl1.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smInches;
            rulerControl1.MajorInterval = 1;
            rulerControl2.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smInches;
            rulerControl2.MajorInterval = 1;
            rulerControl1.Width = pictureBox1.Width + 5;
            rulerControl2.Height = pictureBox1.Height + 5;
            lblcorner.Text = "IN";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            rulerControl1.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smPoints;
            rulerControl1.MajorInterval = 50;
            rulerControl2.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smPoints;
            rulerControl2.MajorInterval = 50;
            rulerControl1.Width = pictureBox1.Width + 5;
            rulerControl2.Height = pictureBox1.Height + 5;
            lblcorner.Text = "PT";
        }

        private void lbldatedigit_MouseDown(object sender, MouseEventArgs e)
        {
            pontxy = e.Location;
           
        }

        private void lbldatedigit_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Control c = (Control)sender;
                if (e.Button == MouseButtons.Left)
                {
                    c.Left += e.X - pontxy.X;
                    c.Top += e.Y - pontxy.Y;
                    g = pictureBox1.CreateGraphics();
                    pictureBox1.Refresh();
                    int x = c.Right;
                    int y = c.Bottom;
                 
                    g.DrawLine(Pens.Black, x, 0, x, pictureBox1.Height);
                    g.DrawLine(Pens.Black, 0, y, pictureBox1.Width, y);
                }
            }
            catch
            {
                //MessageBox.Show("لطفا از محدوده عکس بیرون نروید");
            }
        }

        private void lbldatelet_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void lbldatelet_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Control c = (Control)sender;
                if (e.Button == MouseButtons.Left)
                {
                    c.Left += e.X - pontxy.X;
                    c.Top += e.Y - pontxy.Y;
                    g = pictureBox1.CreateGraphics();
                    pictureBox1.Refresh();
                    int x = c.Right;
                    int y = c.Bottom;

                 
                    g.DrawLine(Pens.Black, x, 0, x, pictureBox1.Height);
                    g.DrawLine(Pens.Black, 0, y, pictureBox1.Width, y);
                }
            }
            catch
            {
                //MessageBox.Show("لطفا از محدوده عکس بیرون نروید");
            }
        }

        private void recive_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Control c = (Control)sender;
                if (e.Button == MouseButtons.Left)
                {
                    c.Left += e.X - pontxy.X;
                    c.Top += e.Y - pontxy.Y;
                    g = pictureBox1.CreateGraphics();
                    pictureBox1.Refresh();
                    int x = c.Right;
                    int y = c.Bottom;

                  
                    g.DrawLine(Pens.Black, x, 0, x, pictureBox1.Height);
                    g.DrawLine(Pens.Black, 0, y, pictureBox1.Width, y);
                }
            }
            catch
            {
                //MessageBox.Show("لطفا از محدوده عکس بیرون نروید");
            }
        }

        private void description_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Control c = (Control)sender;
                if (e.Button == MouseButtons.Left)
                {
                    c.Left += e.X - pontxy.X;
                    c.Top += e.Y - pontxy.Y;
                    g = pictureBox1.CreateGraphics();
                    pictureBox1.Refresh();
                    int x = c.Right;
                    int y = c.Bottom;

                 
                    g.DrawLine(Pens.Black, x, 0, x, pictureBox1.Height);
                    g.DrawLine(Pens.Black, 0, y, pictureBox1.Width, y);
                }
            }
            catch
            {
                //MessageBox.Show("لطفا از محدوده عکس بیرون نروید");
            }
        }

        private void fieldmore_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Control c = (Control)sender;
                if (e.Button == MouseButtons.Left)
                {
                    c.Left += e.X - pontxy.X;
                    c.Top += e.Y - pontxy.Y;
                    g = pictureBox1.CreateGraphics();
                    pictureBox1.Refresh();
                    int x = c.Right;
                    int y = c.Bottom;

                 
                    g.DrawLine(Pens.Black, x, 0, x, pictureBox1.Height);
                    g.DrawLine(Pens.Black, 0, y, pictureBox1.Width, y);
                }
            }
            catch
            {
                //MessageBox.Show("لطفا از محدوده عکس بیرون نروید");
            }
        }

        private void pricelet_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Control c = (Control)sender;
                if (e.Button == MouseButtons.Left)
                {
                    c.Left += e.X - pontxy.X;
                    c.Top += e.Y - pontxy.Y;
                    g = pictureBox1.CreateGraphics();
                    pictureBox1.Refresh();
                    int x = c.Right;
                    int y = c.Bottom;

                   
                    g.DrawLine(Pens.Black, x, 0, x, pictureBox1.Height);
                    g.DrawLine(Pens.Black, 0, y, pictureBox1.Width, y);
                }
            }
            catch
            {
                //MessageBox.Show("لطفا از محدوده عکس بیرون نروید");
            }
        }

        private void pricedigit_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Control c = (Control)sender;
                if (e.Button == MouseButtons.Left)
                {
                    c.Left += e.X - pontxy.X;
                    c.Top += e.Y - pontxy.Y;
                    g = pictureBox1.CreateGraphics();
                    pictureBox1.Refresh();
                    int x = c.Right;
                    int y = c.Bottom;

                
                    g.DrawLine(Pens.Black, x, 0, x, pictureBox1.Height);
                    g.DrawLine(Pens.Black, 0, y, pictureBox1.Width, y);
                }
            }
            catch
            {
                //MessageBox.Show("لطفا از محدوده عکس بیرون نروید");
            }
        }

        private void letters_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Control c = (Control)sender;
                if (e.Button == MouseButtons.Left)
                {
                    c.Left += e.X - pontxy.X;
                    c.Top += e.Y - pontxy.Y;
                    g = pictureBox1.CreateGraphics();
                    pictureBox1.Refresh();
                    int x = c.Right;
                    int y = c.Bottom;

                  
                    g.DrawLine(Pens.Black, x, 0, x, pictureBox1.Height);
                    g.DrawLine(Pens.Black, 0, y, pictureBox1.Width, y);
                }
            }
            catch
            {
                //MessageBox.Show("لطفا از محدوده عکس بیرون نروید");
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            pictureBox1.Refresh();
            int x = e.X;
            int y = e.Y;
            g.DrawLine(Pens.Black, x, 0, x, pictureBox1.Height);
            g.DrawLine(Pens.Black, 0, y, pictureBox1.Width, y);
        }

   

    
       
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
         

        }


        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void loadimage() {
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                loadimage();
                loaddata();
            }
            
        }

      
       

        
     
        private void lbldatelet_MouseDown(object sender, MouseEventArgs e)
        {
            pontxy = e.Location;
           
        }

        private void pricelet_MouseDown(object sender, MouseEventArgs e)
        {
            pontxy = e.Location;
        }

        private void recive_MouseDown(object sender, MouseEventArgs e)
        {
            pontxy = e.Location;
        }

        private void pricedigit_MouseDown(object sender, MouseEventArgs e)
        {
            pontxy = e.Location;
        }

        private void description_MouseDown(object sender, MouseEventArgs e)
        {
            pontxy = e.Location;
        }

        private void letters_MouseDown(object sender, MouseEventArgs e)
        {
            pontxy = e.Location;
        }

        private void fieldmore_MouseDown(object sender, MouseEventArgs e)
        {
            pontxy = e.Location;
        }

        SqlConnection mycom;
        SqlDataAdapter myda;
      

       
       
     

      

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
    }
}


