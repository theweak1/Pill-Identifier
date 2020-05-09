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
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void AddPill_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            addPill add = new addPill();
            add.ShowDialog();
            
        }

        private void ModifyPill_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyPill modify = new ModifyPill();
            modify.ShowDialog();
            
        }

        private void PillIdentifier_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            pillIdentifier identify = new pillIdentifier();
            identify.ShowDialog();
            
        }

        private void PillReport_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            pillReport report = new pillReport();
            report.ShowDialog();
            
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpContentsToolStripMenuItem_Click(object sender, EventArgs e)
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
