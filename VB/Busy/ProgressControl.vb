Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Threading

Namespace Busy

    Public Partial Class ProgressControl
        Inherits UserControl

        Private _IsOperationInProgress As Boolean

        Public Property IsOperationInProgress As Boolean
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
            Thread.Sleep(INT_operationTime)
        End Sub

        Private Sub UpdateProgressBar(ByVal value As Integer)
            progressBarControl1.EditValue = value
        End Sub

        Private Sub backgroundWorker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
            For i As Integer = 1 To INT_filesCount
                Call CopyFile()
                Dim progress As Integer = i * 100 \ INT_filesCount
                backgroundWorker.ReportProgress(progress)
            Next
        End Sub

        Private Sub backgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
            UpdateProgressBar(e.ProgressPercentage)
        End Sub

        Private Sub backgroundWorker_Completed(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
            UpdateProgressBar(0)
            IsOperationInProgress = False
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            IsOperationInProgress = True
            backgroundWorker.RunWorkerAsync()
        End Sub
    End Class
End Namespace
