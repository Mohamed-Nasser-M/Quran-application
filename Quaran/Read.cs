using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Data;
using System.Data.SqlClient;
using WMPLib;
namespace Quran

{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        



        // initializing The Image at the beginning and Marker

        int Current_Image1 = 0001;
        int Marker;

        // Marker Event
        private void Marker_BTN_Click_1(object sender, EventArgs e)
        {
            Marker = Current_Image1;
        }

        //Move To Mark Event 
        private void Move_toMark_BTN_Click(object sender, EventArgs e)
        {
            string Image_Path2 = string.Format(@"C:\Users\HP\Downloads\1\{0:D4}.jpg", Marker);
            pictureBoxREAD.Load(Image_Path2);
            Current_Image1 = Marker;
        }

        // Previous Button Event
        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            if (Current_Image1 > 1)
            {
                Current_Image1--;
                //Current_Image2 += 2;
                string Image_Path1 = string.Format(@"C:\Users\HP\Downloads\1\{0:D4}.jpg", Current_Image1);
                //string Image_Path2 = string.Format(@"C:\Users\HP\Downloads\1\{0:D4}.jpg",Current_Image2);

                // Load images into picture boxes
                //pictureBox1.Load(Image_Path1);
                pictureBoxREAD.Load(Image_Path1);
            }
        }

        // Next Button Event
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Current_Image1 < 618)
            {
                Current_Image1++;
                //Current_Image2 += 2;
                string Image_Path1 = string.Format(@"C:\Users\HP\Downloads\1\{0:D4}.jpg", Current_Image1);
                //string Image_Path2 = string.Format(@"C:\Users\HP\Downloads\1\{0:D4}.jpg",Current_Image2);

                // Load images into picture boxes
                //pictureBox1.Load(Image_Path1);
                pictureBoxREAD.Load(Image_Path1);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
