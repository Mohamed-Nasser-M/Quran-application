namespace Quran
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Marker_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.Move_toMarker_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.الفهرس = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrev = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBoxTafseer = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTafseer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.Marker_BTN);
            this.panel1.Controls.Add(this.Move_toMarker_BTN);
            this.panel1.Controls.Add(this.الفهرس);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 97);
            this.panel1.TabIndex = 6;
            // 
            // Marker_BTN
            // 
            this.Marker_BTN.CheckedState.Parent = this.Marker_BTN;
            this.Marker_BTN.CustomImages.Parent = this.Marker_BTN;
            this.Marker_BTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.Marker_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Marker_BTN.ForeColor = System.Drawing.Color.White;
            this.Marker_BTN.HoverState.Parent = this.Marker_BTN;
            this.Marker_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Marker_BTN.Image")));
            this.Marker_BTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Marker_BTN.ImageSize = new System.Drawing.Size(25, 25);
            this.Marker_BTN.Location = new System.Drawing.Point(800, 3);
            this.Marker_BTN.Name = "Marker_BTN";
            this.Marker_BTN.ShadowDecoration.Parent = this.Marker_BTN;
            this.Marker_BTN.Size = new System.Drawing.Size(293, 91);
            this.Marker_BTN.TabIndex = 9;
            this.Marker_BTN.Text = "حفظ علامة";
            this.Marker_BTN.Click += new System.EventHandler(this.Marker_BTN_Click);
            // 
            // Move_toMarker_BTN
            // 
            this.Move_toMarker_BTN.CheckedState.Parent = this.Move_toMarker_BTN;
            this.Move_toMarker_BTN.CustomImages.Parent = this.Move_toMarker_BTN;
            this.Move_toMarker_BTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.Move_toMarker_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Move_toMarker_BTN.ForeColor = System.Drawing.Color.White;
            this.Move_toMarker_BTN.HoverState.Parent = this.Move_toMarker_BTN;
            this.Move_toMarker_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Move_toMarker_BTN.Image")));
            this.Move_toMarker_BTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Move_toMarker_BTN.ImageSize = new System.Drawing.Size(25, 25);
            this.Move_toMarker_BTN.Location = new System.Drawing.Point(501, 3);
            this.Move_toMarker_BTN.Name = "Move_toMarker_BTN";
            this.Move_toMarker_BTN.ShadowDecoration.Parent = this.Move_toMarker_BTN;
            this.Move_toMarker_BTN.Size = new System.Drawing.Size(293, 91);
            this.Move_toMarker_BTN.TabIndex = 8;
            this.Move_toMarker_BTN.Text = "الانتقال الى علامة";
            this.Move_toMarker_BTN.Click += new System.EventHandler(this.Move_toMarker_BTN_Click);
            // 
            // الفهرس
            // 
            this.الفهرس.CheckedState.Parent = this.الفهرس;
            this.الفهرس.CustomImages.Parent = this.الفهرس;
            this.الفهرس.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.الفهرس.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.الفهرس.ForeColor = System.Drawing.Color.White;
            this.الفهرس.HoverState.Parent = this.الفهرس;
            this.الفهرس.Image = ((System.Drawing.Image)(resources.GetObject("الفهرس.Image")));
            this.الفهرس.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.الفهرس.ImageSize = new System.Drawing.Size(25, 25);
            this.الفهرس.Location = new System.Drawing.Point(202, 3);
            this.الفهرس.Name = "الفهرس";
            this.الفهرس.ShadowDecoration.Parent = this.الفهرس;
            this.الفهرس.Size = new System.Drawing.Size(293, 91);
            this.الفهرس.TabIndex = 7;
            this.الفهرس.Text = "الفهرس";
            this.الفهرس.Click += new System.EventHandler(this.الفهرس_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.CheckedState.Parent = this.btnPrev;
            this.btnPrev.HoverState.Parent = this.btnPrev;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPrev.Location = new System.Drawing.Point(944, 358);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.PressedState.Parent = this.btnPrev;
            this.btnPrev.Size = new System.Drawing.Size(54, 56);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageSize = new System.Drawing.Size(50, 50);
            this.btnNext.Location = new System.Drawing.Point(244, 358);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedState.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(54, 56);
            this.btnNext.TabIndex = 8;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureBoxTafseer
            // 
            this.pictureBoxTafseer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTafseer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxTafseer.Enabled = false;
            this.pictureBoxTafseer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTafseer.Image")));
            this.pictureBoxTafseer.Location = new System.Drawing.Point(304, 103);
            this.pictureBoxTafseer.Name = "pictureBoxTafseer";
            this.pictureBoxTafseer.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBoxTafseer.Size = new System.Drawing.Size(634, 585);
            this.pictureBoxTafseer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTafseer.TabIndex = 9;
            this.pictureBoxTafseer.TabStop = false;
            this.pictureBoxTafseer.Click += new System.EventHandler(this.pictureBoxTafseer_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1238, 700);
            this.Controls.Add(this.pictureBoxTafseer);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTafseer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button الفهرس;
        private Guna.UI2.WinForms.Guna2Button Marker_BTN;
        private Guna.UI2.WinForms.Guna2Button Move_toMarker_BTN;
        private Guna.UI2.WinForms.Guna2ImageButton btnPrev;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private System.Windows.Forms.PictureBox pictureBoxTafseer;
    }
}

