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
    public partial class frmmanagepattern : Form
    {
        public frmmanagepattern()
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

            numdigitx.Value = pictureBox1.Width - xlbl1;
            numdigity.Value = pictureBox1.Height - ylbl1;

            numdigitx2.Value = pictureBox1.Width - xlbl2;
            numdigity2.Value = pictureBox1.Height - ylbl2;

            numdigitx3.Value = pictureBox1.Width - xlbl3;
            numdigity3.Value = pictureBox1.Height - ylbl3;

            numdigitx4.Value = pictureBox1.Width - xlbl4;
            numdigity4.Value = pictureBox1.Height - ylbl4;

            numdigitx5.Value = pictureBox1.Width - xlbl5;
            numdigity5.Value = pictureBox1.Height - ylbl5;

            numdigitx6.Value = pictureBox1.Width - xlbl6;
            numdigity6.Value = pictureBox1.Height - ylbl6;

            numdigitx7.Value = pictureBox1.Width - xlbl7;
            numdigity7.Value = pictureBox1.Height - ylbl7;

            numdigitx8.Value = pictureBox1.Width - xlbl8;
            numdigity8.Value = pictureBox1.Height - ylbl8;

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedText != "")
            {
                loadimage1.Enabled = true;
                Edit.Enabled = true;
                delete.Enabled = true;
            }
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
        private void loadimage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image i = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Width = i.Width;
                pictureBox1.Height = i.Height;
                rulerControl1.Width = i.Width + 5;
                rulerControl2.Height = i.Height + 5;
                passdate.SelectImage = i;
             /////modify image from database  
                mycon = new SqlConnection(connecteiondatabase.passconnection());

                picture = new SqlParameter("@picture", SqlDbType.Image);
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
                mycmd.Parameters.Clear();
                mycmd.Connection = mycon;
                mycon.Open();
                mycmd.Parameters.AddWithValue("@picture", a);
                mycmd.CommandText = "UPDATE pnamepimage SET image=@picture where namepattern='" + comboBox1.Text.Trim() + "'";
                mycmd.ExecuteNonQuery();
                mycon.Close();
                MessageBox.Show("عکس مورد نظر جایگزین شد");
            }
        }

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
            tabControl1.SelectTab(0);
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
                    numdigitx.Value = pictureBox1.Width - x;
                    numdigity.Value = pictureBox1.Height - y;
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

                    numdigitx2.Value = pictureBox1.Width - x;
                    numdigity2.Value = pictureBox1.Height - y;
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

                    numdigitx4.Value = pictureBox1.Width - x;
                    numdigity4.Value = pictureBox1.Height - y;
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

                    numdigitx6.Value = pictureBox1.Width - x;
                    numdigity6.Value = pictureBox1.Height - y;
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

                    numdigitx8.Value = pictureBox1.Width - x;
                    numdigity8.Value = pictureBox1.Height - y;
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

                    numdigitx3.Value = pictureBox1.Width - x;
                    numdigity3.Value = pictureBox1.Height - y;
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

                    numdigitx5.Value = pictureBox1.Width - x;
                    numdigity5.Value = pictureBox1.Height - y;
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

                    numdigitx7.Value = pictureBox1.Width - x;
                    numdigity7.Value = pictureBox1.Height - y;
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

        private void btFont1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtfont.Text = fontDialog1.Font.Name;
                txtstyle.Text = fontDialog1.Font.Style.ToString();
                int sizep = (int)fontDialog1.Font.Size;
                txtsize.Text = sizep.ToString();
                lbldatedigit.Font = new System.Drawing.Font(fontDialog1.Font.Name, sizep, fontDialog1.Font.Style);
            }
        }

        private void plShowColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                plShowColor.BackColor = colorDialog1.Color;
                lbldatedigit.ForeColor = colorDialog1.Color;
            }
        }

        private void btnFont2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtfont2.Text = fontDialog1.Font.Name;
                txtstyle2.Text = fontDialog1.Font.Style.ToString();
                int sizep = (int)fontDialog1.Font.Size;
                txtsize2.Text = sizep.ToString();
                lbldatelet.Font = new System.Drawing.Font(fontDialog1.Font.Name, sizep, fontDialog1.Font.Style);
            }
        }

        private void plShowColor2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                plShowColor2.BackColor = colorDialog1.Color;
                lbldatelet.ForeColor = colorDialog1.Color;
            }
        }

        private void btnFont3_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtfont3.Text = fontDialog1.Font.Name;
                txtstyle3.Text = fontDialog1.Font.Style.ToString();
                int sizep = (int)fontDialog1.Font.Size;
                txtsize3.Text = sizep.ToString();
                pricelet.Font = new System.Drawing.Font(fontDialog1.Font.Name, sizep, fontDialog1.Font.Style);
            }
        }

        private void plShowColor3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                plShowColor3.BackColor = colorDialog1.Color;
                pricelet.ForeColor = colorDialog1.Color;
            }
        }

        private void btnFont4_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtfont4.Text = fontDialog1.Font.Name;
                txtstyle4.Text = fontDialog1.Font.Style.ToString();
                int sizep = (int)fontDialog1.Font.Size;
                txtsize4.Text = sizep.ToString();
                recive.Font = new System.Drawing.Font(fontDialog1.Font.Name, sizep, fontDialog1.Font.Style);
            }
        }

        private void plShowColor4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                plShowColor4.BackColor = colorDialog1.Color;
                recive.ForeColor = colorDialog1.Color;
            }
        }

        private void btnFont5_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtfont5.Text = fontDialog1.Font.Name;
                txtstyle5.Text = fontDialog1.Font.Style.ToString();
                int sizep = (int)fontDialog1.Font.Size;
                txtsize5.Text = sizep.ToString();
                pricedigit.Font = new System.Drawing.Font(fontDialog1.Font.Name, sizep, fontDialog1.Font.Style);
            }
        }

        private void plShowColor5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                plShowColor5.BackColor = colorDialog1.Color;
                pricedigit.ForeColor = colorDialog1.Color;
            }
        }

        private void btnFont6_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtfont6.Text = fontDialog1.Font.Name;
                txtstyle6.Text = fontDialog1.Font.Style.ToString();
                int sizep = (int)fontDialog1.Font.Size;
                txtsize6.Text = sizep.ToString();
                description.Font = new System.Drawing.Font(fontDialog1.Font.Name, sizep, fontDialog1.Font.Style);
            }
        }

        private void plShowColor6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                plShowColor6.BackColor = colorDialog1.Color;
                description.ForeColor = colorDialog1.Color;
            }
        }

        private void btnFont7_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtfont7.Text = fontDialog1.Font.Name;
                txtstyle7.Text = fontDialog1.Font.Style.ToString();
                int sizep = (int)fontDialog1.Font.Size;
                txtsize7.Text = sizep.ToString();
                letters.Font = new System.Drawing.Font(fontDialog1.Font.Name, sizep, fontDialog1.Font.Style);
            }
        }

        private void plShowColor7_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                plShowColor7.BackColor = colorDialog1.Color;
                letters.ForeColor = colorDialog1.Color;
            }
        }

        private void btnFont8_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtfont8.Text = fontDialog1.Font.Name;
                txtstyle8.Text = fontDialog1.Font.Style.ToString();
                int sizep = (int)fontDialog1.Font.Size;
                txtsize8.Text = sizep.ToString();
                fieldmore.Font = new System.Drawing.Font(fontDialog1.Font.Name, sizep, fontDialog1.Font.Style);
            }
        }

        private void plShowColor8_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                plShowColor8.BackColor = colorDialog1.Color;
                fieldmore.ForeColor = colorDialog1.Color;
            }
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
                        txtfont.Text = dr["namefont"].ToString();
                        txtstyle.Text = dr["stylefont"].ToString();
                        txtsize.Text = dr["sizefont"].ToString();
                        plShowColor.BackColor = Color.FromName(dr["color"].ToString());
                        lbldatedigit.ForeColor = Color.FromName(dr["color"].ToString());
                        numdigitx.Value = int.Parse(dr["Rright"].ToString());
                        numdigity.Value = int.Parse(dr["Bbottom"].ToString());
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
                        txtfont2.Text = dr["namefont"].ToString();
                        txtstyle2.Text = dr["stylefont"].ToString();
                        txtsize2.Text = dr["sizefont"].ToString();
                        lbldatelet.ForeColor = Color.FromName(dr["color"].ToString());

                        plShowColor2.BackColor = Color.FromName(dr["color"].ToString());
                        numdigitx2.Value = int.Parse(dr["Rright"].ToString());
                        numdigity2.Value = int.Parse(dr["Bbottom"].ToString());
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
                        txtfont3.Text = dr["namefont"].ToString();
                        txtstyle3.Text = dr["stylefont"].ToString();
                        txtsize3.Text = dr["sizefont"].ToString();
                        plShowColor3.BackColor = Color.FromName(dr["color"].ToString());
                        numdigitx3.Value = int.Parse(dr["Rright"].ToString());
                        numdigity3.Value = int.Parse(dr["Bbottom"].ToString());
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


                        txtfont4.Text = dr["namefont"].ToString();
                        txtstyle4.Text = dr["stylefont"].ToString();
                        txtsize4.Text = dr["sizefont"].ToString();
                        plShowColor4.BackColor = Color.FromName(dr["color"].ToString());
                        numdigitx4.Value = int.Parse(dr["Rright"].ToString());
                        numdigity4.Value = int.Parse(dr["Bbottom"].ToString());
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
                        txtfont5.Text = dr["namefont"].ToString();
                        txtstyle5.Text = dr["stylefont"].ToString();
                        txtsize5.Text = dr["sizefont"].ToString();
                        plShowColor5.BackColor = Color.FromName(dr["color"].ToString());
                        numdigitx5.Value = int.Parse(dr["Rright"].ToString());
                        numdigity5.Value = int.Parse(dr["Bbottom"].ToString());
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
                        txtfont6.Text = dr["namefont"].ToString();
                        txtstyle6.Text = dr["stylefont"].ToString();
                        txtsize6.Text = dr["sizefont"].ToString();
                        plShowColor6.BackColor = Color.FromName(dr["color"].ToString());
                        numdigitx6.Value = int.Parse(dr["Rright"].ToString());
                        numdigity6.Value = int.Parse(dr["Bbottom"].ToString());
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
                        txtfont7.Text = dr["namefont"].ToString();
                        txtstyle7.Text = dr["stylefont"].ToString();
                        txtsize7.Text = dr["sizefont"].ToString();
                        plShowColor7.BackColor = Color.FromName(dr["color"].ToString());
                        numdigitx7.Value = int.Parse(dr["Rright"].ToString());
                        numdigity7.Value = int.Parse(dr["Bbottom"].ToString());
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
                        txtfont8.Text = dr["namefont"].ToString();
                        txtstyle8.Text = dr["stylefont"].ToString();
                        txtsize8.Text = dr["sizefont"].ToString();
                        plShowColor8.BackColor = Color.FromName(dr["color"].ToString());
                        numdigitx8.Value = int.Parse(dr["Rright"].ToString());
                        numdigity8.Value = int.Parse(dr["Bbottom"].ToString());
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

        private void numdigitx_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluex1 = (int)numdigitx.Value;
        }

        private void numdigitx_ValueChanged(object sender, EventArgs e)
        {
            if (numdigitx.Value > oldvaluex1)
            {
                lbldatedigit.Left--;
            }
            else
            {
                lbldatedigit.Left++;
            }
        }

        private void numdigity_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluey1 = (int)numdigity.Value;
        }

        private void numdigity_ValueChanged(object sender, EventArgs e)
        {
            if (numdigity.Value > oldvaluey1)
            {
                lbldatedigit.Top--;
            }
            else
            {
                lbldatedigit.Top++;
            }
        }

        private void numdigitx2_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluex2 = (int)numdigitx2.Value;
        }

        private void numdigitx2_ValueChanged(object sender, EventArgs e)
        {
            if (numdigitx2.Value > oldvaluex2)
            {
                lbldatelet.Left--;
            }
            else
            {
                lbldatelet.Left++;
            }
        }

        private void numdigity2_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluey2 = (int)numdigity2.Value;
        }

        private void numdigity2_ValueChanged(object sender, EventArgs e)
        {
            if (numdigity2.Value > oldvaluey2)
            {
                lbldatelet.Top--;
            }
            else
            {
                lbldatelet.Top++;
            }
        }

        private void numdigitx3_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluex3 = (int)numdigitx3.Value;
        }

        private void numdigitx3_ValueChanged(object sender, EventArgs e)
        {
            if (numdigitx3.Value > oldvaluex3)
            {
                pricelet.Left--;
            }
            else
            {
                pricelet.Left++;
            }
        }

        private void numdigity3_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluey3 = (int)numdigity3.Value;
        }

        private void numdigity3_ValueChanged(object sender, EventArgs e)
        {
            if (numdigity3.Value > oldvaluey3)
            {
                pricelet.Top--;
            }
            else
            {
                pricelet.Top++;
            }
        }

        private void numdigity4_ValueChanged(object sender, EventArgs e)
        {
            if (numdigity4.Value > oldvaluey4)
            {
                recive.Top--;
            }
            else
            {
                recive.Top++;
            }
        }

        private void numdigity4_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluey4 = (int)numdigity4.Value;
        }

        private void numdigitx5_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluex5 = (int)numdigitx5.Value;
        }

        private void numdigitx5_ValueChanged(object sender, EventArgs e)
        {
            if (numdigitx5.Value > oldvaluex5)
            {
                pricedigit.Left--;
            }
            else
            {
                pricedigit.Left++;
            }
        }

        private void numdigity5_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluey5 = (int)numdigity5.Value;

        }

        private void numdigity5_ValueChanged(object sender, EventArgs e)
        {
            if (numdigity5.Value > oldvaluey5)
            {
                pricedigit.Top--;
            }
            else
            {
                pricedigit.Top++;
            }
        }

        private void numdigitx4_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluex4 = (int)numdigitx4.Value;

        }

        private void numdigitx4_ValueChanged(object sender, EventArgs e)
        {
            if (numdigitx4.Value > oldvaluex4)
            {
                recive.Left--;
            }
            else
            {
                recive.Left++;
            }
        }

        private void numdigitx6_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluex6 = (int)numdigitx6.Value;
        }

        private void numdigitx6_ValueChanged(object sender, EventArgs e)
        {
            if (numdigitx6.Value > oldvaluex6)
            {
                description.Left--;
            }
            else
            {
                description.Left++;
            }
        }

        private void numdigity6_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluey6 = (int)numdigity6.Value;
        }

        private void numdigity6_ValueChanged(object sender, EventArgs e)
        {
            if (numdigity6.Value > oldvaluey6)
            {
                description.Top--;
            }
            else
            {
                description.Top++;
            }
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluex7 = (int)numdigitx7.Value;
        }

        private void numdigitx7_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluex7 = (int)numdigitx7.Value;
        }

        private void numdigitx7_ValueChanged(object sender, EventArgs e)
        {
            if (numdigitx7.Value > oldvaluex7)
            {
                letters.Left--;
            }
            else
            {
                letters.Left++;
            }
        }

        private void numdigity7_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluey7 = (int)numdigity7.Value;
        }

        private void numdigity7_ValueChanged(object sender, EventArgs e)
        {
            if (numdigity7.Value > oldvaluey7)
            {
                letters.Top--;
            }
            else
            {
                letters.Top++;
            }
        }

        private void numdigitx8_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluex8 = (int)numdigitx8.Value;
        }

        private void numdigitx8_ValueChanged(object sender, EventArgs e)
        {
            if (numdigitx8.Value > oldvaluex8)
            {
                fieldmore.Left--;
            }
            else
            {
                fieldmore.Left++;
            }
        }

        private void numdigity8_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluey8 = (int)numdigity8.Value;
        }

        private void numdigity8_ValueChanged(object sender, EventArgs e)
        {
            if (numdigity8.Value > oldvaluey8)
            {
                fieldmore.Top--;
            }
            else
            {
                fieldmore.Top++;
            }
        }

        private void lbldatelet_MouseDown(object sender, MouseEventArgs e)
        {
            pontxy = e.Location;
            tabControl1.SelectTab(1);
        }

        private void pricelet_MouseDown(object sender, MouseEventArgs e)
        {
            pontxy = e.Location;
            tabControl1.SelectTab(2);
        }

        private void recive_MouseDown(object sender, MouseEventArgs e)
        {
            pontxy = e.Location;
            tabControl1.SelectTab(3);
        }

        private void pricedigit_MouseDown(object sender, MouseEventArgs e)
        {
            pontxy = e.Location;
            tabControl1.SelectTab(4);
        }

        private void description_MouseDown(object sender, MouseEventArgs e)
        {
            pontxy = e.Location;
            tabControl1.SelectTab(5);
        }

        private void letters_MouseDown(object sender, MouseEventArgs e)
        {
            pontxy = e.Location;
            tabControl1.SelectTab(6);
        }

        private void fieldmore_MouseDown(object sender, MouseEventArgs e)
        {
            pontxy = e.Location;
            tabControl1.SelectTab(7);
        }

        SqlConnection mycom;
        SqlDataAdapter myda;
        private void Edit_Click(object sender, EventArgs e)
        {
           myda = new SqlDataAdapter();
            mycom = new SqlConnection(connecteiondatabase.passconnection());
            mycom.Open();
            /////1
            mycmd = new SqlCommand("updatedata", mycom);
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.Add("@n_pattern", SqlDbType.NVarChar).Value = comboBox1.Text.Trim();
            mycmd.Parameters.Add("@Tabid", SqlDbType.NVarChar).Value = "1";
            mycmd.Parameters.Add("@namefont", SqlDbType.NVarChar).Value = txtfont.Text;
            mycmd.Parameters.Add("@stylefont", SqlDbType.NVarChar).Value = txtstyle.Text;
            mycmd.Parameters.Add("@sizefont", SqlDbType.NVarChar).Value = txtsize.Text;
            mycmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = plShowColor.BackColor.Name.ToString();
            mycmd.Parameters.Add("@Rright", SqlDbType.Int).Value = numdigitx.Value.ToString();
            mycmd.Parameters.Add("@locx", SqlDbType.Int).Value = pictureBox1.Width - int.Parse((numdigitx.Value).ToString()) - lbldatedigit.Width;
            mycmd.Parameters.Add("@locy", SqlDbType.Int).Value = pictureBox1.Height - int.Parse(numdigity.Value.ToString()) - lbldatedigit.Height;
            mycmd.Parameters.Add("@Bbottom", SqlDbType.Int).Value = numdigity.Value.ToString();
            mycmd.Parameters.Add("@show", SqlDbType.Bit).Value = 1;
            mycmd.ExecuteNonQuery();
            ///////2
            mycmd = new SqlCommand("updatedata", mycom);
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.Add("@n_pattern", SqlDbType.NVarChar).Value = comboBox1.Text.Trim();
            mycmd.Parameters.Add("@Tabid", SqlDbType.NVarChar).Value = "2";
            mycmd.Parameters.Add("@namefont", SqlDbType.NVarChar).Value = txtfont2.Text;
            mycmd.Parameters.Add("@stylefont", SqlDbType.NVarChar).Value = txtstyle2.Text;
            mycmd.Parameters.Add("@sizefont", SqlDbType.NVarChar).Value = txtsize2.Text;
            mycmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = plShowColor2.BackColor.Name.ToString();
            mycmd.Parameters.Add("@Rright", SqlDbType.Int).Value = numdigitx2.Value.ToString();

            mycmd.Parameters.Add("@locx", SqlDbType.Int).Value = pictureBox1.Width - int.Parse((numdigitx2.Value).ToString()) - lbldatelet.Width;
            mycmd.Parameters.Add("@locy", SqlDbType.Int).Value = pictureBox1.Height - int.Parse(numdigity2.Value.ToString()) - lbldatelet.Height;

            mycmd.Parameters.Add("@Bbottom", SqlDbType.Int).Value = numdigity2.Value.ToString();
            mycmd.Parameters.Add("@show", SqlDbType.Bit).Value = 1;
            mycmd.ExecuteNonQuery();
            //////3
            mycmd = new SqlCommand("updatedata", mycom);
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.Add("@Tabid", SqlDbType.NVarChar).Value = "3";
            mycmd.Parameters.Add("@n_pattern", SqlDbType.NVarChar).Value = comboBox1.Text.Trim();
            mycmd.Parameters.Add("@namefont", SqlDbType.NVarChar).Value = txtfont3.Text;
            mycmd.Parameters.Add("@stylefont", SqlDbType.NVarChar).Value = txtstyle3.Text;
            mycmd.Parameters.Add("@sizefont", SqlDbType.NVarChar).Value = txtsize3.Text;
            mycmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = plShowColor3.BackColor.Name.ToString();
            mycmd.Parameters.Add("@Rright", SqlDbType.Int).Value = numdigitx3.Value.ToString();

            mycmd.Parameters.Add("@locx", SqlDbType.Int).Value = pictureBox1.Width - int.Parse((numdigitx3.Value).ToString()) - pricelet.Width;
            mycmd.Parameters.Add("@locy", SqlDbType.Int).Value = pictureBox1.Height - int.Parse(numdigity3.Value.ToString()) - pricelet.Height;

            mycmd.Parameters.Add("@Bbottom", SqlDbType.Int).Value = numdigity3.Value.ToString();
            mycmd.Parameters.Add("@show", SqlDbType.Bit).Value = 1;
            mycmd.ExecuteNonQuery();
            /////4
            mycmd = new SqlCommand("updatedata", mycom);
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.Add("@n_pattern", SqlDbType.NVarChar).Value = comboBox1.Text.Trim();
            mycmd.Parameters.Add("@Tabid", SqlDbType.NVarChar).Value = "4";
            mycmd.Parameters.Add("@namefont", SqlDbType.NVarChar).Value = txtfont4.Text;
            mycmd.Parameters.Add("@stylefont", SqlDbType.NVarChar).Value = txtstyle4.Text;
            mycmd.Parameters.Add("@sizefont", SqlDbType.NVarChar).Value = txtsize4.Text;
            mycmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = plShowColor4.BackColor.Name.ToString();

            mycmd.Parameters.Add("@locx", SqlDbType.Int).Value = pictureBox1.Width - int.Parse((numdigitx4.Value).ToString()) - recive.Width;
            mycmd.Parameters.Add("@locy", SqlDbType.Int).Value = pictureBox1.Height - int.Parse(numdigity4.Value.ToString()) - recive.Height;


            mycmd.Parameters.Add("@Rright", SqlDbType.Int).Value = numdigitx4.Value.ToString();
            mycmd.Parameters.Add("@Bbottom", SqlDbType.Int).Value = numdigity4.Value.ToString();
            mycmd.Parameters.Add("@show", SqlDbType.Bit).Value = 1;
            mycmd.ExecuteNonQuery();
            /////5
            mycmd = new SqlCommand("updatedata", mycom);
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.Add("@n_pattern", SqlDbType.NVarChar).Value = comboBox1.Text.Trim();
            mycmd.Parameters.Add("@Tabid", SqlDbType.NVarChar).Value = "5";

            mycmd.Parameters.Add("@namefont", SqlDbType.NVarChar).Value = txtfont5.Text;
            mycmd.Parameters.Add("@stylefont", SqlDbType.NVarChar).Value = txtstyle5.Text;
            mycmd.Parameters.Add("@sizefont", SqlDbType.NVarChar).Value = txtsize5.Text;
            mycmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = plShowColor5.BackColor.Name.ToString();
            mycmd.Parameters.Add("@Rright", SqlDbType.Int).Value = numdigitx5.Value.ToString();

            mycmd.Parameters.Add("@locx", SqlDbType.Int).Value = pictureBox1.Width - int.Parse((numdigitx5.Value).ToString()) - pricedigit.Width;
            mycmd.Parameters.Add("@locy", SqlDbType.Int).Value = pictureBox1.Height - int.Parse(numdigity5.Value.ToString()) - pricedigit.Height;

            mycmd.Parameters.Add("@Bbottom", SqlDbType.Int).Value = numdigity5.Value.ToString();
            mycmd.Parameters.Add("@show", SqlDbType.Bit).Value = 1;
            mycmd.ExecuteNonQuery();
            /////6
            mycmd = new SqlCommand("updatedata", mycom);
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.Add("@n_pattern", SqlDbType.NVarChar).Value = comboBox1.Text.Trim();
            mycmd.Parameters.Add("@Tabid", SqlDbType.NVarChar).Value = "6";

            mycmd.Parameters.Add("@namefont", SqlDbType.NVarChar).Value = txtfont6.Text;
            mycmd.Parameters.Add("@stylefont", SqlDbType.NVarChar).Value = txtstyle6.Text;
            mycmd.Parameters.Add("@sizefont", SqlDbType.NVarChar).Value = txtsize6.Text;
            mycmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = plShowColor6.BackColor.Name.ToString();

            mycmd.Parameters.Add("@locx", SqlDbType.Int).Value = pictureBox1.Width - int.Parse((numdigitx6.Value).ToString()) - description.Width;
            mycmd.Parameters.Add("@locy", SqlDbType.Int).Value = pictureBox1.Height - int.Parse(numdigity6.Value.ToString()) - description.Height;


            mycmd.Parameters.Add("@Rright", SqlDbType.Int).Value = numdigitx6.Value.ToString();
            mycmd.Parameters.Add("@Bbottom", SqlDbType.Int).Value = numdigity6.Value.ToString();
            mycmd.Parameters.Add("@show", SqlDbType.Bit).Value = 1;
            mycmd.ExecuteNonQuery();
            /////7
            mycmd = new SqlCommand("updatedata", mycom);
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.Add("@n_pattern", SqlDbType.NVarChar).Value = comboBox1.Text.Trim();
            mycmd.Parameters.Add("@Tabid", SqlDbType.NVarChar).Value = "7";
            mycmd.Parameters.Add("@namefont", SqlDbType.NVarChar).Value = txtfont7.Text;
            mycmd.Parameters.Add("@stylefont", SqlDbType.NVarChar).Value = txtstyle7.Text;
            mycmd.Parameters.Add("@sizefont", SqlDbType.NVarChar).Value = txtsize7.Text;
            mycmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = plShowColor7.BackColor.Name.ToString();
            mycmd.Parameters.Add("@Rright", SqlDbType.Int).Value = numdigitx7.Value.ToString();

            mycmd.Parameters.Add("@locx", SqlDbType.Int).Value = pictureBox1.Width - int.Parse((numdigitx7.Value).ToString()) - letters.Width;
            mycmd.Parameters.Add("@locy", SqlDbType.Int).Value = pictureBox1.Height - int.Parse(numdigity7.Value.ToString()) - letters.Height;


            mycmd.Parameters.Add("@Bbottom", SqlDbType.Int).Value = numdigity7.Value.ToString();
            mycmd.Parameters.Add("@show", SqlDbType.Bit).Value = 1;
            mycmd.ExecuteNonQuery();
            /////8
            mycmd = new SqlCommand("updatedata", mycom);
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.Add("@n_pattern", SqlDbType.NVarChar).Value = comboBox1.Text.Trim();
            mycmd.Parameters.Add("@Tabid", SqlDbType.NVarChar).Value = "8";
            mycmd.Parameters.Add("@namefont", SqlDbType.NVarChar).Value = txtfont8.Text;
            mycmd.Parameters.Add("@stylefont", SqlDbType.NVarChar).Value = txtstyle8.Text;
            mycmd.Parameters.Add("@sizefont", SqlDbType.NVarChar).Value = txtsize8.Text;
            mycmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = plShowColor8.BackColor.Name.ToString();
            mycmd.Parameters.Add("@Rright", SqlDbType.Int).Value = numdigitx8.Value.ToString();

            mycmd.Parameters.Add("@locx", SqlDbType.Int).Value = pictureBox1.Width - int.Parse((numdigitx8.Value).ToString()) - fieldmore.Width;
            mycmd.Parameters.Add("@locy", SqlDbType.Int).Value = pictureBox1.Height - int.Parse(numdigity8.Value.ToString()) - fieldmore.Height;

            mycmd.Parameters.Add("@Bbottom", SqlDbType.Int).Value = numdigity8.Value.ToString();
            mycmd.Parameters.Add("@show", SqlDbType.Bit).Value = 1;
            mycmd.ExecuteNonQuery();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            myda = new SqlDataAdapter();
            mycom = new SqlConnection(connecteiondatabase.passconnection());
            mycom.Open();
            mycmd = new SqlCommand("deletepattern", mycom);
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.Add("@namepattern", SqlDbType.NVarChar).Value = comboBox1.Text.Trim();
            mycmd.ExecuteNonQuery();
            loadincombobox();
            loaddata();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}


