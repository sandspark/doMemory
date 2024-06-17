using doMemory.cls;
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
    public partial class frmMaintainDb : Form
    {
        public frmLogin frmlogin = null;
        public frmMaintainDb()
        {
            InitializeComponent();
        }

        private void frmMaintainDb_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmlogin.frmMain.Show();
        }

        private void buttonResetToFactory_Click(object sender, EventArgs e)
        {
            DBHelperSQLite.DropDb();
            DBHelperSQLite.ExistsDataBase();
            this.Hide();
            frmlogin.Show();
        }
    }
}
