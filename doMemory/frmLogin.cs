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
    public partial class frmLogin : Form
    {
        public frmBeisong frmBeisong = new frmBeisong();
        public frmMain frmMain = new frmMain();
        public frmMaintainDb frmMaintain = new frmMaintainDb();
        public DBHelperSQLite dbtools = new DBHelperSQLite();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void buttonRegUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            DBHelperSQLite.ExistsDataBase();
            if (username == "sandspark" && password == "11111111")
            {
                //登陆成功 载入主窗体
                frmMain = new frmMain();
                frmMain.Show();
                frmMain.frmLogin = this;
                this.Hide();
            }
            else
            {
                //登陆失败
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
