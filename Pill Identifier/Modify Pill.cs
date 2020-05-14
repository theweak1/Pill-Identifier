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

        private void Save_Clck(object sender, EventArgs e)
        {
            PillDB database = new PillDB();
            PillIdentifier pill = new PillIdentifier(imprint_value.Text, resultColor_value.Text, resultShape_value.Text,
                resultDrugName_value.Text, resultStrength_value.Text, "Testing.png");


            database.UpdatePet(pill);

        }

        private void Search_Click(object sender, EventArgs e)
        {

            PillIdentifier pill = new PillIdentifier();

            if (pill.IdentifyPill(imprint_value.Text)) // change hi for what ever the database suppose to be
            {
                resultDrugName_value.Text = pill.DrugName;
                resultImprint_value.Text = pill.PillImprint;
                resultStrength_value.Text = pill.DrugStrenght;
                resultColor_value.Text = pill.PillColor;
                resultShape_value.Text = pill.PillShape;
                pictureBox1.AccessibleName = pill.PillPhoto;

                search_container.Hide();
                modify_container.Show();
            }
            else
            {
                MessageBox.Show("That imprint you have entered is not in the data base");
            }

        }
    }
}
