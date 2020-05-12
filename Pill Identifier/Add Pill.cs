using System;
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
    public partial class addPill : Form
    {
        public addPill()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyPill modify = new ModifyPill();
            modify.ShowDialog();
            
        }

        private void pillIdentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            pillIdentifier identify = new pillIdentifier();
            identify.ShowDialog();
            
        }

        private void pillReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            pillReport report = new pillReport();
            report.ShowDialog();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            drugName_value.Clear();
            strength_value.Clear();
            pillImprint_value.Clear();
            color_value.Clear();
            shape_value.Clear();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string pillImprint = pillImprint_value.Text;


            PillIdentifier pill = new PillIdentifier(); 


        }

        private void helpContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpContents help = new HelpContents();
            help.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About info = new About();
            info.ShowDialog();
        }

       /*
        * TODO
        * 1. make folder dialog to be able to add picture of pill
        */
    }
}
