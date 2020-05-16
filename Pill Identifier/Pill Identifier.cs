using System;
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

        private void identify_button_Click(object sender, EventArgs e)
        {
            PillIdentifier pill = new PillIdentifier();

            if (pill.IdentifyPill(imprint_value.Text))
            {
                drug_result.Text = pill.DrugName;
                strength_result.Text = pill.PillImprint;
                imprint_result.Text = pill.DrugStrenght;
                color_result.Text = pill.PillColor;
                shape_result.Text = pill.PillShape;
                pictureBox1.AccessibleName = pill.PillPhoto;
                date_result.Text = pill.Date.ToString();
            }
            else
            {
                MessageBox.Show("That imprint you have entered is not in the data base");
            }

        }
    }
}
