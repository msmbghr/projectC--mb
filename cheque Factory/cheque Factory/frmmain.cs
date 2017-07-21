using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cheque_Factory
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void frmmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        bool foundp=true;
        private void button2_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            button6.Visible = false;
            foreach (TabPage ttp in tabControl1.TabPages)
            {
                if (ttp.Text == "   چاپ الگو    X")
                {
                    tabControl1.SelectedTab = ttp;
                    foundp = false;
                    break;
                }
            }
            if (foundp==true)
            {
                frmmanagepattern1 f = new frmmanagepattern1();
                f.TopLevel = false;
                f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                TabPage newTabPagep = new TabPage("   چاپ الگو    X");
                newTabPagep.ImageIndex = 0;
                newTabPagep.Controls.Add(f);
                this.tabControl1.TabPages.Add(newTabPagep);
                this.tabControl1.SelectTab(newTabPagep);
                f.Show();
                foundp = false;

            }
           
        }


        ImageList iconsList;
        private void frmmain_Load(object sender, EventArgs e)
        {
            iconsList = new ImageList();
            iconsList.TransparentColor = Color.Blue;
            iconsList.ColorDepth = ColorDepth.Depth32Bit;
            iconsList.ImageSize = new Size(25, 25);
            iconsList.Images.Add(Image.FromFile(@"printer.png"));
            iconsList.Images.Add(Image.FromFile(@"tool.png"));
            tabControl1.ImageList = iconsList;

        }
         bool foundm = true;
        private void button3_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            button6.Visible = false;
            foreach (TabPage ttp in tabControl1.TabPages)
            {
                if (ttp.Text == "   مدیریت الگو ها   X")
                {
                    tabControl1.SelectedTab = ttp;
                    foundm = false;
                }
            }
            if (foundm==true)
            {
                frmmanagepattern f = new frmmanagepattern();
                f.TopLevel = false;
                f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                TabPage newTabPagem = new TabPage("   مدیریت الگو ها   X");
                newTabPagem.ImageIndex = 1;
                newTabPagem.Controls.Add(f);
                this.tabControl1.TabPages.Add(newTabPagem);
                this.tabControl1.SelectTab(newTabPagem);
                f.Show();
                foundm = false;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //This code will render a "x" mark at the end of the Tab caption. 
            e.Graphics.DrawString("  X  ", e.Font, Brushes.Blue, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();

        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                Rectangle r = tabControl1.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 15, 20);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("آیا می خواهید این پنجره را ببندید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (this.tabControl1.TabPages[i].Text == "   مدیریت الگو ها   X")
                        {
                            foundm = true;
                        }
                        else 
                        {
                            foundp = true;
                        }
                        this.tabControl1.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }
        #region 
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(220,11,120);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(20, 50, 180);

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.FromArgb(100, 20, 100);

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(220, 11, 120);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(20, 50, 180);

        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.ForeColor = Color.FromArgb(100, 20, 100);

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.FromArgb(220, 11, 120);

        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.ForeColor = Color.FromArgb(100, 20, 100);

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.FromArgb(20, 50, 180);

        }

        private void aboutme_MouseLeave(object sender, EventArgs e)
        {
            aboutme.ForeColor = Color.FromArgb(220, 11, 120);

        }

        private void aboutme_MouseHover(object sender, EventArgs e)
        {
            aboutme.ForeColor = Color.FromArgb(20, 50, 180);

        }

        private void aboutme_MouseDown(object sender, MouseEventArgs e)
        {
            aboutme.ForeColor = Color.FromArgb(100, 20, 100);

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.FromArgb(220, 11, 120);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.ForeColor = Color.FromArgb(20, 50, 180);
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            button4.ForeColor = Color.FromArgb(100, 20, 100);

        }
        #endregion
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.analogClock3.Time = DateTime.Now;
           

            DateTime Day = DateTime.Now;
            int year = Convert.ToInt32(Day.Year);
            int month = Convert.ToInt32(Day.Month);
            int day = Convert.ToInt32(Day.Day);
            label1.Text = Miladi2Shamsi.shamsi2miladi.Mil2Sham(year, month, day, 2);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            button6.Visible = false;
            //using(wizrard.frmfirst f=new wizrard.frmfirst())
            //{
            //    f.Show();
            //}


            //wizrard.frmfirst f = new wizrard.frmfirst();
            //f.Location = new Point(100, 100);
            //f.ShowDialog();

            //var frm = new wizrard.frmfirst();
            //frm.Load += (s, ea) =>
            //{
            //    var wa = Screen.PrimaryScreen.WorkingArea;
            //    frm.Location = new Point(wa.Right - frm.Width, wa.Bottom - frm.Height);
            //};
            //frm.Show();
            //////////////////////////////////////////
            wizrard.frmfirst f = new wizrard.frmfirst();
            f.StartPosition = FormStartPosition.Manual;
            f.Left = 2;
            f.Top = 2;
            f.ShowDialog();
           
        }

        private void aboutme_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            button6.Visible = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5.Visible = false;
            button6.Visible = false;
            new frmbankaccount().ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            button6.Visible = false;
            new frmmanageaccount().ShowDialog();
        }
    }
}
