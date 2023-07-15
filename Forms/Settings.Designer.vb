<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.miscTbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.failsTbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.successWebhookTbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.otherSettingsApplyBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.catchallDomainTbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.aycdAutosolveAPIKeyTbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.aycdAutosolveAccessTokenTbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.apiServiceCombo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.proxyOnCaptchaBox = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.captchaAPIKeyTbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.queuePassesBox = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.successOnlyBox = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2GroupBox4.SuspendLayout()
        Me.Guna2GroupBox3.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'miscTbx
        '
        Me.miscTbx.BorderRadius = 10
        Me.miscTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.miscTbx.DefaultText = ""
        Me.miscTbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.miscTbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.miscTbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.miscTbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.miscTbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.miscTbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.miscTbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.miscTbx.Location = New System.Drawing.Point(8, 208)
        Me.miscTbx.Name = "miscTbx"
        Me.miscTbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.miscTbx.PlaceholderText = "Discord Webhook"
        Me.miscTbx.SelectedText = ""
        Me.miscTbx.Size = New System.Drawing.Size(473, 36)
        Me.miscTbx.TabIndex = 11
        '
        'failsTbx
        '
        Me.failsTbx.BorderRadius = 10
        Me.failsTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.failsTbx.DefaultText = ""
        Me.failsTbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.failsTbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.failsTbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.failsTbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.failsTbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.failsTbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.failsTbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.failsTbx.Location = New System.Drawing.Point(6, 146)
        Me.failsTbx.Name = "failsTbx"
        Me.failsTbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.failsTbx.PlaceholderText = "Discord Webhook"
        Me.failsTbx.SelectedText = ""
        Me.failsTbx.Size = New System.Drawing.Size(475, 36)
        Me.failsTbx.TabIndex = 9
        '
        'successWebhookTbx
        '
        Me.successWebhookTbx.BorderRadius = 10
        Me.successWebhookTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.successWebhookTbx.DefaultText = ""
        Me.successWebhookTbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.successWebhookTbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.successWebhookTbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.successWebhookTbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.successWebhookTbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.successWebhookTbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.successWebhookTbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.successWebhookTbx.Location = New System.Drawing.Point(6, 75)
        Me.successWebhookTbx.Name = "successWebhookTbx"
        Me.successWebhookTbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.successWebhookTbx.PlaceholderText = "Discord Webhook"
        Me.successWebhookTbx.SelectedText = ""
        Me.successWebhookTbx.Size = New System.Drawing.Size(475, 36)
        Me.successWebhookTbx.TabIndex = 7
        '
        'Guna2GradientButton2
        '
        Me.Guna2GradientButton2.BorderRadius = 10
        Me.Guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Guna2GradientButton2.FillColor2 = System.Drawing.Color.Transparent
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(335, 261)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(146, 36)
        Me.Guna2GradientButton2.TabIndex = 0
        Me.Guna2GradientButton2.Text = "Test"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.otherSettingsApplyBtn)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GroupBox4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GroupBox3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GroupBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1147, 764)
        Me.Guna2Panel1.TabIndex = 19
        '
        'otherSettingsApplyBtn
        '
        Me.otherSettingsApplyBtn.BorderRadius = 10
        Me.otherSettingsApplyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.otherSettingsApplyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.otherSettingsApplyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.otherSettingsApplyBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.otherSettingsApplyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.otherSettingsApplyBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.otherSettingsApplyBtn.FillColor2 = System.Drawing.Color.Transparent
        Me.otherSettingsApplyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.otherSettingsApplyBtn.ForeColor = System.Drawing.Color.White
        Me.otherSettingsApplyBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.otherSettingsApplyBtn.Location = New System.Drawing.Point(472, 662)
        Me.otherSettingsApplyBtn.Name = "otherSettingsApplyBtn"
        Me.otherSettingsApplyBtn.Size = New System.Drawing.Size(146, 36)
        Me.otherSettingsApplyBtn.TabIndex = 28
        Me.otherSettingsApplyBtn.Text = "Apply All"
        '
        'Guna2GroupBox4
        '
        Me.Guna2GroupBox4.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2GroupBox4.Controls.Add(Me.catchallDomainTbx)
        Me.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox4.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox4.Location = New System.Drawing.Point(559, 413)
        Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
        Me.Guna2GroupBox4.Size = New System.Drawing.Size(454, 234)
        Me.Guna2GroupBox4.TabIndex = 27
        Me.Guna2GroupBox4.Text = "Other Settings"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(12, 43)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(80, 15)
        Me.Guna2HtmlLabel9.TabIndex = 25
        Me.Guna2HtmlLabel9.Text = "Catchall Domain"
        '
        'catchallDomainTbx
        '
        Me.catchallDomainTbx.BorderRadius = 10
        Me.catchallDomainTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.catchallDomainTbx.DefaultText = ""
        Me.catchallDomainTbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.catchallDomainTbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.catchallDomainTbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.catchallDomainTbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.catchallDomainTbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.catchallDomainTbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.catchallDomainTbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.catchallDomainTbx.Location = New System.Drawing.Point(8, 73)
        Me.catchallDomainTbx.Name = "catchallDomainTbx"
        Me.catchallDomainTbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.catchallDomainTbx.PlaceholderText = "Domain"
        Me.catchallDomainTbx.SelectedText = ""
        Me.catchallDomainTbx.Size = New System.Drawing.Size(384, 36)
        Me.catchallDomainTbx.TabIndex = 9
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2GroupBox3.Controls.Add(Me.aycdAutosolveAPIKeyTbx)
        Me.Guna2GroupBox3.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2GroupBox3.Controls.Add(Me.aycdAutosolveAccessTokenTbx)
        Me.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(12, 413)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(508, 234)
        Me.Guna2GroupBox3.TabIndex = 26
        Me.Guna2GroupBox3.Text = "AYCD Settings"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(12, 133)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(123, 15)
        Me.Guna2HtmlLabel6.TabIndex = 27
        Me.Guna2HtmlLabel6.Text = "AYCD Autosolve API Key"
        '
        'aycdAutosolveAPIKeyTbx
        '
        Me.aycdAutosolveAPIKeyTbx.BorderRadius = 10
        Me.aycdAutosolveAPIKeyTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.aycdAutosolveAPIKeyTbx.DefaultText = ""
        Me.aycdAutosolveAPIKeyTbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.aycdAutosolveAPIKeyTbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.aycdAutosolveAPIKeyTbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.aycdAutosolveAPIKeyTbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.aycdAutosolveAPIKeyTbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.aycdAutosolveAPIKeyTbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.aycdAutosolveAPIKeyTbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.aycdAutosolveAPIKeyTbx.Location = New System.Drawing.Point(8, 162)
        Me.aycdAutosolveAPIKeyTbx.Name = "aycdAutosolveAPIKeyTbx"
        Me.aycdAutosolveAPIKeyTbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.aycdAutosolveAPIKeyTbx.PlaceholderText = "API Key"
        Me.aycdAutosolveAPIKeyTbx.SelectedText = ""
        Me.aycdAutosolveAPIKeyTbx.Size = New System.Drawing.Size(384, 36)
        Me.aycdAutosolveAPIKeyTbx.TabIndex = 26
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(12, 43)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(154, 15)
        Me.Guna2HtmlLabel7.TabIndex = 25
        Me.Guna2HtmlLabel7.Text = "AYCD Autosolve Access Token"
        '
        'aycdAutosolveAccessTokenTbx
        '
        Me.aycdAutosolveAccessTokenTbx.BorderRadius = 10
        Me.aycdAutosolveAccessTokenTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.aycdAutosolveAccessTokenTbx.DefaultText = ""
        Me.aycdAutosolveAccessTokenTbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.aycdAutosolveAccessTokenTbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.aycdAutosolveAccessTokenTbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.aycdAutosolveAccessTokenTbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.aycdAutosolveAccessTokenTbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.aycdAutosolveAccessTokenTbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.aycdAutosolveAccessTokenTbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.aycdAutosolveAccessTokenTbx.Location = New System.Drawing.Point(8, 73)
        Me.aycdAutosolveAccessTokenTbx.Name = "aycdAutosolveAccessTokenTbx"
        Me.aycdAutosolveAccessTokenTbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.aycdAutosolveAccessTokenTbx.PlaceholderText = "Access Token"
        Me.aycdAutosolveAccessTokenTbx.SelectedText = ""
        Me.aycdAutosolveAccessTokenTbx.Size = New System.Drawing.Size(384, 36)
        Me.aycdAutosolveAccessTokenTbx.TabIndex = 9
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2GroupBox2.Controls.Add(Me.apiServiceCombo)
        Me.Guna2GroupBox2.Controls.Add(Me.proxyOnCaptchaBox)
        Me.Guna2GroupBox2.Controls.Add(Me.captchaAPIKeyTbx)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(559, 74)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(454, 315)
        Me.Guna2GroupBox2.TabIndex = 25
        Me.Guna2GroupBox2.Text = "Captcha Settings"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(12, 46)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(102, 15)
        Me.Guna2HtmlLabel4.TabIndex = 26
        Me.Guna2HtmlLabel4.Text = "Captcha API Service"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(18, 146)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(41, 15)
        Me.Guna2HtmlLabel5.TabIndex = 25
        Me.Guna2HtmlLabel5.Text = "API Key"
        '
        'apiServiceCombo
        '
        Me.apiServiceCombo.BackColor = System.Drawing.Color.Transparent
        Me.apiServiceCombo.BorderThickness = 2
        Me.apiServiceCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.apiServiceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.apiServiceCombo.FocusedColor = System.Drawing.Color.Yellow
        Me.apiServiceCombo.FocusedState.BorderColor = System.Drawing.Color.Yellow
        Me.apiServiceCombo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.apiServiceCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.apiServiceCombo.ItemHeight = 30
        Me.apiServiceCombo.Items.AddRange(New Object() {"2Captcha", "Anti-Captcha", "AntiCaptcha", "AnyCaptcha", "AZcaptcha", "BypassCaptcha", "Capmonster", "Capsolver", "Death By Captcha", "EndCaptcha"})
        Me.apiServiceCombo.Location = New System.Drawing.Point(12, 75)
        Me.apiServiceCombo.MaxDropDownItems = 3
        Me.apiServiceCombo.Name = "apiServiceCombo"
        Me.apiServiceCombo.Size = New System.Drawing.Size(208, 36)
        Me.apiServiceCombo.Sorted = True
        Me.apiServiceCombo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.apiServiceCombo.TabIndex = 23
        '
        'proxyOnCaptchaBox
        '
        Me.proxyOnCaptchaBox.AutoSize = True
        Me.proxyOnCaptchaBox.Checked = True
        Me.proxyOnCaptchaBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.proxyOnCaptchaBox.CheckedState.BorderRadius = 0
        Me.proxyOnCaptchaBox.CheckedState.BorderThickness = 0
        Me.proxyOnCaptchaBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.proxyOnCaptchaBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.proxyOnCaptchaBox.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.proxyOnCaptchaBox.Location = New System.Drawing.Point(12, 244)
        Me.proxyOnCaptchaBox.Name = "proxyOnCaptchaBox"
        Me.proxyOnCaptchaBox.Size = New System.Drawing.Size(115, 17)
        Me.proxyOnCaptchaBox.TabIndex = 22
        Me.proxyOnCaptchaBox.Text = "Proxy on Captcha"
        Me.proxyOnCaptchaBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.proxyOnCaptchaBox.UncheckedState.BorderRadius = 0
        Me.proxyOnCaptchaBox.UncheckedState.BorderThickness = 0
        Me.proxyOnCaptchaBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'captchaAPIKeyTbx
        '
        Me.captchaAPIKeyTbx.BorderRadius = 10
        Me.captchaAPIKeyTbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.captchaAPIKeyTbx.DefaultText = ""
        Me.captchaAPIKeyTbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.captchaAPIKeyTbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.captchaAPIKeyTbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.captchaAPIKeyTbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.captchaAPIKeyTbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.captchaAPIKeyTbx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.captchaAPIKeyTbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.captchaAPIKeyTbx.Location = New System.Drawing.Point(12, 175)
        Me.captchaAPIKeyTbx.Name = "captchaAPIKeyTbx"
        Me.captchaAPIKeyTbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.captchaAPIKeyTbx.PlaceholderText = "Key"
        Me.captchaAPIKeyTbx.SelectedText = ""
        Me.captchaAPIKeyTbx.Size = New System.Drawing.Size(363, 36)
        Me.captchaAPIKeyTbx.TabIndex = 9
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(12, 40)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1001, 28)
        Me.Guna2Separator1.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Settings"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.queuePassesBox)
        Me.Guna2GroupBox1.Controls.Add(Me.successOnlyBox)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2GroupBox1.Controls.Add(Me.successWebhookTbx)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GroupBox1.Controls.Add(Me.failsTbx)
        Me.Guna2GroupBox1.Controls.Add(Me.miscTbx)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2GradientButton2)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(508, 315)
        Me.Guna2GroupBox1.TabIndex = 22
        Me.Guna2GroupBox1.Text = "Discord Settings"
        '
        'queuePassesBox
        '
        Me.queuePassesBox.AutoSize = True
        Me.queuePassesBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.queuePassesBox.CheckedState.BorderRadius = 0
        Me.queuePassesBox.CheckedState.BorderThickness = 0
        Me.queuePassesBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.queuePassesBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.queuePassesBox.Location = New System.Drawing.Point(12, 284)
        Me.queuePassesBox.Name = "queuePassesBox"
        Me.queuePassesBox.Size = New System.Drawing.Size(96, 17)
        Me.queuePassesBox.TabIndex = 23
        Me.queuePassesBox.Text = "Queue Passes"
        Me.queuePassesBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.queuePassesBox.UncheckedState.BorderRadius = 0
        Me.queuePassesBox.UncheckedState.BorderThickness = 0
        Me.queuePassesBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'successOnlyBox
        '
        Me.successOnlyBox.AutoSize = True
        Me.successOnlyBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.successOnlyBox.CheckedState.BorderRadius = 0
        Me.successOnlyBox.CheckedState.BorderThickness = 0
        Me.successOnlyBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.successOnlyBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.successOnlyBox.Location = New System.Drawing.Point(12, 261)
        Me.successOnlyBox.Name = "successOnlyBox"
        Me.successOnlyBox.Size = New System.Drawing.Size(92, 17)
        Me.successOnlyBox.TabIndex = 22
        Me.successOnlyBox.Text = "Success Only"
        Me.successOnlyBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.successOnlyBox.UncheckedState.BorderRadius = 0
        Me.successOnlyBox.UncheckedState.BorderThickness = 0
        Me.successOnlyBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(12, 52)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(56, 15)
        Me.Guna2HtmlLabel1.TabIndex = 19
        Me.Guna2HtmlLabel1.Text = "Successful"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(12, 187)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(26, 15)
        Me.Guna2HtmlLabel3.TabIndex = 21
        Me.Guna2HtmlLabel3.Text = "Misc"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(12, 125)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(26, 15)
        Me.Guna2HtmlLabel2.TabIndex = 20
        Me.Guna2HtmlLabel2.Text = "Fails"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1147, 764)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2GroupBox4.ResumeLayout(False)
        Me.Guna2GroupBox4.PerformLayout()
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox3.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents miscTbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents failsTbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents successWebhookTbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label2 As Label
    Friend WithEvents queuePassesBox As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents successOnlyBox As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents apiServiceCombo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents proxyOnCaptchaBox As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents captchaAPIKeyTbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox4 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents otherSettingsApplyBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents catchallDomainTbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents aycdAutosolveAPIKeyTbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents aycdAutosolveAccessTokenTbx As Guna.UI2.WinForms.Guna2TextBox
End Class
