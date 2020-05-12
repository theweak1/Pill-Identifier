﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pill_Identifier
{
    public partial class pillIdentifier : Form
    {
        public pillIdentifier()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifyPillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyPill modify = new ModifyPill();
            modify.ShowDialog();
        }

        private void addPillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            addPill add = new addPill();
            add.ShowDialog();
        }

        private void pillReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            pillReport report = new pillReport();
            report.ShowDialog();
        }

        private void helpContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpContents help = new HelpContents();
            help.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About info = new About();
            info.ShowDialog();
        }
    }
}
