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
    public partial class ManageAdmin : Form
    {
        public ManageAdmin()
        {
            InitializeComponent();
        }
        public void LoadStudent()
        {
            DATABASE_KINGFOODEntities2 db = new DATABASE_KINGFOODEntities2(); // create connection to your database
            this.lstUsers.DataSource = db.Personal_Information.ToList();
            this.lstUsers.DefaultCellStyle.Font = new Font("Tahoma", 11);
            this.lstUsers.Columns["password"].Visible = false;

        }
        private void lstUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedRows.Count == 1) 
            {
                var row = lstUsers.SelectedRows[0]; 
                var cell = row.Cells["id"]; 
                int id = (int)cell.Value; 
                DATABASE_KINGFOODEntities2 db = new DATABASE_KINGFOODEntities2(); 
                Personal_Information pi = db.Personal_Information.Single(st => st.id == id);
                db.Personal_Information.Remove(pi); 
                db.SaveChanges(); 
                this.LoadStudent(); 
            }
            else
            {
                MessageBox.Show("You should select a student!");
            }

        }
    }
}
