namespace Pill_Identifier
{
    partial class menuForm
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
            this.AddPill_button = new System.Windows.Forms.Button();
            this.ModifyPill_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PillIdentifier_button = new System.Windows.Forms.Button();
            this.PillReport_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddPill_button
            // 
            this.AddPill_button.Location = new System.Drawing.Point(81, 26);
            this.AddPill_button.Name = "AddPill_button";
            this.AddPill_button.Size = new System.Drawing.Size(75, 23);
            this.AddPill_button.TabIndex = 0;
            this.AddPill_button.Text = "Add Pill";
            this.AddPill_button.UseVisualStyleBackColor = true;
            this.AddPill_button.Click += new System.EventHandler(this.AddPill_button_Click);
            // 
            // ModifyPill_button
            // 
            this.ModifyPill_button.Location = new System.Drawing.Point(81, 67);
            this.ModifyPill_button.Name = "ModifyPill_button";
            this.ModifyPill_button.Size = new System.Drawing.Size(75, 23);
            this.ModifyPill_button.TabIndex = 1;
            this.ModifyPill_button.Text = "Modify Pill";
            this.ModifyPill_button.UseVisualStyleBackColor = true;
            this.ModifyPill_button.Click += new System.EventHandler(this.ModifyPill_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(222, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpContentsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // helpContentsToolStripMenuItem
            // 
            this.helpContentsToolStripMenuItem.Name = "helpContentsToolStripMenuItem";
            this.helpContentsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.helpContentsToolStripMenuItem.Text = "Help Contents";
            this.helpContentsToolStripMenuItem.Click += new System.EventHandler(this.HelpContentsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // PillIdentifier_button
            // 
            this.PillIdentifier_button.Location = new System.Drawing.Point(81, 108);
            this.PillIdentifier_button.Name = "PillIdentifier_button";
            this.PillIdentifier_button.Size = new System.Drawing.Size(75, 23);
            this.PillIdentifier_button.TabIndex = 3;
            this.PillIdentifier_button.Text = "Pill Identifier";
            this.PillIdentifier_button.UseVisualStyleBackColor = true;
            this.PillIdentifier_button.Click += new System.EventHandler(this.PillIdentifier_button_Click);
            // 
            // PillReport_button
            // 
            this.PillReport_button.Location = new System.Drawing.Point(81, 149);
            this.PillReport_button.Name = "PillReport_button";
            this.PillReport_button.Size = new System.Drawing.Size(75, 23);
            this.PillReport_button.TabIndex = 4;
            this.PillReport_button.Text = "Pill Report";
            this.PillReport_button.UseVisualStyleBackColor = true;
            this.PillReport_button.Click += new System.EventHandler(this.PillReport_button_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 185);
            this.Controls.Add(this.PillReport_button);
            this.Controls.Add(this.PillIdentifier_button);
            this.Controls.Add(this.ModifyPill_button);
            this.Controls.Add(this.AddPill_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menuForm";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPill_button;
        private System.Windows.Forms.Button ModifyPill_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpContentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button PillIdentifier_button;
        private System.Windows.Forms.Button PillReport_button;
    }
}