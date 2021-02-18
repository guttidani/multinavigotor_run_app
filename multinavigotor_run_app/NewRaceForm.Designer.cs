
namespace multinavigotor_run_app
{
    partial class NewRaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRaceForm));
            this.RaceNameTxtbox = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.createRaceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RaceNameTxtbox
            // 
            this.RaceNameTxtbox.Location = new System.Drawing.Point(96, 25);
            this.RaceNameTxtbox.Name = "RaceNameTxtbox";
            this.RaceNameTxtbox.Size = new System.Drawing.Size(100, 23);
            this.RaceNameTxtbox.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 60);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // createRaceBtn
            // 
            this.createRaceBtn.Location = new System.Drawing.Point(18, 234);
            this.createRaceBtn.Name = "createRaceBtn";
            this.createRaceBtn.Size = new System.Drawing.Size(129, 23);
            this.createRaceBtn.TabIndex = 6;
            this.createRaceBtn.Text = "Create New Race";
            this.createRaceBtn.UseVisualStyleBackColor = true;
            this.createRaceBtn.Click += new System.EventHandler(this.createRaceBtn_Click);
            // 
            // NewRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 272);
            this.Controls.Add(this.createRaceBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.RaceNameTxtbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewRaceForm";
            this.Text = "New race";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RaceNameTxtbox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createRaceBtn;
    }
}