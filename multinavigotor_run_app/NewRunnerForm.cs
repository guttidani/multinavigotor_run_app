using multinavigotor_run_app.Persistency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace multinavigotor_run_app
{
    public partial class NewRunnerForm : Form
    {
        public NewRunnerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTxtb.Text.Length == 0 || comboBox1.SelectedItem == null || birthDateTxtb.Text.Length == 0)
            {
                MessageBox.Show("Please don't let the fields empty! ☻");
            }
            else
            {
                GPXLoader gpxLoad = new GPXLoader();
                RunnerDataProcessing rdp = new RunnerDataProcessing();
                openFileDialogNewRunner.Filter = "GPX |*.gpx";
                openFileDialogNewRunner.ShowDialog();
                string fileName = openFileDialogNewRunner.FileName;
                List<TrackDto> tracks = gpxLoad.LoadGPXTracks(fileName);

                Runner runner = new Runner
                {
                    Name = nameTxtb.Text,
                    Gender = rdp.getGender(comboBox1.SelectedItem.ToString()),
                    BirthDate = DateTime.Parse(birthDateTxtb.Text),
                    DateofRunning = tracks.First().Time.Date,
                    RunTime = rdp.RunningTimeCount(tracks),
                    ElevationUp = Math.Round(rdp.ElevationUp(tracks)),
                    ElevationDown = Math.Round(rdp.ElevationDown(tracks)),
                    Distance = Math.Round((rdp.CountDistance(tracks) / 1000), 2)
                };

                RunnerPersistency.runnersList.Add(runner);
                MessageBox.Show("The runner added to race");
            }

            nameTxtb.Clear();
            birthDateTxtb.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
