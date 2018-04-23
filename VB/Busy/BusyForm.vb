Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace Busy
	Partial Public Class BusyForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub


		Private Sub BusyForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			If realProgress1.IsOperationInProgress Then

				e.Cancel = True
				MessageBox.Show(Me,"This operation in not completed yet. Please wait.", "Cannot close this form")
			End If
		End Sub

		Private Sub realProgress1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles realProgress1.Load

		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Text &= "Click! "
		End Sub
	End Class
End Namespace
