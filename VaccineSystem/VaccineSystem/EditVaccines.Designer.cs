
namespace VaccineSystem
{
    partial class EditVaccines
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pfizercb = new System.Windows.Forms.CheckBox();
            this.modernacb = new System.Windows.Forms.CheckBox();
            this.sinopharmcb = new System.Windows.Forms.CheckBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Admin > Vaccine Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Vaccination Management System\r\n";
            // 
            // Pfizercb
            // 
            this.Pfizercb.AutoSize = true;
            this.Pfizercb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pfizercb.Location = new System.Drawing.Point(28, 163);
            this.Pfizercb.Name = "Pfizercb";
            this.Pfizercb.Size = new System.Drawing.Size(205, 28);
            this.Pfizercb.TabIndex = 22;
            this.Pfizercb.Text = "Edit Quantity of Pfizer";
            this.Pfizercb.UseVisualStyleBackColor = true;
            this.Pfizercb.CheckedChanged += new System.EventHandler(this.Pfizercb_CheckedChanged);
            // 
            // modernacb
            // 
            this.modernacb.AutoSize = true;
            this.modernacb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernacb.Location = new System.Drawing.Point(28, 265);
            this.modernacb.Name = "modernacb";
            this.modernacb.Size = new System.Drawing.Size(235, 28);
            this.modernacb.TabIndex = 24;
            this.modernacb.Text = "Edit Quantity of Moderna\r\n";
            this.modernacb.UseVisualStyleBackColor = true;
            // 
            // sinopharmcb
            // 
            this.sinopharmcb.AutoSize = true;
            this.sinopharmcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinopharmcb.Location = new System.Drawing.Point(28, 215);
            this.sinopharmcb.Name = "sinopharmcb";
            this.sinopharmcb.Size = new System.Drawing.Size(251, 28);
            this.sinopharmcb.TabIndex = 25;
            this.sinopharmcb.Text = "Edit Quantity of Sinopharm\r\n";
            this.sinopharmcb.UseVisualStyleBackColor = true;
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(28, 344);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(79, 38);
            this.backbtn.TabIndex = 26;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbtn.Location = new System.Drawing.Point(543, 333);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(79, 38);
            this.Editbtn.TabIndex = 27;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // EditVaccines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.sinopharmcb);
            this.Controls.Add(this.modernacb);
            this.Controls.Add(this.Pfizercb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "EditVaccines";
            this.Text = "EditVaccines";
            this.Load += new System.EventHandler(this.EditVaccines_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Pfizercb;
        private System.Windows.Forms.CheckBox modernacb;
        private System.Windows.Forms.CheckBox sinopharmcb;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button Editbtn;
    }
}