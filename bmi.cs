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
    public partial class bmi : Form
    {
        public bmi()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {

            using (var context = new DATABASE_KINGFOODEntities2())
            {

                // Query for the Blog named ADO.NET Blog 
                var blog = context.Personal_Information
                                .Where(b => b.name == label2.Text)
                                .FirstOrDefault();
                blog.bmi = float.Parse(label1.Text.ToString());
                context.Entry(blog).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                this.Close();
                if (blog.bmi > 25)
                {
                    MessageBox.Show("Ban nen giam mo!");
                }
                if(blog.bmi <= 25)
                {
                    MessageBox.Show("Co the ban rat vua can");
                }
                
            }
        }

        private void bmi_Load(object sender, EventArgs e)
        {

        }
    }
}
