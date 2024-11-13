
namespace VaccineSystem
{
    partial class SearchForm
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
            this.Searchlbl = new System.Windows.Forms.Label();
            this.agecb = new System.Windows.Forms.CheckBox();
            this.gendercb = new System.Windows.Forms.CheckBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.selectgender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Vaccination Management System\r\n";
            // 
            // Searchlbl
            // 
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlbl.Location = new System.Drawing.Point(50, 108);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(82, 24);
            this.Searchlbl.TabIndex = 40;
            this.Searchlbl.Text = "Search:";
            // 
            // agecb
            // 
            this.agecb.AutoSize = true;
            this.agecb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agecb.Location = new System.Drawing.Point(54, 167);
            this.agecb.Name = "agecb";
            this.agecb.Size = new System.Drawing.Size(96, 28);
            this.agecb.TabIndex = 41;
            this.agecb.Text = "By Age";
            this.agecb.UseVisualStyleBackColor = true;
            // 
            // gendercb
            // 
            this.gendercb.AutoSize = true;
            this.gendercb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gendercb.Location = new System.Drawing.Point(54, 211);
            this.gendercb.Name = "gendercb";
            this.gendercb.Size = new System.Drawing.Size(128, 28);
            this.gendercb.TabIndex = 42;
            this.gendercb.Text = "By Gender";
            this.gendercb.UseVisualStyleBackColor = true;
            this.gendercb.CheckedChanged += new System.EventHandler(this.gendercb_CheckedChanged);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(54, 341);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(78, 40);
            this.backbtn.TabIndex = 43;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // viewbtn
            // 
            this.viewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbtn.Location = new System.Drawing.Point(611, 332);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(78, 40);
            this.viewbtn.TabIndex = 44;
            this.viewbtn.Text = "View";
            this.viewbtn.UseVisualStyleBackColor = true;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // selectgender
            // 
            this.selectgender.FormattingEnabled = true;
            this.selectgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Transgender"});
            this.selectgender.Location = new System.Drawing.Point(188, 218);
            this.selectgender.Name = "selectgender";
            this.selectgender.Size = new System.Drawing.Size(121, 21);
            this.selectgender.TabIndex = 45;
            this.selectgender.Visible = false;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectgender);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.gendercb);
            this.Controls.Add(this.agecb);
            this.Controls.Add(this.Searchlbl);
            this.Controls.Add(this.label2);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Searchlbl;
        private System.Windows.Forms.CheckBox agecb;
        private System.Windows.Forms.CheckBox gendercb;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.ComboBox selectgender;
    }
}