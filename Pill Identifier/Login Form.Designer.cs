namespace Pill_Identifier
{
    partial class Login
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userName_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.userName_value = new System.Windows.Forms.TextBox();
            this.password_value = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Register_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(258, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.Location = new System.Drawing.Point(44, 58);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(59, 13);
            this.userName_label.TabIndex = 1;
            this.userName_label.Text = "username: ";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(47, 95);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(58, 13);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "password: ";
            // 
            // userName_value
            // 
            this.userName_value.Location = new System.Drawing.Point(110, 58);
            this.userName_value.Name = "userName_value";
            this.userName_value.Size = new System.Drawing.Size(100, 20);
            this.userName_value.TabIndex = 3;
            // 
            // password_value
            // 
            this.password_value.AcceptsReturn = true;
            this.password_value.Location = new System.Drawing.Point(110, 95);
            this.password_value.Name = "password_value";
            this.password_value.PasswordChar = '*';
            this.password_value.Size = new System.Drawing.Size(100, 20);
            this.password_value.TabIndex = 4;
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(47, 153);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(75, 23);
            this.Login_button.TabIndex = 5;
            this.Login_button.Text = "login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(135, 153);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(75, 23);
            this.Clear_button.TabIndex = 6;
            this.Clear_button.Text = "clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Register_button
            // 
            this.Register_button.Location = new System.Drawing.Point(88, 196);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(75, 23);
            this.Register_button.TabIndex = 7;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 230);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.password_value);
            this.Controls.Add(this.userName_value);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.userName_label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.Text = "Login Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox userName_value;
        private System.Windows.Forms.TextBox password_value;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Register_button;
    }
}