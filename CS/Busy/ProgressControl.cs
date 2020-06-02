using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Busy {
    public partial class ProgressControl : UserControl {
        private bool _IsOperationInProgress;
        public bool IsOperationInProgress {
            get { return _IsOperationInProgress; }
            set { _IsOperationInProgress = value; simpleButton1.Enabled = !value; }
        }

        private const int INT_filesCount = 500;
        private const int INT_operationTime = 10;
        public ProgressControl() {
            InitializeComponent();
        }

        private static void CopyFile() {
            Thread.Sleep(INT_operationTime);
        }

        private void UpdateProgressBar(int value) {
           progressBarControl1.EditValue = value;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            for(int i = 1; i <= INT_filesCount; i++) {
                CopyFile();
                int progress = i * 100 / INT_filesCount;
                backgroundWorker.ReportProgress(progress);
            }
        }


        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            UpdateProgressBar(e.ProgressPercentage);
        }

        private void backgroundWorker_Completed(object sender, RunWorkerCompletedEventArgs e) {
            UpdateProgressBar(0);
            IsOperationInProgress = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            IsOperationInProgress = true;
            backgroundWorker.RunWorkerAsync();
        }
    }
}
