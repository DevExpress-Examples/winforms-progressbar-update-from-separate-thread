Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace Busy
	Partial Public Class ProgressControl
		Inherits UserControl
		Private _IsOperationInProgress As Boolean
		Public Property IsOperationInProgress() As Boolean
			Get
				Return _IsOperationInProgress
			End Get
			Set(ByVal value As Boolean)
				_IsOperationInProgress = value
				simpleButton1.Enabled = Not value
			End Set
		End Property

		Private Const INT_filesCount As Integer = 500
		Private Const INT_operationTime As Integer = 10
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Shared Sub CopyFile()
			System.Threading.Thread.Sleep(INT_operationTime)
		End Sub

		Private Sub UpdateProgressBar(ByVal value As Integer)
			BeginInvoke(New MethodInvoker(Function() AnonymousMethod1(value)))
		End Sub
		
		Private Function AnonymousMethod1(ByVal value As Integer) As Boolean
			progressBarControl1.EditValue = value
			Return True
		End Function

		Private Sub backgroundWorker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles backgroundWorker.DoWork
			For i As Integer = 1 To INT_filesCount
				CopyFile()
				Dim progress As Integer = i * 100 \ INT_filesCount
				backgroundWorker.ReportProgress(progress)
			Next i
		End Sub


		Private Sub backgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs) Handles backgroundWorker.ProgressChanged
			UpdateProgressBar(e.ProgressPercentage)
		End Sub

		Private Sub backgroundWorker_Completed(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles backgroundWorker.RunWorkerCompleted
			UpdateProgressBar(0)
			IsOperationInProgress = False
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			IsOperationInProgress = True
			backgroundWorker.RunWorkerAsync()
		End Sub
	End Class
End Namespace
