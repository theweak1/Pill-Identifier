namespace Pill_Identifier
{
    partial class pillIdentifier
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
            this.imprint_label = new System.Windows.Forms.Label();
            this.imprint_value = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drugResult_label = new System.Windows.Forms.Label();
            this.drug_result = new System.Windows.Forms.TextBox();
            this.strengthResult_labe = new System.Windows.Forms.Label();
            this.strength_result = new System.Windows.Forms.TextBox();
            this.shape_result = new System.Windows.Forms.TextBox();
            this.shapeResult_label = new System.Windows.Forms.Label();
            this.color_result = new System.Windows.Forms.TextBox();
            this.colorResult_label = new System.Windows.Forms.Label();
            this.imprint_result = new System.Windows.Forms.TextBox();
            this.imprintResult_label = new System.Windows.Forms.Label();
            this.identify_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pillReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.date_result = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imprint_label
            // 
            this.imprint_label.AutoSize = true;
            this.imprint_label.Location = new System.Drawing.Point(21, 61);
            this.imprint_label.Name = "imprint_label";
            this.imprint_label.Size = new System.Drawing.Size(65, 13);
            this.imprint_label.TabIndex = 0;
            this.imprint_label.Text = "Enter imprint";
            // 
            // imprint_value
            // 
            this.imprint_value.Location = new System.Drawing.Point(92, 61);
            this.imprint_value.Name = "imprint_value";
            this.imprint_value.Size = new System.Drawing.Size(105, 20);
            this.imprint_value.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(310, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 118);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // drugResult_label
            // 
            this.drugResult_label.AutoSize = true;
            this.drugResult_label.Location = new System.Drawing.Point(307, 211);
            this.drugResult_label.Name = "drugResult_label";
            this.drugResult_label.Size = new System.Drawing.Size(61, 13);
            this.drugResult_label.TabIndex = 7;
            this.drugResult_label.Text = "Drug Name";
            // 
            // drug_result
            // 
            this.drug_result.Enabled = false;
            this.drug_result.Location = new System.Drawing.Point(375, 203);
            this.drug_result.Name = "drug_result";
            this.drug_result.Size = new System.Drawing.Size(100, 20);
            this.drug_result.TabIndex = 8;
            // 
            // strengthResult_labe
            // 
            this.strengthResult_labe.AutoSize = true;
            this.strengthResult_labe.Location = new System.Drawing.Point(306, 242);
            this.strengthResult_labe.Name = "strengthResult_labe";
            this.strengthResult_labe.Size = new System.Drawing.Size(47, 13);
            this.strengthResult_labe.TabIndex = 9;
            this.strengthResult_labe.Text = "Strength";
            // 
            // strength_result
            // 
            this.strength_result.Enabled = false;
            this.strength_result.Location = new System.Drawing.Point(375, 242);
            this.strength_result.Name = "strength_result";
            this.strength_result.Size = new System.Drawing.Size(100, 20);
            this.strength_result.TabIndex = 10;
            // 
            // shape_result
            // 
            this.shape_result.Enabled = false;
            this.shape_result.Location = new System.Drawing.Point(375, 337);
            this.shape_result.Name = "shape_result";
            this.shape_result.Size = new System.Drawing.Size(100, 20);
            this.shape_result.TabIndex = 16;
            this.shape_result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // shapeResult_label
            // 
            this.shapeResult_label.AutoSize = true;
            this.shapeResult_label.Location = new System.Drawing.Point(306, 340);
            this.shapeResult_label.Name = "shapeResult_label";
            this.shapeResult_label.Size = new System.Drawing.Size(38, 13);
            this.shapeResult_label.TabIndex = 15;
            this.shapeResult_label.Text = "Shape";
            // 
            // color_result
            // 
            this.color_result.Enabled = false;
            this.color_result.Location = new System.Drawing.Point(375, 307);
            this.color_result.Name = "color_result";
            this.color_result.Size = new System.Drawing.Size(100, 20);
            this.color_result.TabIndex = 14;
            this.color_result.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // colorResult_label
            // 
            this.colorResult_label.AutoSize = true;
            this.colorResult_label.Location = new System.Drawing.Point(306, 310);
            this.colorResult_label.Name = "colorResult_label";
            this.colorResult_label.Size = new System.Drawing.Size(31, 13);
            this.colorResult_label.TabIndex = 13;
            this.colorResult_label.Text = "Color";
            // 
            // imprint_result
            // 
            this.imprint_result.Enabled = false;
            this.imprint_result.Location = new System.Drawing.Point(375, 277);
            this.imprint_result.Name = "imprint_result";
            this.imprint_result.Size = new System.Drawing.Size(100, 20);
            this.imprint_result.TabIndex = 12;
            this.imprint_result.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // imprintResult_label
            // 
            this.imprintResult_label.AutoSize = true;
            this.imprintResult_label.Location = new System.Drawing.Point(306, 277);
            this.imprintResult_label.Name = "imprintResult_label";
            this.imprintResult_label.Size = new System.Drawing.Size(38, 13);
            this.imprintResult_label.TabIndex = 11;
            this.imprintResult_label.Text = "Imprint";
            // 
            // identify_button
            // 
            this.identify_button.Location = new System.Drawing.Point(122, 112);
            this.identify_button.Name = "identify_button";
            this.identify_button.Size = new System.Drawing.Size(75, 23);
            this.identify_button.TabIndex = 17;
            this.identify_button.Text = "Identify";
            this.identify_button.UseVisualStyleBackColor = true;
            this.identify_button.Click += new System.EventHandler(this.identify_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPillToolStripMenuItem,
            this.modifyPillToolStripMenuItem,
            this.pillReportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addPillToolStripMenuItem
            // 
            this.addPillToolStripMenuItem.Name = "addPillToolStripMenuItem";
            this.addPillToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addPillToolStripMenuItem.Text = "Add Pill";
            this.addPillToolStripMenuItem.Click += new System.EventHandler(this.addPillToolStripMenuItem_Click);
            // 
            // modifyPillToolStripMenuItem
            // 
            this.modifyPillToolStripMenuItem.Name = "modifyPillToolStripMenuItem";
            this.modifyPillToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.modifyPillToolStripMenuItem.Text = "Modify Pill";
            // 
            // pillReportToolStripMenuItem
            // 
            this.pillReportToolStripMenuItem.Name = "pillReportToolStripMenuItem";
            this.pillReportToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.pillReportToolStripMenuItem.Text = "Pill Report";
            this.pillReportToolStripMenuItem.Click += new System.EventHandler(this.pillReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Date";
            // 
            // date_result
            // 
            this.date_result.Location = new System.Drawing.Point(375, 368);
            this.date_result.Name = "date_result";
            this.date_result.Size = new System.Drawing.Size(100, 20);
            this.date_result.TabIndex = 20;
            // 
            // pillIdentifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 425);
            this.Controls.Add(this.date_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.identify_button);
            this.Controls.Add(this.shape_result);
            this.Controls.Add(this.shapeResult_label);
            this.Controls.Add(this.color_result);
            this.Controls.Add(this.colorResult_label);
            this.Controls.Add(this.imprint_result);
            this.Controls.Add(this.imprintResult_label);
            this.Controls.Add(this.strength_result);
            this.Controls.Add(this.strengthResult_labe);
            this.Controls.Add(this.drug_result);
            this.Controls.Add(this.drugResult_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imprint_value);
            this.Controls.Add(this.imprint_label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "pillIdentifier";
            this.Text = "Pill Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imprint_label;
        private System.Windows.Forms.TextBox imprint_value;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label drugResult_label;
        private System.Windows.Forms.TextBox drug_result;
        private System.Windows.Forms.Label strengthResult_labe;
        private System.Windows.Forms.TextBox strength_result;
        private System.Windows.Forms.TextBox shape_result;
        private System.Windows.Forms.Label shapeResult_label;
        private System.Windows.Forms.TextBox color_result;
        private System.Windows.Forms.Label colorResult_label;
        private System.Windows.Forms.TextBox imprint_result;
        private System.Windows.Forms.Label imprintResult_label;
        private System.Windows.Forms.Button identify_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyPillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pillReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpContentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox date_result;
    }
}