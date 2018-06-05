using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingFood
{
    public partial class UserInfoForm : Form
    {
        private int age;
        public UserInfoForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            using (var context = new DATABASE_KINGFOODEntities2())
            {
                
                // Query for the Blog named ADO.NET Blog 
                var blog = context.Personal_Information
                                .Where(b => b.name == textBox1.Text)
                                .FirstOrDefault();
                int current = Int32.Parse(DateTime.Now.Year.ToString());

                DateTime birth = Convert.ToDateTime(blog.birthday.ToString());
                int year = birth.Year;
                int age2 = current - year;
                lbAge.Text = age2.ToString();
                lbAge.Text = age2.ToString();
                if (txtBmi.Text == "") {
                    txtBmi.Text = "Not calculated";
                }
                else {
                    String s = blog.bmi.ToString();
                //Lay 3 chu so thap phan
                    double db = Math.Round(Double.Parse(s), 3);
                    txtBmi.Text = db.ToString();
                }
            }

        }

        private void lbAge_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int height = Int32.Parse(this.txtHeight.Text);
            int weight = Int32.Parse(this.txtWeight.Text);
            double bmi =Math.Round((double)(weight / (Math.Pow(height,2) / 10000)),3);
            bmi bm = new bmi();
            bm.label1.Text = bmi.ToString();
            bm.label2.Text = textBox1.Text;
            bm.ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

            using (var context = new DATABASE_KINGFOODEntities2())
            {

                // Query for the Blog named ADO.NET Blog 
                var blog = context.Personal_Information
                                .Where(b => b.name == textBox1.Text)
                                .FirstOrDefault();
                int current = Int32.Parse(DateTime.Now.Year.ToString());

                DateTime birth = Convert.ToDateTime(blog.birthday.ToString());
                int year = birth.Year;
                int age2 = current - year;
                lbAge.Text = age2.ToString();
                String s = blog.bmi.ToString();

                //Lay 3 chu so thap phan
                double db = Math.Round(Double.Parse(s),3);
                txtBmi.Text = db.ToString();
            }
        }

        private void btnAdvise_Click(object sender, EventArgs e)
        {
                float myBmi = float.Parse(txtBmi.Text.ToString());
           
                if (myBmi > 25)
                {
                    MessageBox.Show("Ban nen giam mo!");
                }
                if (myBmi < 25)
                {
                    MessageBox.Show("Co the ban rat vua can");
                }


           
        }

       public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
            this.Close();

        }
    }
}
