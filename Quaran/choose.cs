using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quran
{
    public partial class choose : Form
    {
        public choose()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ListeningForm listeningForm = new ListeningForm();  
            listeningForm.Show();
            this.Hide();
        }

        private void Readd_Click(object sender, EventArgs e)
        {
            Reading reading = new Reading();
            reading.Show();
            this.Hide();
        }
    }
}
