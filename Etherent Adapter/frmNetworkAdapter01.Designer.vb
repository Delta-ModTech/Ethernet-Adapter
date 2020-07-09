<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNetworkAdapter01
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNetworkAdapter01))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lstMessages = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtAdapterName = New System.Windows.Forms.TextBox()
        Me.lblAdapterName = New System.Windows.Forms.Label()
        Me.lblmessagedescription = New System.Windows.Forms.Label()
        Me.cmdSearchAdapters = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(108, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Disable"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(206, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 50)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Enable"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lstMessages
        '
        Me.lstMessages.FormattingEnabled = True
        Me.lstMessages.Location = New System.Drawing.Point(522, 76)
        Me.lstMessages.Name = "lstMessages"
        Me.lstMessages.Size = New System.Drawing.Size(221, 212)
        Me.lstMessages.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(647, 294)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 50)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtAdapterName
        '
        Me.txtAdapterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdapterName.Location = New System.Drawing.Point(147, 66)
        Me.txtAdapterName.Name = "txtAdapterName"
        Me.txtAdapterName.Size = New System.Drawing.Size(262, 26)
        Me.txtAdapterName.TabIndex = 4
        '
        'lblAdapterName
        '
        Me.lblAdapterName.AutoSize = True
        Me.lblAdapterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdapterName.Location = New System.Drawing.Point(25, 70)
        Me.lblAdapterName.Name = "lblAdapterName"
        Me.lblAdapterName.Size = New System.Drawing.Size(116, 20)
        Me.lblAdapterName.TabIndex = 5
        Me.lblAdapterName.Text = "Adapter Name:"
        '
        'lblmessagedescription
        '
        Me.lblmessagedescription.AutoSize = True
        Me.lblmessagedescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmessagedescription.ForeColor = System.Drawing.Color.Blue
        Me.lblmessagedescription.Location = New System.Drawing.Point(519, 60)
        Me.lblmessagedescription.Name = "lblmessagedescription"
        Me.lblmessagedescription.Size = New System.Drawing.Size(119, 16)
        Me.lblmessagedescription.TabIndex = 6
        Me.lblmessagedescription.Text = "What is happening"
        '
        'cmdSearchAdapters
        '
        Me.cmdSearchAdapters.Location = New System.Drawing.Point(522, 294)
        Me.cmdSearchAdapters.Name = "cmdSearchAdapters"
        Me.cmdSearchAdapters.Size = New System.Drawing.Size(96, 50)
        Me.cmdSearchAdapters.TabIndex = 7
        Me.cmdSearchAdapters.Text = "Search"
        Me.cmdSearchAdapters.UseVisualStyleBackColor = True
        '
        'frmNetworkAdapter01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdSearchAdapters)
        Me.Controls.Add(Me.lblmessagedescription)
        Me.Controls.Add(Me.lblAdapterName)
        Me.Controls.Add(Me.txtAdapterName)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lstMessages)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNetworkAdapter01"
        Me.Text = "Ethernet Enable/Disable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lstMessages As ListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents txtAdapterName As TextBox
    Friend WithEvents lblAdapterName As Label
    Friend WithEvents lblmessagedescription As Label
    Friend WithEvents cmdSearchAdapters As Button
End Class
