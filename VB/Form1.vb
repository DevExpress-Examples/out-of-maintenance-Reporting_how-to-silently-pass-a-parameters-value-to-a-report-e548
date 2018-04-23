Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
' ...

Namespace PassParametersSilently
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' Create a report instance.
			Dim report As New XtraReport1()

			' Obtain a parameter, and set its value.
			report.catID.Value = 2

			' Hide the Parameters UI from end-users.
			report.catID.Visible = False

			' Show the report's print preview.
			Dim printTool As New ReportPrintTool(report)
			printTool.ShowPreviewDialog()
		End Sub
	End Class
End Namespace