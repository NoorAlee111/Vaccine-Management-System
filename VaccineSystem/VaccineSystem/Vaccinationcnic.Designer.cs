
namespace VaccineSystem
{
    partial class cnic
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
            this.cnictxt = new System.Windows.Forms.TextBox();
            this.Cniclbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Nextbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cnictxt
            // 
            this.cnictxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnictxt.Location = new System.Drawing.Point(104, 145);
            this.cnictxt.Name = "cnictxt";
            this.cnictxt.Size = new System.Drawing.Size(191, 29);
            this.cnictxt.TabIndex = 2;
            this.cnictxt.TextChanged += new System.EventHandler(this.cnictxt_TextChanged);
            this.cnictxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cnictxt_KeyPress);
            // 
            // Cniclbl
            // 
            this.Cniclbl.AutoSize = true;
            this.Cniclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cniclbl.Location = new System.Drawing.Point(12, 150);
            this.Cniclbl.Name = "Cniclbl";
            this.Cniclbl.Size = new System.Drawing.Size(58, 24);
            this.Cniclbl.TabIndex = 3;
            this.Cniclbl.Text = "Cinc:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 38);
            this.button1.TabIndex = 41;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nextbtn
            // 
            this.Nextbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nextbtn.Location = new System.Drawing.Point(293, 305);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(76, 38);
            this.Nextbtn.TabIndex = 42;
            this.Nextbtn.Text = "Next";
            this.Nextbtn.UseVisualStyleBackColor = true;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Vaccination Management System\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 40);
            this.label3.TabIndex = 45;
            this.label3.Text = "\r\n\r\n";
            // 
            // cnic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 444);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nextbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cniclbl);
            this.Controls.Add(this.cnictxt);
            this.Name = "cnic";
            this.Text = "Vaccinationcnic";
            this.Load += new System.EventHandler(this.Vaccinationcnic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cnictxt;
        private System.Windows.Forms.Label Cniclbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Nextbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}