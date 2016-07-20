using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShervinShahrdar_GA_HW
{
    public static class WinFormsExtensions
    {
        public static void AppendLine(this TextBox source, string value)
        {
            if (source.Text.Length == 0)
                source.Text = value;
            else
                source.AppendText("\r\n" + value);
        }
    }
    public partial class ShervinGA : Form
    {
        public ShervinGA()
        {
            InitializeComponent();
        }
        private void RunButton_Click(object sender, EventArgs e)
        {
            
        }


        private void GAThreadWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Logger.RefToWorker = GAThreadWorker;
            Problem.InitializeCities();
            Problem.initialized = false;
            Logger.results.Clear();
            GeneticAlgorithm gA = new GeneticAlgorithm();
            Logger.GenerateFile();
            gA = null;
        }

        private void GAThreadWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            logbox.AppendLine(e.UserState.ToString());
        }

        private void GAThreadWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            run.Enabled = true;
        }

        private void run_Click(object sender, EventArgs e)
        {
            run.Enabled = false;
            GeneticAlgorithm.PopulationSize = Convert.ToInt32(populationSizeBox.Text);
            GeneticAlgorithm.mutationRate = Convert.ToDouble(mutationRateBox.Text);
            GeneticAlgorithm.tournamentSize = Convert.ToInt32(TournamentSizeBox.Text);
            GeneticAlgorithm.GenerationsToRun = Convert.ToInt32(generationsBox.Text);
            GAThreadWorker.RunWorkerAsync();
        }
    }
}
