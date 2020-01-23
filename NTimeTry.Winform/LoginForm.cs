using NTT.DataAccess.Services;
using NTT.PO.Global;
using NTT.DataAccess.DataContexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Utils;

namespace NTT
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            accountService = Factory.Entry<AccountService>();
            accountService.Init();

            Load += LoginForm_Load;
            FormClosed += LoginForm_FormClosed;
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            accountService.Release();
        }

        AccountService accountService;


        private void btnLogin_Click(object sender, EventArgs e)
        {
            var t1 = Environment.TickCount;

            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("账号未填写");
                return;
            }

            userName = userName.Trim();
            password = Misc.MD5(password?.Trim());

            UserInfo entity  = accountService.GetUser(userName, password);
            if (entity != null)
            {
                Session.Current.User.BusinessId = entity.BusinessId;

                var t2 = Environment.TickCount;

                //Console.WriteLine("t2 - t1: " + (t2 - t1).ToString());


                this.Hide();
                MainForm form1 = new MainForm();
                form1.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("账号或密码错误");
            }
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             
            AccountInfo entity = new AccountInfo();
            entity.UserName = "test";
            entity.Password = Misc.MD5("111111");
             

            UserInfo user = new UserInfo()
            {
                Name = "DaMao",
                BusinessId = Guid.NewGuid().ToString("N")
            };

            var result = Factory.Entry<AccountUserService>().AddAccountAndUser(entity, user);
            if (result != null)
            {
                MessageBox.Show("注册成功");
            }
        }
    }
}
