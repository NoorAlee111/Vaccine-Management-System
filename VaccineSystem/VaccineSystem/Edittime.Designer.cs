
namespace VaccineSystem
{
    partial class Edittime
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datetxt = new System.Windows.Forms.TextBox();
            this.monthtxt = new System.Windows.Forms.TextBox();
            this.timetxt = new System.Windows.Forms.TextBox();
            this.editbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Vaccination Management System\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "Date:";
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.Location = new System.Drawing.Point(36, 136);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(63, 24);
            this.timelbl.TabIndex = 43;
            this.timelbl.Text = "Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "Month:";
            // 
            // datetxt
            // 
            this.datetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetxt.Location = new System.Drawing.Point(125, 192);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(262, 26);
            this.datetxt.TabIndex = 45;
            this.datetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.datetxt_KeyPress);
            // 
            // monthtxt
            // 
            this.monthtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthtxt.Location = new System.Drawing.Point(125, 264);
            this.monthtxt.Name = "monthtxt";
            this.monthtxt.Size = new System.Drawing.Size(262, 26);
            this.monthtxt.TabIndex = 46;
            this.monthtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.monthtxt_KeyPress);
            // 
            // timetxt
            // 
            this.timetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetxt.Location = new System.Drawing.Point(125, 134);
            this.timetxt.Name = "timetxt";
            this.timetxt.Size = new System.Drawing.Size(262, 26);
            this.timetxt.TabIndex = 47;
            this.timetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timetxt_KeyPress);
            // 
            // editbtn
            // 
            this.editbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.Location = new System.Drawing.Point(569, 327);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(90, 43);
            this.editbtn.TabIndex = 48;
            this.editbtn.Text = "Set";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(77, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 43);
            this.button1.TabIndex = 49;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edittime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.timetxt);
            this.Controls.Add(this.monthtxt);
            this.Controls.Add(this.datetxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Edittime";
            this.Text = "Set";
            this.Load += new System.EventHandler(this.Edittime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox datetxt;
        private System.Windows.Forms.TextBox monthtxt;
        private System.Windows.Forms.TextBox timetxt;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button button1;
    }
}