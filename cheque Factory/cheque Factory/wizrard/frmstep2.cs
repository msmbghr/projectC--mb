using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cheque_Factory.wizrard
{
    public partial class frmstep2 : Form
    {
        public frmstep2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wizrard.frmfirst f = new wizrard.frmfirst();
            f.StartPosition = FormStartPosition.Manual;
            f.Left = 2;
            f.Top = 2;
            this.Close();
            f.ShowDialog();
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

        private void button4_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                Image i = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Width = i.Width;
                pictureBox1.Height = i.Height;
                rulerControl1.Width = i.Width + 5;
                rulerControl2.Height = i.Height + 5;
                passdate.SelectImage = i;
                radioButton1.Checked = true;
               
                }
            

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            wizrard.frmstep3 f = new wizrard.frmstep3();
            f.StartPosition = FormStartPosition.Manual;
            f.Left = 2;
            f.Top = 2;
            this.Close();
            f.ShowDialog();
        }
       
        private void frmstep2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image!=null)
            {
                btnnext.Enabled = true;
            }
        }

        private void frmstep2_Deactivate(object sender, EventArgs e)
        {

        }
      
      
    }
}
