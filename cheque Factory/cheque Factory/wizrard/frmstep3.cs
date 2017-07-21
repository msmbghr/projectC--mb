using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace cheque_Factory.wizrard
{
    public partial class frmstep3 : Form
    {
        public frmstep3()
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
        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wizrard.frmstep2 f = new wizrard.frmstep2();
            f.StartPosition = FormStartPosition.Manual;
            f.Left = 2;
            f.Top = 2;
            this.Hide();
            f.ShowDialog();
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
        Graphics g;

        Brush bb = new SolidBrush(Color.Red);
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Refresh();

        }

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
        private void frmstep3_Load(object sender, EventArgs e)
        {

            pictureBox1.Image = passdate.SelectImage;
            pictureBox1.Width = passdate.SelectImage.Width;
            pictureBox1.Height = passdate.SelectImage.Height;
            radioButton1.Checked = true;
            this.Width = 883;
            panel1.Width = 855;
            ////////////////////////////
            loadbase();
            //////////////////////////////////
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



        bool settings = false;
        private void button4_Click(object sender, EventArgs e)
        {
            settings = true;
            numdigitx.Maximum = pictureBox1.Width;
            numdigity.Maximum = pictureBox1.Height;
            numdigitx2.Maximum = pictureBox1.Width;
            numdigity2.Maximum = pictureBox1.Height;
            numdigitx3.Maximum = pictureBox1.Width;
            numdigity3.Maximum = pictureBox1.Height;
            numdigitx4.Maximum = pictureBox1.Width;
            numdigity4.Maximum = pictureBox1.Height;
            numdigitx5.Maximum = pictureBox1.Width;
            numdigity5.Maximum = pictureBox1.Height;
            numdigitx6.Maximum = pictureBox1.Width;
            numdigity6.Maximum = pictureBox1.Height;
            numdigitx7.Maximum = pictureBox1.Width;
            numdigity7.Maximum = pictureBox1.Height;
            numdigitx8.Maximum = pictureBox1.Width;
            numdigity8.Maximum = pictureBox1.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (settings)
            {
                btnshowsetting.Visible = false;

                while (this.Width <= 1150)
                {
                    this.Width += 10;
                    panel1.Width += 8;
                    if (this.Width >= 1150)
                    {
                        panel1.Width = 1119;
                        settings = false;
                        pinfo.Visible = true;
                    }
                }

            }

            if (settingclose)
            {
                while (this.Width >= 883)
                {
                    this.Width -= 12;
                    panel1.Width -= 10;
                    if (this.Width <= 883)
                    {
                        panel1.Width = 855;
                        settingclose = false;
                        btnshowsetting.Visible = true;
                        pinfo.Visible = false;

                    }

                }

            }
        }

        private void frmstep3_Deactivate(object sender, EventArgs e)
        {

        }

        bool settingclose;
        private void button4_Click_1(object sender, EventArgs e)
        {
            settingclose = true;
        }


        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            pontxy = e.Location;
            pontxy = e.Location;
            tabControl1.SelectTab(0);
        }


        
        
        private void label2_MouseMove_1(object sender, MouseEventArgs e)
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

        private void panel5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                plShowColor.BackColor = colorDialog1.Color;
                lbldatedigit.ForeColor = colorDialog1.Color;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void numdigitx_Click(object sender, EventArgs e)
        {
        }
     
        private void numdigitx_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluex1 =(int) numdigitx.Value;
            

        }

       
        private void numdigitx_ValueChanged(object sender, EventArgs e)
        {
            if (numdigitx.Value>oldvaluex1)
            {
                lbldatedigit.Left--;
            }
            else
            {
                lbldatedigit.Left++;
            }
        }
       
        private void label9_MouseMove(object sender, MouseEventArgs e)
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

        private void label3_MouseMove(object sender, MouseEventArgs e)
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

        private void label4_MouseMove(object sender, MouseEventArgs e)
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

        private void label5_MouseMove(object sender, MouseEventArgs e)
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

        private void label8_MouseMove(object sender, MouseEventArgs e)
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

        private void label6_MouseMove(object sender, MouseEventArgs e)
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

        private void label7_MouseMove(object sender, MouseEventArgs e)
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

        private void numdigity_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluey1 = (int)numdigity.Value;
        }
        #region
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

        private void plShowColor2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                plShowColor2.BackColor = colorDialog1.Color;
                lbldatelet.ForeColor = colorDialog1.Color;
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

        private void plShowColor6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                plShowColor6.BackColor = colorDialog1.Color;
                description.ForeColor = colorDialog1.Color;
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
        #endregion
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
        #region
        private void numdigitx2_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluex2 = (int)numdigitx2.Value;

        }

        private void numdigity2_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluey2 = (int)numdigity2.Value;

        }

        private void numdigitx3_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluex3= (int)numdigitx3.Value;
        }

        private void numdigity3_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluey3 = (int)numdigity3.Value;

        }

        private void numdigitx4_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluex4 = (int)numdigitx4.Value;

        }

        private void numdigity4_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluey4 = (int)numdigity4.Value;

        }

        private void numdigitx5_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluex5 = (int)numdigitx5.Value;

        }

        private void numdigity5_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluey5 = (int)numdigity5.Value;

        }

        private void numdigitx6_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluex6 = (int)numdigitx6.Value;

        }

        private void numdigity6_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluey6 = (int)numdigity6.Value;

        }

        private void numdigitx7_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluex7 = (int)numdigitx7.Value;

        }

        private void numdigity7_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluey7 = (int)numdigity7.Value;

        }

        private void numdigitx8_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluex8 = (int)numdigitx8.Value;

        }

        private void numdigity8_MouseDown(object sender, MouseEventArgs e)
        {
            oldvaluey8 = (int)numdigity8.Value;

        }

        #endregion

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
            pontxy2 = e.Location;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            passdate.font1 = txtfont.Text;
            passdate.style1 = txtstyle.Text;
            passdate.size1 = txtsize.Text;
            passdate.color1 = plShowColor.BackColor.Name.ToString();
            passdate.numdigitx1 = numdigitx.Value.ToString();
            passdate.numdigity1 = numdigity.Value.ToString();
            passdate.locx = pictureBox1.Width - int.Parse((numdigitx.Value).ToString()) - lbldatedigit.Width;
            passdate.locy = pictureBox1.Height - int.Parse(numdigity.Value.ToString())-lbldatedigit.Height;

            passdate.font2 = txtfont2.Text;
            passdate.style2 = txtstyle2.Text;
            passdate.size2 = txtsize2.Text;
            passdate.color2 = plShowColor2.BackColor.Name.ToString();
            passdate.numdigitx2 = numdigitx2.Value.ToString();
            passdate.numdigity2 = numdigity2.Value.ToString();
            passdate.locx2 = pictureBox1.Width - int.Parse((numdigitx2.Value).ToString()) - lbldatelet.Width;
            passdate.locy2 = pictureBox1.Height - int.Parse(numdigity2.Value.ToString()) - lbldatelet.Height;

            passdate.font3 = txtfont3.Text;
            passdate.style3 = txtstyle3.Text;
            passdate.size3 = txtsize3.Text;
            passdate.color3 = plShowColor3.BackColor.Name.ToString();
            passdate.numdigitx3 = numdigitx3.Value.ToString();
            passdate.numdigity3 = numdigity3.Value.ToString();

            passdate.locx3 = pictureBox1.Width - int.Parse((numdigitx3.Value).ToString()) - pricelet.Width;
            passdate.locy3 = pictureBox1.Height - int.Parse(numdigity3.Value.ToString()) - pricelet.Height;

            passdate.font4 = txtfont4.Text;
            passdate.style4 = txtstyle4.Text;
            passdate.size4 = txtsize4.Text;
            passdate.color4 = plShowColor4.BackColor.Name.ToString();
            passdate.numdigitx4 = numdigitx4.Value.ToString();
            passdate.numdigity4 = numdigity4.Value.ToString();
            passdate.locx4 = pictureBox1.Width - int.Parse((numdigitx4.Value).ToString()) - recive.Width;
            passdate.locy4 = pictureBox1.Height - int.Parse(numdigity4.Value.ToString()) - recive.Height;


            passdate.font5 = txtfont5.Text;
            passdate.style5 = txtstyle5.Text;
            passdate.size5 = txtsize5.Text;
            passdate.color5 = plShowColor5.BackColor.Name.ToString();
            passdate.numdigitx5 = numdigitx5.Value.ToString();
            passdate.numdigity5 = numdigity5.Value.ToString();
            passdate.locx5 = pictureBox1.Width - int.Parse((numdigitx5.Value).ToString()) - pricedigit.Width;
            passdate.locy5 = pictureBox1.Height - int.Parse(numdigity5.Value.ToString()) - pricedigit.Height;


            passdate.font6 = txtfont6.Text;
            passdate.style6 = txtstyle6.Text;
            passdate.size6 = txtsize6.Text;
            passdate.color6 = plShowColor6.BackColor.Name.ToString();
            passdate.numdigitx6 = numdigitx6.Value.ToString();
            passdate.numdigity6 = numdigity6.Value.ToString();
            passdate.locx6 = pictureBox1.Width - int.Parse((numdigitx6.Value).ToString()) - description.Width;
            passdate.locy6 = pictureBox1.Height - int.Parse(numdigity6.Value.ToString()) - description.Height;


            passdate.font7 = txtfont7.Text;
            passdate.style7 = txtstyle7.Text;
            passdate.size7 = txtsize7.Text;
            passdate.color7 = plShowColor7.BackColor.Name.ToString();
            passdate.numdigitx7 = numdigitx7.Value.ToString();
            passdate.numdigity7 = numdigity7.Value.ToString();
            passdate.locx7 = pictureBox1.Width - int.Parse((numdigitx7.Value).ToString()) - letters.Width;
            passdate.locy7 = pictureBox1.Height - int.Parse(numdigity7.Value.ToString()) - letters.Height;



            passdate.font8 = txtfont8.Text;
            passdate.style8 = txtstyle8.Text;
            passdate.size8= txtsize8.Text;
            passdate.color8 = plShowColor8.BackColor.Name.ToString();
            passdate.numdigitx8 = numdigitx8.Value.ToString();
            passdate.numdigity8 = numdigity8.Value.ToString();
            passdate.locx8 = pictureBox1.Width - int.Parse((numdigitx8.Value).ToString()) - fieldmore.Width;
            passdate.locy8 = pictureBox1.Height - int.Parse(numdigity8.Value.ToString()) - fieldmore.Height;


            wizrard.frmstep4 f = new wizrard.frmstep4();
            //f.StartPosition = FormStartPosition.Manual;
            //f.Left = 2;
            //f.Top = 2;
            this.Close();
            f.ShowDialog();
        }

        private void plShowColor2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numdigitx_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void lbldatelet_MouseDown_1(object sender, MouseEventArgs e)
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



    }
}
