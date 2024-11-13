
namespace VaccineSystem
{
    partial class VaccineEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.newquantitytxt = new System.Windows.Forms.TextBox();
            this.vaccinenametxt = new System.Windows.Forms.Label();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.buackbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Vaccination Management System\r\n";
            // 
            // newquantitytxt
            // 
            this.newquantitytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newquantitytxt.Location = new System.Drawing.Point(387, 124);
            this.newquantitytxt.Name = "newquantitytxt";
            this.newquantitytxt.Size = new System.Drawing.Size(155, 29);
            this.newquantitytxt.TabIndex = 24;
            this.newquantitytxt.TextChanged += new System.EventHandler(this.newquantitytxt_TextChanged);
            this.newquantitytxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newquantitytxt_KeyPress);
            // 
            // vaccinenametxt
            // 
            this.vaccinenametxt.AutoSize = true;
            this.vaccinenametxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vaccinenametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaccinenametxt.Location = new System.Drawing.Point(0, 124);
            this.vaccinenametxt.Name = "vaccinenametxt";
            this.vaccinenametxt.Size = new System.Drawing.Size(12, 50);
            this.vaccinenametxt.TabIndex = 25;
            this.vaccinenametxt.Text = "\r\n\r\n";
            // 
            // confirmbtn
            // 
            this.confirmbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbtn.Location = new System.Drawing.Point(417, 222);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(97, 36);
            this.confirmbtn.TabIndex = 26;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // buackbtn
            // 
            this.buackbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buackbtn.Location = new System.Drawing.Point(89, 222);
            this.buackbtn.Name = "buackbtn";
            this.buackbtn.Size = new System.Drawing.Size(84, 36);
            this.buackbtn.TabIndex = 27;
            this.buackbtn.Text = "Back";
            this.buackbtn.UseVisualStyleBackColor = true;
            this.buackbtn.Click += new System.EventHandler(this.buackbtn_Click);
            // 
            // VaccineEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 331);
            this.Controls.Add(this.buackbtn);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.vaccinenametxt);
            this.Controls.Add(this.newquantitytxt);
            this.Controls.Add(this.label1);
            this.Name = "VaccineEditForm";
            this.Text = "VaccineEditForm";
            this.Load += new System.EventHandler(this.VaccineEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newquantitytxt;
        private System.Windows.Forms.Label vaccinenametxt;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.Button buackbtn;
    }
}