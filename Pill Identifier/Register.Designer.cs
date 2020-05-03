namespace Pill_Identifier
{
    partial class Register
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
            this.firstName_label = new System.Windows.Forms.Label();
            this.lastName_label = new System.Windows.Forms.Label();
            this.firstName_value = new System.Windows.Forms.TextBox();
            this.lastName_value = new System.Windows.Forms.TextBox();
            this.userName_value = new System.Windows.Forms.TextBox();
            this.userName_label = new System.Windows.Forms.Label();
            this.password_value = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstName_label
            // 
            this.firstName_label.AutoSize = true;
            this.firstName_label.Location = new System.Drawing.Point(13, 40);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(60, 13);
            this.firstName_label.TabIndex = 0;
            this.firstName_label.Text = "First Name:";
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.Location = new System.Drawing.Point(13, 75);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(64, 13);
            this.lastName_label.TabIndex = 1;
            this.lastName_label.Text = "Last Name: ";
            // 
            // firstName_value
            // 
            this.firstName_value.Location = new System.Drawing.Point(80, 40);
            this.firstName_value.Name = "firstName_value";
            this.firstName_value.Size = new System.Drawing.Size(100, 20);
            this.firstName_value.TabIndex = 2;
            // 
            // lastName_value
            // 
            this.lastName_value.Location = new System.Drawing.Point(80, 72);
            this.lastName_value.Name = "lastName_value";
            this.lastName_value.Size = new System.Drawing.Size(138, 20);
            this.lastName_value.TabIndex = 3;
            // 
            // userName_value
            // 
            this.userName_value.Location = new System.Drawing.Point(85, 120);
            this.userName_value.Name = "userName_value";
            this.userName_value.Size = new System.Drawing.Size(100, 20);
            this.userName_value.TabIndex = 4;
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.Location = new System.Drawing.Point(16, 123);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(63, 13);
            this.userName_label.TabIndex = 5;
            this.userName_label.Text = "User Name:";
            // 
            // password_value
            // 
            this.password_value.Location = new System.Drawing.Point(85, 147);
            this.password_value.Name = "password_value";
            this.password_value.Size = new System.Drawing.Size(100, 20);
            this.password_value.TabIndex = 6;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(19, 147);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(59, 13);
            this.password_label.TabIndex = 7;
            this.password_label.Text = "Password: ";
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(37, 199);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(75, 23);
            this.register_button.TabIndex = 8;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(118, 199);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 9;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 255);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password_value);
            this.Controls.Add(this.userName_label);
            this.Controls.Add(this.userName_value);
            this.Controls.Add(this.lastName_value);
            this.Controls.Add(this.firstName_value);
            this.Controls.Add(this.lastName_label);
            this.Controls.Add(this.firstName_label);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName_label;
        private System.Windows.Forms.Label lastName_label;
        private System.Windows.Forms.TextBox firstName_value;
        private System.Windows.Forms.TextBox lastName_value;
        private System.Windows.Forms.TextBox userName_value;
        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.TextBox password_value;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button clear_button;
    }
}