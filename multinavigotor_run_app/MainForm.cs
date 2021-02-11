using multinavigotor_run_app.Persistency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace multinavigotor_run_app
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void new_runner_btn_Click(object sender, EventArgs e)
        {
            //GPXLoader gpxLoad = new GPXLoader();
            //RunnerDataProcessing rdp = new RunnerDataProcessing();
            //openFileDialogNewRunner.Filter = "GPX |*.gpx";
            //openFileDialogNewRunner.ShowDialog();
            //string fileName = openFileDialogNewRunner.FileName;
            //List<TrackDto> tracks = gpxLoad.LoadGPXTracks(fileName);

            //Runner runner = new Runner
            //{
            //    Name = rdp.getNameFromFileName(Path.GetFileName(fileName)),
            //    DateofRunning = tracks.First().Time.Date,
            //    RunTime = rdp.RunningTimeCount(tracks),
            //    ElevationUp = Math.Round(rdp.ElevationUp(tracks)),
            //    ElevationDown = Math.Round(rdp.ElevationDown(tracks)),
            //    Distance = Math.Round((rdp.CountDistance(tracks) / 1000),2)
            //};

            //RunnerPersistency.runnersList.Add(runner);
            //dataGridView1.DataSource = RunnerPersistency.runnersList;

            NewRunnerForm nRunnerForm = new NewRunnerForm();
            nRunnerForm.Show();
        }

        private void new_race_btn_Click(object sender, EventArgs e)
        {
            NewRaceForm nRaceForm = new NewRaceForm();
            nRaceForm.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e) //doesnt work
        {
            dataGridView1.DataSource = RunnerPersistency.runnersList;
            RunnerPersistency.runnersList.OrderBy(q => q.RunTime);
            dataGridView1.EndEdit();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}


