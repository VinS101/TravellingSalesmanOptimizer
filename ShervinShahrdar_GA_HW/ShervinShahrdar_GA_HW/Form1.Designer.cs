namespace ShervinShahrdar_GA_HW
{
    partial class ShervinGA
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
            this.GAThreadWorker = new System.ComponentModel.BackgroundWorker();
            this.logbox = new System.Windows.Forms.TextBox();
            this.populationSizeBox = new System.Windows.Forms.TextBox();
            this.PopulationSizeLabel = new System.Windows.Forms.Label();
            this.MutationRateLabel = new System.Windows.Forms.Label();
            this.mutationRateBox = new System.Windows.Forms.TextBox();
            this.TournamentSizeLabel = new System.Windows.Forms.Label();
            this.TournamentSizeBox = new System.Windows.Forms.TextBox();
            this.GenerationsLabel = new System.Windows.Forms.Label();
            this.generationsBox = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GAThreadWorker
            // 
            this.GAThreadWorker.WorkerReportsProgress = true;
            this.GAThreadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GAThreadWorker_DoWork);
            this.GAThreadWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.GAThreadWorker_ProgressChanged);
            this.GAThreadWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.GAThreadWorker_RunWorkerCompleted);
            // 
            // logbox
            // 
            this.logbox.Location = new System.Drawing.Point(186, 28);
            this.logbox.Multiline = true;
            this.logbox.Name = "logbox";
            this.logbox.Size = new System.Drawing.Size(393, 359);
            this.logbox.TabIndex = 1;
            // 
            // populationSizeBox
            // 
            this.populationSizeBox.Location = new System.Drawing.Point(108, 28);
            this.populationSizeBox.Name = "populationSizeBox";
            this.populationSizeBox.Size = new System.Drawing.Size(44, 20);
            this.populationSizeBox.TabIndex = 2;
            this.populationSizeBox.Text = "1000";
            // 
            // PopulationSizeLabel
            // 
            this.PopulationSizeLabel.AutoSize = true;
            this.PopulationSizeLabel.Location = new System.Drawing.Point(22, 31);
            this.PopulationSizeLabel.Name = "PopulationSizeLabel";
            this.PopulationSizeLabel.Size = new System.Drawing.Size(80, 13);
            this.PopulationSizeLabel.TabIndex = 3;
            this.PopulationSizeLabel.Text = "Population Size";
            // 
            // MutationRateLabel
            // 
            this.MutationRateLabel.AutoSize = true;
            this.MutationRateLabel.Location = new System.Drawing.Point(22, 57);
            this.MutationRateLabel.Name = "MutationRateLabel";
            this.MutationRateLabel.Size = new System.Drawing.Size(74, 13);
            this.MutationRateLabel.TabIndex = 5;
            this.MutationRateLabel.Text = "Mutation Rate";
            // 
            // mutationRateBox
            // 
            this.mutationRateBox.Location = new System.Drawing.Point(108, 54);
            this.mutationRateBox.Name = "mutationRateBox";
            this.mutationRateBox.Size = new System.Drawing.Size(44, 20);
            this.mutationRateBox.TabIndex = 4;
            this.mutationRateBox.Text = "0.025";
            // 
            // TournamentSizeLabel
            // 
            this.TournamentSizeLabel.AutoSize = true;
            this.TournamentSizeLabel.Location = new System.Drawing.Point(22, 84);
            this.TournamentSizeLabel.Name = "TournamentSizeLabel";
            this.TournamentSizeLabel.Size = new System.Drawing.Size(83, 13);
            this.TournamentSizeLabel.TabIndex = 7;
            this.TournamentSizeLabel.Text = "tournament Size";
            // 
            // TournamentSizeBox
            // 
            this.TournamentSizeBox.Location = new System.Drawing.Point(108, 81);
            this.TournamentSizeBox.Name = "TournamentSizeBox";
            this.TournamentSizeBox.Size = new System.Drawing.Size(44, 20);
            this.TournamentSizeBox.TabIndex = 6;
            this.TournamentSizeBox.Text = "5";
            // 
            // GenerationsLabel
            // 
            this.GenerationsLabel.AutoSize = true;
            this.GenerationsLabel.Location = new System.Drawing.Point(22, 113);
            this.GenerationsLabel.Name = "GenerationsLabel";
            this.GenerationsLabel.Size = new System.Drawing.Size(64, 13);
            this.GenerationsLabel.TabIndex = 9;
            this.GenerationsLabel.Text = "Generations";
            // 
            // generationsBox
            // 
            this.generationsBox.Location = new System.Drawing.Point(108, 110);
            this.generationsBox.Name = "generationsBox";
            this.generationsBox.Size = new System.Drawing.Size(44, 20);
            this.generationsBox.TabIndex = 8;
            this.generationsBox.Text = "50";
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(25, 148);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(127, 23);
            this.run.TabIndex = 10;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // ShervinGA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 416);
            this.Controls.Add(this.run);
            this.Controls.Add(this.GenerationsLabel);
            this.Controls.Add(this.generationsBox);
            this.Controls.Add(this.TournamentSizeLabel);
            this.Controls.Add(this.TournamentSizeBox);
            this.Controls.Add(this.MutationRateLabel);
            this.Controls.Add(this.mutationRateBox);
            this.Controls.Add(this.PopulationSizeLabel);
            this.Controls.Add(this.populationSizeBox);
            this.Controls.Add(this.logbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ShervinGA";
            this.Text = "ShervinGA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker GAThreadWorker;
        private System.Windows.Forms.TextBox logbox;
        private System.Windows.Forms.TextBox populationSizeBox;
        private System.Windows.Forms.Label PopulationSizeLabel;
        private System.Windows.Forms.Label MutationRateLabel;
        private System.Windows.Forms.TextBox mutationRateBox;
        private System.Windows.Forms.Label TournamentSizeLabel;
        private System.Windows.Forms.TextBox TournamentSizeBox;
        private System.Windows.Forms.Label GenerationsLabel;
        private System.Windows.Forms.TextBox generationsBox;
        private System.Windows.Forms.Button run;
    }
}

