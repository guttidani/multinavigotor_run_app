
namespace multinavigotor_run_app
{
    partial class NewRunnerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.newRunnerBtn = new System.Windows.Forms.Button();
            this.openFileDialogNewRunner = new System.Windows.Forms.OpenFileDialog();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 23);
            this.textBox3.TabIndex = 2;
            // 
            // newRunnerBtn
            // 
            this.newRunnerBtn.Location = new System.Drawing.Point(198, 150);
            this.newRunnerBtn.Name = "newRunnerBtn";
            this.newRunnerBtn.Size = new System.Drawing.Size(109, 23);
            this.newRunnerBtn.TabIndex = 3;
            this.newRunnerBtn.Text = "New Runner";
            this.newRunnerBtn.UseVisualStyleBackColor = true;
            this.newRunnerBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialogNewRunner
            // 
            this.openFileDialogNewRunner.FileName = "openFileDialogNewRunner";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(713, 415);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // NewRunnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.newRunnerBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "NewRunnerForm";
            this.Text = "NewRunnerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button newRunnerBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialogNewRunner;
        private System.Windows.Forms.Button backBtn;
    }
}