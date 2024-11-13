
namespace VaccineSystem
{
    partial class VaccinationStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaccinationStatus));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vaccinestatuslbl1 = new System.Windows.Forms.Label();
            this.vaccinestatuslbl2 = new System.Windows.Forms.Label();
            this.vaccinestatuslbl3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Vaccination Management System\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 60);
            this.label3.TabIndex = 46;
            this.label3.Text = "\r\n\r\nUSER > Vaccination status";
            // 
            // vaccinestatuslbl1
            // 
            this.vaccinestatuslbl1.AutoSize = true;
            this.vaccinestatuslbl1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vaccinestatuslbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaccinestatuslbl1.Location = new System.Drawing.Point(26, 175);
            this.vaccinestatuslbl1.Name = "vaccinestatuslbl1";
            this.vaccinestatuslbl1.Size = new System.Drawing.Size(9, 20);
            this.vaccinestatuslbl1.TabIndex = 47;
            this.vaccinestatuslbl1.Text = "\r\n";
            // 
            // vaccinestatuslbl2
            // 
            this.vaccinestatuslbl2.AutoSize = true;
            this.vaccinestatuslbl2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vaccinestatuslbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaccinestatuslbl2.Location = new System.Drawing.Point(26, 263);
            this.vaccinestatuslbl2.Name = "vaccinestatuslbl2";
            this.vaccinestatuslbl2.Size = new System.Drawing.Size(9, 20);
            this.vaccinestatuslbl2.TabIndex = 48;
            this.vaccinestatuslbl2.Text = "\r\n";
            // 
            // vaccinestatuslbl3
            // 
            this.vaccinestatuslbl3.AutoSize = true;
            this.vaccinestatuslbl3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vaccinestatuslbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaccinestatuslbl3.Location = new System.Drawing.Point(26, 296);
            this.vaccinestatuslbl3.Name = "vaccinestatuslbl3";
            this.vaccinestatuslbl3.Size = new System.Drawing.Size(9, 20);
            this.vaccinestatuslbl3.TabIndex = 49;
            this.vaccinestatuslbl3.Text = "\r\n";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(528, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 38);
            this.button1.TabIndex = 50;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VaccineSystem.Properties.Resources.download__1_;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(379, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 148);
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // VaccinationStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 438);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vaccinestatuslbl3);
            this.Controls.Add(this.vaccinestatuslbl2);
            this.Controls.Add(this.vaccinestatuslbl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "VaccinationStatus";
            this.Text = "VaccinationStatus";
            this.Load += new System.EventHandler(this.VaccinationStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label vaccinestatuslbl1;
        private System.Windows.Forms.Label vaccinestatuslbl2;
        private System.Windows.Forms.Label vaccinestatuslbl3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}