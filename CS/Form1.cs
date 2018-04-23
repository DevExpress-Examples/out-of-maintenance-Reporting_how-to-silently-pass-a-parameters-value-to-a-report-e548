using System;
using System.Windows.Forms;
// ...

namespace PassParametersSilently {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create a report instance.
            XtraReport1 report = new XtraReport1();

            // Set the parameter's value.
            report.catID.Value = 3;

            // Hide the Parameters Request pane by default in preview.
            report.RequestParameters = false;

            // Show the report's print preview.
            report.ShowPreview();
        }
    }
}