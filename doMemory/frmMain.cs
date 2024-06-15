using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doMemory
{
    public partial class frmMain : Form
    {
        public frmLogin frmLogin = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void buttonStartText_Click(object sender, EventArgs e)
        {
            frmBeisong frm = new frmBeisong();
            frm.Show();
            frm.frmLogin = frmLogin;
            this.Hide();
        }

        private void buttonMatainDB_Click(object sender, EventArgs e)
        {
            frmMaintainDb frm = new frmMaintainDb();
            frm.Show();
            frm.frmlogin = frmLogin;
            this.Hide();
        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
