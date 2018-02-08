<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnSendToServer = New System.Windows.Forms.Button
        Me.txtInfo = New System.Windows.Forms.TextBox
        Me.Sock = New AxMSWinsockLib.AxWinsock
        CType(Me.Sock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSendToServer
        '
        Me.btnSendToServer.Location = New System.Drawing.Point(12, 12)
        Me.btnSendToServer.Name = "btnSendToServer"
        Me.btnSendToServer.Size = New System.Drawing.Size(98, 30)
        Me.btnSendToServer.TabIndex = 0
        Me.btnSendToServer.Text = "Send"
        Me.btnSendToServer.UseVisualStyleBackColor = True
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(10, 48)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInfo.Size = New System.Drawing.Size(438, 201)
        Me.txtInfo.TabIndex = 1
        '
        'Sock
        '
        Me.Sock.Enabled = True
        Me.Sock.Location = New System.Drawing.Point(129, 12)
        Me.Sock.Name = "Sock"
        Me.Sock.OcxState = CType(resources.GetObject("Sock.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Sock.Size = New System.Drawing.Size(28, 28)
        Me.Sock.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 261)
        Me.Controls.Add(Me.Sock)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.btnSendToServer)
        Me.Name = "frmMain"
        Me.Text = "XML test"
        CType(Me.Sock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSendToServer As System.Windows.Forms.Button
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents Sock As AxMSWinsockLib.AxWinsock

End Class
