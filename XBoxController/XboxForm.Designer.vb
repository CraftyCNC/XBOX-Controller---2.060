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
            Me.radioButton3 = New System.Windows.Forms.RadioButton()
            Me.radioButton2 = New System.Windows.Forms.RadioButton()
            Me.radioButton1 = New System.Windows.Forms.RadioButton()
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
            Me.radioButton6 = New System.Windows.Forms.RadioButton()
            Me.radioButton5 = New System.Windows.Forms.RadioButton()
            Me.radioButton4 = New System.Windows.Forms.RadioButton()
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
            Me.radioButton7 = New System.Windows.Forms.RadioButton()
            Me.radioButton8 = New System.Windows.Forms.RadioButton()
            Me.radioButton9 = New System.Windows.Forms.RadioButton()
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
            Me.label4.Location = New System.Drawing.Point(118, 56)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(77, 16)
            Me.label4.TabIndex = 32
            Me.label4.Text = "RightStickY"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.toolTip1.SetToolTip(Me.label4, "Z axis jogging")
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label3.Location = New System.Drawing.Point(118, 24)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(76, 16)
            Me.label3.TabIndex = 30
            Me.label3.Text = "RightStickX"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.toolTip1.SetToolTip(Me.label3, "Used to select the 'step jog' size (.001, .010, .100, 1.00)")
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label2.Location = New System.Drawing.Point(9, 56)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(67, 16)
            Me.label2.TabIndex = 31
            Me.label2.Text = "LeftStickY"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.toolTip1.SetToolTip(Me.label2, "Y axis jogging")
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label1.Location = New System.Drawing.Point(9, 24)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(66, 16)
            Me.label1.TabIndex = 28
            Me.label1.Text = "LeftStickX"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.toolTip1.SetToolTip(Me.label1, "X axis jogging")
            '
            'cbEnableMain
            '
            Me.cbEnableMain.AutoSize = True
            Me.cbEnableMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbEnableMain.Location = New System.Drawing.Point(503, 625)
            Me.cbEnableMain.Name = "cbEnableMain"
            Me.cbEnableMain.Size = New System.Drawing.Size(228, 20)
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
            Me.groupBox1.Controls.Add(Me.radioButton3)
            Me.groupBox1.Controls.Add(Me.radioButton2)
            Me.groupBox1.Controls.Add(Me.radioButton1)
            Me.groupBox1.Location = New System.Drawing.Point(308, 105)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(207, 243)
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
            Me.cbLSMaxVel.Location = New System.Drawing.Point(3, 153)
            Me.cbLSMaxVel.Name = "cbLSMaxVel"
            Me.cbLSMaxVel.Size = New System.Drawing.Size(152, 19)
            Me.cbLSMaxVel.TabIndex = 4
            Me.cbLSMaxVel.Text = "Use Max Vel. Setpoints"
            Me.cbLSMaxVel.UseVisualStyleBackColor = True
            '
            'nudMaxVelLSV
            '
            Me.nudMaxVelLSV.ImeMode = System.Windows.Forms.ImeMode.[On]
            Me.nudMaxVelLSV.InterceptArrowKeys = False
            Me.nudMaxVelLSV.Location = New System.Drawing.Point(136, 197)
            Me.nudMaxVelLSV.Margin = New System.Windows.Forms.Padding(2)
            Me.nudMaxVelLSV.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudMaxVelLSV.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudMaxVelLSV.Name = "nudMaxVelLSV"
            Me.nudMaxVelLSV.Size = New System.Drawing.Size(66, 20)
            Me.nudMaxVelLSV.TabIndex = 52
            Me.toolTip1.SetToolTip(Me.nudMaxVelLSV, resources.GetString("nudMaxVelLSV.ToolTip"))
            Me.nudMaxVelLSV.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label42
            '
            Me.label42.AutoSize = True
            Me.label42.Location = New System.Drawing.Point(102, 18)
            Me.label42.Name = "label42"
            Me.label42.Size = New System.Drawing.Size(14, 13)
            Me.label42.TabIndex = 43
            Me.label42.Text = "X"
            '
            'label41
            '
            Me.label41.AutoSize = True
            Me.label41.Location = New System.Drawing.Point(153, 18)
            Me.label41.Name = "label41"
            Me.label41.Size = New System.Drawing.Size(14, 13)
            Me.label41.TabIndex = 42
            Me.label41.Text = "Y"
            '
            'label46
            '
            Me.label46.AutoSize = True
            Me.label46.Location = New System.Drawing.Point(13, 201)
            Me.label46.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.label46.Name = "label46"
            Me.label46.Size = New System.Drawing.Size(109, 13)
            Me.label46.TabIndex = 6
            Me.label46.Text = "Max Vel Left Stick - Y"
            '
            'cbMixAxisJogLS
            '
            Me.cbMixAxisJogLS.AutoSize = True
            Me.cbMixAxisJogLS.Location = New System.Drawing.Point(3, 130)
            Me.cbMixAxisJogLS.Name = "cbMixAxisJogLS"
            Me.cbMixAxisJogLS.Size = New System.Drawing.Size(153, 17)
            Me.cbMixAxisJogLS.TabIndex = 3
            Me.cbMixAxisJogLS.Text = "Allowed mixed axis velocity"
            Me.toolTip1.SetToolTip(Me.cbMixAxisJogLS, "Allow Jogging in both axis defined for a stick at same time " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(i.e., combined X &" &
        " Y movement allowed if enabled).")
            Me.cbMixAxisJogLS.UseVisualStyleBackColor = True
            '
            'label29
            '
            Me.label29.AutoSize = True
            Me.label29.Location = New System.Drawing.Point(8, 36)
            Me.label29.Name = "label29"
            Me.label29.Size = New System.Drawing.Size(78, 13)
            Me.label29.TabIndex = 41
            Me.label29.Text = "Left Deadband"
            '
            'nudLYdeadband
            '
            Me.nudLYdeadband.DecimalPlaces = 2
            Me.nudLYdeadband.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudLYdeadband.InterceptArrowKeys = False
            Me.nudLYdeadband.Location = New System.Drawing.Point(140, 33)
            Me.nudLYdeadband.Margin = New System.Windows.Forms.Padding(2)
            Me.nudLYdeadband.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
            Me.nudLYdeadband.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudLYdeadband.Name = "nudLYdeadband"
            Me.nudLYdeadband.Size = New System.Drawing.Size(46, 20)
            Me.nudLYdeadband.TabIndex = 40
            Me.nudLYdeadband.Value = New Decimal(New Integer() {2, 0, 0, 131072})
            '
            'nudLXDeadBand
            '
            Me.nudLXDeadBand.DecimalPlaces = 2
            Me.nudLXDeadBand.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudLXDeadBand.InterceptArrowKeys = False
            Me.nudLXDeadBand.Location = New System.Drawing.Point(90, 33)
            Me.nudLXDeadBand.Margin = New System.Windows.Forms.Padding(2)
            Me.nudLXDeadBand.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
            Me.nudLXDeadBand.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudLXDeadBand.Name = "nudLXDeadBand"
            Me.nudLXDeadBand.Size = New System.Drawing.Size(46, 20)
            Me.nudLXDeadBand.TabIndex = 39
            Me.nudLXDeadBand.Value = New Decimal(New Integer() {2, 0, 0, 131072})
            '
            'label39
            '
            Me.label39.AutoSize = True
            Me.label39.Location = New System.Drawing.Point(13, 179)
            Me.label39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.label39.Name = "label39"
            Me.label39.Size = New System.Drawing.Size(109, 13)
            Me.label39.TabIndex = 5
            Me.label39.Text = "Max Vel Left Stick - X"
            '
            'nudMaxVelLSH
            '
            Me.nudMaxVelLSH.ImeMode = System.Windows.Forms.ImeMode.[On]
            Me.nudMaxVelLSH.InterceptArrowKeys = False
            Me.nudMaxVelLSH.Location = New System.Drawing.Point(136, 175)
            Me.nudMaxVelLSH.Margin = New System.Windows.Forms.Padding(2)
            Me.nudMaxVelLSH.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudMaxVelLSH.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudMaxVelLSH.Name = "nudMaxVelLSH"
            Me.nudMaxVelLSH.Size = New System.Drawing.Size(66, 20)
            Me.nudMaxVelLSH.TabIndex = 37
            Me.toolTip1.SetToolTip(Me.nudMaxVelLSH, resources.GetString("nudMaxVelLSH.ToolTip"))
            Me.nudMaxVelLSH.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label19
            '
            Me.label19.AutoSize = True
            Me.label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label19.Location = New System.Drawing.Point(35, 220)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(124, 16)
            Me.label19.TabIndex = 36
            Me.label19.Text = "Left Stick calc Feed"
            Me.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'radioButton3
            '
            Me.radioButton3.AutoSize = True
            Me.radioButton3.Location = New System.Drawing.Point(15, 102)
            Me.radioButton3.Name = "radioButton3"
            Me.radioButton3.Size = New System.Drawing.Size(131, 17)
            Me.radioButton3.TabIndex = 2
            Me.radioButton3.Text = "Cubed (most sensitive)"
            Me.radioButton3.UseVisualStyleBackColor = True
            '
            'radioButton2
            '
            Me.radioButton2.AutoSize = True
            Me.radioButton2.Location = New System.Drawing.Point(15, 79)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(141, 17)
            Me.radioButton2.TabIndex = 1
            Me.radioButton2.Text = "Squared (more sensitive)"
            Me.radioButton2.UseVisualStyleBackColor = True
            '
            'radioButton1
            '
            Me.radioButton1.AutoSize = True
            Me.radioButton1.Checked = True
            Me.radioButton1.Location = New System.Drawing.Point(15, 55)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(54, 17)
            Me.radioButton1.TabIndex = 0
            Me.radioButton1.TabStop = True
            Me.radioButton1.Text = "Linear"
            Me.radioButton1.UseVisualStyleBackColor = True
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
            Me.groupBox2.Controls.Add(Me.radioButton6)
            Me.groupBox2.Controls.Add(Me.radioButton5)
            Me.groupBox2.Controls.Add(Me.radioButton4)
            Me.groupBox2.Location = New System.Drawing.Point(521, 105)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(209, 243)
            Me.groupBox2.TabIndex = 3
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Velocity Rate (Right stick)"
            Me.toolTip1.SetToolTip(Me.groupBox2, "Select the Velocity sensitivity rate for the right stick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "movement.  Linear is le" &
        "ast sensitive, Cubed is most " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensitive at low speed.")
            '
            'cbMixAxisJogRS
            '
            Me.cbMixAxisJogRS.AutoSize = True
            Me.cbMixAxisJogRS.Location = New System.Drawing.Point(4, 130)
            Me.cbMixAxisJogRS.Name = "cbMixAxisJogRS"
            Me.cbMixAxisJogRS.Size = New System.Drawing.Size(153, 17)
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
            Me.cbRSMaxVel.Location = New System.Drawing.Point(4, 153)
            Me.cbRSMaxVel.Name = "cbRSMaxVel"
            Me.cbRSMaxVel.Size = New System.Drawing.Size(152, 19)
            Me.cbRSMaxVel.TabIndex = 4
            Me.cbRSMaxVel.Text = "Use Max Vel. Setpoints"
            Me.cbRSMaxVel.UseVisualStyleBackColor = True
            '
            'nudMaxVelRSV
            '
            Me.nudMaxVelRSV.ImeMode = System.Windows.Forms.ImeMode.[On]
            Me.nudMaxVelRSV.InterceptArrowKeys = False
            Me.nudMaxVelRSV.Location = New System.Drawing.Point(133, 196)
            Me.nudMaxVelRSV.Margin = New System.Windows.Forms.Padding(2)
            Me.nudMaxVelRSV.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudMaxVelRSV.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudMaxVelRSV.Name = "nudMaxVelRSV"
            Me.nudMaxVelRSV.Size = New System.Drawing.Size(66, 20)
            Me.nudMaxVelRSV.TabIndex = 49
            Me.toolTip1.SetToolTip(Me.nudMaxVelRSV, resources.GetString("nudMaxVelRSV.ToolTip"))
            Me.nudMaxVelRSV.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label47
            '
            Me.label47.AutoSize = True
            Me.label47.Location = New System.Drawing.Point(11, 200)
            Me.label47.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.label47.Name = "label47"
            Me.label47.Size = New System.Drawing.Size(116, 13)
            Me.label47.TabIndex = 6
            Me.label47.Text = "Max Vel Right Stick - Y"
            '
            'label43
            '
            Me.label43.AutoSize = True
            Me.label43.Location = New System.Drawing.Point(111, 18)
            Me.label43.Name = "label43"
            Me.label43.Size = New System.Drawing.Size(14, 13)
            Me.label43.TabIndex = 48
            Me.label43.Text = "X"
            '
            'label44
            '
            Me.label44.AutoSize = True
            Me.label44.Location = New System.Drawing.Point(162, 18)
            Me.label44.Name = "label44"
            Me.label44.Size = New System.Drawing.Size(14, 13)
            Me.label44.TabIndex = 47
            Me.label44.Text = "Y"
            '
            'label45
            '
            Me.label45.AutoSize = True
            Me.label45.Location = New System.Drawing.Point(9, 36)
            Me.label45.Name = "label45"
            Me.label45.Size = New System.Drawing.Size(86, 13)
            Me.label45.TabIndex = 46
            Me.label45.Text = "RIght Deadband"
            '
            'nudRYdeadband
            '
            Me.nudRYdeadband.DecimalPlaces = 2
            Me.nudRYdeadband.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudRYdeadband.InterceptArrowKeys = False
            Me.nudRYdeadband.Location = New System.Drawing.Point(149, 33)
            Me.nudRYdeadband.Margin = New System.Windows.Forms.Padding(2)
            Me.nudRYdeadband.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
            Me.nudRYdeadband.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudRYdeadband.Name = "nudRYdeadband"
            Me.nudRYdeadband.Size = New System.Drawing.Size(46, 20)
            Me.nudRYdeadband.TabIndex = 45
            Me.nudRYdeadband.Value = New Decimal(New Integer() {2, 0, 0, 131072})
            '
            'nudRXdeadband
            '
            Me.nudRXdeadband.DecimalPlaces = 2
            Me.nudRXdeadband.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudRXdeadband.InterceptArrowKeys = False
            Me.nudRXdeadband.Location = New System.Drawing.Point(99, 33)
            Me.nudRXdeadband.Margin = New System.Windows.Forms.Padding(2)
            Me.nudRXdeadband.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
            Me.nudRXdeadband.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.nudRXdeadband.Name = "nudRXdeadband"
            Me.nudRXdeadband.Size = New System.Drawing.Size(46, 20)
            Me.nudRXdeadband.TabIndex = 44
            Me.nudRXdeadband.Value = New Decimal(New Integer() {2, 0, 0, 131072})
            '
            'nudMaxVelRSH
            '
            Me.nudMaxVelRSH.ImeMode = System.Windows.Forms.ImeMode.[On]
            Me.nudMaxVelRSH.InterceptArrowKeys = False
            Me.nudMaxVelRSH.Location = New System.Drawing.Point(133, 174)
            Me.nudMaxVelRSH.Margin = New System.Windows.Forms.Padding(2)
            Me.nudMaxVelRSH.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudMaxVelRSH.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudMaxVelRSH.Name = "nudMaxVelRSH"
            Me.nudMaxVelRSH.Size = New System.Drawing.Size(66, 20)
            Me.nudMaxVelRSH.TabIndex = 40
            Me.toolTip1.SetToolTip(Me.nudMaxVelRSH, resources.GetString("nudMaxVelRSH.ToolTip"))
            Me.nudMaxVelRSH.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label40
            '
            Me.label40.AutoSize = True
            Me.label40.Location = New System.Drawing.Point(12, 178)
            Me.label40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.label40.Name = "label40"
            Me.label40.Size = New System.Drawing.Size(116, 13)
            Me.label40.TabIndex = 5
            Me.label40.Text = "Max Vel Right Stick - X"
            '
            'label20
            '
            Me.label20.AutoSize = True
            Me.label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label20.Location = New System.Drawing.Point(35, 219)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(134, 16)
            Me.label20.TabIndex = 38
            Me.label20.Text = "Right Stick calc Feed"
            Me.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'radioButton6
            '
            Me.radioButton6.AutoSize = True
            Me.radioButton6.Location = New System.Drawing.Point(11, 102)
            Me.radioButton6.Name = "radioButton6"
            Me.radioButton6.Size = New System.Drawing.Size(131, 17)
            Me.radioButton6.TabIndex = 2
            Me.radioButton6.Text = "Cubed (most sensitive)"
            Me.radioButton6.UseVisualStyleBackColor = True
            '
            'radioButton5
            '
            Me.radioButton5.AutoSize = True
            Me.radioButton5.Location = New System.Drawing.Point(11, 79)
            Me.radioButton5.Name = "radioButton5"
            Me.radioButton5.Size = New System.Drawing.Size(141, 17)
            Me.radioButton5.TabIndex = 1
            Me.radioButton5.Text = "Squared (more sensitive)"
            Me.radioButton5.UseVisualStyleBackColor = True
            '
            'radioButton4
            '
            Me.radioButton4.AutoSize = True
            Me.radioButton4.Checked = True
            Me.radioButton4.Location = New System.Drawing.Point(11, 55)
            Me.radioButton4.Name = "radioButton4"
            Me.radioButton4.Size = New System.Drawing.Size(54, 17)
            Me.radioButton4.TabIndex = 0
            Me.radioButton4.TabStop = True
            Me.radioButton4.Text = "Linear"
            Me.radioButton4.UseVisualStyleBackColor = True
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
            Me.groupboxJogStep.Location = New System.Drawing.Point(521, 358)
            Me.groupboxJogStep.Name = "groupboxJogStep"
            Me.groupboxJogStep.Size = New System.Drawing.Size(188, 214)
            Me.groupboxJogStep.TabIndex = 5
            Me.groupboxJogStep.TabStop = False
            Me.groupboxJogStep.Text = "Jog Step Selection"
            Me.toolTip1.SetToolTip(Me.groupboxJogStep, resources.GetString("groupboxJogStep.ToolTip"))
            '
            'cbJogStepNotify
            '
            Me.cbJogStepNotify.AutoSize = True
            Me.cbJogStepNotify.Location = New System.Drawing.Point(33, 183)
            Me.cbJogStepNotify.Name = "cbJogStepNotify"
            Me.cbJogStepNotify.Size = New System.Drawing.Size(154, 17)
            Me.cbJogStepNotify.TabIndex = 81
            Me.cbJogStepNotify.Text = "Display selct. on NotifyIcon"
            Me.toolTip1.SetToolTip(Me.cbJogStepNotify, resources.GetString("cbJogStepNotify.ToolTip"))
            Me.cbJogStepNotify.UseVisualStyleBackColor = True
            '
            'cbJSTrigEnab
            '
            Me.cbJSTrigEnab.AutoSize = True
            Me.cbJSTrigEnab.Location = New System.Drawing.Point(16, 20)
            Me.cbJSTrigEnab.Name = "cbJSTrigEnab"
            Me.cbJSTrigEnab.Size = New System.Drawing.Size(148, 30)
            Me.cbJSTrigEnab.TabIndex = 80
            Me.cbJSTrigEnab.Text = "Require Trigger to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "enable Jog Step selection"
            Me.toolTip1.SetToolTip(Me.cbJSTrigEnab, resources.GetString("cbJSTrigEnab.ToolTip"))
            Me.cbJSTrigEnab.UseVisualStyleBackColor = True
            '
            'label37
            '
            Me.label37.AutoSize = True
            Me.label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label37.Location = New System.Drawing.Point(86, 136)
            Me.label37.Name = "label37"
            Me.label37.Size = New System.Drawing.Size(72, 16)
            Me.label37.TabIndex = 3
            Me.label37.Text = "Jog Step 4"
            Me.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'jog4
            '
            Me.jog4.FormattingEnabled = True
            Me.jog4.Items.AddRange(New Object() {".001", ".002", ".005", ".010", ".020", ".050", ".100", ".250", ".500", "1.000"})
            Me.jog4.Location = New System.Drawing.Point(17, 136)
            Me.jog4.Name = "jog4"
            Me.jog4.Size = New System.Drawing.Size(64, 21)
            Me.jog4.TabIndex = 79
            Me.toolTip1.SetToolTip(Me.jog4, "Leave blank for default step size of 1.000, or enter a custom step size." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is" &
        " selected by pushing the Right stick X-axis full right." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'label36
            '
            Me.label36.AutoSize = True
            Me.label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label36.Location = New System.Drawing.Point(86, 110)
            Me.label36.Name = "label36"
            Me.label36.Size = New System.Drawing.Size(72, 16)
            Me.label36.TabIndex = 2
            Me.label36.Text = "Jog Step 3"
            Me.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'jog3
            '
            Me.jog3.FormattingEnabled = True
            Me.jog3.Items.AddRange(New Object() {".001", ".002", ".005", ".010", ".020", ".050", ".100", ".250", ".500", "1.000"})
            Me.jog3.Location = New System.Drawing.Point(17, 110)
            Me.jog3.Name = "jog3"
            Me.jog3.Size = New System.Drawing.Size(64, 21)
            Me.jog3.TabIndex = 77
            Me.toolTip1.SetToolTip(Me.jog3, "Leave blank for default step size of .100, or enter a custom step size." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is " &
        "selected by pushing the Right stick X-axis half right." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'label35
            '
            Me.label35.AutoSize = True
            Me.label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label35.Location = New System.Drawing.Point(86, 86)
            Me.label35.Name = "label35"
            Me.label35.Size = New System.Drawing.Size(72, 16)
            Me.label35.TabIndex = 1
            Me.label35.Text = "Jog Step 2"
            Me.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'jog2
            '
            Me.jog2.FormattingEnabled = True
            Me.jog2.Items.AddRange(New Object() {".001", ".002", ".005", ".010", ".020", ".050", ".100", ".250", ".500", "1.000"})
            Me.jog2.Location = New System.Drawing.Point(17, 86)
            Me.jog2.Name = "jog2"
            Me.jog2.Size = New System.Drawing.Size(64, 21)
            Me.jog2.TabIndex = 75
            Me.toolTip1.SetToolTip(Me.jog2, "Leave blank for default step size of .010, or enter a custom step size." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is " &
        "selected by pushing the Right stick X-axis half left." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'label34
            '
            Me.label34.AutoSize = True
            Me.label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label34.Location = New System.Drawing.Point(86, 60)
            Me.label34.Name = "label34"
            Me.label34.Size = New System.Drawing.Size(72, 16)
            Me.label34.TabIndex = 0
            Me.label34.Text = "Jog Step 1"
            Me.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'jog1
            '
            Me.jog1.FormattingEnabled = True
            Me.jog1.Items.AddRange(New Object() {".001", ".002", ".005", ".010", ".020", ".050", ".100", ".250", ".500", "1.000"})
            Me.jog1.Location = New System.Drawing.Point(17, 60)
            Me.jog1.Name = "jog1"
            Me.jog1.Size = New System.Drawing.Size(64, 21)
            Me.jog1.TabIndex = 73
            Me.toolTip1.SetToolTip(Me.jog1, "Leave blank for default step size of .001, or enter a custom step size." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is " &
        "selected by pushing the Right stick X-axis full left.")
            '
            'checkBox4
            '
            Me.checkBox4.AutoSize = True
            Me.checkBox4.Location = New System.Drawing.Point(33, 162)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(144, 17)
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
            Me.tabControl1.Name = "tabControl1"
            Me.tabControl1.SelectedIndex = 0
            Me.tabControl1.Size = New System.Drawing.Size(746, 759)
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
            Me.tabPage1.Location = New System.Drawing.Point(4, 22)
            Me.tabPage1.Name = "tabPage1"
            Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage1.Size = New System.Drawing.Size(738, 733)
            Me.tabPage1.TabIndex = 0
            Me.tabPage1.Text = "Controls"
            Me.tabPage1.UseVisualStyleBackColor = True
            '
            'btnConfigForm
            '
            Me.btnConfigForm.Location = New System.Drawing.Point(221, 681)
            Me.btnConfigForm.Name = "btnConfigForm"
            Me.btnConfigForm.Size = New System.Drawing.Size(156, 24)
            Me.btnConfigForm.TabIndex = 78
            Me.btnConfigForm.Text = "Config 'Open'  Button Code "
            Me.toolTip1.SetToolTip(Me.btnConfigForm, resources.GetString("btnConfigForm.ToolTip"))
            Me.btnConfigForm.UseVisualStyleBackColor = True
            '
            'cbSaveSettings
            '
            Me.cbSaveSettings.AutoSize = True
            Me.cbSaveSettings.Location = New System.Drawing.Point(16, 682)
            Me.cbSaveSettings.Margin = New System.Windows.Forms.Padding(2)
            Me.cbSaveSettings.Name = "cbSaveSettings"
            Me.cbSaveSettings.Size = New System.Drawing.Size(154, 17)
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
            Me.groupBoxDPad.Location = New System.Drawing.Point(317, 496)
            Me.groupBoxDPad.Name = "groupBoxDPad"
            Me.groupBoxDPad.Size = New System.Drawing.Size(198, 109)
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
            Me.comboLRShoulder.Location = New System.Drawing.Point(106, 22)
            Me.comboLRShoulder.Name = "comboLRShoulder"
            Me.comboLRShoulder.Size = New System.Drawing.Size(87, 21)
            Me.comboLRShoulder.TabIndex = 3
            '
            'comboUDDpad
            '
            Me.comboUDDpad.FormattingEnabled = True
            Me.comboUDDpad.Items.AddRange(New Object() {"Xaxis", "Yaxis", "Zaxis", "Aaxis", "Baxis", "Caxis", "Rev_Xaxis", "Rev_Yaxis", "Rev_Zaxis", "Rev_Aaxis", "Rev_Baxis", "Rev_Caxis"})
            Me.comboUDDpad.Location = New System.Drawing.Point(106, 48)
            Me.comboUDDpad.Name = "comboUDDpad"
            Me.comboUDDpad.Size = New System.Drawing.Size(87, 21)
            Me.comboUDDpad.TabIndex = 1
            '
            'comboLRDpad
            '
            Me.comboLRDpad.FormattingEnabled = True
            Me.comboLRDpad.Items.AddRange(New Object() {"Xaxis", "Yaxis", "Zaxis", "Aaxis", "Baxis", "Caxis", "Rev_Xaxis", "Rev_Yaxis", "Rev_Zaxis", "Rev_Aaxis", "Rev_Baxis", "Rev_Caxis"})
            Me.comboLRDpad.Location = New System.Drawing.Point(106, 74)
            Me.comboLRDpad.Name = "comboLRDpad"
            Me.comboLRDpad.Size = New System.Drawing.Size(87, 21)
            Me.comboLRDpad.TabIndex = 0
            '
            'Label38
            '
            Me.Label38.AutoSize = True
            Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.Label38.Location = New System.Drawing.Point(10, 24)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(93, 16)
            Me.Label38.TabIndex = 75
            Me.Label38.Text = "L/R Shoulders"
            Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label49
            '
            Me.Label49.AutoSize = True
            Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.Label49.Location = New System.Drawing.Point(10, 50)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(70, 16)
            Me.Label49.TabIndex = 73
            Me.Label49.Text = "U/D DPad"
            Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label50
            '
            Me.Label50.AutoSize = True
            Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.Label50.Location = New System.Drawing.Point(11, 76)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New System.Drawing.Size(67, 16)
            Me.Label50.TabIndex = 72
            Me.Label50.Text = "L/R DPad"
            Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.RadioButton16)
            Me.GroupBox5.Controls.Add(Me.RadioButton17)
            Me.GroupBox5.Controls.Add(Me.RadioButton18)
            Me.GroupBox5.Location = New System.Drawing.Point(2, 261)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(184, 94)
            Me.GroupBox5.TabIndex = 62
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Trigger Assignment"
            Me.toolTip1.SetToolTip(Me.GroupBox5, "Select the Velocity sensitivity rate for the left stick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "movement.  Linear is lea" &
        "st sensitive, Cubed is most " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensitive at low speed.")
            '
            'RadioButton16
            '
            Me.RadioButton16.AutoSize = True
            Me.RadioButton16.Location = New System.Drawing.Point(15, 23)
            Me.RadioButton16.Name = "RadioButton16"
            Me.RadioButton16.Size = New System.Drawing.Size(131, 17)
            Me.RadioButton16.TabIndex = 31
            Me.RadioButton16.Text = "Double Trigger Enable"
            Me.RadioButton16.UseVisualStyleBackColor = True
            '
            'RadioButton17
            '
            Me.RadioButton17.AutoSize = True
            Me.RadioButton17.Location = New System.Drawing.Point(15, 42)
            Me.RadioButton17.Name = "RadioButton17"
            Me.RadioButton17.Size = New System.Drawing.Size(126, 17)
            Me.RadioButton17.TabIndex = 30
            Me.RadioButton17.Text = "Single Trigger Enable"
            Me.RadioButton17.UseVisualStyleBackColor = True
            '
            'RadioButton18
            '
            Me.RadioButton18.AutoSize = True
            Me.RadioButton18.Checked = True
            Me.RadioButton18.Location = New System.Drawing.Point(15, 64)
            Me.RadioButton18.Name = "RadioButton18"
            Me.RadioButton18.Size = New System.Drawing.Size(164, 17)
            Me.RadioButton18.TabIndex = 29
            Me.RadioButton18.TabStop = True
            Me.RadioButton18.Text = "Triggers as Velocity Increaser"
            Me.RadioButton18.UseVisualStyleBackColor = True
            '
            'cbAutoEnable
            '
            Me.cbAutoEnable.AutoSize = True
            Me.cbAutoEnable.Location = New System.Drawing.Point(16, 663)
            Me.cbAutoEnable.Margin = New System.Windows.Forms.Padding(2)
            Me.cbAutoEnable.Name = "cbAutoEnable"
            Me.cbAutoEnable.Size = New System.Drawing.Size(186, 17)
            Me.cbAutoEnable.TabIndex = 16
            Me.cbAutoEnable.Text = "Automatically Enable Jog on Load"
            Me.toolTip1.SetToolTip(Me.cbAutoEnable, "Try to enable jog on load " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Fails if controler not found)")
            Me.cbAutoEnable.UseVisualStyleBackColor = True
            '
            'cbMinimizeOnLoad
            '
            Me.cbMinimizeOnLoad.AutoSize = True
            Me.cbMinimizeOnLoad.Location = New System.Drawing.Point(16, 644)
            Me.cbMinimizeOnLoad.Margin = New System.Windows.Forms.Padding(2)
            Me.cbMinimizeOnLoad.Name = "cbMinimizeOnLoad"
            Me.cbMinimizeOnLoad.Size = New System.Drawing.Size(155, 17)
            Me.cbMinimizeOnLoad.TabIndex = 15
            Me.cbMinimizeOnLoad.Text = "Automatically Hide on Load"
            Me.toolTip1.SetToolTip(Me.cbMinimizeOnLoad, "Hide plugin form on load")
            Me.cbMinimizeOnLoad.UseVisualStyleBackColor = True
            '
            'cbErrMsg
            '
            Me.cbErrMsg.AutoSize = True
            Me.cbErrMsg.Location = New System.Drawing.Point(16, 626)
            Me.cbErrMsg.Margin = New System.Windows.Forms.Padding(2)
            Me.cbErrMsg.Name = "cbErrMsg"
            Me.cbErrMsg.Size = New System.Drawing.Size(150, 17)
            Me.cbErrMsg.TabIndex = 14
            Me.cbErrMsg.Text = "Show messages/warnings"
            Me.toolTip1.SetToolTip(Me.cbErrMsg, "Use to suppress messages")
            Me.cbErrMsg.UseVisualStyleBackColor = True
            '
            'cbRightStickEnab
            '
            Me.cbRightStickEnab.AutoSize = True
            Me.cbRightStickEnab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbRightStickEnab.Location = New System.Drawing.Point(530, 667)
            Me.cbRightStickEnab.Name = "cbRightStickEnab"
            Me.cbRightStickEnab.Size = New System.Drawing.Size(154, 20)
            Me.cbRightStickEnab.TabIndex = 11
            Me.cbRightStickEnab.Text = "Enable Right Stick"
            Me.cbRightStickEnab.UseVisualStyleBackColor = True
            '
            'cbLeftStickEnab
            '
            Me.cbLeftStickEnab.AutoSize = True
            Me.cbLeftStickEnab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbLeftStickEnab.Location = New System.Drawing.Point(530, 646)
            Me.cbLeftStickEnab.Name = "cbLeftStickEnab"
            Me.cbLeftStickEnab.Size = New System.Drawing.Size(143, 20)
            Me.cbLeftStickEnab.TabIndex = 10
            Me.cbLeftStickEnab.Text = "Enable Left Stick"
            Me.cbLeftStickEnab.UseVisualStyleBackColor = True
            '
            'btnLoadSettings
            '
            Me.btnLoadSettings.Location = New System.Drawing.Point(221, 654)
            Me.btnLoadSettings.Name = "btnLoadSettings"
            Me.btnLoadSettings.Size = New System.Drawing.Size(157, 24)
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
            Me.groupBox8.Location = New System.Drawing.Point(317, 358)
            Me.groupBox8.Name = "groupBox8"
            Me.groupBox8.Size = New System.Drawing.Size(198, 132)
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
            Me.comboBoxRYStick.Location = New System.Drawing.Point(105, 99)
            Me.comboBoxRYStick.Name = "comboBoxRYStick"
            Me.comboBoxRYStick.Size = New System.Drawing.Size(88, 21)
            Me.comboBoxRYStick.TabIndex = 3
            '
            'comboBoxRXStick
            '
            Me.comboBoxRXStick.FormattingEnabled = True
            Me.comboBoxRXStick.Items.AddRange(New Object() {"Xaxis", "Yaxis", "Zaxis", "Aaxis", "Baxis", "Caxis", "Rev_Xaxis", "Rev_Yaxis", "Rev_Zaxis", "Rev_Aaxis", "Rev_Baxis", "Rev_Caxis", "JogStep"})
            Me.comboBoxRXStick.Location = New System.Drawing.Point(105, 73)
            Me.comboBoxRXStick.Name = "comboBoxRXStick"
            Me.comboBoxRXStick.Size = New System.Drawing.Size(88, 21)
            Me.comboBoxRXStick.TabIndex = 2
            Me.toolTip1.SetToolTip(Me.comboBoxRXStick, "Assign either an axis control, or Jog Step Size " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "selection")
            '
            'comboBoxLYStick
            '
            Me.comboBoxLYStick.FormattingEnabled = True
            Me.comboBoxLYStick.Items.AddRange(New Object() {"Xaxis", "Yaxis", "Zaxis", "Aaxis", "Baxis", "Caxis", "Rev_Xaxis", "Rev_Yaxis", "Rev_Zaxis", "Rev_Aaxis", "Rev_Baxis", "Rev_Caxis"})
            Me.comboBoxLYStick.Location = New System.Drawing.Point(105, 48)
            Me.comboBoxLYStick.Name = "comboBoxLYStick"
            Me.comboBoxLYStick.Size = New System.Drawing.Size(88, 21)
            Me.comboBoxLYStick.TabIndex = 1
            '
            'comboBoxLXStick
            '
            Me.comboBoxLXStick.FormattingEnabled = True
            Me.comboBoxLXStick.Items.AddRange(New Object() {"Xaxis", "Yaxis", "Zaxis", "Aaxis", "Baxis", "Caxis", "Rev_Xaxis", "Rev_Yaxis", "Rev_Zaxis", "Rev_Aaxis", "Rev_Baxis", "Rev_Caxis"})
            Me.comboBoxLXStick.Location = New System.Drawing.Point(105, 23)
            Me.comboBoxLXStick.Name = "comboBoxLXStick"
            Me.comboBoxLXStick.Size = New System.Drawing.Size(88, 21)
            Me.comboBoxLXStick.TabIndex = 0
            '
            'label32
            '
            Me.label32.AutoSize = True
            Me.label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label32.Location = New System.Drawing.Point(11, 99)
            Me.label32.Name = "label32"
            Me.label32.Size = New System.Drawing.Size(79, 16)
            Me.label32.TabIndex = 75
            Me.label32.Text = "RIght Y Axis"
            Me.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label33
            '
            Me.label33.AutoSize = True
            Me.label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label33.Location = New System.Drawing.Point(11, 75)
            Me.label33.Name = "label33"
            Me.label33.Size = New System.Drawing.Size(78, 16)
            Me.label33.TabIndex = 74
            Me.label33.Text = "RIght X Axis"
            Me.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label31
            '
            Me.label31.AutoSize = True
            Me.label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label31.Location = New System.Drawing.Point(10, 50)
            Me.label31.Name = "label31"
            Me.label31.Size = New System.Drawing.Size(69, 16)
            Me.label31.TabIndex = 73
            Me.label31.Text = "Left Y Axis"
            Me.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label30
            '
            Me.label30.AutoSize = True
            Me.label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label30.Location = New System.Drawing.Point(11, 25)
            Me.label30.Name = "label30"
            Me.label30.Size = New System.Drawing.Size(68, 16)
            Me.label30.TabIndex = 72
            Me.label30.Text = "Left X Axis"
            Me.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'groupBox9
            '
            Me.groupBox9.Controls.Add(Me.radioButton13)
            Me.groupBox9.Controls.Add(Me.radioButton14)
            Me.groupBox9.Controls.Add(Me.radioButton15)
            Me.groupBox9.Location = New System.Drawing.Point(2, 261)
            Me.groupBox9.Name = "groupBox9"
            Me.groupBox9.Size = New System.Drawing.Size(184, 94)
            Me.groupBox9.TabIndex = 62
            Me.groupBox9.TabStop = False
            Me.groupBox9.Text = "Trigger Assignment"
            Me.toolTip1.SetToolTip(Me.groupBox9, "Select the Velocity sensitivity rate for the left stick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "movement.  Linear is lea" &
        "st sensitive, Cubed is most " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensitive at low speed.")
            '
            'radioButton13
            '
            Me.radioButton13.AutoSize = True
            Me.radioButton13.Location = New System.Drawing.Point(15, 23)
            Me.radioButton13.Name = "radioButton13"
            Me.radioButton13.Size = New System.Drawing.Size(131, 17)
            Me.radioButton13.TabIndex = 31
            Me.radioButton13.Text = "Double Trigger Enable"
            Me.radioButton13.UseVisualStyleBackColor = True
            '
            'radioButton14
            '
            Me.radioButton14.AutoSize = True
            Me.radioButton14.Location = New System.Drawing.Point(15, 42)
            Me.radioButton14.Name = "radioButton14"
            Me.radioButton14.Size = New System.Drawing.Size(126, 17)
            Me.radioButton14.TabIndex = 30
            Me.radioButton14.Text = "Single Trigger Enable"
            Me.radioButton14.UseVisualStyleBackColor = True
            '
            'radioButton15
            '
            Me.radioButton15.AutoSize = True
            Me.radioButton15.Checked = True
            Me.radioButton15.Location = New System.Drawing.Point(15, 64)
            Me.radioButton15.Name = "radioButton15"
            Me.radioButton15.Size = New System.Drawing.Size(164, 17)
            Me.radioButton15.TabIndex = 29
            Me.radioButton15.TabStop = True
            Me.radioButton15.Text = "Triggers as Velocity Increaser"
            Me.radioButton15.UseVisualStyleBackColor = True
            '
            'groupBox6
            '
            Me.groupBox6.Controls.Add(Me.groupBox7)
            Me.groupBox6.Controls.Add(Me.radioButton7)
            Me.groupBox6.Controls.Add(Me.radioButton8)
            Me.groupBox6.Controls.Add(Me.radioButton9)
            Me.groupBox6.Location = New System.Drawing.Point(448, 5)
            Me.groupBox6.Name = "groupBox6"
            Me.groupBox6.Size = New System.Drawing.Size(184, 94)
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
            Me.groupBox7.Location = New System.Drawing.Point(2, 261)
            Me.groupBox7.Name = "groupBox7"
            Me.groupBox7.Size = New System.Drawing.Size(184, 94)
            Me.groupBox7.TabIndex = 62
            Me.groupBox7.TabStop = False
            Me.groupBox7.Text = "Trigger Assignment"
            Me.toolTip1.SetToolTip(Me.groupBox7, "Select the Velocity sensitivity rate for the left stick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "movement.  Linear is lea" &
        "st sensitive, Cubed is most " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensitive at low speed.")
            '
            'radioButton10
            '
            Me.radioButton10.AutoSize = True
            Me.radioButton10.Location = New System.Drawing.Point(15, 23)
            Me.radioButton10.Name = "radioButton10"
            Me.radioButton10.Size = New System.Drawing.Size(131, 17)
            Me.radioButton10.TabIndex = 31
            Me.radioButton10.Text = "Double Trigger Enable"
            Me.radioButton10.UseVisualStyleBackColor = True
            '
            'radioButton11
            '
            Me.radioButton11.AutoSize = True
            Me.radioButton11.Location = New System.Drawing.Point(15, 42)
            Me.radioButton11.Name = "radioButton11"
            Me.radioButton11.Size = New System.Drawing.Size(126, 17)
            Me.radioButton11.TabIndex = 30
            Me.radioButton11.Text = "Single Trigger Enable"
            Me.radioButton11.UseVisualStyleBackColor = True
            '
            'radioButton12
            '
            Me.radioButton12.AutoSize = True
            Me.radioButton12.Checked = True
            Me.radioButton12.Location = New System.Drawing.Point(15, 64)
            Me.radioButton12.Name = "radioButton12"
            Me.radioButton12.Size = New System.Drawing.Size(164, 17)
            Me.radioButton12.TabIndex = 29
            Me.radioButton12.TabStop = True
            Me.radioButton12.Text = "Triggers as Velocity Increaser"
            Me.radioButton12.UseVisualStyleBackColor = True
            '
            'radioButton7
            '
            Me.radioButton7.AutoSize = True
            Me.radioButton7.Location = New System.Drawing.Point(15, 23)
            Me.radioButton7.Name = "radioButton7"
            Me.radioButton7.Size = New System.Drawing.Size(131, 17)
            Me.radioButton7.TabIndex = 31
            Me.radioButton7.Text = "Double Trigger Enable"
            Me.toolTip1.SetToolTip(Me.radioButton7, "Double Trigger Enable requires both triggers to be simultaneously" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "held down to a" &
        "llow jogging with either of the analog joysticks.")
            Me.radioButton7.UseVisualStyleBackColor = True
            '
            'radioButton8
            '
            Me.radioButton8.AutoSize = True
            Me.radioButton8.Location = New System.Drawing.Point(15, 42)
            Me.radioButton8.Name = "radioButton8"
            Me.radioButton8.Size = New System.Drawing.Size(126, 17)
            Me.radioButton8.TabIndex = 30
            Me.radioButton8.Text = "Single Trigger Enable"
            Me.toolTip1.SetToolTip(Me.radioButton8, "Single Trigger Enable requires either one of the triggers to be individually" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hel" &
        "d down to allow jogging with either of the analog joysticks." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            Me.radioButton8.UseVisualStyleBackColor = True
            '
            'radioButton9
            '
            Me.radioButton9.AutoSize = True
            Me.radioButton9.Checked = True
            Me.radioButton9.Location = New System.Drawing.Point(15, 64)
            Me.radioButton9.Name = "radioButton9"
            Me.radioButton9.Size = New System.Drawing.Size(164, 17)
            Me.radioButton9.TabIndex = 29
            Me.radioButton9.TabStop = True
            Me.radioButton9.Text = "Triggers as Velocity Increaser"
            Me.toolTip1.SetToolTip(Me.radioButton9, resources.GetString("radioButton9.ToolTip"))
            Me.radioButton9.UseVisualStyleBackColor = True
            '
            'btnShowCodes
            '
            Me.btnShowCodes.Location = New System.Drawing.Point(331, 31)
            Me.btnShowCodes.Name = "btnShowCodes"
            Me.btnShowCodes.Size = New System.Drawing.Size(100, 50)
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
            Me.groupBox3.Location = New System.Drawing.Point(4, 5)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(298, 616)
            Me.groupBox3.TabIndex = 12
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "Test Buttons Out"
            Me.toolTip1.SetToolTip(Me.groupBox3, resources.GetString("groupBox3.ToolTip"))
            '
            'btnLED14
            '
            Me.btnLED14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED14.Location = New System.Drawing.Point(12, 580)
            Me.btnLED14.Name = "btnLED14"
            Me.btnLED14.Size = New System.Drawing.Size(15, 15)
            Me.btnLED14.TabIndex = 86
            Me.btnLED14.UseVisualStyleBackColor = True
            '
            'btnLED10
            '
            Me.btnLED10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED10.Location = New System.Drawing.Point(12, 256)
            Me.btnLED10.Name = "btnLED10"
            Me.btnLED10.Size = New System.Drawing.Size(15, 15)
            Me.btnLED10.TabIndex = 82
            Me.btnLED10.UseVisualStyleBackColor = True
            '
            'btnLED13
            '
            Me.btnLED13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED13.Location = New System.Drawing.Point(12, 546)
            Me.btnLED13.Name = "btnLED13"
            Me.btnLED13.Size = New System.Drawing.Size(15, 15)
            Me.btnLED13.TabIndex = 85
            Me.btnLED13.UseVisualStyleBackColor = True
            '
            'btnLED9
            '
            Me.btnLED9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED9.Location = New System.Drawing.Point(12, 219)
            Me.btnLED9.Name = "btnLED9"
            Me.btnLED9.Size = New System.Drawing.Size(15, 15)
            Me.btnLED9.TabIndex = 81
            Me.btnLED9.UseVisualStyleBackColor = True
            '
            'btnLED8
            '
            Me.btnLED8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED8.Location = New System.Drawing.Point(12, 182)
            Me.btnLED8.Name = "btnLED8"
            Me.btnLED8.Size = New System.Drawing.Size(15, 15)
            Me.btnLED8.TabIndex = 80
            Me.btnLED8.UseVisualStyleBackColor = True
            '
            'btnLED7
            '
            Me.btnLED7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED7.Location = New System.Drawing.Point(12, 148)
            Me.btnLED7.Name = "btnLED7"
            Me.btnLED7.Size = New System.Drawing.Size(15, 15)
            Me.btnLED7.TabIndex = 79
            Me.btnLED7.UseVisualStyleBackColor = True
            '
            'comboBox7
            '
            Me.comboBox7.FormattingEnabled = True
            Me.comboBox7.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox7.Location = New System.Drawing.Point(217, 256)
            Me.comboBox7.Name = "comboBox7"
            Me.comboBox7.Size = New System.Drawing.Size(64, 21)
            Me.comboBox7.TabIndex = 7
            '
            'comboBox8
            '
            Me.comboBox8.FormattingEnabled = True
            Me.comboBox8.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox8.Location = New System.Drawing.Point(130, 257)
            Me.comboBox8.Name = "comboBox8"
            Me.comboBox8.Size = New System.Drawing.Size(64, 21)
            Me.comboBox8.TabIndex = 6
            '
            'comboBox5
            '
            Me.comboBox5.FormattingEnabled = True
            Me.comboBox5.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox5.Location = New System.Drawing.Point(217, 219)
            Me.comboBox5.Name = "comboBox5"
            Me.comboBox5.Size = New System.Drawing.Size(64, 21)
            Me.comboBox5.TabIndex = 5
            '
            'comboBox6
            '
            Me.comboBox6.FormattingEnabled = True
            Me.comboBox6.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox6.Location = New System.Drawing.Point(130, 220)
            Me.comboBox6.Name = "comboBox6"
            Me.comboBox6.Size = New System.Drawing.Size(64, 21)
            Me.comboBox6.TabIndex = 4
            '
            'comboBox3
            '
            Me.comboBox3.FormattingEnabled = True
            Me.comboBox3.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox3.Location = New System.Drawing.Point(217, 182)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(64, 21)
            Me.comboBox3.TabIndex = 3
            '
            'comboBox4
            '
            Me.comboBox4.FormattingEnabled = True
            Me.comboBox4.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox4.Location = New System.Drawing.Point(130, 183)
            Me.comboBox4.Name = "comboBox4"
            Me.comboBox4.Size = New System.Drawing.Size(64, 21)
            Me.comboBox4.TabIndex = 2
            '
            'comboBox2
            '
            Me.comboBox2.FormattingEnabled = True
            Me.comboBox2.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox2.Location = New System.Drawing.Point(130, 146)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(64, 21)
            Me.comboBox2.TabIndex = 0
            '
            'comboBox1
            '
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox1.Location = New System.Drawing.Point(217, 145)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(64, 21)
            Me.comboBox1.TabIndex = 1
            '
            'label22
            '
            Me.label22.AutoSize = True
            Me.label22.Location = New System.Drawing.Point(214, 118)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(75, 26)
            Me.label22.TabIndex = 41
            Me.label22.Text = "Release Press" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Functions"
            Me.toolTip1.SetToolTip(Me.label22, resources.GetString("label22.ToolTip"))
            '
            'comboBox15
            '
            Me.comboBox15.FormattingEnabled = True
            Me.comboBox15.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox15.Location = New System.Drawing.Point(217, 579)
            Me.comboBox15.Name = "comboBox15"
            Me.comboBox15.Size = New System.Drawing.Size(64, 21)
            Me.comboBox15.TabIndex = 15
            '
            'label21
            '
            Me.label21.AutoSize = True
            Me.label21.Location = New System.Drawing.Point(128, 117)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(53, 26)
            Me.label21.TabIndex = 40
            Me.label21.Text = "On Press" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Functions"
            Me.toolTip1.SetToolTip(Me.label21, resources.GetString("label21.ToolTip"))
            '
            'comboBox16
            '
            Me.comboBox16.FormattingEnabled = True
            Me.comboBox16.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox16.Location = New System.Drawing.Point(130, 580)
            Me.comboBox16.Name = "comboBox16"
            Me.comboBox16.Size = New System.Drawing.Size(64, 21)
            Me.comboBox16.TabIndex = 14
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label10.Location = New System.Drawing.Point(32, 255)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(57, 16)
            Me.label10.TabIndex = 38
            Me.label10.Text = "Y Button"
            Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label9.Location = New System.Drawing.Point(32, 218)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(56, 16)
            Me.label9.TabIndex = 37
            Me.label9.Text = "X Button"
            Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'comboBox13
            '
            Me.comboBox13.FormattingEnabled = True
            Me.comboBox13.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox13.Location = New System.Drawing.Point(217, 543)
            Me.comboBox13.Name = "comboBox13"
            Me.comboBox13.Size = New System.Drawing.Size(64, 21)
            Me.comboBox13.TabIndex = 13
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label8.Location = New System.Drawing.Point(31, 181)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(57, 16)
            Me.label8.TabIndex = 36
            Me.label8.Text = "B Button"
            Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label7.Location = New System.Drawing.Point(31, 147)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(57, 16)
            Me.label7.TabIndex = 35
            Me.label7.Text = "A Button"
            Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'comboBox14
            '
            Me.comboBox14.FormattingEnabled = True
            Me.comboBox14.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox14.Location = New System.Drawing.Point(130, 544)
            Me.comboBox14.Name = "comboBox14"
            Me.comboBox14.Size = New System.Drawing.Size(64, 21)
            Me.comboBox14.TabIndex = 12
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label6.Location = New System.Drawing.Point(118, 88)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(83, 16)
            Me.label6.TabIndex = 34
            Me.label6.Text = "RightTrigger"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.toolTip1.SetToolTip(Me.label6, "Accelerator for the right stick jogs (Z)")
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label5.Location = New System.Drawing.Point(9, 88)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(73, 16)
            Me.label5.TabIndex = 33
            Me.label5.Text = "LeftTrigger"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.toolTip1.SetToolTip(Me.label5, "Accelerator for the left stick jogs (X and Y)")
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label13.Location = New System.Drawing.Point(30, 545)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(76, 16)
            Me.label13.TabIndex = 41
            Me.label13.Text = "BackButton"
            Me.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label14
            '
            Me.label14.AutoSize = True
            Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label14.Location = New System.Drawing.Point(30, 581)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(72, 16)
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
            Me.GroupBox4.Location = New System.Drawing.Point(6, 279)
            Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
            Me.GroupBox4.Size = New System.Drawing.Size(286, 255)
            Me.GroupBox4.TabIndex = 77
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "GroupBox4"
            '
            'btnLED18
            '
            Me.btnLED18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED18.Location = New System.Drawing.Point(5, 229)
            Me.btnLED18.Name = "btnLED18"
            Me.btnLED18.Size = New System.Drawing.Size(15, 15)
            Me.btnLED18.TabIndex = 90
            Me.btnLED18.UseVisualStyleBackColor = True
            '
            'btnLED17
            '
            Me.btnLED17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED17.Location = New System.Drawing.Point(5, 195)
            Me.btnLED17.Name = "btnLED17"
            Me.btnLED17.Size = New System.Drawing.Size(15, 15)
            Me.btnLED17.TabIndex = 89
            Me.btnLED17.UseVisualStyleBackColor = True
            '
            'btnLED16
            '
            Me.btnLED16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED16.Location = New System.Drawing.Point(5, 155)
            Me.btnLED16.Name = "btnLED16"
            Me.btnLED16.Size = New System.Drawing.Size(15, 15)
            Me.btnLED16.TabIndex = 88
            Me.btnLED16.UseVisualStyleBackColor = True
            '
            'btnLED12
            '
            Me.btnLED12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED12.Location = New System.Drawing.Point(5, 83)
            Me.btnLED12.Name = "btnLED12"
            Me.btnLED12.Size = New System.Drawing.Size(15, 15)
            Me.btnLED12.TabIndex = 84
            Me.btnLED12.UseVisualStyleBackColor = True
            '
            'btnLED15
            '
            Me.btnLED15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED15.Location = New System.Drawing.Point(5, 121)
            Me.btnLED15.Name = "btnLED15"
            Me.btnLED15.Size = New System.Drawing.Size(15, 15)
            Me.btnLED15.TabIndex = 87
            Me.btnLED15.UseVisualStyleBackColor = True
            '
            'label23
            '
            Me.label23.AutoSize = True
            Me.label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label23.Location = New System.Drawing.Point(160, 45)
            Me.label23.Name = "label23"
            Me.label23.Size = New System.Drawing.Size(101, 17)
            Me.label23.TabIndex = 66
            Me.label23.Text = "Z Step Jog +"
            '
            'btnLED11
            '
            Me.btnLED11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLED11.Location = New System.Drawing.Point(5, 49)
            Me.btnLED11.Name = "btnLED11"
            Me.btnLED11.Size = New System.Drawing.Size(15, 15)
            Me.btnLED11.TabIndex = 83
            Me.btnLED11.UseVisualStyleBackColor = True
            '
            'cbCustomDpad
            '
            Me.cbCustomDpad.AutoSize = True
            Me.cbCustomDpad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbCustomDpad.Location = New System.Drawing.Point(56, 15)
            Me.cbCustomDpad.Margin = New System.Windows.Forms.Padding(2)
            Me.cbCustomDpad.Name = "cbCustomDpad"
            Me.cbCustomDpad.Size = New System.Drawing.Size(215, 21)
            Me.cbCustomDpad.TabIndex = 13
            Me.cbCustomDpad.Text = "Customize DPad/Shoulder"
            Me.cbCustomDpad.UseVisualStyleBackColor = True
            '
            'label27
            '
            Me.label27.AutoSize = True
            Me.label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label27.Location = New System.Drawing.Point(160, 230)
            Me.label27.Name = "label27"
            Me.label27.Size = New System.Drawing.Size(101, 17)
            Me.label27.TabIndex = 71
            Me.label27.Text = "X Step Jog +"
            '
            'comboBox9
            '
            Me.comboBox9.Enabled = False
            Me.comboBox9.FormattingEnabled = True
            Me.comboBox9.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox9.Location = New System.Drawing.Point(211, 41)
            Me.comboBox9.Name = "comboBox9"
            Me.comboBox9.Size = New System.Drawing.Size(64, 21)
            Me.comboBox9.TabIndex = 9
            Me.comboBox9.Visible = False
            '
            'comboBox10
            '
            Me.comboBox10.Enabled = False
            Me.comboBox10.FormattingEnabled = True
            Me.comboBox10.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox10.Location = New System.Drawing.Point(122, 41)
            Me.comboBox10.Name = "comboBox10"
            Me.comboBox10.Size = New System.Drawing.Size(64, 21)
            Me.comboBox10.TabIndex = 8
            Me.comboBox10.Visible = False
            '
            'label28
            '
            Me.label28.AutoSize = True
            Me.label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label28.Location = New System.Drawing.Point(160, 193)
            Me.label28.Name = "label28"
            Me.label28.Size = New System.Drawing.Size(98, 17)
            Me.label28.TabIndex = 70
            Me.label28.Text = "X Step Jog -"
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label12.Location = New System.Drawing.Point(22, 82)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(75, 16)
            Me.label12.TabIndex = 40
            Me.label12.Text = "R Shoulder"
            Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label26
            '
            Me.label26.AutoSize = True
            Me.label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label26.Location = New System.Drawing.Point(160, 154)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(98, 17)
            Me.label26.TabIndex = 69
            Me.label26.Text = "Y Step Jog -"
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label18.Location = New System.Drawing.Point(22, 231)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(77, 16)
            Me.label18.TabIndex = 46
            Me.label18.Text = "DPad Right"
            Me.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label25
            '
            Me.label25.AutoSize = True
            Me.label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label25.Location = New System.Drawing.Point(160, 119)
            Me.label25.Name = "label25"
            Me.label25.Size = New System.Drawing.Size(101, 17)
            Me.label25.TabIndex = 68
            Me.label25.Text = "Y Step Jog +"
            '
            'label17
            '
            Me.label17.AutoSize = True
            Me.label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label17.Location = New System.Drawing.Point(22, 194)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(67, 16)
            Me.label17.TabIndex = 45
            Me.label17.Text = "DPad Left"
            Me.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label24
            '
            Me.label24.AutoSize = True
            Me.label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label24.Location = New System.Drawing.Point(159, 80)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(98, 17)
            Me.label24.TabIndex = 67
            Me.label24.Text = "Z Step Jog -"
            '
            'label16
            '
            Me.label16.AutoSize = True
            Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label16.Location = New System.Drawing.Point(22, 156)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(80, 16)
            Me.label16.TabIndex = 44
            Me.label16.Text = "DPad Down"
            Me.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label15
            '
            Me.label15.AutoSize = True
            Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label15.Location = New System.Drawing.Point(22, 120)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(64, 16)
            Me.label15.TabIndex = 43
            Me.label15.Text = "DPad Up"
            Me.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'comboBox23
            '
            Me.comboBox23.Enabled = False
            Me.comboBox23.FormattingEnabled = True
            Me.comboBox23.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox23.Location = New System.Drawing.Point(211, 224)
            Me.comboBox23.Name = "comboBox23"
            Me.comboBox23.Size = New System.Drawing.Size(64, 21)
            Me.comboBox23.TabIndex = 23
            Me.comboBox23.Visible = False
            '
            'comboBox12
            '
            Me.comboBox12.Enabled = False
            Me.comboBox12.FormattingEnabled = True
            Me.comboBox12.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox12.Location = New System.Drawing.Point(122, 76)
            Me.comboBox12.Name = "comboBox12"
            Me.comboBox12.Size = New System.Drawing.Size(64, 21)
            Me.comboBox12.TabIndex = 10
            Me.comboBox12.Visible = False
            '
            'comboBox24
            '
            Me.comboBox24.Enabled = False
            Me.comboBox24.FormattingEnabled = True
            Me.comboBox24.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox24.Location = New System.Drawing.Point(122, 226)
            Me.comboBox24.Name = "comboBox24"
            Me.comboBox24.Size = New System.Drawing.Size(64, 21)
            Me.comboBox24.TabIndex = 22
            Me.comboBox24.Visible = False
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.label11.Location = New System.Drawing.Point(22, 48)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(72, 16)
            Me.label11.TabIndex = 39
            Me.label11.Text = "L Shoulder"
            Me.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'comboBox11
            '
            Me.comboBox11.Enabled = False
            Me.comboBox11.FormattingEnabled = True
            Me.comboBox11.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox11.Location = New System.Drawing.Point(211, 76)
            Me.comboBox11.Name = "comboBox11"
            Me.comboBox11.Size = New System.Drawing.Size(64, 21)
            Me.comboBox11.TabIndex = 11
            Me.comboBox11.Visible = False
            '
            'comboBox21
            '
            Me.comboBox21.Enabled = False
            Me.comboBox21.FormattingEnabled = True
            Me.comboBox21.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox21.Location = New System.Drawing.Point(211, 188)
            Me.comboBox21.Name = "comboBox21"
            Me.comboBox21.Size = New System.Drawing.Size(64, 21)
            Me.comboBox21.TabIndex = 21
            Me.comboBox21.Visible = False
            '
            'comboBox18
            '
            Me.comboBox18.Enabled = False
            Me.comboBox18.FormattingEnabled = True
            Me.comboBox18.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox18.Location = New System.Drawing.Point(122, 115)
            Me.comboBox18.Name = "comboBox18"
            Me.comboBox18.Size = New System.Drawing.Size(64, 21)
            Me.comboBox18.TabIndex = 16
            Me.comboBox18.Visible = False
            '
            'comboBox22
            '
            Me.comboBox22.Enabled = False
            Me.comboBox22.FormattingEnabled = True
            Me.comboBox22.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox22.Location = New System.Drawing.Point(122, 188)
            Me.comboBox22.Name = "comboBox22"
            Me.comboBox22.Size = New System.Drawing.Size(64, 21)
            Me.comboBox22.TabIndex = 20
            Me.comboBox22.Visible = False
            '
            'comboBox17
            '
            Me.comboBox17.Enabled = False
            Me.comboBox17.FormattingEnabled = True
            Me.comboBox17.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox17.Location = New System.Drawing.Point(211, 114)
            Me.comboBox17.Name = "comboBox17"
            Me.comboBox17.Size = New System.Drawing.Size(64, 21)
            Me.comboBox17.TabIndex = 17
            Me.comboBox17.Visible = False
            '
            'comboBox19
            '
            Me.comboBox19.Enabled = False
            Me.comboBox19.FormattingEnabled = True
            Me.comboBox19.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox19.Location = New System.Drawing.Point(211, 150)
            Me.comboBox19.Name = "comboBox19"
            Me.comboBox19.Size = New System.Drawing.Size(64, 21)
            Me.comboBox19.TabIndex = 19
            Me.comboBox19.Visible = False
            '
            'comboBox20
            '
            Me.comboBox20.Enabled = False
            Me.comboBox20.FormattingEnabled = True
            Me.comboBox20.Items.AddRange(New Object() {"Button number", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242 to 292", "293 to 343", "344 to 394", "400 to 449", "450 - 500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525"})
            Me.comboBox20.Location = New System.Drawing.Point(122, 152)
            Me.comboBox20.Name = "comboBox20"
            Me.comboBox20.Size = New System.Drawing.Size(64, 21)
            Me.comboBox20.TabIndex = 18
            Me.comboBox20.Visible = False
            '
            'btnSaveSettings
            '
            Me.btnSaveSettings.Location = New System.Drawing.Point(221, 627)
            Me.btnSaveSettings.Name = "btnSaveSettings"
            Me.btnSaveSettings.Size = New System.Drawing.Size(156, 24)
            Me.btnSaveSettings.TabIndex = 7
            Me.btnSaveSettings.Text = "Save Settings"
            Me.toolTip1.SetToolTip(Me.btnSaveSettings, "Save the setup to XML file")
            Me.btnSaveSettings.UseVisualStyleBackColor = True
            '
            'btnConnect
            '
            Me.btnConnect.Location = New System.Drawing.Point(323, 32)
            Me.btnConnect.Name = "btnConnect"
            Me.btnConnect.Size = New System.Drawing.Size(116, 48)
            Me.btnConnect.TabIndex = 0
            Me.btnConnect.Text = "Not Connected"
            Me.btnConnect.UseVisualStyleBackColor = True
            Me.btnConnect.Visible = False
            '
            'tabPage2
            '
            Me.tabPage2.Controls.Add(Me.textBox1)
            Me.tabPage2.Location = New System.Drawing.Point(4, 22)
            Me.tabPage2.Name = "tabPage2"
            Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage2.Size = New System.Drawing.Size(738, 733)
            Me.tabPage2.TabIndex = 1
            Me.tabPage2.Text = "Help"
            Me.tabPage2.UseVisualStyleBackColor = True
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(26, 19)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.textBox1.Size = New System.Drawing.Size(568, 592)
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
            Me.tabPage3.Location = New System.Drawing.Point(4, 22)
            Me.tabPage3.Name = "tabPage3"
            Me.tabPage3.Size = New System.Drawing.Size(738, 733)
            Me.tabPage3.TabIndex = 2
            Me.tabPage3.Text = "About"
            Me.tabPage3.UseVisualStyleBackColor = True
            '
            'lblAppVersion
            '
            Me.lblAppVersion.AutoSize = True
            Me.lblAppVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            Me.lblAppVersion.Location = New System.Drawing.Point(89, 352)
            Me.lblAppVersion.Name = "lblAppVersion"
            Me.lblAppVersion.Size = New System.Drawing.Size(97, 16)
            Me.lblAppVersion.TabIndex = 39
            Me.lblAppVersion.Text = "Plugin Version:"
            Me.lblAppVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'linkLabel2
            '
            Me.linkLabel2.AutoSize = True
            Me.linkLabel2.Location = New System.Drawing.Point(89, 322)
            Me.linkLabel2.Name = "linkLabel2"
            Me.linkLabel2.Size = New System.Drawing.Size(101, 13)
            Me.linkLabel2.TabIndex = 4
            Me.linkLabel2.TabStop = True
            Me.linkLabel2.Text = "www.craftycnc.com"
            '
            'linkLabel1
            '
            Me.linkLabel1.AutoSize = True
            Me.linkLabel1.Location = New System.Drawing.Point(89, 298)
            Me.linkLabel1.Name = "linkLabel1"
            Me.linkLabel1.Size = New System.Drawing.Size(120, 13)
            Me.linkLabel1.TabIndex = 2
            Me.linkLabel1.TabStop = True
            Me.linkLabel1.Tag = "mailto:eabrust@craftycnc.com"
            Me.linkLabel1.Text = "eabrust@craftycnc.com"
            '
            'textBox2
            '
            Me.textBox2.Location = New System.Drawing.Point(92, 193)
            Me.textBox2.Multiline = True
            Me.textBox2.Name = "textBox2"
            Me.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
            Me.textBox2.Size = New System.Drawing.Size(370, 102)
            Me.textBox2.TabIndex = 1
            Me.textBox2.Text = "Copyright 2020, CraftyCNC / E Brust" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This plugin is provided without any guaran" &
    "tee of any kind." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please use caution with testing." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Questions or comments?  Pl" &
    "ease email me:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'pictureBox1
            '
            Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pictureBox1.Image = Global.Xboxcontroller.Resources.CraftyCNC_Med
            Me.pictureBox1.Location = New System.Drawing.Point(92, 37)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(370, 150)
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
            Me.contextMenuStrip1.Size = New System.Drawing.Size(141, 48)
            '
            'toolStripMenuItem1
            '
            Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
            Me.toolStripMenuItem1.Size = New System.Drawing.Size(140, 22)
            Me.toolStripMenuItem1.Text = "Show Plugin"
            '
            'toolStripMenuItem2
            '
            Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
            Me.toolStripMenuItem2.Size = New System.Drawing.Size(140, 22)
            Me.toolStripMenuItem2.Text = "Exit"
            '
            'statusStrip1
            '
            Me.statusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
            Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1, Me.toolStripStatusLabel2})
            Me.statusStrip1.Location = New System.Drawing.Point(0, 737)
            Me.statusStrip1.Name = "statusStrip1"
            Me.statusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
            Me.statusStrip1.Size = New System.Drawing.Size(746, 22)
            Me.statusStrip1.TabIndex = 52
            Me.statusStrip1.Text = "statusStrip1"
            '
            'toolStripStatusLabel1
            '
            Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
            Me.toolStripStatusLabel1.Size = New System.Drawing.Size(59, 17)
            Me.toolStripStatusLabel1.Text = "Loading..."
            '
            'toolStripStatusLabel2
            '
            Me.toolStripStatusLabel2.Name = "toolStripStatusLabel2"
            Me.toolStripStatusLabel2.Size = New System.Drawing.Size(59, 17)
            Me.toolStripStatusLabel2.Text = "Loading..."
            '
            'timerUpdateScreen
            '
            Me.timerUpdateScreen.Interval = 50
            '
            'XBoxForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(746, 759)
            Me.Controls.Add(Me.statusStrip1)
            Me.Controls.Add(Me.tabControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximumSize = New System.Drawing.Size(762, 798)
            Me.MinimumSize = New System.Drawing.Size(762, 798)
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
        Public WithEvents radioButton3 As Windows.Forms.RadioButton
        Public WithEvents radioButton2 As Windows.Forms.RadioButton
        Public WithEvents radioButton1 As Windows.Forms.RadioButton
        Public groupBox2 As Windows.Forms.GroupBox
        Public WithEvents radioButton6 As Windows.Forms.RadioButton
        Public WithEvents radioButton5 As Windows.Forms.RadioButton
        Public WithEvents radioButton4 As Windows.Forms.RadioButton
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
        Public WithEvents radioButton7 As Windows.Forms.RadioButton
        Public WithEvents radioButton8 As Windows.Forms.RadioButton
        Public WithEvents radioButton9 As Windows.Forms.RadioButton
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
