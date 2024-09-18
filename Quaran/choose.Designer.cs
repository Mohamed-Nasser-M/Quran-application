namespace Quran
{
    partial class choose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choose));
            this.Listenn = new Guna.UI2.WinForms.Guna2Button();
            this.Readd = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Listenn
            // 
            this.Listenn.CheckedState.Parent = this.Listenn;
            this.Listenn.CustomImages.Parent = this.Listenn;
            this.Listenn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.Listenn.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listenn.ForeColor = System.Drawing.Color.White;
            this.Listenn.HoverState.Parent = this.Listenn;
            this.Listenn.Image = ((System.Drawing.Image)(resources.GetObject("Listenn.Image")));
            this.Listenn.Location = new System.Drawing.Point(404, 272);
            this.Listenn.Name = "Listenn";
            this.Listenn.ShadowDecoration.Parent = this.Listenn;
            this.Listenn.Size = new System.Drawing.Size(180, 53);
            this.Listenn.TabIndex = 1;
            this.Listenn.Text = "الأستماع";
            this.Listenn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Readd
            // 
            this.Readd.CheckedState.Parent = this.Readd;
            this.Readd.CustomImages.Parent = this.Readd;
            this.Readd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.Readd.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Readd.ForeColor = System.Drawing.Color.White;
            this.Readd.HoverState.Parent = this.Readd;
            this.Readd.Image = ((System.Drawing.Image)(resources.GetObject("Readd.Image")));
            this.Readd.Location = new System.Drawing.Point(186, 274);
            this.Readd.Name = "Readd";
            this.Readd.ShadowDecoration.Parent = this.Readd;
            this.Readd.Size = new System.Drawing.Size(120, 43);
            this.Readd.TabIndex = 2;
            this.Readd.Text = "القراءة";
            this.Readd.Click += new System.EventHandler(this.Readd_Click);
            // 
            // choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(807, 588);
            this.Controls.Add(this.Readd);
            this.Controls.Add(this.Listenn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "choose";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button Listenn;
        private Guna.UI2.WinForms.Guna2Button Readd;
    }
}

