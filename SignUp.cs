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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form2_Load);
            this.btnSubmit.Click += BtnSubmit_Click;

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //Confirm password
            if (txtConfirm.Text == txtPass.Text)
            {
               
                using (DATABASE_KINGFOODEntities2 context = new DATABASE_KINGFOODEntities2())
                {
                    //Check has already this user in account
                    if (context.Personal_Information.Any(o => o.name == txtName.Text))
                    {
                        MessageBox.Show("Has already this user");
                    }
                    else
                    {
                        DATABASE_KINGFOODEntities2 db = new DATABASE_KINGFOODEntities2(); // open connection to database
                        Personal_Information kf = new Personal_Information(); // create a new student object
                        kf.name = txtName.Text;
                        kf.password = txtPass.Text;

                        kf.birthday = Convert.ToDateTime(txtBirth.Text);
                        kf.gender = selectedText;
                        //Check user
                        string pass = txtPass.Text;
                        db.Personal_Information.Add(kf);
                        db.SaveChanges();
                        this.Close(); // 
                        MessageBox.Show("Add user successfully!");
                    }
                }                

            }
            else
                MessageBox.Show("Wrong Pass");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;

            this.txtBirth.Text = date.ToString("yyyy-MM-dd");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DATABASE_KINGFOODEntities2 db = new DATABASE_KINGFOODEntities2();
        }

        String selectedText;
        //Check readioButton has been checked
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                selectedText = ((RadioButton)sender).Text;
        }
        //Check readioButton has been checked
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                selectedText = ((RadioButton)sender).Text;
        }
    }
}
