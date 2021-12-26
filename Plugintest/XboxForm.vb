Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Threading
Imports System.IO
Imports FormSerialisation
Imports System.Diagnostics
Imports System.String

Namespace Plugins
    Partial Public Class XBoxForm
        Inherits Form

        Private UC As Plugininterface.Entry
        Private Pluginmain As UCCNCplugin
        Private mustclose = False

        Public HoldUpdateForm As Boolean = False



        Private goingtoclose = False

        Private res As DialogResult

        Public Sub New(ByVal Pluginmain As UCCNCplugin)
            UC = Pluginmain.UC
            Me.Pluginmain = Pluginmain
            InitializeComponent()
        End Sub

        Private Sub PluginForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load


            CheckForIllegalCrossThreadCalls = False

            Load_Settings()
            ' FormSerialisation.Deserialise(Me, Application.StartupPath & "\plugins\xboxcontroller.xml") ' get settings


            Try

            Catch ex As Exception
                lblAppVersion.Text = Me.UC.Plugproperties.pluginname & ", v " & Me.UC.Plugproperties.pluginversion

            End Try


            'controls = new GamepadState(0);

            Thread.Sleep(10) ' Allow time to load up before proceed.

            ' Set hidden items to show if checkboxes 
            checkcustompad()
            check_rightCustomVel()
            check_leftCustomVel()

            If comboBoxRXStick.Text = "JogStep" Then
                groupboxJogStep.Enabled = True
            Else
                groupboxJogStep.Enabled = False
            End If

            If cbAutoEnable.Checked Then
                cbEnableMain.Checked = True
            End If

            If Not cbEnableMain.Checked Then
                DoDisable()
            Else
                DoEnable()
            End If


            If cbMinimizeOnLoad.Checked Then
                WindowState = FormWindowState.Minimized
            End If

            Try
                Me.Size = My.Settings.windowSize
                Me.Location = My.Settings.windowPos
            Catch ex As Exception

            End Try

            Me.timerUpdateScreen.Enabled = True


        End Sub

        Private Sub PluginForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            'Do not close the form when the red X button is pressed
            'But start a Thread which will stop the Loop call from the UCCNC
            'to prevent the form closing while there is a GUI update in the Loop event


            If goingtoclose = False Then

                'MessageBox.Show(e.CloseReason.ToString)
                res = MessageBox.Show("OK to close, Cancel to minimize to taskbar.", "Close XBox controller plugin?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

                If res = DialogResult.Cancel Then
                    'if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = True


                    ' MessageBox.Show("You have clicked Cancel Button");
                    'Some task…  
                    WindowState = FormWindowState.Minimized 'if (res == DialogResult.OK)
                Else

                    If Not mustclose Then
                        e.Cancel = True
                        Dim closethr As Thread = New Thread(New ThreadStart(AddressOf Closeform))
                        closethr.Start()
                        goingtoclose = True
                    Else
                        'Form is closing here...
                    End If
                    'MessageBox.Show("You have clicked Ok Button");
                    'Some task… 

                End If
            Else
                'closed here
            End If
        End Sub

        Public Sub Closeform()



            'Stop the Loop event to update the GUI

            Pluginmain.loopstop = True

            'Wait until the loop exited
            While Pluginmain.loopworking
                Thread.Sleep(10)
            End While

            If cbSaveSettings.Checked Then

                ' FormSerialisation.Serialise(Me, Application.StartupPath & "\plugins\xboxcontroller.xml") ' save settings
                Save_settings()

            Else

                If Not Me.WindowState = FormWindowState.Minimized Then
                    My.Settings.windowPos = Me.Location
                    My.Settings.windowSize = Me.Size
                    My.Settings.Save()
                End If

            End If




            'Set the mustclose variable to true and call the .Close() function to close the Form
            mustclose = True
            Close()

        End Sub

        Private Sub btnShowCodes_Click(sender As Object, e As EventArgs) Handles btnShowCodes.Click

            Process.Start(Application.StartupPath & "\documentation\Buttons_by_number.htm")

        End Sub

        Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click

            Save_settings()

        End Sub


        Sub Save_settings()

            If Not Me.WindowState = FormWindowState.Minimized Then
                My.Settings.windowPos = Me.Location
                My.Settings.windowSize = Me.Size
                My.Settings.Save()
            End If

            Try
                Dim profile As String = Path.GetFileNameWithoutExtension(UC.Getprofilename)

                ' MessageBox.Show(profile)

                If profile <> "" Then



                    FormSerialisation.Serialise(Me, Application.StartupPath & "\plugins\xboxcontroller_" & profile & ".xml") ' save settings


                Else

                    FormSerialisation.Serialise(Me, Application.StartupPath & "\plugins\xboxcontroller.xml") ' save settings
                    MessageBox.Show("Could not verify current profile, settings saved to ' xboxcontroller.xml ' ")

                End If

            Catch ex As Exception

            End Try



            'FormSerialisation.Serialise(Me, Application.StartupPath & "\plugins\xboxcontroller.xml") ' save settings



        End Sub


        Private Sub btnLoadSettings_Click(sender As Object, e As EventArgs) Handles btnLoadSettings.Click

            Load_Settings()

            'FormSerialisation.Deserialise(Me, Application.StartupPath & "\plugins\xboxcontroller.xml") ' get settings



        End Sub


        Private Sub Load_Settings()

            Dim profile As String = Path.GetFileNameWithoutExtension(UC.Getprofilename)


            If File.Exists(Application.StartupPath & "\plugins\xboxcontroller_" & profile & ".xml") Then

                FormSerialisation.Deserialise(Me, Application.StartupPath & "\plugins\xboxcontroller_" & profile & ".xml") ' save settings

            Else

                FormSerialisation.Deserialise(Me, Application.StartupPath & "\plugins\xboxcontroller.xml") ' save settings

            End If

        End Sub


        Private Sub button2_Click_2(ByVal sender As Object, ByVal e As EventArgs)
            Pluginmain.controls.Vibrate(5, 0)
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)
            Pluginmain.controls.Vibrate(0, 0)
        End Sub

        Private Sub linkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
            Try
                VisitLink()
            Catch ex As Exception
                MessageBox.Show("Unable to open link that was clicked.")
            End Try
        End Sub

        Private Sub VisitLink()
            ' Change the color of the link text by setting LinkVisited 
            ' to true.
            linkLabel1.LinkVisited = True
            'Call the Process.Start method to open the default browser 
            'with a URL:
            Process.Start("mailto:eabrust@craftycnc.com")
        End Sub

        Private Sub linkLabel2_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLabel2.LinkClicked
            ' Change the color of the link text by setting LinkVisited 
            ' to true.
            linkLabel1.LinkVisited = True
            'Call the Process.Start method to open the default browser 
            'with a URL:
            Process.Start("http:\www.craftycnc.com")
        End Sub

        Private Sub button4_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            Try
                'VisitLink2()
            Catch ex As Exception
                MessageBox.Show("Unable to open link that was clicked.")
            End Try
        End Sub



        Private Sub cbEnableMain_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbEnableMain.CheckedChanged
            If Pluginmain.controls.Connected Then

                If cbEnableMain.Checked = True Then
                    cbLeftStickEnab.Enabled = True
                    cbRightStickEnab.Enabled = True
                Else
                    cbLeftStickEnab.Enabled = False
                    cbRightStickEnab.Enabled = False
                End If
            Else
                NotifyIcon1.BalloonTipTitle = "XBox Controler Not Connected"
                NotifyIcon1.BalloonTipText = "Unable to enable, not connected"
                NotifyIcon1.Text = "XBox Control Not Connected"
                NotifyIcon1.ShowBalloonTip(100)
                NotifyIcon1.Icon = Resources.XBOFF
                cbEnableMain.Checked = False '"Click to disable"
            End If
        End Sub

        Private Sub DoEnable()
            'enablemail = True;
            Try

                If Pluginmain.controls.Connected Then
                    NotifyIcon1.BalloonTipTitle = "XBox Control Activated"
                    NotifyIcon1.BalloonTipText = "Enabling Jogging"
                    NotifyIcon1.Text = "XBox Control Enabled"
                    NotifyIcon1.ShowBalloonTip(100)
                    NotifyIcon1.Icon = Resources.XBON
                    cbEnableMain.Checked = True '"Click to disable"
                Else
                    NotifyIcon1.BalloonTipTitle = "XBox Controler Not Connected"
                    NotifyIcon1.BalloonTipText = "Unable to enable, not connected"
                    NotifyIcon1.Text = "XBox Control Not Connected"
                    NotifyIcon1.ShowBalloonTip(100)
                    NotifyIcon1.Icon = Resources.XBOFF
                    cbEnableMain.Checked = False '"Click to disable"
                End If

            Catch
            End Try
        End Sub

        Private Sub DoDisable()
            NotifyIcon1.BalloonTipTitle = "XBox Control Deactivated"
            NotifyIcon1.BalloonTipText = "Disabling Jogging"
            NotifyIcon1.Text = "XBox Control Disabled"
            NotifyIcon1.ShowBalloonTip(100)
            NotifyIcon1.Icon = Resources.XBOFF
            cbEnableMain.Checked = False '"Click to disable"
        End Sub

        Private Sub notifyIcon1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
            If e.Button = MouseButtons.Left Then

                'checkBox1.Checked = !checkBox1.Checked;
                If cbEnableMain.Checked Then
                    DoDisable()
                Else
                    DoEnable()
                End If
            End If
        End Sub

        Private Sub toolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItem1.Click
            Me.Visible = True
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            Me.ShowInTaskbar = True
        End Sub

        Private Sub toolStripMenuItem2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItem2.Click
            Me.Close()
        End Sub


        'private void PluginForm_ResizeBegin(object sender, EventArgs e)
        '{

        '    NotifyIcon1.Visible = true;
        '    this.Hide();


        '}

        Private Sub PluginForm_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
            If WindowState = FormWindowState.Minimized Then
                NotifyIcon1.Visible = True
                Hide()
            End If
        End Sub

        Private Sub btnConnection_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConnect.Click
            If Not Pluginmain.controls.Connected Then
                MessageBox.Show("Not connected")
            Else
                MessageBox.Show("Connected")
            End If
            'controls = new GamepadState(0);
            '    if (controls.Connected)
            '    {

            '    }

            'checkConnected();





        End Sub

        Public Sub checkConnected()
            If Pluginmain.controls.Connected Then
                toolStripStatusLabel1.Text = "Connected"
                'btnConnect.Text = "Connected";
                'btnConnect.BackColor = Color.LightGreen;

                toolStripStatusLabel1.BackColor = Color.LightGreen
            Else
                toolStripStatusLabel1.Text = "Not Connected"
                toolStripStatusLabel1.BackColor = Color.MistyRose
                'btnConnect.Text = "Not Connected";
                'btnConnect.BackColor = Color.MistyRose;
            End If
        End Sub

        Private Sub checkcustompad()
            If cbCustomDpad.Checked Then 'Customize checkbox is on
                comboBox9.Visible = True
                comboBox10.Visible = True
                comboBox11.Visible = True
                comboBox12.Visible = True
                comboBox17.Visible = True
                comboBox18.Visible = True
                comboBox19.Visible = True
                comboBox20.Visible = True
                comboBox21.Visible = True
                comboBox22.Visible = True
                comboBox23.Visible = True
                comboBox24.Visible = True
                comboBox9.Enabled = True
                comboBox10.Enabled = True
                comboBox11.Enabled = True
                comboBox12.Enabled = True
                comboBox17.Enabled = True
                comboBox18.Enabled = True
                comboBox19.Enabled = True
                comboBox20.Enabled = True
                comboBox21.Enabled = True
                comboBox22.Enabled = True
                comboBox23.Enabled = True
                comboBox24.Enabled = True

                groupBoxDPad.Enabled = False

                label23.Visible = False
                label24.Visible = False
                label25.Visible = False
                label26.Visible = False
                label27.Visible = False
                label28.Visible = False

                GroupBox4.Text = "Set User Defined Functions"
                'RevXStep.Visible = False
                'RevYStep.Visible = False
                'RevZStep.Visible = False
            Else ' dpad & shoulders are fixed to jog.
                comboBox9.Visible = False
                comboBox10.Visible = False
                comboBox11.Visible = False
                comboBox12.Visible = False
                comboBox17.Visible = False
                comboBox18.Visible = False
                comboBox19.Visible = False
                comboBox20.Visible = False
                comboBox21.Visible = False
                comboBox22.Visible = False
                comboBox23.Visible = False
                comboBox24.Visible = False
                comboBox9.Enabled = False
                comboBox10.Enabled = False
                comboBox11.Enabled = False
                comboBox12.Enabled = False
                comboBox17.Enabled = False
                comboBox18.Enabled = False
                comboBox19.Enabled = False
                comboBox20.Enabled = False
                comboBox21.Enabled = False
                comboBox22.Enabled = False
                comboBox23.Enabled = False
                comboBox24.Enabled = False

                groupBoxDPad.Enabled = True

                GroupBox4.Text = "Assigned 'Step Jog' Mapping"

                Try

                    If comboLRDpad.Text = "" Then
                        label27.Text = " n/a "
                        label28.Text = " n/a "

                    ElseIf comboLRDpad.Text.Contains("Rev") Or comboLRDpad.Text.Contains("rev") Then
                        Dim test As String = comboLRDpad.Text
                        Dim testarray() As String = test.Split(New Char() {"_"c})

                        label27.Text = testarray(testarray.Length - 1) & " -"
                        label28.Text = testarray(testarray.Length - 1) & " +"
                    Else
                        label27.Text = comboLRDpad.Text & " + "
                        label28.Text = comboLRDpad.Text & " - "
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)

                End Try

                Try

                    If comboUDDpad.Text = "" Then
                        label25.Text = " n/a "
                        label26.Text = " n/a "

                    ElseIf comboUDDpad.Text.Contains("Rev") Or comboUDDpad.Text.Contains("rev") Then
                        Dim test As String = comboUDDpad.Text
                        Dim testarray() As String = test.Split(New Char() {"_"c})

                        label25.Text = testarray(testarray.Length - 1) & " -"
                        label26.Text = testarray(testarray.Length - 1) & " +"
                    Else
                        label25.Text = comboUDDpad.Text & " + "
                        label26.Text = comboUDDpad.Text & " - "
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try



                Try
                    If comboLRShoulder.Text = "" Then
                        label23.Text = " n/a "
                        label24.Text = " n/a "

                    ElseIf comboLRShoulder.Text.Contains("Rev") Or comboLRShoulder.Text.Contains("rev") Then
                        Dim test As String = comboLRShoulder.Text
                        Dim testarray() As String = test.Split(New Char() {"_"c})

                        label23.Text = testarray(testarray.Length - 1) & " -"
                        label24.Text = testarray(testarray.Length - 1) & " +"
                    Else
                        label23.Text = comboLRShoulder.Text & " + "
                        label24.Text = comboLRShoulder.Text & " - "
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)

                End Try




                'label23.Text = comboLRShoulder.Text
                'label25.Text = comboUDDpad.Text
                'label27.Text = comboLRDpad.Text

                label23.Visible = True
                label24.Visible = True
                label25.Visible = True
                label26.Visible = True
                label27.Visible = True
                label28.Visible = True
                'RevXStep.Visible = True
                'RevYStep.Visible = True
                'RevZStep.Visible = True
            End If
        End Sub


        Private Sub comboLRDpad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboLRDpad.SelectedIndexChanged
            checkcustompad()
        End Sub

        Private Sub comboUDDpad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboUDDpad.SelectedIndexChanged
            checkcustompad()

        End Sub

        Private Sub comboLRShoulder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboLRShoulder.SelectedIndexChanged
            checkcustompad()

        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbCustomDpad.CheckedChanged
            checkcustompad()
        End Sub

        ' Check of max velocity numeric boxes:

        Private Sub nudMaxVelLSH_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub nudMaxVelLSV_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub nudMaxVelRSH_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub nudMaxVelRSV_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub check_leftCustomVel()
            If cbLSMaxVel.Checked Then
                nudMaxVelLSH.Visible = True
                nudMaxVelLSV.Visible = True
                label39.Visible = True
                label46.Visible = True
            Else
                nudMaxVelLSH.Visible = False
                nudMaxVelLSV.Visible = False
                label39.Visible = False
                label46.Visible = False
            End If
        End Sub

        Private Sub check_rightCustomVel()
            If cbRSMaxVel.Checked Then
                nudMaxVelRSH.Visible = True
                nudMaxVelRSV.Visible = True
                label40.Visible = True
                label47.Visible = True
            Else
                nudMaxVelRSH.Visible = False
                nudMaxVelRSV.Visible = False
                label40.Visible = False
                label47.Visible = False
            End If
        End Sub

        Private Sub cbLSMaxVel_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbLSMaxVel.CheckedChanged
            check_leftCustomVel()
        End Sub

        Private Sub cbRSMaxVel_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbRSMaxVel.CheckedChanged
            check_rightCustomVel()
        End Sub

        Private Sub comboBoxRXStick_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxRXStick.SelectedIndexChanged
            If comboBoxRXStick.Text = "JogStep" Then
                groupboxJogStep.Enabled = True
            Else
                groupboxJogStep.Enabled = False
            End If
        End Sub

        Private Sub PluginForm_ResizeBegin(sender As Object, e As EventArgs) Handles MyBase.ResizeBegin
            HoldUpdateForm = True
            SuspendLayout()
            MyBase.SuspendLayout()
        End Sub

        Private Sub PluginForm_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
            HoldUpdateForm = False
            ResumeLayout()
            MyBase.ResumeLayout()

        End Sub

        Private Sub btnConfigForm_Click(sender As Object, e As EventArgs) Handles btnConfigForm.Click
            Dim cform As New ConfigForm(Me.Pluginmain)
            cform.ShowDialog()
        End Sub

        Private Sub timerUpdateScreen_Tick(sender As Object, e As EventArgs) Handles timerUpdateScreen.Tick


#Region "Display back to form"



            If Not (WindowState = FormWindowState.Minimized) AndAlso Not HoldUpdateForm Then

                SuspendLayout()

                If Pluginmain.controls.Connected Then
                    toolStripStatusLabel1.Text = "Controller Connected"
                    'btnConnect.Text = "Connected";
                    'btnConnect.BackColor = Color.LightGreen;

                    toolStripStatusLabel1.BackColor = Color.LightGreen
                Else
                    toolStripStatusLabel1.Text = "Controller Not Connected"
                    toolStripStatusLabel1.BackColor = Color.MistyRose
                    'btnConnect.Text = "Not Connected";
                    'btnConnect.BackColor = Color.MistyRose;
                End If


                'checkConnected()


                label1.Text = "LeftX: " & String.Format("{0:0.000}", Pluginmain.lstickx) ' UC.Getfield(true, 226);
                label2.Text = "LeftY: " & String.Format("{0:0.000}", Pluginmain.lsticky)  ' UC.Getfield(true, 227);
                label3.Text = "RightX: " & String.Format("{0:0.000}", Pluginmain.rstickx) ' UC.Getfield(true, 226);
                label4.Text = "RightY: " & String.Format("{0:0.000}", Pluginmain.rsticky)  ' UC.Getfield(true, 227);
                label5.Text = "Ltrigger: " & String.Format("{0:0.000}", Pluginmain.ltrig) ' UC.Getfield(true, 228);
                label6.Text = "Rtrigger: " & String.Format("{0:0.000}", Pluginmain.rtrig) ' UC.Getfield(true, 229); 



                'V 2.030, replaced text w/ LEDs


                If Pluginmain.A Then
                    btnLED7.BackColor = Color.Green
                Else
                    btnLED7.BackColor = Color.DarkGray
                End If

                If Pluginmain.B Then
                    btnLED8.BackColor = Color.Green
                Else
                    btnLED8.BackColor = Color.DarkGray
                End If

                If Pluginmain.X Then
                    btnLED9.BackColor = Color.Green
                Else
                    btnLED9.BackColor = Color.DarkGray
                End If

                If Pluginmain.Y Then
                    btnLED10.BackColor = Color.Green
                Else
                    btnLED10.BackColor = Color.DarkGray
                End If

                If Pluginmain.LS Then
                    btnLED11.BackColor = Color.Green
                Else
                    btnLED11.BackColor = Color.DarkGray
                End If

                If Pluginmain.RS Then
                    btnLED12.BackColor = Color.Green
                Else
                    btnLED12.BackColor = Color.DarkGray
                End If

                If Pluginmain.back Then
                    btnLED13.BackColor = Color.Green
                Else
                    btnLED13.BackColor = Color.DarkGray
                End If

                If Pluginmain.start Then
                    btnLED14.BackColor = Color.Green
                Else
                    btnLED14.BackColor = Color.DarkGray
                End If


                If Pluginmain.up Then
                    btnLED15.BackColor = Color.Green
                Else
                    btnLED15.BackColor = Color.DarkGray
                End If

                If Pluginmain.down Then
                    btnLED16.BackColor = Color.Green
                Else
                    btnLED16.BackColor = Color.DarkGray
                End If

                If Pluginmain.left Then
                    btnLED17.BackColor = Color.Green
                Else
                    btnLED17.BackColor = Color.DarkGray
                End If

                If Pluginmain.right Then
                    btnLED18.BackColor = Color.Green
                Else
                    btnLED18.BackColor = Color.DarkGray
                End If





                'Right Stick
                If Pluginmain.jogvelRightX > Pluginmain.jogvelRightY Then
                    label20.Text = "feedrate: " & String.Format("{0:0.000}", Pluginmain.jogvelRightX) & " %"
                Else
                    label20.Text = "feedrate: " & String.Format("{0:0.000}", Pluginmain.jogvelRightY) & " %"
                End If






                'Left Stick
                If Pluginmain.jogvelLeftX > Pluginmain.jogvelLeftY Then
                    label19.Text = "feedrate: " & String.Format("{0:0.000}", Pluginmain.jogvelLeftX) & " %"
                Else
                    label19.Text = "feedrate: " & String.Format("{0:0.000}", Pluginmain.jogvelLeftY) & " %"
                End If




                ' Calc and show loop rate

                toolStripStatusLabel2.Text = "Loop OK, cycling @: " & String.Format("{0:0}", Pluginmain.cps) & " Hz"


                ResumeLayout()

            End If

#End Region

        End Sub
    End Class
End Namespace
