namespace Pill_Identifier
{
    partial class addPill
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pillIdentifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pillReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drugName_label = new System.Windows.Forms.Label();
            this.drugName_value = new System.Windows.Forms.TextBox();
            this.strength_label = new System.Windows.Forms.Label();
            this.strength_value = new System.Windows.Forms.TextBox();
            this.pillIprint_label = new System.Windows.Forms.Label();
            this.pillImprint_value = new System.Windows.Forms.TextBox();
            this.color_label = new System.Windows.Forms.Label();
            this.color_value = new System.Windows.Forms.TextBox();
            this.shape_label = new System.Windows.Forms.Label();
            this.shape_value = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.pillIdentifierToolStripMenuItem,
            this.pillReportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.menuToolStripMenuItem.Text = "Modify Pill";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // pillIdentifierToolStripMenuItem
            // 
            this.pillIdentifierToolStripMenuItem.Name = "pillIdentifierToolStripMenuItem";
            this.pillIdentifierToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.pillIdentifierToolStripMenuItem.Text = "Pill Identifier";
            this.pillIdentifierToolStripMenuItem.Click += new System.EventHandler(this.pillIdentifierToolStripMenuItem_Click);
            // 
            // pillReportToolStripMenuItem
            // 
            this.pillReportToolStripMenuItem.Name = "pillReportToolStripMenuItem";
            this.pillReportToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.pillReportToolStripMenuItem.Text = "Pill Report";
            this.pillReportToolStripMenuItem.Click += new System.EventHandler(this.pillReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpContentsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpContentsToolStripMenuItem
            // 
            this.helpContentsToolStripMenuItem.Name = "helpContentsToolStripMenuItem";
            this.helpContentsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.helpContentsToolStripMenuItem.Text = "Help Contents";
            this.helpContentsToolStripMenuItem.Click += new System.EventHandler(this.helpContentsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // drugName_label
            // 
            this.drugName_label.AutoSize = true;
            this.drugName_label.Location = new System.Drawing.Point(13, 37);
            this.drugName_label.Name = "drugName_label";
            this.drugName_label.Size = new System.Drawing.Size(67, 13);
            this.drugName_label.TabIndex = 1;
            this.drugName_label.Text = "Drug Name: ";
            // 
            // drugName_value
            // 
            this.drugName_value.Location = new System.Drawing.Point(76, 34);
            this.drugName_value.Name = "drugName_value";
            this.drugName_value.Size = new System.Drawing.Size(100, 20);
            this.drugName_value.TabIndex = 2;
            // 
            // strength_label
            // 
            this.strength_label.AutoSize = true;
            this.strength_label.Location = new System.Drawing.Point(13, 71);
            this.strength_label.Name = "strength_label";
            this.strength_label.Size = new System.Drawing.Size(53, 13);
            this.strength_label.TabIndex = 3;
            this.strength_label.Text = "Strength: ";
            // 
            // strength_value
            // 
            this.strength_value.Location = new System.Drawing.Point(76, 64);
            this.strength_value.Name = "strength_value";
            this.strength_value.Size = new System.Drawing.Size(60, 20);
            this.strength_value.TabIndex = 4;
            // 
            // pillIprint_label
            // 
            this.pillIprint_label.AutoSize = true;
            this.pillIprint_label.Location = new System.Drawing.Point(13, 95);
            this.pillIprint_label.Name = "pillIprint_label";
            this.pillIprint_label.Size = new System.Drawing.Size(60, 13);
            this.pillIprint_label.TabIndex = 5;
            this.pillIprint_label.Text = "Pill Imprint: ";
            // 
            // pillImprint_value
            // 
            this.pillImprint_value.Location = new System.Drawing.Point(76, 95);
            this.pillImprint_value.Name = "pillImprint_value";
            this.pillImprint_value.Size = new System.Drawing.Size(80, 20);
            this.pillImprint_value.TabIndex = 6;
            // 
            // color_label
            // 
            this.color_label.AutoSize = true;
            this.color_label.Location = new System.Drawing.Point(16, 123);
            this.color_label.Name = "color_label";
            this.color_label.Size = new System.Drawing.Size(37, 13);
            this.color_label.TabIndex = 7;
            this.color_label.Text = "Color: ";
            // 
            // color_value
            // 
            this.color_value.Location = new System.Drawing.Point(76, 123);
            this.color_value.Name = "color_value";
            this.color_value.Size = new System.Drawing.Size(100, 20);
            this.color_value.TabIndex = 8;
            this.color_value.TextChanged += new System.EventHandler(this.color_value_TextChanged);
            // 
            // shape_label
            // 
            this.shape_label.AutoSize = true;
            this.shape_label.Location = new System.Drawing.Point(16, 152);
            this.shape_label.Name = "shape_label";
            this.shape_label.Size = new System.Drawing.Size(44, 13);
            this.shape_label.TabIndex = 9;
            this.shape_label.Text = "Shape: ";
            // 
            // shape_value
            // 
            this.shape_value.Location = new System.Drawing.Point(76, 152);
            this.shape_value.Name = "shape_value";
            this.shape_value.Size = new System.Drawing.Size(80, 20);
            this.shape_value.TabIndex = 10;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(101, 221);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 12;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(268, 221);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 13;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(268, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 106);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addPill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 276);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.shape_value);
            this.Controls.Add(this.shape_label);
            this.Controls.Add(this.color_value);
            this.Controls.Add(this.color_label);
            this.Controls.Add(this.pillImprint_value);
            this.Controls.Add(this.pillIprint_label);
            this.Controls.Add(this.strength_value);
            this.Controls.Add(this.strength_label);
            this.Controls.Add(this.drugName_value);
            this.Controls.Add(this.drugName_label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "addPill";
            this.Text = "Add Pill";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pillIdentifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pillReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpContentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label drugName_label;
        private System.Windows.Forms.TextBox drugName_value;
        private System.Windows.Forms.Label strength_label;
        private System.Windows.Forms.TextBox strength_value;
        private System.Windows.Forms.Label pillIprint_label;
        private System.Windows.Forms.TextBox pillImprint_value;
        private System.Windows.Forms.Label color_label;
        private System.Windows.Forms.TextBox color_value;
        private System.Windows.Forms.Label shape_label;
        private System.Windows.Forms.TextBox shape_value;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}