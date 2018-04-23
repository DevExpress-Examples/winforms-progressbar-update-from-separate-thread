Imports Microsoft.VisualBasic
Imports System
Namespace Busy
	Partial Public Class BusyForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.realProgress1 = New Busy.ProgressControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.SuspendLayout()
			' 
			' realProgress1
			' 
			Me.realProgress1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.realProgress1.IsOperationInProgress = False
			Me.realProgress1.Location = New System.Drawing.Point(0, 0)
			Me.realProgress1.Name = "realProgress1"
			Me.realProgress1.Size = New System.Drawing.Size(556, 97)
			Me.realProgress1.TabIndex = 3
'			Me.realProgress1.Load += New System.EventHandler(Me.realProgress1_Load);
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.simpleButton1.Location = New System.Drawing.Point(0, 97)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(556, 23)
			Me.simpleButton1.TabIndex = 4
			Me.simpleButton1.Text = "Can click"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' BusyForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(556, 120)
			Me.Controls.Add(Me.realProgress1)
			Me.Controls.Add(Me.simpleButton1)
			Me.Name = "BusyForm"
			Me.Text = "Busy Form"
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.BusyForm_FormClosing);
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents realProgress1 As ProgressControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton

	End Class
End Namespace

