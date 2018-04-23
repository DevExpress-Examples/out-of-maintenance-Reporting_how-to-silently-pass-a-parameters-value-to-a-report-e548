using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace PassParametersSilently {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create a report instance.
            XtraReport1 report = new XtraReport1();

            // Obtain a parameter, and set its value.
            report.catID.Value = 2;

            // Hide the Parameters UI from end-users.
            report.catID.Visible = false;

            // Show the report's print preview.
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}