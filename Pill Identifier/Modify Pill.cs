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
    public partial class ModifyPill : Form
    {
        public ModifyPill()
        {
            InitializeComponent();
            modify_container.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(imprint_value.Text == "hi") // change hi for what ever the database suppose to be
            {
                search_container.Hide();
                modify_container.Show();
            }
            else
            {
                MessageBox.Show("That imprint you have entered is not in the data base");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pillReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            pillReport report = new pillReport();
            report.ShowDialog();
        }

        private void identifyPillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            pillIdentifier identify = new pillIdentifier();
            identify.ShowDialog();
        }

        private void addPillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            addPill add = new addPill();
            add.ShowDialog();
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
    }
}
