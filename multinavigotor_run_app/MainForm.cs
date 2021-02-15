using multinavigotor_run_app.Persistency;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace multinavigotor_run_app
{
    public partial class MainForm : Form
    {
        private bool sortAscending;

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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = RunnerPersistency.runnersList;
            //RunnerPersistency.runnersList.Sort();
            
            
            //dataGridView1.DataSource = RunnerPersistency.runnersList.OrderBy(q => q.RunTime);
            //dataGridView1.DataSource = RunnerPersistency.runnersList.OrderByDescending(q => q.RunTime);
            //dataGridView1.Sort
            //dataGridView1.Refresh();
        }

        private void saveRunnertoJson_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JSON | *.json";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(JsonConvert.SerializeObject(RunnerPersistency.runnersList, Formatting.Indented));
                }
            }
        }

        private void ascendingBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = RunnerPersistency.runnersList.OrderBy(q => q.RunTime).ToList(); 
        }

        private void descendingBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = RunnerPersistency.runnersList.OrderByDescending(q => q.RunTime).ToList();
        }

        private void load_race_btn_Click(object sender, EventArgs e)
        {
            //openFileDialogNewRunner
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortAscending)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = RunnerPersistency.runnersList.OrderBy(q => q.RunTime).ToList();
                //dataGridView1.DataSource = RunnerPersistency.runnersList.OrderBy(dataGridView1.Columns[e.ColumnIndex].DataPropertyName).ToList();
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = RunnerPersistency.runnersList.OrderByDescending(q => q.RunTime).ToList();
                //dataGridView1.DataSource = RunnerPersistency.runnersList.OrderBy(dataGridView1.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();
            }
            sortAscending = !sortAscending;
        }
    }
}


