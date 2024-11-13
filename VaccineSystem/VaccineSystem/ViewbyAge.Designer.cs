
namespace VaccineSystem
{
    partial class ViewbyAge
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
            this.recordgrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recordgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // recordgrid
            // 
            this.recordgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordgrid.Location = new System.Drawing.Point(191, 91);
            this.recordgrid.Name = "recordgrid";
            this.recordgrid.Size = new System.Drawing.Size(1097, 432);
            this.recordgrid.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Vaccination Management System\r\n";
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(74, 445);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(78, 40);
            this.backbtn.TabIndex = 44;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // ViewbyAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 535);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recordgrid);
            this.Name = "ViewbyAge";
            this.Text = "ViewbyAge";
            this.Load += new System.EventHandler(this.ViewbyAge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView recordgrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backbtn;
    }
}