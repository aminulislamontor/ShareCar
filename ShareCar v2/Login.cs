using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ShareCar.Repository;
using ShareCar.Entity;

namespace ShareCar_v2
{
    public partial class Login : MetroForm
    {
        //Point lastPoint;
        LoginRepo loginRepo = new LoginRepo();
        UserRepo userRepo = new UserRepo();
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AdminLogin aLogin = new AdminLogin();
            aLogin.username = tbUser.Text;
            aLogin.password = tbPassword.Text;
            
            User ulogin = new User();
            ulogin.username = tbUser.Text;
            ulogin.password = tbPassword.Text;
            

            if (tbUser.Text == "")
            {
                MessageBox.Show("Username required!", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Password required!", "Login validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool b = loginRepo.LoginAdmin(aLogin);
                bool c = userRepo.UserLogin(ulogin);


                if (b == true)
                {
                    MessageBox.Show("Login Successful admin");
                    this.Hide();
                    DashboardAdmin management = new DashboardAdmin();
                    management.Show();
                    this.Hide();
                }
                else if (c == true)
                {
                    MessageBox.Show("Login Successful User");
                    this.Hide();
                    UserDash dashboard = new UserDash();
                    dashboard.Show();
                }
                else
                    MessageBox.Show("Login Failed!", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
