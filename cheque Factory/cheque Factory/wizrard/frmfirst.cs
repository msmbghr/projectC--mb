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
    public partial class frmfirst : Form
    {
        public frmfirst()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            wizrard.frmstep2 f = new wizrard.frmstep2();
            f.StartPosition = FormStartPosition.Manual;
            f.Left = 2;
            f.Top = 2;
            this.Close();
            f.ShowDialog();
        }

        private void frmfirst_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
            
    }
}
