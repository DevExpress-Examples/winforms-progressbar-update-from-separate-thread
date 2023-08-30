Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace Busy

    Public Partial Class BusyForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub BusyForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            If realProgress1.IsOperationInProgress Then
                e.Cancel = True
                MessageBox.Show(Me, "This operation in not completed yet. Please wait.", "Cannot close this form")
            End If
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Text += "Click!"
        End Sub
    End Class
End Namespace
