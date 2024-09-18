using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quran;

namespace Quran
{
    public partial class Reading : Form
    {
        public Reading()
        {
            InitializeComponent();
        }
      
        

        private Form activeForm = null; 
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(childForm); 
            PanelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void PanelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
        choose choose = new choose();
            choose.Show();
            this.Hide();
        }
    }
}
