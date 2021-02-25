using multinavigotor_run_app.Persistency;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private bool sortAscending = false;

        public MainForm()
        {
            InitializeComponent();
            raceNameLabel.Text = null;
        }

        private void new_runner_btn_Click(object sender, EventArgs e)
        {
            if (raceNameLabel.Text.Length == 0)
            {
                MessageBox.Show("Please create a new race! ☻");
            }
            else
            {
                NewRunnerForm nRunnerForm = new NewRunnerForm();
                nRunnerForm.Show();
            }
            datagridview1.DataSource = RunnerPersistency.runnersList;
        }

        private void new_race_btn_Click(object sender, EventArgs e)
        {
            NewRaceForm nRaceForm = new NewRaceForm();
            nRaceForm.Show();
            raceNameLabel.Text = RacePersistency.RaceName;
        }

        private void refreshBtn_Click(object sender, EventArgs e) //doesnt work
        {
            datagridview1.DataSource = null;
            datagridview1.DataSource = RunnerPersistency.runnersList;

            raceNameLabel.Text = RacePersistency.RaceName;
            //datagridview1.Refresh(); // it doesnt work :(
        }

        private void load_race_btn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JSON |*.json";
            openFileDialog.ShowDialog();
            string jsonString = File.ReadAllText(openFileDialog.FileName);
            Race race = new Race();
            race = JsonConvert.DeserializeObject<Race>(jsonString);
            RunnerPersistency.runnersList = race.Runners;
            RacePersistency.RaceName = race.RaceName;
            raceNameLabel.Text = race.RaceName;
            datagridview1.DataSource = RunnerPersistency.runnersList;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            List<Runner> runners = new List<Runner>();
            runners = RunnerPersistency.runnersList;

            #region from microsoft
            //DataGridViewColumn newColumn = dataGridView1.Columns[e.ColumnIndex];
            //DataGridViewColumn oldColumn = dataGridView1.SortedColumn;
            //ListSortDirection direction;

            //// If oldColumn is null, then the DataGridView is not sorted.
            //if (oldColumn != null)
            //{
            //    // Sort the same column again, reversing the SortOrder.
            //    if (oldColumn == newColumn &&
            //        dataGridView1.SortOrder == SortOrder.Ascending)
            //    {
            //        direction = ListSortDirection.Descending;
            //    }
            //    else
            //    {
            //        // Sort a new column and remove the old SortGlyph.
            //        direction = ListSortDirection.Ascending;
            //        oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
            //    }
            //}
            //else
            //{
            //    direction = ListSortDirection.Ascending;
            //}

            //// Sort the selected column.
            //dataGridView1.Sort(newColumn, direction);
            //newColumn.HeaderCell.SortGlyphDirection =
            //    direction == ListSortDirection.Ascending ?
            //    SortOrder.Ascending : SortOrder.Descending;
            #endregion

            #region MyRegion

            //switch (dataGridView1.Columns)
            //{
            //    default:
            //        break;
            //}

            ////foreach (DataGridViewColumn column in dataGridView1.Columns)
            ////{

            ////}

            if (sortAscending)
            {
                datagridview1.DataSource = null;
                datagridview1.DataSource = RunnerPersistency.runnersList.OrderBy(q => q.RunTime).ToList();
                datagridview1.Sort(datagridview1.Columns[0], ListSortDirection.Ascending);
                //dataGridView1.DataSource = RunnerPersistency.runnersList.OrderBy(q => q).ToList();
            }
            else
            {
                datagridview1.DataSource = null;
                //dataGridView1.DataSource = RunnerPersistency.runnersList.OrderByDescending(q => q).ToList();
                datagridview1.DataSource = RunnerPersistency.runnersList.OrderByDescending(q => q.RunTime).ToList();
                sortAscending = !sortAscending;
            }
            #endregion

            #region fromStackOverFlow

            //int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            ////int index = dataGridView1.Columns[e.ColumnIndex];
            //Debug.WriteLine("Current index datapropname: {0}", dataGridView1.Columns[e.ColumnIndex].DataPropertyName);
            //Debug.WriteLine("e.columnIndex: " + e.ColumnIndex);

            //if (sortAscending)
            //{
            //    dataGridView1.DataSource = null;
            //    dataGridView1.DataSource = runners.OrderBy(dataGridView1.Columns[e.ColumnIndex].DataPropertyName).ToList(); //outofindex error on datagridview1
            //    //dataGridView1.DataSource = RunnerPersistency.runnersList.OrderBy(dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].DataPropertyName).ToList();
            //}
            //else
            //{
            //    dataGridView1.DataSource = null;
            //    dataGridView1.DataSource = runners.OrderBy(dataGridView1.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList(); //outofindex error on datagridview1
            //    //dataGridView1.DataSource = RunnerPersistency.runnersList.OrderBy(dataGridView1.Columns[e.ColumnIndex-1].DataPropertyName).Reverse().ToList();
            //    //dataGridView1.DataSource = RunnerPersistency.runnersList.OrderBy(dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].DataPropertyName).Reverse().ToList();
            //    sortAscending = !sortAscending;
            //}
            #endregion
        }

        private void save_race_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JSON | *.json";
            Race race = new Race
            {
                RaceName = RacePersistency.RaceName,
                DateofRunning = RacePersistency.DateofRace,
                Runners = RunnerPersistency.runnersList
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(JsonConvert.SerializeObject(race, Formatting.Indented));
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            RunnerDataProcessing rdp = new RunnerDataProcessing();

            if (searchBtn.Text.Length != 0)
            {
                datagridview1.DataSource = null;
                datagridview1.DataSource = RunnerPersistency.runnersList.Where(q => q.Name.Contains(searchName.Text)).ToList();
            }
            else if (genderBox.SelectedIndex != -1)
            {
                if (genderBox.SelectedItem.ToString() == "null")
                {
                    datagridview1.DataSource = null;
                    datagridview1.DataSource = RunnerPersistency.runnersList;
                }
                else
                {
                    datagridview1.DataSource = null;
                    datagridview1.DataSource = RunnerPersistency.runnersList.Where(q => q.Gender == rdp.getGender(genderBox.SelectedItem.ToString())).ToList();
                }
            }
        }

        private void datagridview1_FilterStringChanged(object sender, EventArgs e)
        {
            datagridview1.DataSource = this.datagridview1.SortString;
            //List<Runner> runners = RunnerPersistency.runnersList;
            //DataTable dt = (DataTable) runners;
        }

        private void datagridview1_SortStringChanged(object sender, EventArgs e)
        {

        }
    }
}


