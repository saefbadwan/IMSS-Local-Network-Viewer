<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_ControlHolderPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Loading_PictureBox = New System.Windows.Forms.PictureBox()
        Me._IMSS_Close = New System.Windows.Forms.Button()
        Me._IMSS_NetworkConnections = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_Connections = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ConnectionStatus = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_LoadConnectionsWorker = New System.ComponentModel.BackgroundWorker()
        Me._IMSS_MainPanel.SuspendLayout()
        Me._IMSS_ControlHolderPanel.SuspendLayout()
        CType(Me._IMSS_Loading_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_NetworkConnections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_ControlHolderPanel)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_NetworkConnections)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(434, 428)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 0
        '
        '_IMSS_ControlHolderPanel
        '
        Me._IMSS_ControlHolderPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_ControlHolderPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_ControlHolderPanel.Controls.Add(Me._IMSS_Loading_PictureBox)
        Me._IMSS_ControlHolderPanel.Controls.Add(Me._IMSS_Close)
        Me._IMSS_ControlHolderPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_ControlHolderPanel.Location = New System.Drawing.Point(0, 384)
        Me._IMSS_ControlHolderPanel.Name = "_IMSS_ControlHolderPanel"
        Me._IMSS_ControlHolderPanel.Size = New System.Drawing.Size(434, 44)
        Me._IMSS_ControlHolderPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_ControlHolderPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_ControlHolderPanel.Style.BackColor2.Color = System.Drawing.Color.LightGray
        Me._IMSS_ControlHolderPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_ControlHolderPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_ControlHolderPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me._IMSS_ControlHolderPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_ControlHolderPanel.Style.GradientAngle = 90
        Me._IMSS_ControlHolderPanel.TabIndex = 2
        '
        '_IMSS_Loading_PictureBox
        '
        Me._IMSS_Loading_PictureBox.Image = Global.IMSS_Local_Network_Viewer.My.Resources.Resources._IMSS_ProcessesManager_Loading_Icon_400x50
        Me._IMSS_Loading_PictureBox.Location = New System.Drawing.Point(12, 11)
        Me._IMSS_Loading_PictureBox.Name = "_IMSS_Loading_PictureBox"
        Me._IMSS_Loading_PictureBox.Size = New System.Drawing.Size(329, 23)
        Me._IMSS_Loading_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_Loading_PictureBox.TabIndex = 3
        Me._IMSS_Loading_PictureBox.TabStop = False
        '
        '_IMSS_Close
        '
        Me._IMSS_Close.Location = New System.Drawing.Point(347, 11)
        Me._IMSS_Close.Name = "_IMSS_Close"
        Me._IMSS_Close.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Close.TabIndex = 2
        Me._IMSS_Close.Text = "Close"
        Me._IMSS_Close.UseVisualStyleBackColor = True
        '
        '_IMSS_NetworkConnections
        '
        Me._IMSS_NetworkConnections.Columns.AddRange(New Object() {Me._IMSS_Connections, Me._IMSS_ConnectionStatus})
        Me._IMSS_NetworkConnections.Location = New System.Drawing.Point(12, 22)
        Me._IMSS_NetworkConnections.Name = "_IMSS_NetworkConnections"
        Me._IMSS_NetworkConnections.Size = New System.Drawing.Size(412, 343)
        Me._IMSS_NetworkConnections.TabIndex = 0
        '
        '_IMSS_Connections
        '
        Me._IMSS_Connections.Name = "_IMSS_Connections"
        Me._IMSS_Connections.Text = "Connections"
        Me._IMSS_Connections.Width = 275
        '
        '_IMSS_ConnectionStatus
        '
        Me._IMSS_ConnectionStatus.Name = "_IMSS_ConnectionStatus"
        Me._IMSS_ConnectionStatus.Text = "Connection Status"
        Me._IMSS_ConnectionStatus.Width = 133
        '
        '_IMSS_LoadConnectionsWorker
        '
        Me._IMSS_LoadConnectionsWorker.WorkerReportsProgress = True
        Me._IMSS_LoadConnectionsWorker.WorkerSupportsCancellation = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 428)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(450, 466)
        Me.MinimumSize = New System.Drawing.Size(450, 466)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMSS Local Network Viewer"
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_ControlHolderPanel.ResumeLayout(False)
        CType(Me._IMSS_Loading_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_NetworkConnections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_NetworkConnections As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_Connections As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_LoadConnectionsWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents _IMSS_ControlHolderPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Close As System.Windows.Forms.Button
    Friend WithEvents _IMSS_ConnectionStatus As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Loading_PictureBox As System.Windows.Forms.PictureBox

End Class
