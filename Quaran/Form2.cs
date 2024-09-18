using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Quran
{
    public partial class ListeningForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-VM7TK3G;Initial Catalog=users;Integrated Security=True;Encrypt=False";
        private WindowsMediaPlayer player;
        private List<string> audioFiles;
        private int currentAudioIndex = 0;
        private bool isPlaying = false;

        public ListeningForm()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
            player.PlayStateChange += Player_PlayStateChange;
            player.PositionChange += Player_PositionChange;

            // Initialize timer
            timer1.Interval = 1000; // 1 second
            timer1.Tick += Timer1_Tick;

            // Initialize audio files list
            audioFiles = new List<string>
            {     
 @"D:\Quran App\المنشاوي\سورة الأحزاب – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الأحقاف – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الإخلاص – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الإسراء – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الأعراف – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الأعلى – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الأنبياء – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الإنسان – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الانشقاق – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الأنعام – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الأنفال – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الانفطار – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة البروج – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة البقرة – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة البلد – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة البينة – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة التحريم – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة التغابن – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة التكاثر – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة التكوير – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة التوبة – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة التين – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الجاثية – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الجمعة – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الجن – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الحاقة – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الحج – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الحجر – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الحجرات – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الحديد – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الحشر – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الدخان – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الذاريات – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الرحمن – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الرعد – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الروم – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الزخرف – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الزلزلة – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الزمر – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة السجدة – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الشرح – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الشعراء – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الشمس – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الشورى – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الصافات – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الصف – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الضحى – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الطارق – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الطلاق – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الطور – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة العاديات – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة العصر – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة العلق – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة العنكبوت – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الغاشية – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الفاتحة – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الفتح – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الفجر – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الفرقان – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الفلق – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة الفيل – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة القارعة – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة القدر – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة القصص – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة القلم – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة يس – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة يوسف – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
@"D:\Quran App\المنشاوي\سورة يونس – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3",
            };
           
        }
       /* private string SearchSurah(string surahName)
        {
            string filePath = string.Empty;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT FilePath FROM Surahs WHERE Name = @Title";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", surahName);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        filePath = reader["FilePath"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            return filePath;
        }*/

        private void ListeningForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void browsebtn_Click(object sender, EventArgs e)
        {

        }

        private void panSlider1_Load(object sender, EventArgs e)
        {

        }

        private void volumeSlider1_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\Quran App\المنشاوي\سورة الفاتحة – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3";
            PlayAudio(filePath);
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsPlaying || player.playState == WMPPlayState.wmppsPaused)
            {
                player.controls.currentPosition = trackBarAudio.Value;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                trackBarAudio.Value = (int)player.controls.currentPosition;
            }
        }

        private void PlayAudio(string filePath)
        {
            player.URL = filePath;
            player.controls.play();
            isPlaying = true;
            //playbtn.Image = Properties.Resources.pause_icon; // Make sure to add a pause icon to your project resources
        }

        private void Player_PlayStateChange(int NewState)
        {
            if (NewState == (int)WMPPlayState.wmppsPlaying)
            {
                trackBarAudio.Maximum = (int)player.currentMedia.duration;
                trackBarAudio.Value = (int)player.controls.currentPosition;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void Player_PositionChange(double oldPosition, double newPosition)
        {
            trackBarAudio.Value = (int)newPosition;
        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\Quran App\المنشاوي\سورة البقرة – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3";
            PlayAudio(filePath);
        }

        private void guna2PictureBox11_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\Quran App\المنشاوي\سورة آل عمران – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3";
            PlayAudio(filePath);
        }

        private void guna2PictureBox14_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\Quran App\المنشاوي\سورةالأنعام – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3";
            PlayAudio(filePath);    
        }

        private void guna2PictureBox17_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\Quran App\المنشاوي\سورة الأعراف – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3";
            PlayAudio(filePath);
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void playlistbtn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
           // string username = usernametextbox.Text.Trim();

            //if (string.IsNullOrEmpty(username))
           // {
             //   MessageBox.Show("Please enter a username to view details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // return;
           // }
/*
            try
            {
                conn.Open();
                string query = "SELECT username, password FROM USERS WHERE username = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string userDetails = $"Username: {reader["username"]}\n" +
                                         $"Password: {reader["password"]}";

                    MessageBox.Show(userDetails, "User Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }*/
        }

        private void previousbtn_Click(object sender, EventArgs e)
        {
            // Previous button functionality
            if (currentAudioIndex > 0)
            {
                currentAudioIndex--;
                PlayAudio(audioFiles[currentAudioIndex]);
            }
        }

        private void playbtn_Click(object sender, EventArgs e)
        {
            // Play/Pause button functionality
            if (isPlaying)
            {
                player.controls.pause();
                isPlaying = false;
                playbtn.Image = Properties.Resources.play_icon; // Make sure to add a play icon to your project resources
            }
            else
            {
                player.controls.play();
                isPlaying = true;
                playbtn.Image = Properties.Resources.pause_icon; // Make sure to add a pause icon to your project resources
            }
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            // Next button functionality
            if (currentAudioIndex < audioFiles.Count - 1)
            {
                currentAudioIndex++;
                PlayAudio(audioFiles[currentAudioIndex]);
            }
        }

        private void audiobar_Scroll(object sender, ScrollEventArgs e)
        {

            // Check if the slider value is 0
            if (audiobar.Value == 0)
            {
                // Mute the player
                player.settings.mute = true;
            }
            else
            {
                // Unmute the player and set the volume
                player.settings.mute = false;
                player.settings.volume = audiobar.Value;
            }
        }
        private bool isMuted = false;
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            // Toggle mute state
            isMuted = !isMuted;

            // Set mute state of the player
            player.settings.mute = isMuted;

            // Change the image of the picture box based on mute state
            if (isMuted)
            {
                mutepic.Image = Properties.Resources.muted_icon; // Set the image for muted state
            }
            else
            {
                mutepic.Image = Properties.Resources.unmuted_icon; // Set the image for unmuted state
            }
        }

        private int currentIndex =1; // Current index of the audio file being played

        private void previousbtn_Click_1(object sender, EventArgs e)
        { 
          
                currentIndex--; // Move to the previous index
                    PlayAudio(audioFiles[currentIndex]); // Play the audio file at the new index
                
             
        }

        private void playbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox20_Click(object sender, EventArgs e)
        {

            string filePath = @"D:\Quran App\المنشاوي\سورة الأنفال – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3";
            PlayAudio(filePath);
        }

        private void guna2PictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox23_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\Quran App\المنشاوي\سورة التوبة – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3";
            PlayAudio(filePath);
        }

        private void guna2PictureBox29_Click(object sender, EventArgs e)
        {

            string filePath = @"D:\Quran App\المنشاوي\سورة يوسف – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3";
            PlayAudio(filePath);
        }

        private void guna2PictureBox26_Click(object sender, EventArgs e)
        { 
            string filePath = @"D:\Quran App\المنشاوي\سورة يونس – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3";
            PlayAudio(filePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
           

        }

        private void guna2PictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\ahmed\Downloads\سورة يس كاملة بصوت الشيخ هيثم الدخين Haitham Aldokhin Surah Yasin.mp3";
            PlayAudio(filePath);
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\Quran App\المنشاوي\سورة الفاتحة – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3";
            PlayAudio(filePath);
        }

        private void alekhlaas_Click(object sender, EventArgs e)
        {

            string filePath = @"D:\Quran App\المنشاوي\سورة الإخلاص – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3";
            PlayAudio(filePath);
        }

        private void alfalak_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\Quran App\المنشاوي\سورة الفلق – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3";
            PlayAudio(filePath);
        }

        private void playlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void guna2CirclePictureBox3_Click_1(object sender, EventArgs e)
        {
            string filePath = @"D:\Quran App\المنشاوي\سورة الجاثية – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3";
            PlayAudio(filePath);
        }

        private void guna2CirclePictureBox4_Click_1(object sender, EventArgs e)
        {
            string filePath =@"D:\Quran App\المنشاوي\سورة الأحقاف – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3";
            PlayAudio(filePath);
        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            string filepath = @"D:\Quran App\المنشاوي\سورة الزمر – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3";
            PlayAudio(filepath);
        }

        private void guna2CirclePictureBox6_Click(object sender, EventArgs e)
        {
            string filepath = @"D:\Quran App\المنشاوي\سورة الشورى – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3";
            PlayAudio(filepath);
        }

        private void guna2CirclePictureBox7_Click(object sender, EventArgs e)
        {
            string filepath = @"D:\Quran App\المنشاوي\سورة الحجرات – محمد صديق المنشاوي _ترتيل جودة عالية_(M4A_128K).mp3";
            PlayAudio(filepath);
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

