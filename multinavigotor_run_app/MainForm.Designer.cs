using System.Windows.Forms;

namespace multinavigotor_run_app
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.file_btn = new System.Windows.Forms.ToolStripDropDownButton();
            this.new_race_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.new_runner_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.save_race_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.load_race_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.raceNameLabel = new System.Windows.Forms.Label();
            this.searchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.datagridview1 = new ADGV.AdvancedDataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 28);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(188, 225);
            this.treeView1.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // file_btn
            // 
            this.file_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.file_btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_race_btn,
            this.new_runner_btn,
            this.save_race_btn,
            this.load_race_btn});
            this.file_btn.Image = ((System.Drawing.Image)(resources.GetObject("file_btn.Image")));
            this.file_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_btn.Name = "file_btn";
            this.file_btn.Size = new System.Drawing.Size(38, 22);
            this.file_btn.Text = "File";
            // 
            // new_race_btn
            // 
            this.new_race_btn.Name = "new_race_btn";
            this.new_race_btn.Size = new System.Drawing.Size(136, 22);
            this.new_race_btn.Text = "New race";
            this.new_race_btn.Click += new System.EventHandler(this.new_race_btn_Click);
            // 
            // new_runner_btn
            // 
            this.new_runner_btn.Name = "new_runner_btn";
            this.new_runner_btn.Size = new System.Drawing.Size(136, 22);
            this.new_runner_btn.Text = "New runner";
            this.new_runner_btn.Click += new System.EventHandler(this.new_runner_btn_Click);
            // 
            // save_race_btn
            // 
            this.save_race_btn.Name = "save_race_btn";
            this.save_race_btn.Size = new System.Drawing.Size(136, 22);
            this.save_race_btn.Text = "Save race";
            this.save_race_btn.Click += new System.EventHandler(this.save_race_btn_Click);
            // 
            // load_race_btn
            // 
            this.load_race_btn.Name = "load_race_btn";
            this.load_race_btn.Size = new System.Drawing.Size(136, 22);
            this.load_race_btn.Text = "Load race";
            this.load_race_btn.Click += new System.EventHandler(this.load_race_btn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(50, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(12, 259);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // raceNameLabel
            // 
            this.raceNameLabel.AutoSize = true;
            this.raceNameLabel.Location = new System.Drawing.Point(428, 7);
            this.raceNameLabel.Name = "raceNameLabel";
            this.raceNameLabel.Size = new System.Drawing.Size(0, 15);
            this.raceNameLabel.TabIndex = 4;
            // 
            // searchName
            // 
            this.searchName.Location = new System.Drawing.Point(56, 288);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(144, 23);
            this.searchName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(125, 346);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // genderBox
            // 
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "Man",
            "Woman",
            "Null"});
            this.genderBox.Location = new System.Drawing.Point(56, 317);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(144, 23);
            this.genderBox.TabIndex = 8;
            // 
            // datagridview1
            // 
            this.datagridview1.AllowUserToOrderColumns = true;
            this.datagridview1.AutoGenerateContextFilters = true;
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview1.DateWithTime = false;
            this.datagridview1.Location = new System.Drawing.Point(206, 28);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.RowTemplate.Height = 25;
            this.datagridview1.Size = new System.Drawing.Size(922, 670);
            this.datagridview1.TabIndex = 9;
            this.datagridview1.TimeFilter = false;
            this.datagridview1.SortStringChanged += new System.EventHandler(this.datagridview1_SortStringChanged);
            this.datagridview1.FilterStringChanged += new System.EventHandler(this.datagridview1_FilterStringChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1140, 710);
            this.Controls.Add(this.datagridview1);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.raceNameLabel);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multinavigátor verseny";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TreeView treeView1;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog1;
        private ToolStripDropDownButton file_btn;
        private ToolStripMenuItem new_race_btn;
        private ToolStripMenuItem new_runner_btn;
        private ToolStripMenuItem save_race_btn;
        private ToolStripMenuItem load_race_btn;
        private ToolStrip toolStrip1;
        private Button refreshBtn;
        private Label raceNameLabel;
        private TextBox searchName;
        private Label label1;
        private Button searchBtn;
        private ComboBox genderBox;
        private ADGV.AdvancedDataGridView datagridview1;
    }
}

