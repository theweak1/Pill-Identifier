namespace Pill_Identifier
{
    partial class About
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
            this.student1_name = new System.Windows.Forms.Label();
            this.student2_name = new System.Windows.Forms.Label();
            this.student3_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // student1_name
            // 
            this.student1_name.AutoSize = true;
            this.student1_name.Location = new System.Drawing.Point(13, 35);
            this.student1_name.Name = "student1_name";
            this.student1_name.Size = new System.Drawing.Size(169, 13);
            this.student1_name.TabIndex = 0;
            this.student1_name.Text = "Jan M. Montalvo Medina - 111957";
            // 
            // student2_name
            // 
            this.student2_name.AutoSize = true;
            this.student2_name.Location = new System.Drawing.Point(13, 68);
            this.student2_name.Name = "student2_name";
            this.student2_name.Size = new System.Drawing.Size(167, 13);
            this.student2_name.TabIndex = 1;
            this.student2_name.Text = "Omar E. Flores Quintana - 113234";
            // 
            // student3_name
            // 
            this.student3_name.AutoSize = true;
            this.student3_name.Location = new System.Drawing.Point(13, 99);
            this.student3_name.Name = "student3_name";
            this.student3_name.Size = new System.Drawing.Size(150, 13);
            this.student3_name.TabIndex = 2;
            this.student3_name.Text = "Lenier Ortiz Rodriguez - 95537";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 195);
            this.Controls.Add(this.student3_name);
            this.Controls.Add(this.student2_name);
            this.Controls.Add(this.student1_name);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label student1_name;
        private System.Windows.Forms.Label student2_name;
        private System.Windows.Forms.Label student3_name;
    }
}