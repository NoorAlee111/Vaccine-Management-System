
namespace VaccineSystem
{
    partial class UserMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userMEnuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recommendationsForYOUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewYourVaccinationStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getYourVaccinationCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMEnuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userMEnuToolStripMenuItem
            // 
            this.userMEnuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recommendationsForYOUToolStripMenuItem,
            this.appointmentToolStripMenuItem,
            this.viewYourVaccinationStatusToolStripMenuItem,
            this.getYourVaccinationCardToolStripMenuItem});
            this.userMEnuToolStripMenuItem.Name = "userMEnuToolStripMenuItem";
            this.userMEnuToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.userMEnuToolStripMenuItem.Text = "User Menu";
            // 
            // recommendationsForYOUToolStripMenuItem
            // 
            this.recommendationsForYOUToolStripMenuItem.Name = "recommendationsForYOUToolStripMenuItem";
            this.recommendationsForYOUToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.recommendationsForYOUToolStripMenuItem.Text = "Recommendations For YOU";
            this.recommendationsForYOUToolStripMenuItem.Click += new System.EventHandler(this.recommendationsForYOUToolStripMenuItem_Click);
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            this.appointmentToolStripMenuItem.Click += new System.EventHandler(this.appointmentToolStripMenuItem_Click);
            // 
            // viewYourVaccinationStatusToolStripMenuItem
            // 
            this.viewYourVaccinationStatusToolStripMenuItem.Name = "viewYourVaccinationStatusToolStripMenuItem";
            this.viewYourVaccinationStatusToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.viewYourVaccinationStatusToolStripMenuItem.Text = "View your vaccination status";
            this.viewYourVaccinationStatusToolStripMenuItem.Click += new System.EventHandler(this.viewYourVaccinationStatusToolStripMenuItem_Click);
            // 
            // getYourVaccinationCardToolStripMenuItem
            // 
            this.getYourVaccinationCardToolStripMenuItem.Name = "getYourVaccinationCardToolStripMenuItem";
            this.getYourVaccinationCardToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.getYourVaccinationCardToolStripMenuItem.Text = "Get your vaccination card ";
            this.getYourVaccinationCardToolStripMenuItem.Click += new System.EventHandler(this.getYourVaccinationCardToolStripMenuItem_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(38, 375);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 33);
            this.back.TabIndex = 18;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VaccineSystem.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(310, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 185);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.Load += new System.EventHandler(this.UserMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userMEnuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recommendationsForYOUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewYourVaccinationStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getYourVaccinationCardToolStripMenuItem;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}