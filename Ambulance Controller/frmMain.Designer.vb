<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.tabControlMain = New System.Windows.Forms.TabControl()
        Me.tabHome = New System.Windows.Forms.TabPage()
        Me.tabEnviron = New System.Windows.Forms.TabPage()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.tabControl = New System.Windows.Forms.TabPage()
        Me.tabJobs = New System.Windows.Forms.TabPage()
        Me.tabStatus = New System.Windows.Forms.TabPage()
        Me.tabComms = New System.Windows.Forms.TabPage()
        Me.tabConfig = New System.Windows.Forms.TabPage()
        Me.tabControlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControlMain
        '
        Me.tabControlMain.Controls.Add(Me.tabHome)
        Me.tabControlMain.Controls.Add(Me.tabEnviron)
        Me.tabControlMain.Controls.Add(Me.tabControl)
        Me.tabControlMain.Controls.Add(Me.tabJobs)
        Me.tabControlMain.Controls.Add(Me.tabStatus)
        Me.tabControlMain.Controls.Add(Me.tabComms)
        Me.tabControlMain.Controls.Add(Me.tabConfig)
        Me.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlMain.ItemSize = New System.Drawing.Size(110, 50)
        Me.tabControlMain.Location = New System.Drawing.Point(0, 0)
        Me.tabControlMain.Name = "tabControlMain"
        Me.tabControlMain.SelectedIndex = 0
        Me.tabControlMain.Size = New System.Drawing.Size(1008, 729)
        Me.tabControlMain.TabIndex = 0
        '
        'tabHome
        '
        Me.tabHome.BackColor = System.Drawing.Color.LightGray
        Me.tabHome.BackgroundImage = Global.Ambulance_Controller.My.Resources.Resources.Metro_Logo_Master_837x250_t
        Me.tabHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tabHome.Location = New System.Drawing.Point(4, 54)
        Me.tabHome.Name = "tabHome"
        Me.tabHome.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHome.Size = New System.Drawing.Size(1000, 671)
        Me.tabHome.TabIndex = 0
        Me.tabHome.Text = "Home"
        '
        'tabEnviron
        '
        Me.tabEnviron.BackColor = System.Drawing.Color.LightGray
        Me.tabEnviron.Location = New System.Drawing.Point(4, 54)
        Me.tabEnviron.Name = "tabEnviron"
        Me.tabEnviron.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEnviron.Size = New System.Drawing.Size(1000, 671)
        Me.tabEnviron.TabIndex = 1
        Me.tabEnviron.Text = "Environ"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlMain.Location = New System.Drawing.Point(0, 671)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1008, 58)
        Me.pnlMain.TabIndex = 1
        '
        'tabControl
        '
        Me.tabControl.BackColor = System.Drawing.Color.LightGray
        Me.tabControl.Location = New System.Drawing.Point(4, 54)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.Size = New System.Drawing.Size(1000, 671)
        Me.tabControl.TabIndex = 2
        Me.tabControl.Text = "Control"
        '
        'tabJobs
        '
        Me.tabJobs.BackColor = System.Drawing.Color.LightGray
        Me.tabJobs.Location = New System.Drawing.Point(4, 54)
        Me.tabJobs.Name = "tabJobs"
        Me.tabJobs.Size = New System.Drawing.Size(1000, 671)
        Me.tabJobs.TabIndex = 3
        Me.tabJobs.Text = "Jobs"
        '
        'tabStatus
        '
        Me.tabStatus.BackColor = System.Drawing.Color.LightGray
        Me.tabStatus.Location = New System.Drawing.Point(4, 54)
        Me.tabStatus.Name = "tabStatus"
        Me.tabStatus.Size = New System.Drawing.Size(1000, 671)
        Me.tabStatus.TabIndex = 4
        Me.tabStatus.Text = "Status"
        '
        'tabComms
        '
        Me.tabComms.BackColor = System.Drawing.Color.LightGray
        Me.tabComms.Location = New System.Drawing.Point(4, 54)
        Me.tabComms.Name = "tabComms"
        Me.tabComms.Size = New System.Drawing.Size(1000, 671)
        Me.tabComms.TabIndex = 5
        Me.tabComms.Text = "Comms"
        '
        'tabConfig
        '
        Me.tabConfig.BackColor = System.Drawing.Color.LightGray
        Me.tabConfig.Location = New System.Drawing.Point(4, 54)
        Me.tabConfig.Name = "tabConfig"
        Me.tabConfig.Size = New System.Drawing.Size(1000, 671)
        Me.tabConfig.TabIndex = 6
        Me.tabConfig.Text = "Config"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.tabControlMain)
        Me.Font = New System.Drawing.Font("MS 33558", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Text = "Ambulance Controller"
        Me.tabControlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabControlMain As TabControl
    Friend WithEvents tabHome As TabPage
    Friend WithEvents tabEnviron As TabPage
    Friend WithEvents tabControl As TabPage
    Friend WithEvents tabJobs As TabPage
    Friend WithEvents tabStatus As TabPage
    Friend WithEvents tabComms As TabPage
    Friend WithEvents tabConfig As TabPage
    Friend WithEvents pnlMain As Panel
End Class
