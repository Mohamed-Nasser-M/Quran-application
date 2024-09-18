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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // initializing The Image at the beginning and Marker

        int Current_Image1 = 0016;
        int Marker;

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (Current_Image1 > 16)
            {
                Current_Image1--;
                //Current_Image2 += 2;
                string Image_Path1 = string.Format(@"C:\Users\HP\Downloads\8\8\8\التفسير الميسر\{0:D4}.jpg", Current_Image1);
                //string Image_Path2 = string.Format(@"C:\Users\HP\Downloads\1\{0:D4}.jpg",Current_Image2);

                // Load images into picture boxes
                //pictureBox1.Load(Image_Path1);
                pictureBoxTafseer.Load(Image_Path1);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (Current_Image1 < 619)
            {
                Current_Image1++;
                //Current_Image2 += 2;
                string Image_Path1 = string.Format(@"C:\Users\HP\Downloads\8\8\8\التفسير الميسر\{0:D4}.jpg", Current_Image1);
                //string Image_Path2 = string.Format(@"C:\Users\HP\Downloads\1\{0:D4}.jpg",Current_Image2);

                // Load images into picture boxes
                //pictureBox1.Load(Image_Path1);
                pictureBoxTafseer.Load(Image_Path1);
            }
        }

        private void Marker_BTN_Click(object sender, EventArgs e)
        {
            Marker = Current_Image1;
        }

        private void Move_toMarker_BTN_Click(object sender, EventArgs e)
        {
            string Image_Path2 = string.Format(@"C:\Users\HP\Downloads\8\8\8\التفسير الميسر\{0:D4}.jpg", Marker);
            pictureBoxTafseer.Load(Image_Path2);
            Current_Image1 = Marker;
        }

        private void pictureBoxTafseer_Click(object sender, EventArgs e) { }

        private void الفهرس_Click(object sender, EventArgs e)
        {

        }
    }
}
