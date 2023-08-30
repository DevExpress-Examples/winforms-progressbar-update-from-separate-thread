Namespace Busy

    Partial Class ProgressControl

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.backgroundWorker = New System.ComponentModel.BackgroundWorker()
            CType((Me.progressBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' progressBarControl1
            ' 
            Me.progressBarControl1.Location = New System.Drawing.Point(14, 56)
            Me.progressBarControl1.Name = "progressBarControl1"
            Me.progressBarControl1.Size = New System.Drawing.Size(371, 18)
            Me.progressBarControl1.TabIndex = 0
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(14, 13)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(377, 23)
            Me.simpleButton1.TabIndex = 1
            Me.simpleButton1.Text = "Copy files"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' backgroundWorker
            ' 
            Me.backgroundWorker.WorkerReportsProgress = True
            Me.backgroundWorker.WorkerSupportsCancellation = True
            AddHandler Me.backgroundWorker.DoWork, New System.ComponentModel.DoWorkEventHandler(AddressOf Me.backgroundWorker_DoWork)
            AddHandler Me.backgroundWorker.RunWorkerCompleted, New System.ComponentModel.RunWorkerCompletedEventHandler(AddressOf Me.backgroundWorker_Completed)
            AddHandler Me.backgroundWorker.ProgressChanged, New System.ComponentModel.ProgressChangedEventHandler(AddressOf Me.backgroundWorker_ProgressChanged)
            ' 
            ' RealProgress
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.progressBarControl1)
            Me.Name = "RealProgress"
            Me.Size = New System.Drawing.Size(413, 99)
            CType((Me.progressBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private backgroundWorker As System.ComponentModel.BackgroundWorker
    End Class
End Namespace
