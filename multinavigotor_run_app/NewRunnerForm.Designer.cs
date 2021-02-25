
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRunnerForm));
            this.nameTxtb = new System.Windows.Forms.TextBox();
            this.createRunnerBtn = new System.Windows.Forms.Button();
            this.openFileDialogNewRunner = new System.Windows.Forms.OpenFileDialog();
            this.backBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.birthDateTxtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTxtb
            // 
            this.nameTxtb.Location = new System.Drawing.Point(123, 37);
            this.nameTxtb.Name = "nameTxtb";
            this.nameTxtb.PlaceholderText = "Type the name here";
            this.nameTxtb.Size = new System.Drawing.Size(146, 23);
            this.nameTxtb.TabIndex = 0;
            // 
            // createRunnerBtn
            // 
            this.createRunnerBtn.Location = new System.Drawing.Point(44, 124);
            this.createRunnerBtn.Name = "createRunnerBtn";
            this.createRunnerBtn.Size = new System.Drawing.Size(132, 23);
            this.createRunnerBtn.TabIndex = 3;
            this.createRunnerBtn.Text = "Create New Runner";
            this.createRunnerBtn.UseVisualStyleBackColor = true;
            this.createRunnerBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialogNewRunner
            // 
            this.openFileDialogNewRunner.FileName = "openFileDialogNewRunner";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(198, 125);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(71, 22);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Man",
            "Woman"});
            this.comboBox1.Location = new System.Drawing.Point(123, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gender";
            // 
            // birthDateTxtb
            // 
            this.birthDateTxtb.Location = new System.Drawing.Point(123, 95);
            this.birthDateTxtb.Name = "birthDateTxtb";
            this.birthDateTxtb.PlaceholderText = "yyyy-mm-dd";
            this.birthDateTxtb.Size = new System.Drawing.Size(146, 23);
            this.birthDateTxtb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Birth Date";
            // 
            // NewRunnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 174);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.birthDateTxtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.createRunnerBtn);
            this.Controls.Add(this.nameTxtb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewRunnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New runner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtb;
        private System.Windows.Forms.Button createRunnerBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialogNewRunner;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox birthDateTxtb;
        private System.Windows.Forms.Label label3;
    }
}