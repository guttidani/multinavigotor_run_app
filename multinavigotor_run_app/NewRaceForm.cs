using multinavigotor_run_app.Persistency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace multinavigotor_run_app
{
    public partial class NewRaceForm : Form
    {
        public NewRaceForm()
        {
            InitializeComponent();
        }

        private void createRaceBtn_Click(object sender, EventArgs e)
        {
            if (RaceNameTxtbox.Text.Length == 0)
            {
                MessageBox.Show("Pleas don't let the fields empty");
            }
            else
            {
                RacePersistency.RaceName = RaceNameTxtbox.Text;
                RacePersistency.DateofRace = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString());

                if (manRBtn.Checked == true)
                {
                    RacePersistency.IsMan = true;
                }
                else if (womanRBtn.Checked == true)
                {
                    RacePersistency.IsMan = false;
                }
                MessageBox.Show("Race created: {0}", RacePersistency.RaceName);
                this.Close();
            }
        }
    }
}
