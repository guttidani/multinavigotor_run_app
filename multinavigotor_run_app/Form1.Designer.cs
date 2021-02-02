using System.Windows.Forms;

namespace multinavigotor_run_app
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.file_btn = new System.Windows.Forms.ToolStripDropDownButton();
            this.new_race_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.new_runner_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.save_race_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.load_race_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // 
            // new_runner_btn
            // 
            this.new_runner_btn.Name = "new_runner_btn";
            this.new_runner_btn.Size = new System.Drawing.Size(136, 22);
            this.new_runner_btn.Text = "New runner";
            // 
            // save_race_btn
            // 
            this.save_race_btn.Name = "save_race_btn";
            this.save_race_btn.Size = new System.Drawing.Size(136, 22);
            this.save_race_btn.Text = "Save race";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(454, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 210);
            this.dataGridView1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 28);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 104);
            this.treeView1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // load_race_btn
            // 
            this.load_race_btn.Name = "load_race_btn";
            this.load_race_btn.Size = new System.Drawing.Size(136, 22);
            this.load_race_btn.Text = "Load race";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton file_btn;
        private ToolStripMenuItem new_race_btn;
        private ToolStripMenuItem new_runner_btn;
        private ToolStripMenuItem save_race_btn;
        private DataGridView dataGridView1;
        private TreeView treeView1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem load_race_btn;
    }
}

