using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingFood
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            using (DATABASE_KINGFOODEntities2 context = new DATABASE_KINGFOODEntities2())
            {
                var users = context.Personal_Information.FirstOrDefault(u => u.name == user);
                if(users != null)
                {
                    if(users.password== pass)
                    {
                        MessageBox.Show("Login Sucessfully");
                        this.Hide();
                        UserInfoForm f3 = new UserInfoForm();
                        f3.textBox1.Text = user;
                        f3.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }else if(user=="admin" && pass == "123456")
                {
                    MessageBox.Show("Login Sucessfully with admin account");
                    this.Hide();
                    ManageAdmin f3 = new ManageAdmin();
                    f3.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No user name call " + user + " found");
                }
            
            }

            
        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp f = new SignUp();
            f.ShowDialog();
        }
    }
}
