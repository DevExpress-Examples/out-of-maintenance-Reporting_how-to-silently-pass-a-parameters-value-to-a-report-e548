Imports System
Imports System.Windows.Forms
' ...

Namespace PassParametersSilently
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) _
		Handles button1.Click
			' Create a report instance.
			Dim report As New XtraReport1()

			' Set the parameter's value.
			report.catID.Value = 3

			' Hide the Parameters Request pane by default in preview.
			report.RequestParameters = False

			' Show the report's print preview.
			report.ShowPreview()
		End Sub
	End Class
End Namespace