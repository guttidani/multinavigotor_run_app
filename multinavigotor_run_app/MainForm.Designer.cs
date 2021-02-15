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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.openFileDialogNewRunner = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.file_btn = new System.Windows.Forms.ToolStripDropDownButton();
            this.new_race_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.new_runner_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.save_race_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.load_race_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.saveRunnertoJson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(206, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(717, 565);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 28);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(188, 225);
            this.treeView1.TabIndex = 2;
            // 
            // openFileDialogNewRunner
            // 
            this.openFileDialogNewRunner.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
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
            // saveRunnertoJson
            // 
            this.saveRunnertoJson.Location = new System.Drawing.Point(12, 288);
            this.saveRunnertoJson.Name = "saveRunnertoJson";
            this.saveRunnertoJson.Size = new System.Drawing.Size(75, 23);
            this.saveRunnertoJson.TabIndex = 4;
            this.saveRunnertoJson.Text = "Save Runners";
            this.saveRunnertoJson.UseVisualStyleBackColor = true;
            this.saveRunnertoJson.Click += new System.EventHandler(this.saveRunnertoJson_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 605);
            this.Controls.Add(this.saveRunnertoJson);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Multinavigátor verseny";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private TreeView treeView1;
        private OpenFileDialog openFileDialogNewRunner;
        private SaveFileDialog saveFileDialog1;
        private ToolStripDropDownButton file_btn;
        private ToolStripMenuItem new_race_btn;
        private ToolStripMenuItem new_runner_btn;
        private ToolStripMenuItem save_race_btn;
        private ToolStripMenuItem load_race_btn;
        private ToolStrip toolStrip1;
        private Button refreshBtn;
        private Button saveRunnertoJson;
    }
}

