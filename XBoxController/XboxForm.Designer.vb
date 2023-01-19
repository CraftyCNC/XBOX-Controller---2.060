Imports System

Namespace Plugins
    Partial Class XBoxForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing


        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XBoxForm))
            Me.label4 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.cbEnableMain = New System.Windows.Forms.CheckBox()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.cbLSMaxVel = New System.Windows.Forms.CheckBox()
            Me.nudMaxVelLSV = New System.Windows.Forms.NumericUpDown()
            Me.label42 = New System.Windows.Forms.Label()
            Me.label41 = New System.Windows.Forms.Label()
            Me.label46 = New System.Windows.Forms.Label()
            Me.cbMixAxisJogLS = New System.Windows.Forms.CheckBox()
            Me.label29 = New System.Windows.Forms.Label()
            Me.nudLYdeadband = New System.Windows.Forms.NumericUpDown()
            Me.nudLXDeadBand = New System.Windows.Forms.NumericUpDown()
            Me.label39 = New System.Windows.Forms.Label()
            Me.nudMaxVelLSH = New System.Windows.Forms.NumericUpDown()
            Me.label19 = New System.Windows.Forms.Label()
            Me.rbCubedRateLeft = New System.Windows.Forms.RadioButton()
            Me.rbSquaredRateLeft = New System.Windows.Forms.RadioButton()
            Me.rbLinearRateLeft = New System.Windows.Forms.RadioButton()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.cbMixAxisJogRS = New System.Windows.Forms.CheckBox()
            Me.cbRSMaxVel = New System.Windows.Forms.CheckBox()
            Me.nudMaxVelRSV = New System.Windows.Forms.NumericUpDown()
            Me.label47 = New System.Windows.Forms.Label()
            Me.label43 = New System.Windows.Forms.Label()
            Me.label44 = New System.Windows.Forms.Label()
            Me.label45 = New System.Windows.Forms.Label()
            Me.nudRYdeadband = New System.Windows.Forms.NumericUpDown()
            Me.nudRXdeadband = New System.Windows.Forms.NumericUpDown()
            Me.nudMaxVelRSH = New System.Windows.Forms.NumericUpDown()
            Me.label40 = New System.Windows.Forms.Label()
            Me.label20 = New System.Windows.Forms.Label()
            Me.rbCubedRateRight = New System.Windows.Forms.RadioButton()
            Me.rbSquaredRateRight = New System.Windows.Forms.RadioButton()
            Me.rbLinearRateRight = New System.Windows.Forms.RadioButton()
            Me.groupboxJogStep = New System.Windows.Forms.GroupBox()
            Me.cbJogStepNotify = New System.Windows.Forms.CheckBox()
            Me.cbJSTrigEnab = New System.Windows.Forms.CheckBox()
            Me.label37 = New System.Windows.Forms.Label()
            Me.jog4 = New System.Windows.Forms.ComboBox()
            Me.label36 = New System.Windows.Forms.Label()
            Me.jog3 = New System.Windows.Forms.ComboBox()
            Me.label35 = New System.Windows.Forms.Label()
            Me.jog2 = New System.Windows.Forms.ComboBox()
            Me.label34 = New System.Windows.Forms.Label()
            Me.jog1 = New System.Windows.Forms.ComboBox()
            Me.checkBox4 = New System.Windows.Forms.CheckBox()
            Me.tabControl1 = New System.Windows.Forms.TabControl()
            Me.tabPage1 = New System.Windows.Forms.TabPage()
            Me.btnConfigForm = New System.Windows.Forms.Button()
            Me.cbSaveSettings = New System.Windows.Forms.CheckBox()
            Me.groupBoxDPad = New System.Windows.Forms.GroupBox()
            Me.comboLRShoulder = New System.Windows.Forms.ComboBox()
            Me.comboUDDpad = New System.Windows.Forms.ComboBox()
            Me.comboLRDpad = New System.Windows.Forms.ComboBox()
            Me.Label38 = New System.Windows.Forms.Label()
            Me.Label49 = New System.Windows.Forms.Label()
            Me.Label50 = New System.Windows.Forms.Label()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.RadioButton16 = New System.Windows.Forms.RadioButton()
            Me.RadioButton17 = New System.Windows.Forms.RadioButton()
            Me.RadioButton18 = New System.Windows.Forms.RadioButton()
            Me.cbAutoEnable = New System.Windows.Forms.CheckBox()
            Me.cbMinimizeOnLoad = New System.Windows.Forms.CheckBox()
            Me.cbErrMsg = New System.Windows.Forms.CheckBox()
            Me.cbRightStickEnab = New System.Windows.Forms.CheckBox()
            Me.cbLeftStickEnab = New System.Windows.Forms.CheckBox()
            Me.btnLoadSettings = New System.Windows.Forms.Button()
            Me.groupBox8 = New System.Windows.Forms.GroupBox()
            Me.comboBoxRYStick = New System.Windows.Forms.ComboBox()
            Me.comboBoxRXStick = New System.Windows.Forms.ComboBox()
            Me.comboBoxLYStick = New System.Windows.Forms.ComboBox()
            Me.comboBoxLXStick = New System.Windows.Forms.ComboBox()
            Me.label32 = New System.Windows.Forms.Label()
            Me.label33 = New System.Windows.Forms.Label()
            Me.label31 = New System.Windows.Forms.Label()
            Me.label30 = New System.Windows.Forms.Label()
            Me.groupBox9 = New System.Windows.Forms.GroupBox()
            Me.radioButton13 = New System.Windows.Forms.RadioButton()
            Me.radioButton14 = New System.Windows.Forms.RadioButton()
            Me.radioButton15 = New System.Windows.Forms.RadioButton()
            Me.groupBox6 = New System.Windows.Forms.GroupBox()
            Me.groupBox7 = New System.Windows.Forms.GroupBox()
            Me.radioButton10 = New System.Windows.Forms.RadioButton()
            Me.radioButton11 = New System.Windows.Forms.RadioButton()
            Me.radioButton12 = New System.Windows.Forms.RadioButton()
            Me.rbDubTrigEnable = New System.Windows.Forms.RadioButton()
            Me.rbSingTrigEnable = New System.Windows.Forms.RadioButton()
            Me.rbVelTrigger = New System.Windows.Forms.RadioButton()
            Me.btnShowCodes = New System.Windows.Forms.Button()
            Me.groupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnLED14 = New System.Windows.Forms.Button()
            Me.btnLED10 = New System.Windows.Forms.Button()
            Me.btnLED13 = New System.Windows.Forms.Button()
            Me.btnLED9 = New System.Windows.Forms.Button()
            Me.btnLED8 = New System.Windows.Forms.Button()
            Me.btnLED7 = New System.Windows.Forms.Button()
            Me.comboBox7 = New System.Windows.Forms.ComboBox()
            Me.comboBox8 = New System.Windows.Forms.ComboBox()
            Me.comboBox5 = New System.Windows.Forms.ComboBox()
            Me.comboBox6 = New System.Windows.Forms.ComboBox()
            Me.comboBox3 = New System.Windows.Forms.ComboBox()
            Me.comboBox4 = New System.Windows.Forms.ComboBox()
            Me.comboBox2 = New System.Windows.Forms.ComboBox()
            Me.comboBox1 = New System.Windows.Forms.ComboBox()
            Me.label22 = New System.Windows.Forms.Label()
            Me.comboBox15 = New System.Windows.Forms.ComboBox()
            Me.label21 = New System.Windows.Forms.Label()
            Me.comboBox16 = New System.Windows.Forms.ComboBox()
            Me.label10 = New System.Windows.Forms.Label()
            Me.label9 = New System.Windows.Forms.Label()
            Me.comboBox13 = New System.Windows.Forms.ComboBox()
            Me.label8 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.comboBox14 = New System.Windows.Forms.ComboBox()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label13 = New System.Windows.Forms.Label()
            Me.label14 = New System.Windows.Forms.Label()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.btnLED18 = New System.Windows.Forms.Button()
            Me.btnLED17 = New System.Windows.Forms.Button()
            Me.btnLED16 = New System.Windows.Forms.Button()
            Me.btnLED12 = New System.Windows.Forms.Button()
            Me.btnLED15 = New System.Windows.Forms.Button()
            Me.label23 = New System.Windows.Forms.Label()
            Me.btnLED11 = New System.Windows.Forms.Button()
            Me.cbCustomDpad = New System.Windows.Forms.CheckBox()
            Me.label27 = New System.Windows.Forms.Label()
            Me.comboBox9 = New System.Windows.Forms.ComboBox()
            Me.comboBox10 = New System.Windows.Forms.ComboBox()
            Me.label28 = New System.Windows.Forms.Label()
            Me.label12 = New System.Windows.Forms.Label()
            Me.label26 = New System.Windows.Forms.Label()
            Me.label18 = New System.Windows.Forms.Label()
            Me.label25 = New System.Windows.Forms.Label()
            Me.label17 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.label16 = New System.Windows.Forms.Label()
            Me.label15 = New System.Windows.Forms.Label()
            Me.comboBox23 = New System.Windows.Forms.ComboBox()
            Me.comboBox12 = New System.Windows.Forms.ComboBox()
            Me.comboBox24 = New System.Windows.Forms.ComboBox()
            Me.label11 = New System.Windows.Forms.Label()
            Me.comboBox11 = New System.Windows.Forms.ComboBox()
            Me.comboBox21 = New System.Windows.Forms.ComboBox()
            Me.comboBox18 = New System.Windows.Forms.ComboBox()
            Me.comboBox22 = New System.Windows.Forms.ComboBox()
            Me.comboBox17 = New System.Windows.Forms.ComboBox()
            Me.comboBox19 = New System.Windows.Forms.ComboBox()
            Me.comboBox20 = New System.Windows.Forms.ComboBox()
            Me.btnSaveSettings = New System.Windows.Forms.Button()
            Me.btnConnect = New System.Windows.Forms.Button()
            Me.tabPage2 = New System.Windows.Forms.TabPage()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.tabPage3 = New System.Windows.Forms.TabPage()
            Me.lblAppVersion = New System.Windows.Forms.Label()
            Me.linkLabel2 = New System.Windows.Forms.LinkLabel()
            Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
            Me.textBox2 = New System.Windows.Forms.TextBox()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
            Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
            Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.toolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.timerUpdateScreen = New System.Windows.Forms.Timer(Me.components)
            Me.groupBox1.SuspendLayout()
            CType(Me.nudMaxVelLSV, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudLYdeadband, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudLXDeadBand, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudMaxVelLSH, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox2.SuspendLayout()
            CType(Me.nudMaxVelRSV, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudRYdeadband, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudRXdeadband, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudMaxVelRSH, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupboxJogStep.SuspendLayout()
            Me.tabControl1.SuspendLayout()
            Me.tabPage1.SuspendLayout()
            Me.groupBoxDPad.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.groupBox8.SuspendLayout()
            Me.groupBox9.SuspendLayout()
            Me.groupBox6.SuspendLayout()
            Me.groupBox7.SuspendLayout()
            Me.groupBox3.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.tabPage2.SuspendLayout()
            Me.tabPage3.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.contextMenuStrip1.SuspendLayout()
            Me.statusStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label4.Location = New System.Drawing.Point(157, 69)
            Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(95, 20)
            Me.label4.TabIndex = 32
            Me.label4.Text = "RightStickY"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.toolTip1.SetToolTip(Me.label4, "Z axis jogging")
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label3.Location = New System.Drawing.Point(157, 30)
            Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(96, 20)
            Me.label3.TabIndex = 30
            Me.label3.Text = "RightStickX"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.toolTip1.SetToolTip(Me.label3, "Used to select the 'step jog' size (.001, .010, .100, 1.00)")
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label2.Location = New System.Drawing.Point(12, 69)
            Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(85, 20)
            Me.label2.TabIndex = 31
            Me.label2.Text = "LeftStickY"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.toolTip1.SetToolTip(Me.label2, "Y axis jogging")
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label1.Location = New System.Drawing.Point(12, 30)
            Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(86, 20)
            Me.label1.TabIndex = 28
            Me.label1.Text = "LeftStickX"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.toolTip1.SetToolTip(Me.label1, "X axis jogging")
            '
            'cbEnableMain
            '
            Me.cbEnableMain.AutoSize = True
            Me.cbEnableMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbEnableMain.Location = New System.Drawing.Point(671, 769)
            Me.cbEnableMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.cbEnableMain.Name = "cbEnableMain"
            Me.cbEnableMain.Size = New System.Drawing.Size(278, 24)
            Me.cbEnableMain.TabIndex = 9
            Me.cbEnableMain.Text = "Enable Joging with Controller"
            Me.cbEnableMain.UseVisualStyleBackColor = True
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.cbLSMaxVel)
            Me.groupBox1.Controls.Add(Me.nudMaxVelLSV)
            Me.groupBox1.Controls.Add(Me.label42)
            Me.groupBox1.Controls.Add(Me.label41)
            Me.groupBox1.Controls.Add(Me.label46)
            Me.groupBox1.Controls.Add(Me.cbMixAxisJogLS)
            Me.groupBox1.Controls.Add(Me.label29)
            Me.groupBox1.Controls.Add(Me.nudLYdeadband)
            Me.groupBox1.Controls.Add(Me.nudLXDeadBand)
            Me.groupBox1.Controls.Add(Me.label39)
            Me.groupBox1.Controls.Add(Me.nudMaxVelLSH)
            Me.groupBox1.Controls.Add(Me.label19)
            Me.groupBox1.Controls.Add(Me.rbCubedRateLeft)
            Me.groupBox1.Controls.Add(Me.rbSquaredRateLeft)
            Me.groupBox1.Controls.Add(Me.rbLinearRateLeft)
            Me.groupBox1.Location = New System.Drawing.Point(411, 129)
            Me.groupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupBox1.Size = New System.Drawing.Size(276, 299)
            Me.groupBox1.TabIndex = 2
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Velocity Rate (Left stick)"
            Me.toolTip1.SetToolTip(Me.groupBox1, "Select the Velocity sensitivity rate for the left stick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "movement.  Linear is lea" &
        "st sensitive, Cubed is most " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensitive at low speed.")
            '
            'cbLSMaxVel
            '
            Me.cbLSMaxVel.AutoSize = True
            Me.cbLSMaxVel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbLSMaxVel.Location = New System.Drawing.Point(4, 188)
            Me.cbLSMaxVel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.cbLSMaxVel.Name = "cbLSMaxVel"
            Me.cbLSMaxVel.Size = New System.Drawing.Size(183, 22)
            Me.cbLSMaxVel.TabIndex = 4
            Me.cbLSMaxVel.Text = "Use Max Vel. Setpoints"
            Me.cbLSMaxVel.UseVisualStyleBackColor = True
            '
            'nudMaxVelLSV
            '
            Me.nudMaxVelLSV.ImeMode = System.Windows.Forms.ImeMode.[On]
            Me.nudMaxVelLSV.InterceptArrowKeys = False
            Me.nudMaxVelLSV.Location = New System.Drawing.Point(181, 242)
            Me.nudMaxVelLSV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.nudMaxVelLSV.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudMaxVelLSV.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudMaxVelLSV.Name = "nudMaxVelLSV"
            Me.nudMaxVelLSV.Size = New System.Drawing.Size(88, 22)
            Me.nudMaxVelLSV.TabIndex = 52
            Me.toolTip1.SetToolTip(Me.nudMaxVelLSV, resources.GetString("nudMaxVelLSV.ToolTip"))
            Me.nudMaxVelLSV.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label42
            '
            Me.label42.AutoSize = True
            Me.label42.Location = New System.Drawing.Point(136, 22)
            Me.label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label42.Name = "label42"
            Me.label42.Size = New System.Drawing.Size(17, 17)
            Me.label42.TabIndex = 43
            Me.label42.Text = "X"
            '
            'label41
            '
            Me.label41.AutoSize = True
            Me.label41.Location = New System.Drawing.Point(204, 22)
            Me.label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label41.Name = "label41"
            Me.label41.Size = New System.Drawing.Size(17, 17)
            Me.label41.TabIndex = 42
            Me.label41.Text = "Y"
            '
            'label46
            '
            Me.label46.AutoSize = True
            Me.label46.Location = New System.Drawing.Point(17, 247)
            Me.label46.Name = "label46"
            Me.label46.Size = New System.Drawing.Size(141, 17)
            Me.label46.TabIndex = 6
            Me.label46.Text = "Max Vel Left Stick - Y"
            '
            'cbMixAxisJogLS
            '
            Me.cbMixAxisJogLS.AutoSize = True
            Me.cbMixAxisJogLS.Location = New System.Drawing.Point(4, 160)
            Me.cbMixAxisJogLS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.cbMixAxisJogLS.Name = "cbMixAxisJogLS"
            Me.cbMixAxisJogLS.Size = New System.Drawing.Size(197, 21)
            Me.cbMixAxisJogLS.TabIndex = 3
            Me.cbMixAxisJogLS.Text = "Allowed mixed axis velocity"
            Me.toolTip1.SetToolTip(Me.cbMixAxisJogLS, "Allow Jogging in both axis defined for a stick at same time " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(i.e., combined X &" &
        " Y movement allowed if enabled).")
            Me.cbMixAxisJogLS.UseVisualStyleBackColor = True
            '
            'label29
            '
            Me.label29.AutoSize = True
            Me.label29.Location = New System.Drawing.Point(11, 44)
            Me.label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label29.Name = "label29"
            Me.label29.Size = New System.Drawing.Size(102, 17)
            Me.label29.TabIndex = 41
            Me.label29.Text = "Left Deadband"
            '
            'nudLYdeadband
            '
            Me.nudLYdeadband.DecimalPlaces = 2
            Me.nudLYdeadband.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudLYdeadband.InterceptArrowKeys = False
            Me.nudLYdeadband.Location = New System.Drawing.Point(187, 41)
            Me.nudLYdeadband.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.nudLYdeadband.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
            Me.nudLYdeadband.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudLYdeadband.Name = "nudLYdeadband"
            Me.nudLYdeadband.Size = New System.Drawing.Size(61, 22)
            Me.nudLYdeadband.TabIndex = 40
            Me.nudLYdeadband.Value = New Decimal(New Integer() {2, 0, 0, 131072})
            '
            'nudLXDeadBand
            '
            Me.nudLXDeadBand.DecimalPlaces = 2
            Me.nudLXDeadBand.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudLXDeadBand.InterceptArrowKeys = False
            Me.nudLXDeadBand.Location = New System.Drawing.Point(120, 41)
            Me.nudLXDeadBand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.nudLXDeadBand.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
            Me.nudLXDeadBand.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudLXDeadBand.Name = "nudLXDeadBand"
            Me.nudLXDeadBand.Size = New System.Drawing.Size(61, 22)
            Me.nudLXDeadBand.TabIndex = 39
            Me.nudLXDeadBand.Value = New Decimal(New Integer() {2, 0, 0, 131072})
            '
            'label39
            '
            Me.label39.AutoSize = True
            Me.label39.Location = New System.Drawing.Point(17, 220)
            Me.label39.Name = "label39"
            Me.label39.Size = New System.Drawing.Size(141, 17)
            Me.label39.TabIndex = 5
            Me.label39.Text = "Max Vel Left Stick - X"
            '
            'nudMaxVelLSH
            '
            Me.nudMaxVelLSH.ImeMode = System.Windows.Forms.ImeMode.[On]
            Me.nudMaxVelLSH.InterceptArrowKeys = False
            Me.nudMaxVelLSH.Location = New System.Drawing.Point(181, 215)
            Me.nudMaxVelLSH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.nudMaxVelLSH.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudMaxVelLSH.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudMaxVelLSH.Name = "nudMaxVelLSH"
            Me.nudMaxVelLSH.Size = New System.Drawing.Size(88, 22)
            Me.nudMaxVelLSH.TabIndex = 37
            Me.toolTip1.SetToolTip(Me.nudMaxVelLSH, resources.GetString("nudMaxVelLSH.ToolTip"))
            Me.nudMaxVelLSH.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label19
            '
            Me.label19.AutoSize = True
            Me.label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label19.Location = New System.Drawing.Point(47, 271)
            Me.label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(158, 20)
            Me.label19.TabIndex = 36
            Me.label19.Text = "Left Stick calc Feed"
            Me.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'rbCubedRateLeft
            '
            Me.rbCubedRateLeft.AutoSize = True
            Me.rbCubedRateLeft.Location = New System.Drawing.Point(20, 126)
            Me.rbCubedRateLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.rbCubedRateLeft.Name = "rbCubedRateLeft"
            Me.rbCubedRateLeft.Size = New System.Drawing.Size(173, 21)
            Me.rbCubedRateLeft.TabIndex = 2
            Me.rbCubedRateLeft.Text = "Cubed (most sensitive)"
            Me.rbCubedRateLeft.UseVisualStyleBackColor = True
            '
            'rbSquaredRateLeft
            '
            Me.rbSquaredRateLeft.AutoSize = True
            Me.rbSquaredRateLeft.Location = New System.Drawing.Point(20, 97)
            Me.rbSquaredRateLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.rbSquaredRateLeft.Name = "rbSquaredRateLeft"
            Me.rbSquaredRateLeft.Size = New System.Drawing.Size(188, 21)
            Me.rbSquaredRateLeft.TabIndex = 1
            Me.rbSquaredRateLeft.Text = "Squared (more sensitive)"
            Me.rbSquaredRateLeft.UseVisualStyleBackColor = True
            '
            'rbLinearRateLeft
            '
            Me.rbLinearRateLeft.AutoSize = True
            Me.rbLinearRateLeft.Checked = True
            Me.rbLinearRateLeft.Location = New System.Drawing.Point(20, 68)
            Me.rbLinearRateLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.rbLinearRateLeft.Name = "rbLinearRateLeft"
            Me.rbLinearRateLeft.Size = New System.Drawing.Size(69, 21)
            Me.rbLinearRateLeft.TabIndex = 0
            Me.rbLinearRateLeft.TabStop = True
            Me.rbLinearRateLeft.Text = "Linear"
            Me.rbLinearRateLeft.UseVisualStyleBackColor = True
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.cbMixAxisJogRS)
            Me.groupBox2.Controls.Add(Me.cbRSMaxVel)
            Me.groupBox2.Controls.Add(Me.nudMaxVelRSV)
            Me.groupBox2.Controls.Add(Me.label47)
            Me.groupBox2.Controls.Add(Me.label43)
            Me.groupBox2.Controls.Add(Me.label44)
            Me.groupBox2.Controls.Add(Me.label45)
            Me.groupBox2.Controls.Add(Me.nudRYdeadband)
            Me.groupBox2.Controls.Add(Me.nudRXdeadband)
            Me.groupBox2.Controls.Add(Me.nudMaxVelRSH)
            Me.groupBox2.Controls.Add(Me.label40)
            Me.groupBox2.Controls.Add(Me.label20)
            Me.groupBox2.Controls.Add(Me.rbCubedRateRight)
            Me.groupBox2.Controls.Add(Me.rbSquaredRateRight)
            Me.groupBox2.Controls.Add(Me.rbLinearRateRight)
            Me.groupBox2.Location = New System.Drawing.Point(695, 129)
            Me.groupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupBox2.Size = New System.Drawing.Size(279, 299)
            Me.groupBox2.TabIndex = 3
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Velocity Rate (Right stick)"
            Me.toolTip1.SetToolTip(Me.groupBox2, "Select the Velocity sensitivity rate for the right stick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "movement.  Linear is le" &
        "ast sensitive, Cubed is most " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensitive at low speed.")
            '
            'cbMixAxisJogRS
            '
            Me.cbMixAxisJogRS.AutoSize = True
            Me.cbMixAxisJogRS.Location = New System.Drawing.Point(5, 160)
            Me.cbMixAxisJogRS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.cbMixAxisJogRS.Name = "cbMixAxisJogRS"
            Me.cbMixAxisJogRS.Size = New System.Drawing.Size(197, 21)
            Me.cbMixAxisJogRS.TabIndex = 3
            Me.cbMixAxisJogRS.Text = "Allowed mixed axis velocity"
            Me.toolTip1.SetToolTip(Me.cbMixAxisJogRS, "Allow Jogging in both axis defined for a stick at same time " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(i.e., combined X &" &
        " Y movement allowed if enabled).")
            Me.cbMixAxisJogRS.UseVisualStyleBackColor = True
            '
            'cbRSMaxVel
            '
            Me.cbRSMaxVel.AutoSize = True
            Me.cbRSMaxVel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbRSMaxVel.Location = New System.Drawing.Point(5, 188)
            Me.cbRSMaxVel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.cbRSMaxVel.Name = "cbRSMaxVel"
            Me.cbRSMaxVel.Size = New System.Drawing.Size(183, 22)
            Me.cbRSMaxVel.TabIndex = 4
            Me.cbRSMaxVel.Text = "Use Max Vel. Setpoints"
            Me.cbRSMaxVel.UseVisualStyleBackColor = True
            '
            'nudMaxVelRSV
            '
            Me.nudMaxVelRSV.ImeMode = System.Windows.Forms.ImeMode.[On]
            Me.nudMaxVelRSV.InterceptArrowKeys = False
            Me.nudMaxVelRSV.Location = New System.Drawing.Point(177, 241)
            Me.nudMaxVelRSV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.nudMaxVelRSV.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudMaxVelRSV.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudMaxVelRSV.Name = "nudMaxVelRSV"
            Me.nudMaxVelRSV.Size = New System.Drawing.Size(88, 22)
            Me.nudMaxVelRSV.TabIndex = 49
            Me.toolTip1.SetToolTip(Me.nudMaxVelRSV, resources.GetString("nudMaxVelRSV.ToolTip"))
            Me.nudMaxVelRSV.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label47
            '
            Me.label47.AutoSize = True
            Me.label47.Location = New System.Drawing.Point(15, 246)
            Me.label47.Name = "label47"
            Me.label47.Size = New System.Drawing.Size(150, 17)
            Me.label47.TabIndex = 6
            Me.label47.Text = "Max Vel Right Stick - Y"
            '
            'label43
            '
            Me.label43.AutoSize = True
            Me.label43.Location = New System.Drawing.Point(148, 22)
            Me.label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label43.Name = "label43"
            Me.label43.Size = New System.Drawing.Size(17, 17)
            Me.label43.TabIndex = 48
            Me.label43.Text = "X"
            '
            'label44
            '
            Me.label44.AutoSize = True
            Me.label44.Location = New System.Drawing.Point(216, 22)
            Me.label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label44.Name = "label44"
            Me.label44.Size = New System.Drawing.Size(17, 17)
            Me.label44.TabIndex = 47
            Me.label44.Text = "Y"
            '
            'label45
            '
            Me.label45.AutoSize = True
            Me.label45.Location = New System.Drawing.Point(12, 44)
            Me.label45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label45.Name = "label45"
            Me.label45.Size = New System.Drawing.Size(111, 17)
            Me.label45.TabIndex = 46
            Me.label45.Text = "RIght Deadband"
            '
            'nudRYdeadband
            '
            Me.nudRYdeadband.DecimalPlaces = 2
            Me.nudRYdeadband.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudRYdeadband.InterceptArrowKeys = False
            Me.nudRYdeadband.Location = New System.Drawing.Point(199, 41)
            Me.nudRYdeadband.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.nudRYdeadband.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
            Me.nudRYdeadband.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudRYdeadband.Name = "nudRYdeadband"
            Me.nudRYdeadband.Size = New System.Drawing.Size(61, 22)
            Me.nudRYdeadband.TabIndex = 45
            Me.nudRYdeadband.Value = New Decimal(New Integer() {2, 0, 0, 131072})
            '
            'nudRXdeadband
            '
            Me.nudRXdeadband.DecimalPlaces = 2
            Me.nudRXdeadband.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudRXdeadband.InterceptArrowKeys = False
            Me.nudRXdeadband.Location = New System.Drawing.Point(132, 41)
            Me.nudRXdeadband.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.nudRXdeadband.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
            Me.nudRXdeadband.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudRXdeadband.Name = "nudRXdeadband"
            Me.nudRXdeadband.Size = New System.Drawing.Size(61, 22)
            Me.nudRXdeadband.TabIndex = 44
            Me.nudRXdeadband.Value = New Decimal(New Integer() {2, 0, 0, 131072})
            '
            'nudMaxVelRSH
            '
            Me.nudMaxVelRSH.ImeMode = System.Windows.Forms.ImeMode.[On]
            Me.nudMaxVelRSH.InterceptArrowKeys = False
            Me.nudMaxVelRSH.Location = New System.Drawing.Point(177, 214)
            Me.nudMaxVelRSH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.nudMaxVelRSH.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudMaxVelRSH.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudMaxVelRSH.Name = "nudMaxVelRSH"
            Me.nudMaxVelRSH.Size = New System.Drawing.Size(88, 22)
            Me.nudMaxVelRSH.TabIndex = 40
            Me.toolTip1.SetToolTip(Me.nudMaxVelRSH, resources.GetString("nudMaxVelRSH.ToolTip"))
            Me.nudMaxVelRSH.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label40
            '
            Me.label40.AutoSize = True
            Me.label40.Location = New System.Drawing.Point(16, 219)
            Me.label40.Name = "label40"
            Me.label40.Size = New System.Drawing.Size(150, 17)
            Me.label40.TabIndex = 5
            Me.label40.Text = "Max Vel Right Stick - X"
            '
            'label20
            '
            Me.label20.AutoSize = True
            Me.label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label20.Location = New System.Drawing.Point(47, 270)
            Me.label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(168, 20)
            Me.label20.TabIndex = 38
            Me.label20.Text = "Right Stick calc Feed"
            Me.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'rbCubedRateRight
            '
            Me.rbCubedRateRight.AutoSize = True
            Me.rbCubedRateRight.Location = New System.Drawing.Point(15, 126)
            Me.rbCubedRateRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.rbCubedRateRight.Name = "rbCubedRateRight"
            Me.rbCubedRateRight.Size = New System.Drawing.Size(173, 21)
            Me.rbCubedRateRight.TabIndex = 2
            Me.rbCubedRateRight.Text = "Cubed (most sensitive)"
            Me.rbCubedRateRight.UseVisualStyleBackColor = True
            '
            'rbSquaredRateRight
            '
            Me.rbSquaredRateRight.AutoSize = True
            Me.rbSquaredRateRight.Location = New System.Drawing.Point(15, 97)
            Me.rbSquaredRateRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.rbSquaredRateRight.Name = "rbSquaredRateRight"
            Me.rbSquaredRateRight.Size = New System.Drawing.Size(188, 21)
            Me.rbSquaredRateRight.TabIndex = 1
            Me.rbSquaredRateRight.Text = "Squared (more sensitive)"
            Me.rbSquaredRateRight.UseVisualStyleBackColor = True
            '
            'rbLinearRateRight
            '
            Me.rbLinearRateRight.AutoSize = True
            Me.rbLinearRateRight.Checked = True
            Me.rbLinearRateRight.Location = New System.Drawing.Point(15, 68)
            Me.rbLinearRateRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.rbLinearRateRight.Name = "rbLinearRateRight"
            Me.rbLinearRateRight.Size = New System.Drawing.Size(69, 21)
            Me.rbLinearRateRight.TabIndex = 0
            Me.rbLinearRateRight.TabStop = True
            Me.rbLinearRateRight.Text = "Linear"
            Me.rbLinearRateRight.UseVisualStyleBackColor = True
            '
            'groupboxJogStep
            '
            Me.groupboxJogStep.Controls.Add(Me.cbJogStepNotify)
            Me.groupboxJogStep.Controls.Add(Me.cbJSTrigEnab)
            Me.groupboxJogStep.Controls.Add(Me.label37)
            Me.groupboxJogStep.Controls.Add(Me.jog4)
            Me.groupboxJogStep.Controls.Add(Me.label36)
            Me.groupboxJogStep.Controls.Add(Me.jog3)
            Me.groupboxJogStep.Controls.Add(Me.label35)
            Me.groupboxJogStep.Controls.Add(Me.jog2)
            Me.groupboxJogStep.Controls.Add(Me.label34)
            Me.groupboxJogStep.Controls.Add(Me.jog1)
            Me.groupboxJogStep.Controls.Add(Me.checkBox4)
            Me.groupboxJogStep.Location = New System.Drawing.Point(695, 441)
            Me.groupboxJogStep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupboxJogStep.Name = "groupboxJogStep"
            Me.groupboxJogStep.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupboxJogStep.Size = New System.Drawing.Size(251, 263)
            Me.groupboxJogStep.TabIndex = 5
            Me.groupboxJogStep.TabStop = False
            Me.groupboxJogStep.Text = "Jog Step Selection"
            Me.toolTip1.SetToolTip(Me.groupboxJogStep, resources.GetString("groupboxJogStep.ToolTip"))
            '
            'cbJogStepNotify
            '
            Me.cbJogStepNotify.AutoSize = True
            Me.cbJogStepNotify.Location = New System.Drawing.Point(44, 225)
            Me.cbJogStepNotify.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.cbJogStepNotify.Name = "cbJogStepNotify"
            Me.cbJogStepNotify.Size = New System.Drawing.Size(199, 21)
            Me.cbJogStepNotify.TabIndex = 81
            Me.cbJogStepNotify.Text = "Display selct. on NotifyIcon"
            Me.toolTip1.SetToolTip(Me.cbJogStepNotify, resources.GetString("cbJogStepNotify.ToolTip"))
            Me.cbJogStepNotify.UseVisualStyleBackColor = True
            '
            'cbJSTrigEnab
            '
            Me.cbJSTrigEnab.AutoSize = True
            Me.cbJSTrigEnab.Location = New System.Drawing.Point(21, 25)
            Me.cbJSTrigEnab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.cbJSTrigEnab.Name = "cbJSTrigEnab"
            Me.cbJSTrigEnab.Size = New System.Drawing.Size(193, 38)
            Me.cbJSTrigEnab.TabIndex = 80
            Me.cbJSTrigEnab.Text = "Require Trigger to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "enable Jog Step selection"
            Me.toolTip1.SetToolTip(Me.cbJSTrigEnab, resources.GetString("cbJSTrigEnab.ToolTip"))
            Me.cbJSTrigEnab.UseVisualStyleBackColor = True
            '
            'label37
            '
            Me.label37.AutoSize = True
            Me.label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label37.Location = New System.Drawing.Point(115, 167)
            Me.label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label37.Name = "label37"
            Me.label37.Size = New System.Drawing.Size(89, 20)
            Me.label37.TabIndex = 3
            Me.label37.Text = "Jog Step 4"
            Me.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'jog4
            '
            Me.jog4.FormattingEnabled = True
            Me.jog4.Items.AddRange(New Object() {".001", ".002", ".005", ".010", ".020", ".050", ".100", ".250", ".500", "1.000"})
            Me.jog4.Location = New System.Drawing.Point(23, 167)
            Me.jog4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.jog4.Name = "jog4"
            Me.jog4.Size = New System.Drawing.Size(84, 24)
            Me.jog4.TabIndex = 79
            Me.toolTip1.SetToolTip(Me.jog4, "Leave blank for default step size of 1.000, or enter a custom step size." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is" &
        " selected by pushing the Right stick X-axis full right." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'label36
            '
            Me.label36.AutoSize = True
            Me.label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label36.Location = New System.Drawing.Point(115, 135)
            Me.label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label36.Name = "label36"
            Me.label36.Size = New System.Drawing.Size(89, 20)
            Me.label36.TabIndex = 2
            Me.label36.Text = "Jog Step 3"
            Me.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'jog3
            '
            Me.jog3.FormattingEnabled = True
            Me.jog3.Items.AddRange(New Object() {".001", ".002", ".005", ".010", ".020", ".050", ".100", ".250", ".500", "1.000"})
            Me.jog3.Location = New System.Drawing.Point(23, 135)
            Me.jog3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.jog3.Name = "jog3"
            Me.jog3.Size = New System.Drawing.Size(84, 24)
            Me.jog3.TabIndex = 77
            Me.toolTip1.SetToolTip(Me.jog3, "Leave blank for default step size of .100, or enter a custom step size." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is " &
        "selected by pushing the Right stick X-axis half right." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'label35
            '
            Me.label35.AutoSize = True
            Me.label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label35.Location = New System.Drawing.Point(115, 106)
            Me.label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label35.Name = "label35"
            Me.label35.Size = New System.Drawing.Size(89, 20)
            Me.label35.TabIndex = 1
            Me.label35.Text = "Jog Step 2"
            Me.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'jog2
            '
            Me.jog2.FormattingEnabled = True
            Me.jog2.Items.AddRange(New Object() {".001", ".002", ".005", ".010", ".020", ".050", ".100", ".250", ".500", "1.000"})
            Me.jog2.Location = New System.Drawing.Point(23, 106)
            Me.jog2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.jog2.Name = "jog2"
            Me.jog2.Size = New System.Drawing.Size(84, 24)
            Me.jog2.TabIndex = 75
            Me.toolTip1.SetToolTip(Me.jog2, "Leave blank for default step size of .010, or enter a custom step size." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is " &
        "selected by pushing the Right stick X-axis half left." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'label34
            '
            Me.label34.AutoSize = True
            Me.label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label34.Location = New System.Drawing.Point(115, 74)
            Me.label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label34.Name = "label34"
            Me.label34.Size = New System.Drawing.Size(89, 20)
            Me.label34.TabIndex = 0
            Me.label34.Text = "Jog Step 1"
            Me.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'jog1
            '
            Me.jog1.FormattingEnabled = True
            Me.jog1.Items.AddRange(New Object() {".001", ".002", ".005", ".010", ".020", ".050", ".100", ".250", ".500", "1.000"})
            Me.jog1.Location = New System.Drawing.Point(23, 74)
            Me.jog1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.jog1.Name = "jog1"
            Me.jog1.Size = New System.Drawing.Size(84, 24)
            Me.jog1.TabIndex = 73
            Me.toolTip1.SetToolTip(Me.jog1, "Leave blank for default step size of .001, or enter a custom step size." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is " &
        "selected by pushing the Right stick X-axis full left.")
            '
            'checkBox4
            '
            Me.checkBox4.AutoSize = True
            Me.checkBox4.Location = New System.Drawing.Point(44, 199)
            Me.checkBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(189, 21)
            Me.checkBox4.TabIndex = 38
            Me.checkBox4.Text = "Vibrate step jog selection"
            Me.toolTip1.SetToolTip(Me.checkBox4, resources.GetString("checkBox4.ToolTip"))
            Me.checkBox4.UseVisualStyleBackColor = True
            '
            'tabControl1
            '
            Me.tabControl1.Controls.Add(Me.tabPage1)
            Me.tabControl1.Controls.Add(Me.tabPage2)
            Me.tabControl1.Controls.Add(Me.tabPage3)
            Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabControl1.Location = New System.Drawing.Point(0, 0)
            Me.tabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.tabControl1.Name = "tabControl1"
            Me.tabControl1.SelectedIndex = 0
            Me.tabControl1.Size = New System.Drawing.Size(992, 924)
            Me.tabControl1.TabIndex = 51
            '
            'tabPage1
            '
            Me.tabPage1.Controls.Add(Me.btnConfigForm)
            Me.tabPage1.Controls.Add(Me.cbSaveSettings)
            Me.tabPage1.Controls.Add(Me.groupBoxDPad)
            Me.tabPage1.Controls.Add(Me.cbAutoEnable)
            Me.tabPage1.Controls.Add(Me.cbMinimizeOnLoad)
            Me.tabPage1.Controls.Add(Me.cbErrMsg)
            Me.tabPage1.Controls.Add(Me.cbRightStickEnab)
            Me.tabPage1.Controls.Add(Me.cbLeftStickEnab)
            Me.tabPage1.Controls.Add(Me.btnLoadSettings)
            Me.tabPage1.Controls.Add(Me.groupBox8)
            Me.tabPage1.Controls.Add(Me.groupboxJogStep)
            Me.tabPage1.Controls.Add(Me.groupBox6)
            Me.tabPage1.Controls.Add(Me.btnShowCodes)
            Me.tabPage1.Controls.Add(Me.groupBox3)
            Me.tabPage1.Controls.Add(Me.cbEnableMain)
            Me.tabPage1.Controls.Add(Me.btnSaveSettings)
            Me.tabPage1.Controls.Add(Me.groupBox1)
            Me.tabPage1.Controls.Add(Me.groupBox2)
            Me.tabPage1.Controls.Add(Me.btnConnect)
            Me.tabPage1.Location = New System.Drawing.Point(4, 25)
            Me.tabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.tabPage1.Name = "tabPage1"
            Me.tabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.tabPage1.Size = New System.Drawing.Size(984, 895)
            Me.tabPage1.TabIndex = 0
            Me.tabPage1.Text = "Controls"
            Me.tabPage1.UseVisualStyleBackColor = True
            '
            'btnConfigForm
            '
            Me.btnConfigForm.Location = New System.Drawing.Point(295, 838)
            Me.btnConfigForm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnConfigForm.Name = "btnConfigForm"
            Me.btnConfigForm.Size = New System.Drawing.Size(208, 30)
            Me.btnConfigForm.TabIndex = 78
            Me.btnConfigForm.Text = "Config 'Open'  Button Code "
            Me.toolTip1.SetToolTip(Me.btnConfigForm, resources.GetString("btnConfigForm.ToolTip"))
            Me.btnConfigForm.UseVisualStyleBackColor = True
            '
            'cbSaveSettings
            '
            Me.cbSaveSettings.AutoSize = True
            Me.cbSaveSettings.Location = New System.Drawing.Point(21, 839)
            Me.cbSaveSettings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.cbSaveSettings.Name = "cbSaveSettings"
            Me.cbSaveSettings.Size = New System.Drawing.Size(199, 21)
            Me.cbSaveSettings.TabIndex = 77
            Me.cbSaveSettings.Text = "Save settings on shutdown"
            Me.toolTip1.SetToolTip(Me.cbSaveSettings, "Try to enable jog on load " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Fails if controler not found)")
            Me.cbSaveSettings.UseVisualStyleBackColor = True
            '
            'groupBoxDPad
            '
            Me.groupBoxDPad.Controls.Add(Me.comboLRShoulder)
            Me.groupBoxDPad.Controls.Add(Me.comboUDDpad)
            Me.groupBoxDPad.Controls.Add(Me.comboLRDpad)
            Me.groupBoxDPad.Controls.Add(Me.Label38)
            Me.groupBoxDPad.Controls.Add(Me.Label49)
            Me.groupBoxDPad.Controls.Add(Me.Label50)
            Me.groupBoxDPad.Controls.Add(Me.GroupBox5)
            Me.groupBoxDPad.Location = New System.Drawing.Point(423, 610)
            Me.groupBoxDPad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupBoxDPad.Name = "groupBoxDPad"
            Me.groupBoxDPad.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupBoxDPad.Size = New System.Drawing.Size(264, 134)
            Me.groupBoxDPad.TabIndex = 76
            Me.groupBoxDPad.TabStop = False
            Me.groupBoxDPad.Text = "DPad/Shoulder Step Jog Assignment"
            Me.toolTip1.SetToolTip(Me.groupBoxDPad, "This section is for assignment of the joysticks analog inputs to specific axis fu" &
        "nctions in UCCNC." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The right X axis may be used as a 'jog step' selector or an" &
        " axis assignment.")
            '
            'comboLRShoulder
            '
            Me.comboLRShoulder.FormattingEnabled = True
            Me.comboLRShoulder.Items.AddRange(New Object() {"Xaxis", "Yaxis", "Zaxis", "Aaxis", "Baxis", "Caxis", "Rev_Xaxis", "Rev_Yaxis", "Rev_Zaxis", "Rev_Aaxis", "Rev_Baxis", "Rev_Caxis"})
            Me.comboLRShoulder.Location = New System.Drawing.Point(141, 27)
            Me.comboLRShoulder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboLRShoulder.Name = "comboLRShoulder"
            Me.comboLRShoulder.Size = New System.Drawing.Size(115, 24)
            Me.comboLRShoulder.TabIndex = 3
            '
            'comboUDDpad
            '
            Me.comboUDDpad.FormattingEnabled = True
            Me.comboUDDpad.Items.AddRange(New Object() {"Xaxis", "Yaxis", "Zaxis", "Aaxis", "Baxis", "Caxis", "Rev_Xaxis", "Rev_Yaxis", "Rev_Zaxis", "Rev_Aaxis", "Rev_Baxis", "Rev_Caxis"})
            Me.comboUDDpad.Location = New System.Drawing.Point(141, 59)
            Me.comboUDDpad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboUDDpad.Name = "comboUDDpad"
            Me.comboUDDpad.Size = New System.Drawing.Size(115, 24)
            Me.comboUDDpad.TabIndex = 1
            '
            'comboLRDpad
            '
            Me.comboLRDpad.FormattingEnabled = True
            Me.comboLRDpad.Items.AddRange(New Object() {"Xaxis", "Yaxis", "Zaxis", "Aaxis", "Baxis", "Caxis", "Rev_Xaxis", "Rev_Yaxis", "Rev_Zaxis", "Rev_Aaxis", "Rev_Baxis", "Rev_Caxis"})
            Me.comboLRDpad.Location = New System.Drawing.Point(141, 91)
            Me.comboLRDpad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboLRDpad.Name = "comboLRDpad"
            Me.comboLRDpad.Size = New System.Drawing.Size(115, 24)
            Me.comboLRDpad.TabIndex = 0
            '
            'Label38
            '
            Me.Label38.AutoSize = True
            Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.Label38.Location = New System.Drawing.Point(13, 30)
            Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(116, 20)
            Me.Label38.TabIndex = 75
            Me.Label38.Text = "L/R Shoulders"
            Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label49
            '
            Me.Label49.AutoSize = True
            Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.Label49.Location = New System.Drawing.Point(13, 62)
            Me.Label49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(86, 20)
            Me.Label49.TabIndex = 73
            Me.Label49.Text = "U/D DPad"
            Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label50
            '
            Me.Label50.AutoSize = True
            Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.Label50.Location = New System.Drawing.Point(15, 94)
            Me.Label50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New System.Drawing.Size(83, 20)
            Me.Label50.TabIndex = 72
            Me.Label50.Text = "L/R DPad"
            Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.RadioButton16)
            Me.GroupBox5.Controls.Add(Me.RadioButton17)
            Me.GroupBox5.Controls.Add(Me.RadioButton18)
            Me.GroupBox5.Location = New System.Drawing.Point(3, 321)
            Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.GroupBox5.Size = New System.Drawing.Size(245, 116)
            Me.GroupBox5.TabIndex = 62
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Trigger Assignment"
            Me.toolTip1.SetToolTip(Me.GroupBox5, "Select the Velocity sensitivity rate for the left stick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "movement.  Linear is lea" &
        "st sensitive, Cubed is most " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensitive at low speed.")
            '
            'RadioButton16
            '
            Me.RadioButton16.AutoSize = True
            Me.RadioButton16.Location = New System.Drawing.Point(20, 28)
            Me.RadioButton16.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.RadioButton16.Name = "RadioButton16"
            Me.RadioButton16.Size = New System.Drawing.Size(172, 21)
            Me.RadioButton16.TabIndex = 31
            Me.RadioButton16.Text = "Double Trigger Enable"
            Me.RadioButton16.UseVisualStyleBackColor = True
            '
            'RadioButton17
            '
            Me.RadioButton17.AutoSize = True
            Me.RadioButton17.Location = New System.Drawing.Point(20, 52)
            Me.RadioButton17.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.RadioButton17.Name = "RadioButton17"
            Me.RadioButton17.Size = New System.Drawing.Size(166, 21)
            Me.RadioButton17.TabIndex = 30
            Me.RadioButton17.Text = "Single Trigger Enable"
            Me.RadioButton17.UseVisualStyleBackColor = True
            '
            'RadioButton18
            '
            Me.RadioButton18.AutoSize = True
            Me.RadioButton18.Checked = True
            Me.RadioButton18.Location = New System.Drawing.Point(20, 79)
            Me.RadioButton18.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.RadioButton18.Name = "RadioButton18"
            Me.RadioButton18.Size = New System.Drawing.Size(217, 21)
            Me.RadioButton18.TabIndex = 29
            Me.RadioButton18.TabStop = True
            Me.RadioButton18.Text = "Triggers as Velocity Increaser"
            Me.RadioButton18.UseVisualStyleBackColor = True
            '
            'cbAutoEnable
            '
            Me.cbAutoEnable.AutoSize = True
            Me.cbAutoEnable.Location = New System.Drawing.Point(21, 816)
            Me.cbAutoEnable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.cbAutoEnable.Name = "cbAutoEnable"
            Me.cbAutoEnable.Size = New System.Drawing.Size(244, 21)
            Me.cbAutoEnable.TabIndex = 16
            Me.cbAutoEnable.Text = "Automatically Enable Jog on Load"
            Me.toolTip1.SetToolTip(Me.cbAutoEnable, "Try to enable jog on load " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Fails if controler not found)")
            Me.cbAutoEnable.UseVisualStyleBackColor = True
            '
            'cbMinimizeOnLoad
            '
            Me.cbMinimizeOnLoad.AutoSize = True
            Me.cbMinimizeOnLoad.Location = New System.Drawing.Point(21, 793)
            Me.cbMinimizeOnLoad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.cbMinimizeOnLoad.Name = "cbMinimizeOnLoad"
            Me.cbMinimizeOnLoad.Size = New System.Drawing.Size(202, 21)
            Me.cbMinimizeOnLoad.TabIndex = 15
            Me.cbMinimizeOnLoad.Text = "Automatically Hide on Load"
            Me.toolTip1.SetToolTip(Me.cbMinimizeOnLoad, "Hide plugin form on load")
            Me.cbMinimizeOnLoad.UseVisualStyleBackColor = True
            '
            'cbErrMsg
            '
            Me.cbErrMsg.AutoSize = True
            Me.cbErrMsg.Location = New System.Drawing.Point(21, 770)
            Me.cbErrMsg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.cbErrMsg.Name = "cbErrMsg"
            Me.cbErrMsg.Size = New System.Drawing.Size(192, 21)
            Me.cbErrMsg.TabIndex = 14
            Me.cbErrMsg.Text = "Show messages/warnings"
            Me.toolTip1.SetToolTip(Me.cbErrMsg, "Use to suppress messages")
            Me.cbErrMsg.UseVisualStyleBackColor = True
            '
            'cbRightStickEnab
            '
            Me.cbRightStickEnab.AutoSize = True
            Me.cbRightStickEnab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbRightStickEnab.Location = New System.Drawing.Point(707, 821)
            Me.cbRightStickEnab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.cbRightStickEnab.Name = "cbRightStickEnab"
            Me.cbRightStickEnab.Size = New System.Drawing.Size(186, 24)
            Me.cbRightStickEnab.TabIndex = 11
            Me.cbRightStickEnab.Text = "Enable Right Stick"
            Me.cbRightStickEnab.UseVisualStyleBackColor = True
            '
            'cbLeftStickEnab
            '
            Me.cbLeftStickEnab.AutoSize = True
            Me.cbLeftStickEnab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbLeftStickEnab.Location = New System.Drawing.Point(707, 795)
            Me.cbLeftStickEnab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.cbLeftStickEnab.Name = "cbLeftStickEnab"
            Me.cbLeftStickEnab.Size = New System.Drawing.Size(175, 24)
            Me.cbLeftStickEnab.TabIndex = 10
            Me.cbLeftStickEnab.Text = "Enable Left Stick"
            Me.cbLeftStickEnab.UseVisualStyleBackColor = True
            '
            'btnLoadSettings
            '
            Me.btnLoadSettings.Location = New System.Drawing.Point(295, 805)
            Me.btnLoadSettings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnLoadSettings.Name = "btnLoadSettings"
            Me.btnLoadSettings.Size = New System.Drawing.Size(209, 30)
            Me.btnLoadSettings.TabIndex = 8
            Me.btnLoadSettings.Text = "Load Settings"
            Me.toolTip1.SetToolTip(Me.btnLoadSettings, "Force Load XML file ")
            Me.btnLoadSettings.UseVisualStyleBackColor = True
            '
            'groupBox8
            '
            Me.groupBox8.Controls.Add(Me.comboBoxRYStick)
            Me.groupBox8.Controls.Add(Me.comboBoxRXStick)
            Me.groupBox8.Controls.Add(Me.comboBoxLYStick)
            Me.groupBox8.Controls.Add(Me.comboBoxLXStick)
            Me.groupBox8.Controls.Add(Me.label32)
            Me.groupBox8.Controls.Add(Me.label33)
            Me.groupBox8.Controls.Add(Me.label31)
            Me.groupBox8.Controls.Add(Me.label30)
            Me.groupBox8.Controls.Add(Me.groupBox9)
            Me.groupBox8.Location = New System.Drawing.Point(423, 441)
            Me.groupBox8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupBox8.Name = "groupBox8"
            Me.groupBox8.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupBox8.Size = New System.Drawing.Size(264, 162)
            Me.groupBox8.TabIndex = 4
            Me.groupBox8.TabStop = False
            Me.groupBox8.Text = "Stick Assignment"
            Me.toolTip1.SetToolTip(Me.groupBox8, "This section is for assignment of the joysticks analog inputs to specific axis fu" &
        "nctions in UCCNC." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The right X axis may be used as a 'jog step' selector or an" &
        " axis assignment.")
            '
            'comboBoxRYStick
            '
            Me.comboBoxRYStick.FormattingEnabled = True
            Me.comboBoxRYStick.Items.AddRange(New Object() {"Xaxis", "Yaxis", "Zaxis", "Aaxis", "Baxis", "Caxis", "Rev_Xaxis", "Rev_Yaxis", "Rev_Zaxis", "Rev_Aaxis", "Rev_Baxis", "Rev_Caxis"})
            Me.comboBoxRYStick.Location = New System.Drawing.Point(140, 122)
            Me.comboBoxRYStick.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBoxRYStick.Name = "comboBoxRYStick"
            Me.comboBoxRYStick.Size = New System.Drawing.Size(116, 24)
            Me.comboBoxRYStick.TabIndex = 3
            '
            'comboBoxRXStick
            '
            Me.comboBoxRXStick.FormattingEnabled = True
            Me.comboBoxRXStick.Items.AddRange(New Object() {"Xaxis", "Yaxis", "Zaxis", "Aaxis", "Baxis", "Caxis", "Rev_Xaxis", "Rev_Yaxis", "Rev_Zaxis", "Rev_Aaxis", "Rev_Baxis", "Rev_Caxis", "JogStep"})
            Me.comboBoxRXStick.Location = New System.Drawing.Point(140, 90)
            Me.comboBoxRXStick.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBoxRXStick.Name = "comboBoxRXStick"
            Me.comboBoxRXStick.Size = New System.Drawing.Size(116, 24)
            Me.comboBoxRXStick.TabIndex = 2
            Me.toolTip1.SetToolTip(Me.comboBoxRXStick, "Assign either an axis control, or Jog Step Size " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "selection")
            '
            'comboBoxLYStick
            '
            Me.comboBoxLYStick.FormattingEnabled = True
            Me.comboBoxLYStick.Items.AddRange(New Object() {"Xaxis", "Yaxis", "Zaxis", "Aaxis", "Baxis", "Caxis", "Rev_Xaxis", "Rev_Yaxis", "Rev_Zaxis", "Rev_Aaxis", "Rev_Baxis", "Rev_Caxis"})
            Me.comboBoxLYStick.Location = New System.Drawing.Point(140, 59)
            Me.comboBoxLYStick.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBoxLYStick.Name = "comboBoxLYStick"
            Me.comboBoxLYStick.Size = New System.Drawing.Size(116, 24)
            Me.comboBoxLYStick.TabIndex = 1
            '
            'comboBoxLXStick
            '
            Me.comboBoxLXStick.FormattingEnabled = True
            Me.comboBoxLXStick.Items.AddRange(New Object() {"Xaxis", "Yaxis", "Zaxis", "Aaxis", "Baxis", "Caxis", "Rev_Xaxis", "Rev_Yaxis", "Rev_Zaxis", "Rev_Aaxis", "Rev_Baxis", "Rev_Caxis"})
            Me.comboBoxLXStick.Location = New System.Drawing.Point(140, 28)
            Me.comboBoxLXStick.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBoxLXStick.Name = "comboBoxLXStick"
            Me.comboBoxLXStick.Size = New System.Drawing.Size(116, 24)
            Me.comboBoxLXStick.TabIndex = 0
            '
            'label32
            '
            Me.label32.AutoSize = True
            Me.label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label32.Location = New System.Drawing.Point(15, 122)
            Me.label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label32.Name = "label32"
            Me.label32.Size = New System.Drawing.Size(100, 20)
            Me.label32.TabIndex = 75
            Me.label32.Text = "RIght Y Axis"
            Me.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label33
            '
            Me.label33.AutoSize = True
            Me.label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label33.Location = New System.Drawing.Point(15, 92)
            Me.label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label33.Name = "label33"
            Me.label33.Size = New System.Drawing.Size(101, 20)
            Me.label33.TabIndex = 74
            Me.label33.Text = "RIght X Axis"
            Me.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label31
            '
            Me.label31.AutoSize = True
            Me.label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label31.Location = New System.Drawing.Point(13, 62)
            Me.label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label31.Name = "label31"
            Me.label31.Size = New System.Drawing.Size(90, 20)
            Me.label31.TabIndex = 73
            Me.label31.Text = "Left Y Axis"
            Me.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label30
            '
            Me.label30.AutoSize = True
            Me.label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label30.Location = New System.Drawing.Point(15, 31)
            Me.label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label30.Name = "label30"
            Me.label30.Size = New System.Drawing.Size(91, 20)
            Me.label30.TabIndex = 72
            Me.label30.Text = "Left X Axis"
            Me.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'groupBox9
            '
            Me.groupBox9.Controls.Add(Me.radioButton13)
            Me.groupBox9.Controls.Add(Me.radioButton14)
            Me.groupBox9.Controls.Add(Me.radioButton15)
            Me.groupBox9.Location = New System.Drawing.Point(3, 321)
            Me.groupBox9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupBox9.Name = "groupBox9"
            Me.groupBox9.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupBox9.Size = New System.Drawing.Size(245, 116)
            Me.groupBox9.TabIndex = 62
            Me.groupBox9.TabStop = False
            Me.groupBox9.Text = "Trigger Assignment"
            Me.toolTip1.SetToolTip(Me.groupBox9, "Select the Velocity sensitivity rate for the left stick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "movement.  Linear is lea" &
        "st sensitive, Cubed is most " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensitive at low speed.")
            '
            'radioButton13
            '
            Me.radioButton13.AutoSize = True
            Me.radioButton13.Location = New System.Drawing.Point(20, 28)
            Me.radioButton13.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.radioButton13.Name = "radioButton13"
            Me.radioButton13.Size = New System.Drawing.Size(172, 21)
            Me.radioButton13.TabIndex = 31
            Me.radioButton13.Text = "Double Trigger Enable"
            Me.radioButton13.UseVisualStyleBackColor = True
            '
            'radioButton14
            '
            Me.radioButton14.AutoSize = True
            Me.radioButton14.Location = New System.Drawing.Point(20, 52)
            Me.radioButton14.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.radioButton14.Name = "radioButton14"
            Me.radioButton14.Size = New System.Drawing.Size(166, 21)
            Me.radioButton14.TabIndex = 30
            Me.radioButton14.Text = "Single Trigger Enable"
            Me.radioButton14.UseVisualStyleBackColor = True
            '
            'radioButton15
            '
            Me.radioButton15.AutoSize = True
            Me.radioButton15.Checked = True
            Me.radioButton15.Location = New System.Drawing.Point(20, 79)
            Me.radioButton15.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.radioButton15.Name = "radioButton15"
            Me.radioButton15.Size = New System.Drawing.Size(217, 21)
            Me.radioButton15.TabIndex = 29
            Me.radioButton15.TabStop = True
            Me.radioButton15.Text = "Triggers as Velocity Increaser"
            Me.radioButton15.UseVisualStyleBackColor = True
            '
            'groupBox6
            '
            Me.groupBox6.Controls.Add(Me.groupBox7)
            Me.groupBox6.Controls.Add(Me.rbDubTrigEnable)
            Me.groupBox6.Controls.Add(Me.rbSingTrigEnable)
            Me.groupBox6.Controls.Add(Me.rbVelTrigger)
            Me.groupBox6.Location = New System.Drawing.Point(597, 6)
            Me.groupBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupBox6.Name = "groupBox6"
            Me.groupBox6.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupBox6.Size = New System.Drawing.Size(245, 116)
            Me.groupBox6.TabIndex = 1
            Me.groupBox6.TabStop = False
            Me.groupBox6.Text = "Trigger Assignment"
            Me.toolTip1.SetToolTip(Me.groupBox6, "Select the Velocity sensitivity rate for the left stick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "movement.  Linear is lea" &
        "st sensitive, Cubed is most " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensitive at low speed.")
            '
            'groupBox7
            '
            Me.groupBox7.Controls.Add(Me.radioButton10)
            Me.groupBox7.Controls.Add(Me.radioButton11)
            Me.groupBox7.Controls.Add(Me.radioButton12)
            Me.groupBox7.Location = New System.Drawing.Point(3, 321)
            Me.groupBox7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupBox7.Name = "groupBox7"
            Me.groupBox7.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupBox7.Size = New System.Drawing.Size(245, 116)
            Me.groupBox7.TabIndex = 62
            Me.groupBox7.TabStop = False
            Me.groupBox7.Text = "Trigger Assignment"
            Me.toolTip1.SetToolTip(Me.groupBox7, "Select the Velocity sensitivity rate for the left stick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "movement.  Linear is lea" &
        "st sensitive, Cubed is most " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensitive at low speed.")
            '
            'radioButton10
            '
            Me.radioButton10.AutoSize = True
            Me.radioButton10.Location = New System.Drawing.Point(20, 28)
            Me.radioButton10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.radioButton10.Name = "radioButton10"
            Me.radioButton10.Size = New System.Drawing.Size(172, 21)
            Me.radioButton10.TabIndex = 31
            Me.radioButton10.Text = "Double Trigger Enable"
            Me.radioButton10.UseVisualStyleBackColor = True
            '
            'radioButton11
            '
            Me.radioButton11.AutoSize = True
            Me.radioButton11.Location = New System.Drawing.Point(20, 52)
            Me.radioButton11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.radioButton11.Name = "radioButton11"
            Me.radioButton11.Size = New System.Drawing.Size(166, 21)
            Me.radioButton11.TabIndex = 30
            Me.radioButton11.Text = "Single Trigger Enable"
            Me.radioButton11.UseVisualStyleBackColor = True
            '
            'radioButton12
            '
            Me.radioButton12.AutoSize = True
            Me.radioButton12.Checked = True
            Me.radioButton12.Location = New System.Drawing.Point(20, 79)
            Me.radioButton12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.radioButton12.Name = "radioButton12"
            Me.radioButton12.Size = New System.Drawing.Size(217, 21)
            Me.radioButton12.TabIndex = 29
            Me.radioButton12.TabStop = True
            Me.radioButton12.Text = "Triggers as Velocity Increaser"
            Me.radioButton12.UseVisualStyleBackColor = True
            '
            'rbDubTrigEnable
            '
            Me.rbDubTrigEnable.AutoSize = True
            Me.rbDubTrigEnable.Location = New System.Drawing.Point(20, 28)
            Me.rbDubTrigEnable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.rbDubTrigEnable.Name = "rbDubTrigEnable"
            Me.rbDubTrigEnable.Size = New System.Drawing.Size(172, 21)
            Me.rbDubTrigEnable.TabIndex = 31
            Me.rbDubTrigEnable.Text = "Double Trigger Enable"
            Me.toolTip1.SetToolTip(Me.rbDubTrigEnable, "Double Trigger Enable requires both triggers to be simultaneously" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "held down to a" &
        "llow jogging with either of the analog joysticks.")
            Me.rbDubTrigEnable.UseVisualStyleBackColor = True
            '
            'rbSingTrigEnable
            '
            Me.rbSingTrigEnable.AutoSize = True
            Me.rbSingTrigEnable.Location = New System.Drawing.Point(20, 52)
            Me.rbSingTrigEnable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.rbSingTrigEnable.Name = "rbSingTrigEnable"
            Me.rbSingTrigEnable.Size = New System.Drawing.Size(166, 21)
            Me.rbSingTrigEnable.TabIndex = 30
            Me.rbSingTrigEnable.Text = "Single Trigger Enable"
            Me.toolTip1.SetToolTip(Me.rbSingTrigEnable, "Single Trigger Enable requires either one of the triggers to be individually" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hel" &
        "d down to allow jogging with either of the analog joysticks." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            Me.rbSingTrigEnable.UseVisualStyleBackColor = True
            '
            'rbVelTrigger
            '
            Me.rbVelTrigger.AutoSize = True
            Me.rbVelTrigger.Checked = True
            Me.rbVelTrigger.Location = New System.Drawing.Point(20, 79)
            Me.rbVelTrigger.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.rbVelTrigger.Name = "rbVelTrigger"
            Me.rbVelTrigger.Size = New System.Drawing.Size(217, 21)
            Me.rbVelTrigger.TabIndex = 29
            Me.rbVelTrigger.TabStop = True
            Me.rbVelTrigger.Text = "Triggers as Velocity Increaser"
            Me.toolTip1.SetToolTip(Me.rbVelTrigger, resources.GetString("rbVelTrigger.ToolTip"))
            Me.rbVelTrigger.UseVisualStyleBackColor = True
            '
            'btnShowCodes
            '
            Me.btnShowCodes.Location = New System.Drawing.Point(441, 38)
            Me.btnShowCodes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnShowCodes.Name = "btnShowCodes"
            Me.btnShowCodes.Size = New System.Drawing.Size(133, 62)
            Me.btnShowCodes.TabIndex = 6
            Me.btnShowCodes.Text = "Show 'button codes' help file"
            Me.toolTip1.SetToolTip(Me.btnShowCodes, "This will open the UCCNC help file with the 'button' code" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "list.  Use the list to" &
        " reference what value to enter into the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "button function codes to activate a fu" &
        "nction." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            Me.btnShowCodes.UseVisualStyleBackColor = True
            '
            'groupBox3
            '
            Me.groupBox3.Controls.Add(Me.btnLED14)
            Me.groupBox3.Controls.Add(Me.btnLED10)
            Me.groupBox3.Controls.Add(Me.btnLED13)
            Me.groupBox3.Controls.Add(Me.btnLED9)
            Me.groupBox3.Controls.Add(Me.btnLED8)
            Me.groupBox3.Controls.Add(Me.btnLED7)
            Me.groupBox3.Controls.Add(Me.comboBox7)
            Me.groupBox3.Controls.Add(Me.comboBox8)
            Me.groupBox3.Controls.Add(Me.comboBox5)
            Me.groupBox3.Controls.Add(Me.comboBox6)
            Me.groupBox3.Controls.Add(Me.comboBox3)
            Me.groupBox3.Controls.Add(Me.comboBox4)
            Me.groupBox3.Controls.Add(Me.comboBox2)
            Me.groupBox3.Controls.Add(Me.comboBox1)
            Me.groupBox3.Controls.Add(Me.label22)
            Me.groupBox3.Controls.Add(Me.comboBox15)
            Me.groupBox3.Controls.Add(Me.label21)
            Me.groupBox3.Controls.Add(Me.comboBox16)
            Me.groupBox3.Controls.Add(Me.label10)
            Me.groupBox3.Controls.Add(Me.label9)
            Me.groupBox3.Controls.Add(Me.comboBox13)
            Me.groupBox3.Controls.Add(Me.label8)
            Me.groupBox3.Controls.Add(Me.label7)
            Me.groupBox3.Controls.Add(Me.comboBox14)
            Me.groupBox3.Controls.Add(Me.label6)
            Me.groupBox3.Controls.Add(Me.label5)
            Me.groupBox3.Controls.Add(Me.label13)
            Me.groupBox3.Controls.Add(Me.label14)
            Me.groupBox3.Controls.Add(Me.label4)
            Me.groupBox3.Controls.Add(Me.label3)
            Me.groupBox3.Controls.Add(Me.label2)
            Me.groupBox3.Controls.Add(Me.label1)
            Me.groupBox3.Controls.Add(Me.GroupBox4)
            Me.groupBox3.Location = New System.Drawing.Point(5, 6)
            Me.groupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.groupBox3.Size = New System.Drawing.Size(397, 758)
            Me.groupBox3.TabIndex = 12
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "Test Buttons Out"
            Me.toolTip1.SetToolTip(Me.groupBox3, resources.GetString("groupBox3.ToolTip"))
            '
            'btnLED14
            '
            Me.btnLED14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED14.Location = New System.Drawing.Point(16, 714)
            Me.btnLED14.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnLED14.Name = "btnLED14"
            Me.btnLED14.Size = New System.Drawing.Size(20, 18)
            Me.btnLED14.TabIndex = 86
            Me.btnLED14.UseVisualStyleBackColor = True
            '
            'btnLED10
            '
            Me.btnLED10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED10.Location = New System.Drawing.Point(16, 315)
            Me.btnLED10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnLED10.Name = "btnLED10"
            Me.btnLED10.Size = New System.Drawing.Size(20, 18)
            Me.btnLED10.TabIndex = 82
            Me.btnLED10.UseVisualStyleBackColor = True
            '
            'btnLED13
            '
            Me.btnLED13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED13.Location = New System.Drawing.Point(16, 672)
            Me.btnLED13.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnLED13.Name = "btnLED13"
            Me.btnLED13.Size = New System.Drawing.Size(20, 18)
            Me.btnLED13.TabIndex = 85
            Me.btnLED13.UseVisualStyleBackColor = True
            '
            'btnLED9
            '
            Me.btnLED9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED9.Location = New System.Drawing.Point(16, 270)
            Me.btnLED9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnLED9.Name = "btnLED9"
            Me.btnLED9.Size = New System.Drawing.Size(20, 18)
            Me.btnLED9.TabIndex = 81
            Me.btnLED9.UseVisualStyleBackColor = True
            '
            'btnLED8
            '
            Me.btnLED8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED8.Location = New System.Drawing.Point(16, 224)
            Me.btnLED8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnLED8.Name = "btnLED8"
            Me.btnLED8.Size = New System.Drawing.Size(20, 18)
            Me.btnLED8.TabIndex = 80
            Me.btnLED8.UseVisualStyleBackColor = True
            '
            'btnLED7
            '
            Me.btnLED7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED7.Location = New System.Drawing.Point(16, 182)
            Me.btnLED7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnLED7.Name = "btnLED7"
            Me.btnLED7.Size = New System.Drawing.Size(20, 18)
            Me.btnLED7.TabIndex = 79
            Me.btnLED7.UseVisualStyleBackColor = True
            '
            'comboBox7
            '
            Me.comboBox7.FormattingEnabled = True
            Me.comboBox7.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox7.Location = New System.Drawing.Point(289, 315)
            Me.comboBox7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox7.Name = "comboBox7"
            Me.comboBox7.Size = New System.Drawing.Size(84, 24)
            Me.comboBox7.TabIndex = 7
            '
            'comboBox8
            '
            Me.comboBox8.FormattingEnabled = True
            Me.comboBox8.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox8.Location = New System.Drawing.Point(173, 316)
            Me.comboBox8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox8.Name = "comboBox8"
            Me.comboBox8.Size = New System.Drawing.Size(84, 24)
            Me.comboBox8.TabIndex = 6
            '
            'comboBox5
            '
            Me.comboBox5.FormattingEnabled = True
            Me.comboBox5.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox5.Location = New System.Drawing.Point(289, 270)
            Me.comboBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox5.Name = "comboBox5"
            Me.comboBox5.Size = New System.Drawing.Size(84, 24)
            Me.comboBox5.TabIndex = 5
            '
            'comboBox6
            '
            Me.comboBox6.FormattingEnabled = True
            Me.comboBox6.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox6.Location = New System.Drawing.Point(173, 271)
            Me.comboBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox6.Name = "comboBox6"
            Me.comboBox6.Size = New System.Drawing.Size(84, 24)
            Me.comboBox6.TabIndex = 4
            '
            'comboBox3
            '
            Me.comboBox3.FormattingEnabled = True
            Me.comboBox3.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox3.Location = New System.Drawing.Point(289, 224)
            Me.comboBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(84, 24)
            Me.comboBox3.TabIndex = 3
            '
            'comboBox4
            '
            Me.comboBox4.FormattingEnabled = True
            Me.comboBox4.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox4.Location = New System.Drawing.Point(173, 225)
            Me.comboBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox4.Name = "comboBox4"
            Me.comboBox4.Size = New System.Drawing.Size(84, 24)
            Me.comboBox4.TabIndex = 2
            '
            'comboBox2
            '
            Me.comboBox2.FormattingEnabled = True
            Me.comboBox2.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox2.Location = New System.Drawing.Point(173, 180)
            Me.comboBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(84, 24)
            Me.comboBox2.TabIndex = 0
            '
            'comboBox1
            '
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox1.Location = New System.Drawing.Point(289, 178)
            Me.comboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(84, 24)
            Me.comboBox1.TabIndex = 1
            '
            'label22
            '
            Me.label22.AutoSize = True
            Me.label22.Location = New System.Drawing.Point(285, 145)
            Me.label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(100, 34)
            Me.label22.TabIndex = 41
            Me.label22.Text = "Release Press" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Functions"
            Me.toolTip1.SetToolTip(Me.label22, resources.GetString("label22.ToolTip"))
            '
            'comboBox15
            '
            Me.comboBox15.FormattingEnabled = True
            Me.comboBox15.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox15.Location = New System.Drawing.Point(289, 713)
            Me.comboBox15.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox15.Name = "comboBox15"
            Me.comboBox15.Size = New System.Drawing.Size(84, 24)
            Me.comboBox15.TabIndex = 15
            '
            'label21
            '
            Me.label21.AutoSize = True
            Me.label21.Location = New System.Drawing.Point(171, 144)
            Me.label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(69, 34)
            Me.label21.TabIndex = 40
            Me.label21.Text = "On Press" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Functions"
            Me.toolTip1.SetToolTip(Me.label21, resources.GetString("label21.ToolTip"))
            '
            'comboBox16
            '
            Me.comboBox16.FormattingEnabled = True
            Me.comboBox16.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox16.Location = New System.Drawing.Point(173, 714)
            Me.comboBox16.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox16.Name = "comboBox16"
            Me.comboBox16.Size = New System.Drawing.Size(84, 24)
            Me.comboBox16.TabIndex = 14
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label10.Location = New System.Drawing.Point(43, 314)
            Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(73, 20)
            Me.label10.TabIndex = 38
            Me.label10.Text = "Y Button"
            Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label9.Location = New System.Drawing.Point(43, 268)
            Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(74, 20)
            Me.label9.TabIndex = 37
            Me.label9.Text = "X Button"
            Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'comboBox13
            '
            Me.comboBox13.FormattingEnabled = True
            Me.comboBox13.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox13.Location = New System.Drawing.Point(289, 668)
            Me.comboBox13.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox13.Name = "comboBox13"
            Me.comboBox13.Size = New System.Drawing.Size(84, 24)
            Me.comboBox13.TabIndex = 13
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label8.Location = New System.Drawing.Point(41, 223)
            Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(75, 20)
            Me.label8.TabIndex = 36
            Me.label8.Text = "B Button"
            Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label7.Location = New System.Drawing.Point(41, 181)
            Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(74, 20)
            Me.label7.TabIndex = 35
            Me.label7.Text = "A Button"
            Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'comboBox14
            '
            Me.comboBox14.FormattingEnabled = True
            Me.comboBox14.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox14.Location = New System.Drawing.Point(173, 670)
            Me.comboBox14.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox14.Name = "comboBox14"
            Me.comboBox14.Size = New System.Drawing.Size(84, 24)
            Me.comboBox14.TabIndex = 12
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label6.Location = New System.Drawing.Point(157, 108)
            Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(101, 20)
            Me.label6.TabIndex = 34
            Me.label6.Text = "RightTrigger"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.toolTip1.SetToolTip(Me.label6, "Accelerator for the right stick jogs (Z)")
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label5.Location = New System.Drawing.Point(12, 108)
            Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(91, 20)
            Me.label5.TabIndex = 33
            Me.label5.Text = "LeftTrigger"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.toolTip1.SetToolTip(Me.label5, "Accelerator for the left stick jogs (X and Y)")
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label13.Location = New System.Drawing.Point(40, 671)
            Me.label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(96, 20)
            Me.label13.TabIndex = 41
            Me.label13.Text = "BackButton"
            Me.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label14
            '
            Me.label14.AutoSize = True
            Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label14.Location = New System.Drawing.Point(40, 715)
            Me.label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(94, 20)
            Me.label14.TabIndex = 42
            Me.label14.Text = "StartButton"
            Me.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.btnLED18)
            Me.GroupBox4.Controls.Add(Me.btnLED17)
            Me.GroupBox4.Controls.Add(Me.btnLED16)
            Me.GroupBox4.Controls.Add(Me.btnLED12)
            Me.GroupBox4.Controls.Add(Me.btnLED15)
            Me.GroupBox4.Controls.Add(Me.label23)
            Me.GroupBox4.Controls.Add(Me.btnLED11)
            Me.GroupBox4.Controls.Add(Me.cbCustomDpad)
            Me.GroupBox4.Controls.Add(Me.label27)
            Me.GroupBox4.Controls.Add(Me.comboBox9)
            Me.GroupBox4.Controls.Add(Me.comboBox10)
            Me.GroupBox4.Controls.Add(Me.label28)
            Me.GroupBox4.Controls.Add(Me.label12)
            Me.GroupBox4.Controls.Add(Me.label26)
            Me.GroupBox4.Controls.Add(Me.label18)
            Me.GroupBox4.Controls.Add(Me.label25)
            Me.GroupBox4.Controls.Add(Me.label17)
            Me.GroupBox4.Controls.Add(Me.label24)
            Me.GroupBox4.Controls.Add(Me.label16)
            Me.GroupBox4.Controls.Add(Me.label15)
            Me.GroupBox4.Controls.Add(Me.comboBox23)
            Me.GroupBox4.Controls.Add(Me.comboBox12)
            Me.GroupBox4.Controls.Add(Me.comboBox24)
            Me.GroupBox4.Controls.Add(Me.label11)
            Me.GroupBox4.Controls.Add(Me.comboBox11)
            Me.GroupBox4.Controls.Add(Me.comboBox21)
            Me.GroupBox4.Controls.Add(Me.comboBox18)
            Me.GroupBox4.Controls.Add(Me.comboBox22)
            Me.GroupBox4.Controls.Add(Me.comboBox17)
            Me.GroupBox4.Controls.Add(Me.comboBox19)
            Me.GroupBox4.Controls.Add(Me.comboBox20)
            Me.GroupBox4.Location = New System.Drawing.Point(8, 343)
            Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.GroupBox4.Size = New System.Drawing.Size(381, 314)
            Me.GroupBox4.TabIndex = 77
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "GroupBox4"
            '
            'btnLED18
            '
            Me.btnLED18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED18.Location = New System.Drawing.Point(7, 282)
            Me.btnLED18.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnLED18.Name = "btnLED18"
            Me.btnLED18.Size = New System.Drawing.Size(20, 18)
            Me.btnLED18.TabIndex = 90
            Me.btnLED18.UseVisualStyleBackColor = True
            '
            'btnLED17
            '
            Me.btnLED17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED17.Location = New System.Drawing.Point(7, 240)
            Me.btnLED17.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnLED17.Name = "btnLED17"
            Me.btnLED17.Size = New System.Drawing.Size(20, 18)
            Me.btnLED17.TabIndex = 89
            Me.btnLED17.UseVisualStyleBackColor = True
            '
            'btnLED16
            '
            Me.btnLED16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED16.Location = New System.Drawing.Point(7, 191)
            Me.btnLED16.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnLED16.Name = "btnLED16"
            Me.btnLED16.Size = New System.Drawing.Size(20, 18)
            Me.btnLED16.TabIndex = 88
            Me.btnLED16.UseVisualStyleBackColor = True
            '
            'btnLED12
            '
            Me.btnLED12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED12.Location = New System.Drawing.Point(7, 102)
            Me.btnLED12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnLED12.Name = "btnLED12"
            Me.btnLED12.Size = New System.Drawing.Size(20, 18)
            Me.btnLED12.TabIndex = 84
            Me.btnLED12.UseVisualStyleBackColor = True
            '
            'btnLED15
            '
            Me.btnLED15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED15.Location = New System.Drawing.Point(7, 149)
            Me.btnLED15.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnLED15.Name = "btnLED15"
            Me.btnLED15.Size = New System.Drawing.Size(20, 18)
            Me.btnLED15.TabIndex = 87
            Me.btnLED15.UseVisualStyleBackColor = True
            '
            'label23
            '
            Me.label23.AutoSize = True
            Me.label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label23.Location = New System.Drawing.Point(213, 55)
            Me.label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label23.Name = "label23"
            Me.label23.Size = New System.Drawing.Size(116, 20)
            Me.label23.TabIndex = 66
            Me.label23.Text = "Z Step Jog +"
            '
            'btnLED11
            '
            Me.btnLED11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED11.Location = New System.Drawing.Point(7, 60)
            Me.btnLED11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnLED11.Name = "btnLED11"
            Me.btnLED11.Size = New System.Drawing.Size(20, 18)
            Me.btnLED11.TabIndex = 83
            Me.btnLED11.UseVisualStyleBackColor = True
            '
            'cbCustomDpad
            '
            Me.cbCustomDpad.AutoSize = True
            Me.cbCustomDpad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbCustomDpad.Location = New System.Drawing.Point(75, 18)
            Me.cbCustomDpad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.cbCustomDpad.Name = "cbCustomDpad"
            Me.cbCustomDpad.Size = New System.Drawing.Size(252, 24)
            Me.cbCustomDpad.TabIndex = 13
            Me.cbCustomDpad.Text = "Customize DPad/Shoulder"
            Me.cbCustomDpad.UseVisualStyleBackColor = True
            '
            'label27
            '
            Me.label27.AutoSize = True
            Me.label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label27.Location = New System.Drawing.Point(213, 283)
            Me.label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label27.Name = "label27"
            Me.label27.Size = New System.Drawing.Size(118, 20)
            Me.label27.TabIndex = 71
            Me.label27.Text = "X Step Jog +"
            '
            'comboBox9
            '
            Me.comboBox9.Enabled = False
            Me.comboBox9.FormattingEnabled = True
            Me.comboBox9.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox9.Location = New System.Drawing.Point(281, 50)
            Me.comboBox9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox9.Name = "comboBox9"
            Me.comboBox9.Size = New System.Drawing.Size(84, 24)
            Me.comboBox9.TabIndex = 9
            Me.comboBox9.Visible = False
            '
            'comboBox10
            '
            Me.comboBox10.Enabled = False
            Me.comboBox10.FormattingEnabled = True
            Me.comboBox10.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox10.Location = New System.Drawing.Point(163, 50)
            Me.comboBox10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox10.Name = "comboBox10"
            Me.comboBox10.Size = New System.Drawing.Size(84, 24)
            Me.comboBox10.TabIndex = 8
            Me.comboBox10.Visible = False
            '
            'label28
            '
            Me.label28.AutoSize = True
            Me.label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label28.Location = New System.Drawing.Point(213, 238)
            Me.label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label28.Name = "label28"
            Me.label28.Size = New System.Drawing.Size(114, 20)
            Me.label28.TabIndex = 70
            Me.label28.Text = "X Step Jog -"
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label12.Location = New System.Drawing.Point(29, 101)
            Me.label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(92, 20)
            Me.label12.TabIndex = 40
            Me.label12.Text = "R Shoulder"
            Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label26
            '
            Me.label26.AutoSize = True
            Me.label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label26.Location = New System.Drawing.Point(213, 190)
            Me.label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(113, 20)
            Me.label26.TabIndex = 69
            Me.label26.Text = "Y Step Jog -"
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label18.Location = New System.Drawing.Point(29, 284)
            Me.label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(95, 20)
            Me.label18.TabIndex = 46
            Me.label18.Text = "DPad Right"
            Me.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label25
            '
            Me.label25.AutoSize = True
            Me.label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label25.Location = New System.Drawing.Point(213, 146)
            Me.label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label25.Name = "label25"
            Me.label25.Size = New System.Drawing.Size(117, 20)
            Me.label25.TabIndex = 68
            Me.label25.Text = "Y Step Jog +"
            '
            'label17
            '
            Me.label17.AutoSize = True
            Me.label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label17.Location = New System.Drawing.Point(29, 239)
            Me.label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(85, 20)
            Me.label17.TabIndex = 45
            Me.label17.Text = "DPad Left"
            Me.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label24
            '
            Me.label24.AutoSize = True
            Me.label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label24.Location = New System.Drawing.Point(212, 98)
            Me.label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(112, 20)
            Me.label24.TabIndex = 67
            Me.label24.Text = "Z Step Jog -"
            '
            'label16
            '
            Me.label16.AutoSize = True
            Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label16.Location = New System.Drawing.Point(29, 192)
            Me.label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(99, 20)
            Me.label16.TabIndex = 44
            Me.label16.Text = "DPad Down"
            Me.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label15
            '
            Me.label15.AutoSize = True
            Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label15.Location = New System.Drawing.Point(29, 148)
            Me.label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(77, 20)
            Me.label15.TabIndex = 43
            Me.label15.Text = "DPad Up"
            Me.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'comboBox23
            '
            Me.comboBox23.Enabled = False
            Me.comboBox23.FormattingEnabled = True
            Me.comboBox23.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox23.Location = New System.Drawing.Point(281, 276)
            Me.comboBox23.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox23.Name = "comboBox23"
            Me.comboBox23.Size = New System.Drawing.Size(84, 24)
            Me.comboBox23.TabIndex = 23
            Me.comboBox23.Visible = False
            '
            'comboBox12
            '
            Me.comboBox12.Enabled = False
            Me.comboBox12.FormattingEnabled = True
            Me.comboBox12.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox12.Location = New System.Drawing.Point(163, 94)
            Me.comboBox12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox12.Name = "comboBox12"
            Me.comboBox12.Size = New System.Drawing.Size(84, 24)
            Me.comboBox12.TabIndex = 10
            Me.comboBox12.Visible = False
            '
            'comboBox24
            '
            Me.comboBox24.Enabled = False
            Me.comboBox24.FormattingEnabled = True
            Me.comboBox24.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox24.Location = New System.Drawing.Point(163, 278)
            Me.comboBox24.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox24.Name = "comboBox24"
            Me.comboBox24.Size = New System.Drawing.Size(84, 24)
            Me.comboBox24.TabIndex = 22
            Me.comboBox24.Visible = False
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label11.Location = New System.Drawing.Point(29, 59)
            Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(90, 20)
            Me.label11.TabIndex = 39
            Me.label11.Text = "L Shoulder"
            Me.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'comboBox11
            '
            Me.comboBox11.Enabled = False
            Me.comboBox11.FormattingEnabled = True
            Me.comboBox11.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox11.Location = New System.Drawing.Point(281, 94)
            Me.comboBox11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox11.Name = "comboBox11"
            Me.comboBox11.Size = New System.Drawing.Size(84, 24)
            Me.comboBox11.TabIndex = 11
            Me.comboBox11.Visible = False
            '
            'comboBox21
            '
            Me.comboBox21.Enabled = False
            Me.comboBox21.FormattingEnabled = True
            Me.comboBox21.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox21.Location = New System.Drawing.Point(281, 231)
            Me.comboBox21.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox21.Name = "comboBox21"
            Me.comboBox21.Size = New System.Drawing.Size(84, 24)
            Me.comboBox21.TabIndex = 21
            Me.comboBox21.Visible = False
            '
            'comboBox18
            '
            Me.comboBox18.Enabled = False
            Me.comboBox18.FormattingEnabled = True
            Me.comboBox18.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox18.Location = New System.Drawing.Point(163, 142)
            Me.comboBox18.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox18.Name = "comboBox18"
            Me.comboBox18.Size = New System.Drawing.Size(84, 24)
            Me.comboBox18.TabIndex = 16
            Me.comboBox18.Visible = False
            '
            'comboBox22
            '
            Me.comboBox22.Enabled = False
            Me.comboBox22.FormattingEnabled = True
            Me.comboBox22.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox22.Location = New System.Drawing.Point(163, 231)
            Me.comboBox22.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox22.Name = "comboBox22"
            Me.comboBox22.Size = New System.Drawing.Size(84, 24)
            Me.comboBox22.TabIndex = 20
            Me.comboBox22.Visible = False
            '
            'comboBox17
            '
            Me.comboBox17.Enabled = False
            Me.comboBox17.FormattingEnabled = True
            Me.comboBox17.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox17.Location = New System.Drawing.Point(281, 140)
            Me.comboBox17.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox17.Name = "comboBox17"
            Me.comboBox17.Size = New System.Drawing.Size(84, 24)
            Me.comboBox17.TabIndex = 17
            Me.comboBox17.Visible = False
            '
            'comboBox19
            '
            Me.comboBox19.Enabled = False
            Me.comboBox19.FormattingEnabled = True
            Me.comboBox19.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox19.Location = New System.Drawing.Point(281, 185)
            Me.comboBox19.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox19.Name = "comboBox19"
            Me.comboBox19.Size = New System.Drawing.Size(84, 24)
            Me.comboBox19.TabIndex = 19
            Me.comboBox19.Visible = False
            '
            'comboBox20
            '
            Me.comboBox20.Enabled = False
            Me.comboBox20.FormattingEnabled = True
            Me.comboBox20.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox20.Location = New System.Drawing.Point(163, 187)
            Me.comboBox20.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox20.Name = "comboBox20"
            Me.comboBox20.Size = New System.Drawing.Size(84, 24)
            Me.comboBox20.TabIndex = 18
            Me.comboBox20.Visible = False
            '
            'btnSaveSettings
            '
            Me.btnSaveSettings.Location = New System.Drawing.Point(295, 772)
            Me.btnSaveSettings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnSaveSettings.Name = "btnSaveSettings"
            Me.btnSaveSettings.Size = New System.Drawing.Size(208, 30)
            Me.btnSaveSettings.TabIndex = 7
            Me.btnSaveSettings.Text = "Save Settings"
            Me.toolTip1.SetToolTip(Me.btnSaveSettings, "Save the setup to XML file")
            Me.btnSaveSettings.UseVisualStyleBackColor = True
            '
            'btnConnect
            '
            Me.btnConnect.Location = New System.Drawing.Point(431, 39)
            Me.btnConnect.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnConnect.Name = "btnConnect"
            Me.btnConnect.Size = New System.Drawing.Size(155, 59)
            Me.btnConnect.TabIndex = 0
            Me.btnConnect.Text = "Not Connected"
            Me.btnConnect.UseVisualStyleBackColor = True
            Me.btnConnect.Visible = False
            '
            'tabPage2
            '
            Me.tabPage2.Controls.Add(Me.textBox1)
            Me.tabPage2.Location = New System.Drawing.Point(4, 25)
            Me.tabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.tabPage2.Name = "tabPage2"
            Me.tabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.tabPage2.Size = New System.Drawing.Size(987, 905)
            Me.tabPage2.TabIndex = 1
            Me.tabPage2.Text = "Help"
            Me.tabPage2.UseVisualStyleBackColor = True
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(35, 23)
            Me.textBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.textBox1.Size = New System.Drawing.Size(756, 728)
            Me.textBox1.TabIndex = 1
            Me.textBox1.Text = resources.GetString("textBox1.Text")
            '
            'tabPage3
            '
            Me.tabPage3.Controls.Add(Me.lblAppVersion)
            Me.tabPage3.Controls.Add(Me.linkLabel2)
            Me.tabPage3.Controls.Add(Me.linkLabel1)
            Me.tabPage3.Controls.Add(Me.textBox2)
            Me.tabPage3.Controls.Add(Me.pictureBox1)
            Me.tabPage3.Location = New System.Drawing.Point(4, 25)
            Me.tabPage3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.tabPage3.Name = "tabPage3"
            Me.tabPage3.Size = New System.Drawing.Size(987, 905)
            Me.tabPage3.TabIndex = 2
            Me.tabPage3.Text = "About"
            Me.tabPage3.UseVisualStyleBackColor = True
            '
            'lblAppVersion
            '
            Me.lblAppVersion.AutoSize = True
            Me.lblAppVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.lblAppVersion.Location = New System.Drawing.Point(119, 433)
            Me.lblAppVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblAppVersion.Name = "lblAppVersion"
            Me.lblAppVersion.Size = New System.Drawing.Size(122, 20)
            Me.lblAppVersion.TabIndex = 39
            Me.lblAppVersion.Text = "Plugin Version:"
            Me.lblAppVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'linkLabel2
            '
            Me.linkLabel2.AutoSize = True
            Me.linkLabel2.Location = New System.Drawing.Point(119, 396)
            Me.linkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.linkLabel2.Name = "linkLabel2"
            Me.linkLabel2.Size = New System.Drawing.Size(126, 17)
            Me.linkLabel2.TabIndex = 4
            Me.linkLabel2.TabStop = True
            Me.linkLabel2.Text = "www.craftycnc.com"
            '
            'linkLabel1
            '
            Me.linkLabel1.AutoSize = True
            Me.linkLabel1.Location = New System.Drawing.Point(119, 367)
            Me.linkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.linkLabel1.Name = "linkLabel1"
            Me.linkLabel1.Size = New System.Drawing.Size(157, 17)
            Me.linkLabel1.TabIndex = 2
            Me.linkLabel1.TabStop = True
            Me.linkLabel1.Tag = "mailto:eabrust@craftycnc.com"
            Me.linkLabel1.Text = "eabrust@craftycnc.com"
            '
            'textBox2
            '
            Me.textBox2.Location = New System.Drawing.Point(123, 238)
            Me.textBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.textBox2.Multiline = True
            Me.textBox2.Name = "textBox2"
            Me.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
            Me.textBox2.Size = New System.Drawing.Size(492, 125)
            Me.textBox2.TabIndex = 1
            Me.textBox2.Text = "Copyright 2020, CraftyCNC / E Brust" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This plugin is provided without any guaran" &
    "tee of any kind." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please use caution with testing." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Questions or comments?  Pl" &
    "ease email me:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'pictureBox1
            '
            Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pictureBox1.Image = Global.Xboxcontroller.Resources.CraftyCNC_Med
            Me.pictureBox1.Location = New System.Drawing.Point(123, 46)
            Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(492, 184)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pictureBox1.TabIndex = 3
            Me.pictureBox1.TabStop = False
            '
            'NotifyIcon1
            '
            Me.NotifyIcon1.ContextMenuStrip = Me.contextMenuStrip1
            Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
            Me.NotifyIcon1.Text = "XBox for UCCNC"
            Me.NotifyIcon1.Visible = True
            '
            'contextMenuStrip1
            '
            Me.contextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
            Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1, Me.toolStripMenuItem2})
            Me.contextMenuStrip1.Name = "contextMenuStrip1"
            Me.contextMenuStrip1.Size = New System.Drawing.Size(160, 52)
            '
            'toolStripMenuItem1
            '
            Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
            Me.toolStripMenuItem1.Size = New System.Drawing.Size(159, 24)
            Me.toolStripMenuItem1.Text = "Show Plugin"
            '
            'toolStripMenuItem2
            '
            Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
            Me.toolStripMenuItem2.Size = New System.Drawing.Size(159, 24)
            Me.toolStripMenuItem2.Text = "Exit"
            '
            'statusStrip1
            '
            Me.statusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
            Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1, Me.toolStripStatusLabel2})
            Me.statusStrip1.Location = New System.Drawing.Point(0, 898)
            Me.statusStrip1.Name = "statusStrip1"
            Me.statusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
            Me.statusStrip1.Size = New System.Drawing.Size(992, 26)
            Me.statusStrip1.TabIndex = 52
            Me.statusStrip1.Text = "statusStrip1"
            '
            'toolStripStatusLabel1
            '
            Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
            Me.toolStripStatusLabel1.Size = New System.Drawing.Size(72, 20)
            Me.toolStripStatusLabel1.Text = "Loading..."
            '
            'toolStripStatusLabel2
            '
            Me.toolStripStatusLabel2.Name = "toolStripStatusLabel2"
            Me.toolStripStatusLabel2.Size = New System.Drawing.Size(72, 20)
            Me.toolStripStatusLabel2.Text = "Loading..."
            '
            'timerUpdateScreen
            '
            Me.timerUpdateScreen.Interval = 50
            '
            'XBoxForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(992, 924)
            Me.Controls.Add(Me.statusStrip1)
            Me.Controls.Add(Me.tabControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.MaximumSize = New System.Drawing.Size(1010, 971)
            Me.MinimumSize = New System.Drawing.Size(1010, 971)
            Me.Name = "XBoxForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "XBOX Control for UCCNC"
            Me.TopMost = True
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.nudMaxVelLSV, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudLYdeadband, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudLXDeadBand, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudMaxVelLSH, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            CType(Me.nudMaxVelRSV, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudRYdeadband, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudRXdeadband, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudMaxVelRSH, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupboxJogStep.ResumeLayout(False)
            Me.groupboxJogStep.PerformLayout()
            Me.tabControl1.ResumeLayout(False)
            Me.tabPage1.ResumeLayout(False)
            Me.tabPage1.PerformLayout()
            Me.groupBoxDPad.ResumeLayout(False)
            Me.groupBoxDPad.PerformLayout()
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox5.PerformLayout()
            Me.groupBox8.ResumeLayout(False)
            Me.groupBox8.PerformLayout()
            Me.groupBox9.ResumeLayout(False)
            Me.groupBox9.PerformLayout()
            Me.groupBox6.ResumeLayout(False)
            Me.groupBox6.PerformLayout()
            Me.groupBox7.ResumeLayout(False)
            Me.groupBox7.PerformLayout()
            Me.groupBox3.ResumeLayout(False)
            Me.groupBox3.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.tabPage2.ResumeLayout(False)
            Me.tabPage2.PerformLayout()
            Me.tabPage3.ResumeLayout(False)
            Me.tabPage3.PerformLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.contextMenuStrip1.ResumeLayout(False)
            Me.statusStrip1.ResumeLayout(False)
            Me.statusStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub


#End Region

        Private tabControl1 As Windows.Forms.TabControl
        Private tabPage1 As Windows.Forms.TabPage
        Private groupBox3 As Windows.Forms.GroupBox
        Private label27 As Windows.Forms.Label
        Private label28 As Windows.Forms.Label
        Private label26 As Windows.Forms.Label
        Private label25 As Windows.Forms.Label
        Private label24 As Windows.Forms.Label
        Private label23 As Windows.Forms.Label
        Public comboBox23 As Windows.Forms.ComboBox
        Public comboBox24 As Windows.Forms.ComboBox
        Public comboBox21 As Windows.Forms.ComboBox
        Public comboBox22 As Windows.Forms.ComboBox
        Public comboBox19 As Windows.Forms.ComboBox
        Public comboBox20 As Windows.Forms.ComboBox
        Public comboBox17 As Windows.Forms.ComboBox
        Public comboBox18 As Windows.Forms.ComboBox
        Public comboBox15 As Windows.Forms.ComboBox
        Public comboBox16 As Windows.Forms.ComboBox
        Public comboBox13 As Windows.Forms.ComboBox
        Public comboBox14 As Windows.Forms.ComboBox
        Public comboBox11 As Windows.Forms.ComboBox
        Public comboBox12 As Windows.Forms.ComboBox
        Public comboBox9 As Windows.Forms.ComboBox
        Public comboBox10 As Windows.Forms.ComboBox
        Public comboBox7 As Windows.Forms.ComboBox
        Public comboBox8 As Windows.Forms.ComboBox
        Public comboBox5 As Windows.Forms.ComboBox
        Public comboBox6 As Windows.Forms.ComboBox
        Public comboBox3 As Windows.Forms.ComboBox
        Public comboBox4 As Windows.Forms.ComboBox
        Public comboBox2 As Windows.Forms.ComboBox
        Public comboBox1 As Windows.Forms.ComboBox
        Private label22 As Windows.Forms.Label
        Private label21 As Windows.Forms.Label
        Public label15 As Windows.Forms.Label
        Public label16 As Windows.Forms.Label
        Public label17 As Windows.Forms.Label
        Public label18 As Windows.Forms.Label
        Public label11 As Windows.Forms.Label
        Public label12 As Windows.Forms.Label
        Public label13 As Windows.Forms.Label
        Public label14 As Windows.Forms.Label
        Public label10 As Windows.Forms.Label
        Public label9 As Windows.Forms.Label
        Public label8 As Windows.Forms.Label
        Public label7 As Windows.Forms.Label
        Public label6 As Windows.Forms.Label
        Public label5 As Windows.Forms.Label
        Public label4 As Windows.Forms.Label
        Public label3 As Windows.Forms.Label
        Public label2 As Windows.Forms.Label
        Public label1 As Windows.Forms.Label
        Public WithEvents cbEnableMain As Windows.Forms.CheckBox
        Private WithEvents btnSaveSettings As Windows.Forms.Button
        Public groupBox1 As Windows.Forms.GroupBox
        Public WithEvents rbCubedRateLeft As Windows.Forms.RadioButton
        Public WithEvents rbSquaredRateLeft As Windows.Forms.RadioButton
        Public WithEvents rbLinearRateLeft As Windows.Forms.RadioButton
        Public groupBox2 As Windows.Forms.GroupBox
        Public WithEvents rbCubedRateRight As Windows.Forms.RadioButton
        Public WithEvents rbSquaredRateRight As Windows.Forms.RadioButton
        Public WithEvents rbLinearRateRight As Windows.Forms.RadioButton
        Private tabPage2 As Windows.Forms.TabPage
        Private tabPage3 As Windows.Forms.TabPage
        Private textBox1 As Windows.Forms.TextBox
        Private WithEvents linkLabel1 As Windows.Forms.LinkLabel
        Private textBox2 As Windows.Forms.TextBox
        Private WithEvents btnShowCodes As Windows.Forms.Button
        Private pictureBox1 As Windows.Forms.PictureBox
        Private WithEvents linkLabel2 As Windows.Forms.LinkLabel
        Private groupboxJogStep As Windows.Forms.GroupBox
        Public WithEvents checkBox4 As Windows.Forms.CheckBox
        Private toolTip1 As Windows.Forms.ToolTip
        Public groupBox6 As Windows.Forms.GroupBox
        Public WithEvents rbDubTrigEnable As Windows.Forms.RadioButton
        Public WithEvents rbSingTrigEnable As Windows.Forms.RadioButton
        Public WithEvents rbVelTrigger As Windows.Forms.RadioButton
        Public groupBox8 As Windows.Forms.GroupBox
        Public label32 As Windows.Forms.Label
        Public label33 As Windows.Forms.Label
        Public label31 As Windows.Forms.Label
        Public label30 As Windows.Forms.Label
        Public groupBox9 As Windows.Forms.GroupBox
        Public WithEvents radioButton13 As Windows.Forms.RadioButton
        Public WithEvents radioButton14 As Windows.Forms.RadioButton
        Public WithEvents radioButton15 As Windows.Forms.RadioButton
        Public groupBox7 As Windows.Forms.GroupBox
        Public WithEvents radioButton10 As Windows.Forms.RadioButton
        Public WithEvents radioButton11 As Windows.Forms.RadioButton
        Public WithEvents radioButton12 As Windows.Forms.RadioButton
        Public comboBoxRYStick As Windows.Forms.ComboBox
        Public WithEvents comboBoxRXStick As Windows.Forms.ComboBox
        Public comboBoxLYStick As Windows.Forms.ComboBox
        Public comboBoxLXStick As Windows.Forms.ComboBox
        Public label37 As Windows.Forms.Label
        Public jog4 As Windows.Forms.ComboBox
        Public label36 As Windows.Forms.Label
        Public jog3 As Windows.Forms.ComboBox
        Public label35 As Windows.Forms.Label
        Public jog2 As Windows.Forms.ComboBox
        Public label34 As Windows.Forms.Label
        Public jog1 As Windows.Forms.ComboBox
        Private WithEvents btnLoadSettings As Windows.Forms.Button
        Public label19 As Windows.Forms.Label
        Public label20 As Windows.Forms.Label
        Public lblAppVersion As Windows.Forms.Label
        Private label39 As Windows.Forms.Label
        Private label40 As Windows.Forms.Label
        Public WithEvents cbMixAxisJogLS As Windows.Forms.CheckBox
        Public nudMaxVelLSH As Windows.Forms.NumericUpDown
        Public nudMaxVelRSH As Windows.Forms.NumericUpDown
        Public WithEvents cbRightStickEnab As Windows.Forms.CheckBox
        Public WithEvents cbLeftStickEnab As Windows.Forms.CheckBox
        Private label42 As Windows.Forms.Label
        Private label41 As Windows.Forms.Label
        Private label29 As Windows.Forms.Label
        Public nudLYdeadband As Windows.Forms.NumericUpDown
        Public nudLXDeadBand As Windows.Forms.NumericUpDown
        Private label43 As Windows.Forms.Label
        Private label44 As Windows.Forms.Label
        Private label45 As Windows.Forms.Label
        Public nudRYdeadband As Windows.Forms.NumericUpDown
        Public nudRXdeadband As Windows.Forms.NumericUpDown
        Private contextMenuStrip1 As Windows.Forms.ContextMenuStrip
        Private WithEvents toolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
        Private WithEvents toolStripMenuItem2 As Windows.Forms.ToolStripMenuItem
        Public WithEvents btnConnect As Windows.Forms.Button
        Private statusStrip1 As Windows.Forms.StatusStrip
        Public toolStripStatusLabel1 As Windows.Forms.ToolStripStatusLabel
        Public toolStripStatusLabel2 As Windows.Forms.ToolStripStatusLabel
        Public WithEvents cbCustomDpad As Windows.Forms.CheckBox
        Public nudMaxVelLSV As Windows.Forms.NumericUpDown
        Private label46 As Windows.Forms.Label
        Public nudMaxVelRSV As Windows.Forms.NumericUpDown
        Private label47 As Windows.Forms.Label
        Public WithEvents cbLSMaxVel As Windows.Forms.CheckBox
        Public WithEvents cbRSMaxVel As Windows.Forms.CheckBox
        Public WithEvents cbMixAxisJogRS As Windows.Forms.CheckBox
        Public WithEvents cbAutoEnable As Windows.Forms.CheckBox
        Public WithEvents cbMinimizeOnLoad As Windows.Forms.CheckBox
        Public WithEvents cbErrMsg As Windows.Forms.CheckBox
        Public WithEvents cbJogStepNotify As Windows.Forms.CheckBox
        Public WithEvents cbJSTrigEnab As Windows.Forms.CheckBox
        Friend WithEvents NotifyIcon1 As Windows.Forms.NotifyIcon
        Public WithEvents groupBoxDPad As Windows.Forms.GroupBox
        Public WithEvents comboLRShoulder As Windows.Forms.ComboBox
        Public WithEvents comboUDDpad As Windows.Forms.ComboBox
        Public WithEvents comboLRDpad As Windows.Forms.ComboBox
        Public WithEvents Label38 As Windows.Forms.Label
        Public WithEvents Label49 As Windows.Forms.Label
        Public WithEvents Label50 As Windows.Forms.Label
        Public WithEvents GroupBox5 As Windows.Forms.GroupBox
        Public WithEvents RadioButton16 As Windows.Forms.RadioButton
        Public WithEvents RadioButton17 As Windows.Forms.RadioButton
        Public WithEvents RadioButton18 As Windows.Forms.RadioButton
        Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
        Public WithEvents cbSaveSettings As Windows.Forms.CheckBox
        Private WithEvents btnConfigForm As Windows.Forms.Button
        Friend WithEvents btnLED7 As Windows.Forms.Button
        Friend WithEvents btnLED14 As Windows.Forms.Button
        Friend WithEvents btnLED10 As Windows.Forms.Button
        Friend WithEvents btnLED13 As Windows.Forms.Button
        Friend WithEvents btnLED9 As Windows.Forms.Button
        Friend WithEvents btnLED8 As Windows.Forms.Button
        Friend WithEvents btnLED18 As Windows.Forms.Button
        Friend WithEvents btnLED17 As Windows.Forms.Button
        Friend WithEvents btnLED16 As Windows.Forms.Button
        Friend WithEvents btnLED12 As Windows.Forms.Button
        Friend WithEvents btnLED15 As Windows.Forms.Button
        Friend WithEvents btnLED11 As Windows.Forms.Button
        Private WithEvents timerUpdateScreen As Windows.Forms.Timer
    End Class
End Namespace
