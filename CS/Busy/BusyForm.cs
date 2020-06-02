using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Busy {
    public partial class BusyForm : Form {
        public BusyForm() {
            InitializeComponent();
        }

        private void BusyForm_FormClosing(object sender, FormClosingEventArgs e) {
            if(realProgress1.IsOperationInProgress) {

                e.Cancel = true;
                MessageBox.Show(this, "This operation in not completed yet. Please wait.", "Cannot close this form");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            Text += "Click!";
        }
    }
}
