Option Explicit Off

Imports System
Imports System.Windows.Forms
Imports System.Threading
Imports Xbox360Controller
Imports Xboxcontroller.Xbox360Controller
Imports System.Diagnostics
Imports System.Drawing

Namespace Plugins
    Public Class UCCNCplugin 'Class name must be UCCNCplugin to work! 
        Private firstrun = True
        Public UC As Plugininterface.Entry
        Private myform As XBoxForm
        Public loopstop = False
        Public loopworking = False
        '
#Region "Declarations"

        Public currentStickState1 As Boolean ' Lx
        Public previousStickState1 As Boolean ' Lx
        Public currentStickState2 As Boolean ' Ly
        Public previousStickState2 As Boolean ' Ly
        Public currentStickState3 As Boolean ' Rx
        Public previousStickState3 As Boolean ' Rx
        Public currentStickState4 As Boolean ' Ry
        Public previousStickState4 As Boolean 'Ry
        Public currentStickState5 As Boolean ' Rx2
        Public previousStickState5 As Boolean ' Rx2
        Public currentA As Boolean
        Public previousA As Boolean
        Public currentB As Boolean
        Public previousB As Boolean
        Public currentX As Boolean
        Public previousX As Boolean
        Public currentY As Boolean
        Public previousY As Boolean
        Public currentBACK As Boolean
        Public previousBACK As Boolean
        Public currentSTART As Boolean
        Public previousSTART As Boolean
        Public currentLS As Boolean
        Public previousLS As Boolean
        Public currentRS As Boolean
        Public previousRS As Boolean
        Public currentUP As Boolean
        Public previousUP As Boolean
        Public currentDOWN As Boolean
        Public previousDOWN As Boolean
        Public currentLEFT As Boolean
        Public previousLEFT As Boolean
        Public currentRIGHT As Boolean
        Public previousRIGHT As Boolean
        Public JogEnable As Boolean

        Public jogvelLeft As Double
        Public jogvelRight As Double
        Public jogvelSet As Double
        Public originalVel As Integer
        Public JogPlusGo As Integer
        Public JogMinusGo As Integer
        Public JogPlusStop As Integer
        Public JogMinusStop As Integer
        Public JogSelected As Integer


        ' New 12/19
        Public MaxVelL As Double
        Public MaxvelR As Double
        Public axis As Integer
        Public plusdir As Boolean
        Public minusdir As Boolean
        Public LSspeedX As Double
        Public LSspeedY As Double
        Public RSspeedX As Double
        Public RSspeedY As Double
        Public xmaxVel, ymaxVel, zmaxVel, amaxVel, bmaxVel, cmaxVel As Double
        Public jogvelLeftX, jogvelLeftY, jogvelRightX, jogvelRightY As Double
        Public LSMaxSpdX, RSMaxSpdX, LSMaxSpdY, RSMaxSpdY As Double
        Public LXdb, LYdb, RXdb, RYdb, LXscale, LYscale, RXscale, RYscale As Double
        Public stepmode As Boolean
        Public jogstepEnable As Boolean


        Dim sw As New Stopwatch

        Public cps As Single

        '

        ' initialize controller
        Public controls As GamepadState


        Public lsticky As Single
        Public lstickx As Single
        Public rsticky As Single
        Public rstickx As Single
        Public ltrig As Single
        Public rtrig As Single
        Public A As Boolean
        Public B As Boolean
        Public X As Boolean
        Public Y As Boolean
        Public LS As Boolean
        Public RS As Boolean
        Public up As Boolean
        Public down As Boolean
        Public left As Boolean
        Public right As Boolean
        Public back As Boolean
        Public start As Boolean

        '' Used for testing feedback
        'Dim LSX As String
        'Dim LSY As String
        'Dim RSX As String
        'Dim RSY As String
        'Dim LT As String
        'Dim RT As String
        'Dim Abutton As String
        'Dim Bbutton As String
        'Dim Xbutton As String
        'Dim Ybutton As String
        'Dim LSbutton As String
        'Dim RSbutton As String
        'Dim Upbutton As String
        'Dim Downbutton As String
        'Dim Leftbutton As String
        'Dim Rightbutton As String
        'Dim Backbutton As String
        'Dim Startbutton As String



        '
#End Region

#Region "Main UC Plugin Stuff"
        Public Sub New()
        End Sub


        'Called when the plugin is initialised.
        'The parameter is the Plugin interface object which contains all functions prototypes for calls and callbacks.
        Public Sub Init_event(ByVal UC As Plugininterface.Entry)
            Me.UC = UC
            myform = New XBoxForm(Me)
        End Sub


        'Called when the plugin is loaded, the author of the plugin should set the details of the plugin here.
        Public Function Getproperties_event(ByVal Properties As Plugininterface.Entry.Pluginproperties) As Plugininterface.Entry.Pluginproperties
            Properties.author = "CraftyCNC"
            Properties.pluginname = "XBox360-Veloc. Control"
            Properties.pluginversion = "2.060"
            Return Properties
        End Function


        'Called from UCCNC when the user presses the Configuration button in the Plugin configuration menu.
        'Typically the plugin configuration window is shown to the user.
        Public Sub Configure_event()
            Dim cform As ConfigForm = New ConfigForm(Me)
            cform.ShowDialog()
        End Sub


        'Called from UCCNC when the plugin is loaded and started.
        Public Sub Startup_event()
            Try
                controls = New GamepadState(0)
                loopstop = False

            Catch
                MessageBox.Show("Unable to open xbox control")
            End Try

            If myform.IsDisposed Then
                myform = New XBoxForm(Me)
            End If

            myform.Show()
            myform.TopMost = False  'added to send back
        End Sub


        'Called when the Pluginshowup(string Pluginfilename); function is executed in the UCCNC.
        Public Sub Showup_event()
            Try
                controls = New GamepadState(0)
                loopstop = False
            Catch
                MessageBox.Show("Unable to open xbox control")
            End Try

            If myform.IsDisposed Then
                myform = New XBoxForm(Me)
            End If

            myform.Show()
            myform.TopMost = False ' added to send back
            myform.BringToFront()
        End Sub


        'Called when the UCCNC software is closing.
        Public Sub Shutdown_event()
            Try
                myform.Close()
            Catch __unusedException1__ As Exception
            End Try
        End Sub

        Public Sub Buttonpress_event(ByVal buttonnumber As Integer, ByVal onscreen As Boolean)
            If onscreen Then

                If buttonnumber = My.Settings.OpenCode Then

                    loopstop = False

                    UC.Pluginshowup("Xboxcontroller.dll")

                    'OR
                    'This doesnt work well, issues with loop restart and things not working right afterwards....  Use above!

                    'Dim thrShowForm As Thread = New Thread(New ThreadStart(AddressOf showform))
                    'thrShowForm.CurrentCulture = Thread.CurrentThread.CurrentCulture
                    'thrShowForm.Start()

                    'LoopStop = False ' re-enable lo

                End If
            End If
        End Sub


#End Region

#Region "20HzLoop"

        'Called in a loop with a 25Hz interval.
        Public Sub Loop_event()



            If loopstop Then
                Return
            End If

            loopworking = True

            If myform Is Nothing OrElse myform.IsDisposed Then Return

            If firstrun Then
                Thread.Sleep(100)
                firstrun = False
                'Write code here which has to be run on first cycle only...   
                'bool testfeed = int.TryParse(myform.comboBox25.Text, out originalVel);

                sw.Start()

                myform.lblAppVersion.Text = Me.UC.Plugproperties.pluginname & ", v " & Me.UC.Plugproperties.pluginversion

                'myform.label38.Text = Me.UC.Plugproperties.pluginname & ", v " & Me.UC.Plugproperties.pluginversion   '"Plugin Version:  " & 123


                '  GET ALL AXIS MAXIMUM VELOCITIES, TO USE FOR CONVERTING SPEEDS TO PCTs.
                xmaxVel = UC.Getfielddouble(True, 9)
                ymaxVel = UC.Getfielddouble(True, 24)
                zmaxVel = UC.Getfielddouble(True, 39)
                amaxVel = UC.Getfielddouble(True, 54)
                bmaxVel = UC.Getfielddouble(True, 69)
                cmaxVel = UC.Getfielddouble(True, 84)

                If myform.cbErrMsg.Checked Then
                    If xmaxVel <> ymaxVel Then
                        MessageBox.Show("Recommend setting X and Y axis max velocities to same value in UCCNC, and restarting")
                    End If
                End If
            End If




            ''' THIS IS THE MAIN LOOP
            Try



                'NEW in ver 2.030, Run the main loop stuff in a new thread.
                Dim thrRun As New Thread(Sub() executeLoop())
                thrRun.CurrentCulture = Thread.CurrentThread.CurrentCulture ' Preserve regional settings
                thrRun.Start()


                '' Calc and show loop rate
                'sw.Stop()

                'cps = 1000 / sw.ElapsedMilliseconds

                ''toolStripStatusLabel2.Text = "Loop OK, cycling @: " & String.Format("{0:0}", cps) & " Hz"

                'sw.Reset()
                'sw.Start()


            Catch __unusedException1__ As Exception
                ' MessageBox.Show("Plugin faulted");
                myform.toolStripStatusLabel2.Text = "Loop Fault"
            End Try



            loopworking = False



        End Sub






        Sub executeLoop()

            ' Calc and show loop rate

            sw.Stop()

            cps = 1000 / sw.ElapsedMilliseconds

            'toolStripStatusLabel2.Text = "Loop OK, cycling @: " & String.Format("{0:0}", cps) & " Hz"

            sw.Reset()
            sw.Start()


            Try

                ' Get control inputs here
                Try
                controls.Update()
            Catch
                myform.toolStripStatusLabel2.Text = "Error Updating Control Values"
            End Try


#Region "GET BUTTON/STICK DATA"

            lsticky = controls.LeftStick.Position.Y
            lstickx = controls.LeftStick.Position.X
            rsticky = controls.RightStick.Position.Y
            rstickx = controls.RightStick.Position.X
                ltrig = controls.LeftTrigger
                rtrig = controls.RightTrigger
                A = controls.A
                B = controls.B
                X = controls.X
                Y = controls.Y
                LS = controls.LeftShoulder
                RS = controls.RightShoulder
                up = controls.DPad.Up
                down = controls.DPad.Down
                left = controls.DPad.Left
                right = controls.DPad.Right
                back = controls.Back
                start = controls.Start

                '' Used for testing feedback
                'LSX = Convert.ToString(lstickx)
                'LSY = Convert.ToString(lsticky)
                'RSX = Convert.ToString(rstickx)
                'RSY = Convert.ToString(rsticky)
                'LT = Convert.ToString(ltrig)
                'RT = Convert.ToString(rtrig)
                'Abutton = Convert.ToString(A)
                'Bbutton = Convert.ToString(B)
                'Xbutton = Convert.ToString(X)
                'Ybutton = Convert.ToString(Y)
                'LSbutton = Convert.ToString(LS)
                'RSbutton = Convert.ToString(RS)
                'Upbutton = Convert.ToString(up)
                'Downbutton = Convert.ToString(down)
                'Leftbutton = Convert.ToString(left)
                'Rightbutton = Convert.ToString(right)
                'Backbutton = Convert.ToString(back)
                'Startbutton = Convert.ToString(start)




#End Region

#Region "SAFETY ENABLE   "

                If myform.rbDubTrigEnable.Checked Then

                    If ltrig > 0.5 AndAlso rtrig > 0.5 AndAlso myform.cbEnableMain.Checked Then
                        JogEnable = True
                    Else
                        JogEnable = False
                    End If
                ElseIf myform.rbSingTrigEnable.Checked Then

                    If (ltrig > 0.5 OrElse rtrig > 0.5) AndAlso myform.cbEnableMain.Checked Then
                        JogEnable = True
                    Else
                        JogEnable = False
                    End If
                ElseIf myform.rbVelTrigger.Checked Then
                    JogEnable = myform.cbEnableMain.Checked
                End If


                If myform.cbJSTrigEnab.Checked Then
                    If (ltrig > 0.5 OrElse rtrig > 0.5) Then
                        jogstepEnable = True
                    Else
                        jogstepEnable = False
                    End If
                Else
                    jogstepEnable = True
                End If


#End Region

                ' Pickup new velocity default value:
                'bool testfeed = int.TryParse(myform.comboBox25.Text, out originalVel);


#Region "Velocity_calcs"

                LXdb = Convert.ToDouble(myform.nudLXDeadBand.Value) 'Deadband settings
                LYdb = Convert.ToDouble(myform.nudLYdeadband.Value)
                RXdb = Convert.ToDouble(myform.nudRXdeadband.Value)
                RYdb = Convert.ToDouble(myform.nudRYdeadband.Value)
                LXscale = 1 / (1 - LXdb)  ' scalefactors to set the stick output to be 0-1.0 after taking off d.band
                LYscale = 1 / (1 - LYdb)
                RXscale = 1 / (1 - RXdb)
                RYscale = 1 / (1 - RYdb)


                '==================================================
                'Right stick velocity
                '==================================================

                'if ((Math.Abs(rsticky) >= .01))  // turn on action for velocity source - removed x axis from check


                If Math.Abs(rstickx) >= RXdb OrElse Math.Abs(rsticky) >= RYdb Then  ' turn on action for velocity source


                    If myform.cbMixAxisJogRS.Checked = False Then

                        If Math.Abs(rstickx) >= Math.Abs(rsticky) AndAlso Not Equals(myform.comboBoxRXStick.Text, "JogStep") Then
                            jogvelRightY = 0
                            jogvelRightX = (Math.Abs(rstickx) - RXdb) * RXscale
                        End If

                        If Math.Abs(rstickx) >= Math.Abs(rsticky) AndAlso Equals(myform.comboBoxRXStick.Text, "JogStep") Then
                            jogvelRightX = 0
                            jogvelRightY = (Math.Abs(rsticky) - RYdb) * RYscale

                        ElseIf Math.Abs(rstickx) < Math.Abs(rsticky) Then
                            jogvelRightX = 0
                            jogvelRightY = (Math.Abs(rsticky) - RYdb) * RYscale
                        End If
                    ElseIf myform.cbMixAxisJogRS.Checked = True Then

                        If Math.Abs(rstickx) >= Math.Abs(rsticky) AndAlso Equals(myform.comboBoxRXStick.Text, "JogStep") Then
                            jogvelRightX = 0
                            jogvelRightY = (Math.Abs(rsticky) - RYdb) * RYscale
                        Else
                            jogvelRightX = (Math.Abs(rstickx) - RXdb) * RXscale
                            jogvelRightY = (Math.Abs(rsticky) - RYdb) * RYscale
                        End If
                    End If







                    ' sensitivity selector
                    If myform.rbLinearRateRight.Checked Then
                        'jogvelRight = jogvelRight * 50
                        jogvelRightX = jogvelRightX * 50
                        jogvelRightY = jogvelRightY * 50
                    ElseIf myform.rbSquaredRateRight.Checked Then
                        'jogvelRight = jogvelRight * jogvelRight * 50 'jogvel^2
                        jogvelRightX = jogvelRightX * jogvelRightX * 50 'jogvel^2
                        jogvelRightY = jogvelRightY * jogvelRightY * 50 'jogvel^2
                    ElseIf myform.rbCubedRateRight.Checked Then
                        'jogvelRight = jogvelRight * jogvelRight * jogvelRight * 50 'jogvel^3 best
                        jogvelRightX = jogvelRightX * jogvelRightX * jogvelRightX * 50 'jogvel^3 best
                        jogvelRightY = jogvelRightY * jogvelRightY * jogvelRightY * 50 'jogvel^3 best
                    End If

                    'else
                    '    MessageBox.Show("error selecting speed");



                    If myform.rbVelTrigger.Checked Then
                        Dim accelRight As Double
                        accelRight = rtrig + 1 ' set accel to be between 1-2 with trigger pull
                        'jogvelRight = jogvelRight * accelRight  'velocity is mix of stick and trigger actions
                        jogvelRightX = jogvelRightX * accelRight  'velocity is mix of stick and trigger actions
                        jogvelRightY = jogvelRightY * accelRight  'velocity is mix of stick and trigger actions
                    ElseIf myform.rbDubTrigEnable.Checked OrElse myform.rbSingTrigEnable.Checked Then  ' If using the shoulder as a safety.... velocity scale to 100
                        'jogvelRight = jogvelRight * 2
                        jogvelRightX = jogvelRightX * 2
                        jogvelRightY = jogvelRightY * 2
                    End If


                End If











                '==================================================
                'Left stick velocity
                '==================================================

                If Math.Abs(lstickx) >= LXdb OrElse Math.Abs(lsticky) >= LYdb Then  ' turn on action for velocity source
                    If myform.cbMixAxisJogLS.Checked = False Then

                        If Math.Abs(lstickx) >= Math.Abs(lsticky) Then
                            jogvelLeftX = (Math.Abs(lstickx) - LXdb) * LXscale
                            'jogvelLeftX = 0;
                            jogvelLeftY = 0
                        ElseIf Math.Abs(lstickx) < Math.Abs(lsticky) Then
                            jogvelLeftY = (Math.Abs(lsticky) - LYdb) * LYscale
                            jogvelLeftX = 0
                            'jogvelLeftY = 0;
                        End If
                    ElseIf myform.cbMixAxisJogLS.Checked = True Then
                        'jogvelLeft = 0;                   
                        jogvelLeftX = (Math.Abs(lstickx) - LXdb) * LXscale
                        jogvelLeftY = (Math.Abs(lsticky) - LYdb) * LYscale
                    End If




                    ' sensitivity selector  
                    If myform.rbLinearRateLeft.Checked Then ' jogvel
                        'jogvelLeft = jogvelLeft * 50
                        jogvelLeftX = jogvelLeftX * 50
                        jogvelLeftY = jogvelLeftY * 50
                    ElseIf myform.rbSquaredRateLeft.Checked Then
                        'jogvelLeft = jogvelLeft * jogvelLeft * 50 'jogvel^2
                        jogvelLeftX = jogvelLeftX * jogvelLeftX * 50 'jogvel^2
                        jogvelLeftY = jogvelLeftY * jogvelLeftY * 50 'jogvel^2
                    ElseIf myform.rbCubedRateLeft.Checked Then
                        'jogvelLeft = jogvelLeft * jogvelLeft * jogvelLeft * 50 'jogvel^3 best
                        jogvelLeftX = jogvelLeftX * jogvelLeftX * jogvelLeftX * 50 'jogvel^3 best
                        jogvelLeftY = jogvelLeftY * jogvelLeftY * jogvelLeftY * 50 'jogvel^3 best
                    End If

                    'else
                    '    MessageBox.Show("error selecting speed");

                    If myform.rbVelTrigger.Checked Then ' If the shoulder button is not safety enable, use to modify velocity
                        Dim accelLeft As Double
                        accelLeft = ltrig + 1 ' set accel to be between 1-2 with trigger pull
                        'jogvelLeft = jogvelLeft * accelLeft  'velocity is mix of stick and trigger actions
                        jogvelLeftX = jogvelLeftX * accelLeft  'velocity is mix of stick and trigger actions
                        jogvelLeftY = jogvelLeftY * accelLeft  'velocity is mix of stick and trigger actions
                    ElseIf myform.rbDubTrigEnable.Checked OrElse myform.rbSingTrigEnable.Checked Then  ' If using the shoulder as a safety.... velocity scale to 100
                        'jogvelLeft = jogvelLeft * 2
                        jogvelLeftX = jogvelLeftX * 2
                        jogvelLeftY = jogvelLeftY * 2
                    End If


                End If

#End Region

#Region "PerformButtonActions"


                ' Start of stick action and sending jog commands to UCCNC


                'if (JogEnable==true)
                If myform.cbEnableMain.Checked = True Then
                CheckStickLX(lstickx)
                CheckStickLY(lsticky)
                CheckStickRX(rstickx)
                CheckStickRY(rsticky)
                CheckA(A)
                CheckB(B)
                CheckX(X)
                CheckY(Y)
                CheckSTART(start)
                CheckBACK(back)
                CheckLS(LS)
                CheckRS(RS)
                CheckUP(up)
                CheckDOWN(down)
                CheckLEFT(left)
                CheckRIGHT(right)
            End If


#End Region




            Catch ex As Exception

            End Try

        End Sub


#End Region



#Region "Sticks Actions"



        ' Sub to start/stop axis with button presses based on stick positioning




#Region "LeftStick"

        '  Left Stick =  X Axis
        Public Sub CheckStickLX(ByVal stick As Double)


            ' Assign axis/buttons from pulldowns

            Dim LXAssign = myform.comboBoxLXStick.Text
            LSMaxSpdX = Convert.ToDouble(myform.nudMaxVelLSH.Value)

            Select Case LXAssign
                Case "Xaxis"
                    axis = 0
                    plusdir = False
                    minusdir = True
                    LSspeedX = LSMaxSpdX / xmaxVel * jogvelLeftX
                Case "Yaxis"
                    axis = 1
                    plusdir = False
                    minusdir = True
                    LSspeedX = LSMaxSpdX / ymaxVel * jogvelLeftX
                Case "Zaxis"
                    axis = 2
                    plusdir = False
                    minusdir = True
                    LSspeedX = LSMaxSpdX / zmaxVel * jogvelLeftX
                Case "Aaxis"
                    axis = 3
                    plusdir = False
                    minusdir = True
                    LSspeedX = LSMaxSpdX / amaxVel * jogvelLeftX
                Case "Baxis"
                    axis = 4
                    plusdir = False
                    minusdir = True
                    LSspeedX = LSMaxSpdX / bmaxVel * jogvelLeftX
                Case "Caxis"
                    axis = 5
                    plusdir = False
                    minusdir = True
                    LSspeedX = LSMaxSpdX / cmaxVel * jogvelLeftX
                Case "Rev_Xaxis"
                    axis = 0
                    plusdir = True
                    minusdir = False
                    LSspeedX = LSMaxSpdX / xmaxVel * jogvelLeftX
                Case "Rev_Yaxis"
                    axis = 1
                    plusdir = True
                    minusdir = False
                    LSspeedX = LSMaxSpdX / ymaxVel * jogvelLeftX
                Case "Rev_Zaxis"
                    axis = 2
                    plusdir = True
                    minusdir = False
                    LSspeedX = LSMaxSpdX / zmaxVel * jogvelLeftX
                Case "Rev_Aaxis"
                    axis = 3
                    plusdir = True
                    minusdir = False
                    LSspeedX = LSMaxSpdX / amaxVel * jogvelLeftX
                Case "Rev_Baxis"
                    axis = 4
                    plusdir = True
                    minusdir = False
                    LSspeedX = LSMaxSpdX / bmaxVel * jogvelLeftX
                Case "Rev_Caxis"
                    axis = 5
                    plusdir = True
                    minusdir = False
                    LSspeedX = LSMaxSpdX / cmaxVel * jogvelLeftX
                Case Else
                    axis = 0
                    plusdir = True
                    minusdir = False
            End Select



            '  Ensure limited to 100, and select if max vel or not
            If LSspeedX > 100 Then
                LSspeedX = 100
            End If

            If Not myform.cbLSMaxVel.Checked Then
                LSspeedX = jogvelLeftX
            End If

            currentStickState1 = Math.Abs(stick) > Convert.ToDouble(myform.nudLXDeadBand.Value)

            If JogEnable = True AndAlso myform.cbLeftStickEnab.Checked Then

                If stick > Convert.ToDouble(myform.nudLXDeadBand.Value) Then
                    UC100.JogOnSpeed(axis, plusdir, LSspeedX) '' X joy velocity set to 0
                ElseIf stick < -1 * Convert.ToDouble(myform.nudLXDeadBand.Value) Then
                    UC100.JogOnSpeed(axis, minusdir, LSspeedX) '' X joy velocity set to 0
                End If
            End If

            If currentStickState1 = False AndAlso previousStickState1 = True Then  'additional functionality if desired
                'button just released, call other code

                UC100.JogOnSpeed(axis, plusdir, 0) '' X joy velocity set to 0
                LSspeedX = 0 ' Default speed back to zero to avoid jumpy starts.
                jogvelLeftX = 0
            End If

            previousStickState1 = currentStickState1
        End Sub






        '  Left Stick =  Y Axis
        Public Sub CheckStickLY(ByVal stick As Double)
            LSMaxSpdY = Convert.ToDouble(myform.nudMaxVelLSV.Value)
            Dim LYAssign = myform.comboBoxLYStick.Text

            Select Case LYAssign
                Case "Xaxis"
                    axis = 0
                    plusdir = False
                    minusdir = True
                    LSspeedY = LSMaxSpdY / xmaxVel * jogvelLeftY
                Case "Yaxis"
                    axis = 1
                    plusdir = False
                    minusdir = True
                    LSspeedY = LSMaxSpdY / ymaxVel * jogvelLeftY
                Case "Zaxis"
                    axis = 2
                    plusdir = False
                    minusdir = True
                    LSspeedY = LSMaxSpdY / zmaxVel * jogvelLeftY
                Case "Aaxis"
                    axis = 3
                    plusdir = False
                    minusdir = True
                    LSspeedY = LSMaxSpdY / amaxVel * jogvelLeftY
                Case "Baxis"
                    axis = 4
                    plusdir = False
                    minusdir = True
                    LSspeedY = LSMaxSpdY / bmaxVel * jogvelLeftY
                Case "Caxis"
                    axis = 5
                    plusdir = False
                    minusdir = True
                    LSspeedY = LSMaxSpdY / cmaxVel * jogvelLeftY
                Case "Rev_Xaxis"
                    axis = 0
                    plusdir = True
                    minusdir = False
                    LSspeedY = LSMaxSpdY / xmaxVel * jogvelLeftY
                Case "Rev_Yaxis"
                    axis = 1
                    plusdir = True
                    minusdir = False
                    LSspeedY = LSMaxSpdY / ymaxVel * jogvelLeftY
                Case "Rev_Zaxis"
                    axis = 2
                    plusdir = True
                    minusdir = False
                    LSspeedY = LSMaxSpdY / zmaxVel * jogvelLeftY
                Case "Rev_Aaxis"
                    axis = 3
                    plusdir = True
                    minusdir = False
                    LSspeedY = LSMaxSpdY / amaxVel * jogvelLeftY
                Case "Rev_Baxis"
                    axis = 4
                    plusdir = True
                    minusdir = False
                    LSspeedY = LSMaxSpdY / bmaxVel * jogvelLeftY
                Case "Rev_Caxis"
                    axis = 5
                    plusdir = True
                    minusdir = False
                    LSspeedY = LSMaxSpdY / zmaxVel * jogvelLeftY
                Case Else
                    axis = 0
                    plusdir = True
                    minusdir = False
            End Select




            '  Ensure limited to 100, and select if max vel or not
            If LSspeedY > 100 Then
                LSspeedY = 100
            End If

            If Not myform.cbLSMaxVel.Checked Then
                LSspeedY = jogvelLeftY
            End If

            currentStickState2 = Math.Abs(stick) > Convert.ToDouble(myform.nudLYdeadband.Value)

            If JogEnable = True AndAlso myform.cbLeftStickEnab.Checked Then

                If stick > Convert.ToDouble(myform.nudLYdeadband.Value) Then
                    UC100.JogOnSpeed(axis, plusdir, LSspeedY) '' X joy velocity set to 0
                ElseIf stick < -1 * Convert.ToDouble(myform.nudLYdeadband.Value) Then
                    UC100.JogOnSpeed(axis, minusdir, LSspeedY) '' X joy velocity set to 0
                End If
            End If

            If currentStickState2 = False AndAlso previousStickState2 = True Then  'additional functionality if desired
                UC100.JogOnSpeed(axis, plusdir, 0)
                LSspeedY = 0
                jogvelLeftY = 0
            End If

            previousStickState2 = currentStickState2
        End Sub


#End Region

#Region "Right Stick"

        '  Right Stick =  X Axis
        Public Sub CheckStickRX(ByVal stick As Double)
            RSMaxSpdX = Convert.ToDouble(myform.nudMaxVelRSH.Value)
            currentStickState3 = Math.Abs(stick) > Convert.ToDouble(myform.nudRXdeadband.Value)
            Dim RXAssign = myform.comboBoxRXStick.Text
            Dim JogStepSelect = False

            Select Case RXAssign
                Case "Xaxis"
                    axis = 0
                    plusdir = False
                    minusdir = True
                    RSspeedX = RSMaxSpdX / xmaxVel * jogvelRightX
                Case "Yaxis"
                    axis = 1
                    plusdir = False
                    minusdir = True
                    RSspeedX = RSMaxSpdX / ymaxVel * jogvelRightX
                Case "Zaxis"
                    axis = 2
                    plusdir = False
                    minusdir = True
                    RSspeedX = RSMaxSpdX / zmaxVel * jogvelRightX
                Case "Aaxis"
                    axis = 3
                    plusdir = False
                    minusdir = True
                    RSspeedX = RSMaxSpdX / amaxVel * jogvelRightX
                Case "Baxis"
                    axis = 4
                    plusdir = False
                    minusdir = True
                    RSspeedX = RSMaxSpdX / bmaxVel * jogvelRightX
                Case "Caxis"
                    axis = 5
                    plusdir = False
                    minusdir = True
                    RSspeedX = RSMaxSpdX / cmaxVel * jogvelRightX
                Case "Rev_Xaxis"
                    axis = 0
                    plusdir = True
                    minusdir = False
                    RSspeedX = RSMaxSpdX / xmaxVel * jogvelRightX
                Case "Rev_Yaxis"
                    axis = 1
                    plusdir = True
                    minusdir = False
                    RSspeedX = RSMaxSpdX / ymaxVel * jogvelRightX
                Case "Rev_Zaxis"
                    axis = 2
                    plusdir = True
                    minusdir = False
                    RSspeedX = RSMaxSpdX / zmaxVel * jogvelRightX
                Case "Rev_Aaxis"
                    axis = 3
                    plusdir = True
                    minusdir = False
                    RSspeedX = RSMaxSpdX / amaxVel * jogvelRightX
                Case "Rev_Baxis"
                    axis = 4
                    plusdir = True
                    minusdir = False
                    RSspeedX = RSMaxSpdX / bmaxVel * jogvelRightX
                Case "Rev_Caxis"
                    axis = 5
                    plusdir = True
                    minusdir = False
                    RSspeedX = RSMaxSpdX / cmaxVel * jogvelRightX
                Case "JogStep"
                    axis = 0
                    plusdir = False
                    minusdir = True
                    JogStepSelect = True
                Case Else
                    axis = 0
                    plusdir = True
                    minusdir = False
            End Select

            If JogStepSelect = False Then


                '  Ensure limited to 100, and select if max vel or not
                If RSspeedX > 100 Then
                    RSspeedX = 100
                End If

                If Not myform.cbRSMaxVel.Checked Then
                    RSspeedX = jogvelRightX
                End If

                If JogEnable = True AndAlso myform.cbRightStickEnab.Checked Then

                    If stick > Convert.ToDouble(myform.nudRXdeadband.Value) Then
                        UC100.JogOnSpeed(axis, plusdir, RSspeedX) '' X joy velocity set to 0
                    ElseIf stick < -1 * Convert.ToDouble(myform.nudRXdeadband.Value) Then
                        UC100.JogOnSpeed(axis, minusdir, RSspeedX) '' X joy velocity set to 0
                    End If
                End If

                If currentStickState3 = False AndAlso previousStickState3 = True Then  'additional functionality if desired
                    UC100.JogOnSpeed(axis, plusdir, 0)
                    RSspeedX = 0
                    jogvelRightX = 0
                End If

                previousStickState3 = currentStickState3
            End If



#Region "jog select"



            If JogStepSelect = True AndAlso Not UC.IsMoving() AndAlso myform.cbRightStickEnab.Checked AndAlso jogstepEnable Then
                Dim jog1, jog2, jog3, jog4 As Double


                'int JogSelected = 0;
                currentStickState5 = Math.Abs(stick) > 0.8
                currentStickState3 = Math.Abs(stick) > 0.2

                If currentStickState5 = True AndAlso previousStickState5 = False Then

                    'button just pressed, call code

                    'originalVel = Convert.ToDouble(UC.Getfield(false, 913));  // get original feedrate
                    If Math.Abs(rstickx) > Math.Abs(rsticky) Then

                        If stick > 0 Then
                            JogSelected = 4
                            'Dim Jog4 As Double
                            Dim test = Double.TryParse(myform.jog4.Text, jog4)

                            If test Then
                                UC.Setfield(False, jog4, 2027)
                                UC.Validatefield(False, 2027)  ' default value
                            Else
                                UC.Callbutton(166)   ' Full left code
                            End If
                        Else

                            'full left code  // override value
                            JogSelected = 1
                            'Dim Jog1 As Double
                            Dim test = Double.TryParse(myform.jog1.Text, jog1)

                            If test Then
                                UC.Setfield(False, jog1, 2027)
                                UC.Validatefield(False, 2027)  ' default value
                            Else
                                UC.Callbutton(241)   ' Full left code
                            End If
                        End If
                    End If
                End If

                If currentStickState3 = True AndAlso previousStickState3 = False Then

                    'button just pressed, call code

                    'originalVel = Convert.ToDouble(UC.Getfield(false, 913));  // get original feedrate
                    If Math.Abs(rstickx) > Math.Abs(rsticky) Then

                        If stick > 0 Then
                            JogSelected = 3
                            'Dim Jog3 As Double
                            Dim test = Double.TryParse(myform.jog3.Text, jog3)

                            If test Then
                                UC.Setfield(False, jog3, 2027)
                                UC.Validatefield(False, 2027)  ' default value
                            Else
                                UC.Callbutton(165)   ' Full left code
                            End If
                        Else

                            'full left code  // override value
                            JogSelected = 2
                            'Dim Jog2 As Double
                            Dim test = Double.TryParse(myform.jog2.Text, jog2)

                            If test Then
                                UC.Setfield(False, jog2, 2027)
                                UC.Validatefield(False, 2027)  ' default value
                            Else
                                UC.Callbutton(164)   ' Full left code
                            End If
                        End If
                    End If
                End If

                'additional functionality if desired-released
                If currentStickState3 = False AndAlso previousStickState3 = True Then
                    Try
                        If myform.checkBox4.Checked AndAlso Not UC.IsMoving() Then

                            If JogSelected = 1 Then
                                'Console.Beep();
                                'Console.Beep(10, 50);
                                'System.Media.SystemSounds.Beep.Play();
                                Shake(1)
                            ElseIf JogSelected = 2 Then
                                'System.Media.SystemSounds.Asterisk.Play();
                                Shake(2)
                            ElseIf JogSelected = 3 Then
                                'System.Media.SystemSounds.Hand.Play();
                                Shake(3)
                            ElseIf JogSelected = 4 Then
                                Shake(4)
                                'System.Media.SystemSounds.Exclamation.Play();
                            End If
                        End If
                    Catch ex As Exception

                    End Try

                    Try
                        If myform.cbJogStepNotify.Checked AndAlso Not UC.IsMoving() Then

                            If JogSelected = 1 Then
                                myform.NotifyIcon1.Visible = False ' Pop any existing balloon....
                                myform.NotifyIcon1.Visible = True

                                myform.NotifyIcon1.BalloonTipTitle = "Step Jog Value Set To:  " & myform.jog1.Text
                                myform.NotifyIcon1.BalloonTipText = " "
                                myform.NotifyIcon1.Text = " "
                                myform.NotifyIcon1.ShowBalloonTip(1000)
                                myform.NotifyIcon1.Icon = Resources.XBON

                            ElseIf JogSelected = 2 Then
                                myform.NotifyIcon1.Visible = False ' Pop any existing balloon....
                                myform.NotifyIcon1.Visible = True

                                myform.NotifyIcon1.BalloonTipTitle = "Step Jog Value Set To:  " & myform.jog2.Text
                                myform.NotifyIcon1.BalloonTipText = " "
                                myform.NotifyIcon1.Text = " "
                                myform.NotifyIcon1.ShowBalloonTip(1000)
                                myform.NotifyIcon1.Icon = Resources.XBON
                            ElseIf JogSelected = 3 Then
                                myform.NotifyIcon1.Visible = False ' Pop any existing balloon....
                                myform.NotifyIcon1.Visible = True

                                myform.NotifyIcon1.BalloonTipTitle = "Step Jog Value Set To:  " & myform.jog3.Text
                                myform.NotifyIcon1.BalloonTipText = " "
                                myform.NotifyIcon1.Text = " "
                                myform.NotifyIcon1.ShowBalloonTip(1000)
                                myform.NotifyIcon1.Icon = Resources.XBON
                            ElseIf JogSelected = 4 Then
                                myform.NotifyIcon1.Visible = False ' Pop any existing balloon....
                                myform.NotifyIcon1.Visible = True

                                myform.NotifyIcon1.BalloonTipTitle = "Step Jog Value Set To:  " & myform.jog4.Text
                                myform.NotifyIcon1.BalloonTipText = " "
                                myform.NotifyIcon1.Text = " "
                                myform.NotifyIcon1.ShowBalloonTip(1000)
                                myform.NotifyIcon1.Icon = Resources.XBON
                            End If
                        End If
                    Catch ex As Exception

                    End Try


                End If

                previousStickState3 = currentStickState3
                previousStickState5 = currentStickState5
            End If

        End Sub



#End Region


        '  Right Stick =  Y Axis
        Public Sub CheckStickRY(ByVal stick As Double)
            currentStickState4 = Math.Abs(stick) > Convert.ToDouble(myform.nudRYdeadband.Value)
            RSMaxSpdY = Convert.ToDouble(myform.nudMaxVelRSV.Value)
            Dim RYAssign = myform.comboBoxRYStick.Text

            Select Case RYAssign
                Case "Xaxis"
                    axis = 0
                    plusdir = False
                    minusdir = True
                    RSspeedY = RSMaxSpdY / xmaxVel * jogvelRightY
                Case "Yaxis"
                    axis = 1
                    plusdir = False
                    minusdir = True
                    RSspeedY = RSMaxSpdY / ymaxVel * jogvelRightY
                Case "Zaxis"
                    axis = 2
                    plusdir = False
                    minusdir = True
                    RSspeedY = RSMaxSpdY / zmaxVel * jogvelRightY
                Case "Aaxis"
                    axis = 3
                    plusdir = False
                    minusdir = True
                    RSspeedY = RSMaxSpdY / amaxVel * jogvelRightY
                Case "Baxis"
                    axis = 4
                    plusdir = False
                    minusdir = True
                    RSspeedY = RSMaxSpdY / bmaxVel * jogvelRightY
                Case "Caxis"
                    axis = 5
                    plusdir = False
                    minusdir = True
                    RSspeedY = RSMaxSpdY / cmaxVel * jogvelRightY
                Case "Rev_Xaxis"
                    axis = 0
                    plusdir = True
                    minusdir = False
                    RSspeedY = RSMaxSpdY / xmaxVel * jogvelRightY
                Case "Rev_Yaxis"
                    axis = 1
                    plusdir = True
                    minusdir = False
                    RSspeedY = RSMaxSpdY / ymaxVel * jogvelRightY
                Case "Rev_Zaxis"
                    axis = 2
                    plusdir = True
                    minusdir = False
                    RSspeedY = RSMaxSpdY / zmaxVel * jogvelRightY
                Case "Rev_Aaxis"
                    axis = 3
                    plusdir = True
                    minusdir = False
                    RSspeedY = RSMaxSpdY / amaxVel * jogvelRightY
                Case "Rev_Baxis"
                    axis = 4
                    plusdir = True
                    minusdir = False
                    RSspeedY = RSMaxSpdY / bmaxVel * jogvelRightY
                Case "Rev_Caxis"
                    axis = 5
                    plusdir = True
                    minusdir = False
                    RSspeedY = RSMaxSpdY / zmaxVel * jogvelRightY
                Case Else
                    axis = 0
                    plusdir = True
                    minusdir = False
            End Select




            '  Ensure limited to 100, and select if max vel or not
            If RSspeedY > 100 Then
                RSspeedY = 100
            End If

            If Not myform.cbRSMaxVel.Checked Then
                RSspeedY = jogvelRightY
            End If

            If JogEnable = True AndAlso myform.cbRightStickEnab.Checked Then

                If stick > Convert.ToDouble(myform.nudRYdeadband.Value) Then
                    UC100.JogOnSpeed(axis, plusdir, RSspeedY) '' X joy velocity set to 0
                ElseIf stick < -1 * Convert.ToDouble(myform.nudRYdeadband.Value) Then
                    UC100.JogOnSpeed(axis, minusdir, RSspeedY) '' X joy velocity set to 0
                End If
            End If

            If currentStickState4 = False AndAlso previousStickState4 = True Then  'additional functionality if desired
                UC100.JogOnSpeed(axis, plusdir, 0)
                RSspeedY = 0
                jogvelRightY = 0
            End If

            previousStickState4 = currentStickState4
        End Sub


#End Region

#End Region


#Region "Button Actions"
        ' Button state checks and actions to perform
        '  A Button
        Public Sub CheckA(ByVal A As Boolean)
            currentA = A

            If currentA = True AndAlso previousA = False Then

                'button just pressed, call code
                If True Then
                    Dim OnA As Integer
                    Dim test = Integer.TryParse(myform.comboBox2.Text, OnA)


                    'int OnA = Convert.ToInt32(myform.comboBox2.Text);
                    If test Then
                        UC.Callbutton(OnA)  ' Z+ Jog code
                    End If
                End If
            End If

            If currentA = False AndAlso previousA = True Then  'additional functionality if desired
                'button just released, call other code
                Dim OffA As Integer
                Dim test = Integer.TryParse(myform.comboBox1.Text, OffA)


                'int OffA = Convert.ToInt32(myform.comboBox1.Text);
                If test Then
                    UC.Callbutton(OffA) ' Z Jog stop codes
                End If
            End If

            previousA = currentA
        End Sub


        '  B Button
        Public Sub CheckB(ByVal B As Boolean)
            currentB = B

            If currentB = True AndAlso previousB = False Then

                'button just pressed, call code

                If True Then
                    Dim OnB As Integer
                    Dim test = Integer.TryParse(myform.comboBox4.Text, OnB)


                    'int OnA = Convert.ToInt32(myform.comboBox2.Text);
                    If test Then
                        UC.Callbutton(OnB)  ' Z+ Jog code
                    End If
                End If
            End If

            If currentB = False AndAlso previousB = True Then  'additional functionality if desired
                'button just released, call other code
                Dim OffB As Integer
                Dim test = Integer.TryParse(myform.comboBox3.Text, OffB)


                'int OffA = Convert.ToInt32(myform.comboBox1.Text);
                If test Then
                    UC.Callbutton(OffB) ' Z Jog stop codes
                End If
            End If

            previousB = currentB
        End Sub



        '  X Button
        Public Sub CheckX(ByVal X As Boolean)
            currentX = X

            If currentX = True AndAlso previousX = False Then

                'button just pressed, call code
                If True Then
                    Dim OnX As Integer
                    Dim test = Integer.TryParse(myform.comboBox6.Text, OnX)


                    'int OnA = Convert.ToInt32(myform.comboBox2.Text);
                    If test Then
                        UC.Callbutton(OnX)  ' Z+ Jog code
                    End If
                End If
            End If

            If currentX = False AndAlso previousX = True Then  'additional functionality if desired
                'button just released, call other code
                Dim OffX As Integer
                Dim test = Integer.TryParse(myform.comboBox5.Text, OffX)


                'int OffA = Convert.ToInt32(myform.comboBox1.Text);
                If test Then
                    UC.Callbutton(OffX) ' Z Jog stop codes
                End If
            End If

            previousX = currentX
        End Sub



        '  Y Button
        Public Sub CheckY(ByVal Y As Boolean)
            currentY = Y

            If currentY = True AndAlso previousY = False Then

                'button just pressed, call code
                If True Then
                    Dim OnY As Integer
                    Dim test = Integer.TryParse(myform.comboBox8.Text, OnY)


                    'int OnA = Convert.ToInt32(myform.comboBox2.Text);
                    If test Then
                        UC.Callbutton(OnY)  ' Z+ Jog code
                    End If
                End If
            End If

            If currentY = False AndAlso previousY = True Then  'additional functionality if desired
                'button just released, call other code
                Dim OffY As Integer
                Dim test = Integer.TryParse(myform.comboBox7.Text, OffY)


                'int OffA = Convert.ToInt32(myform.comboBox1.Text);
                If test Then
                    UC.Callbutton(OffY) ' Z Jog stop codes
                End If
            End If

            previousY = currentY
        End Sub


        '  LS Button
        Public Sub CheckLS(ByVal LS As Boolean)
            currentLS = LS
            Dim jogButton As Integer
            Dim jogButtonSet As Boolean
            Dim LSAssign = myform.comboLRShoulder.Text

            Select Case LSAssign
                Case "Xaxis"
                    jogButton = 147
                    jogButtonSet = True
                Case "Yaxis"
                    jogButton = 149
                    jogButtonSet = True

                Case "Zaxis"
                    jogButton = 151
                    jogButtonSet = True

                Case "Aaxis"
                    jogButton = 153
                    jogButtonSet = True

                Case "Baxis"
                    jogButton = 155
                    jogButtonSet = True

                Case "Caxis"
                    jogButton = 157
                    jogButtonSet = True

                Case "Rev_Xaxis"
                    jogButton = 148
                    jogButtonSet = True


                Case "Rev_Yaxis"
                    jogButton = 150
                    jogButtonSet = True


                Case "Rev_Zaxis"
                    jogButton = 152
                    jogButtonSet = True


                Case "Rev_Aaxis"
                    jogButton = 154
                    jogButtonSet = True


                Case "Rev_Baxis"
                    jogButton = 156
                    jogButtonSet = True


                Case "Rev_Caxis"
                    jogButton = 158
                    jogButtonSet = True


                Case Else
                    jogButtonSet = False
            End Select


            Dim stopbutton = jogButton + 82



            If Not myform.cbCustomDpad.Checked Then ' Regular JOG BUTTON CODE


                If currentLS = True AndAlso previousLS = False AndAlso jogButtonSet Then  'button just pressed, call code

                    stepmode = UC.GetLED(146)  'True if step mode, false if cont. mode
                    UC.Callbutton(162) ' set mode to step jog
                    UC.Callbutton(jogButton) 'Jog z+
                End If

                If currentLS = False AndAlso previousLS = True Then  'button just released, call other code

                    UC.Callbutton(stopbutton) ' axis stop

                    ' Reset back to step or continuous
                    If stepmode Then
                        UC.Callbutton(162) ' set mode to step jog
                    Else
                        UC.Callbutton(161) ' set mode to continuous jog
                    End If
                End If

            Else ' CUSTOM BUTTON CODE

                If currentLS = True AndAlso previousLS = False Then

                    'button just pressed, call code
                    If True Then
                        Dim OnLS As Integer
                        Dim test = Integer.TryParse(myform.comboBox10.Text, OnLS)


                        'int OnA = Convert.ToInt32(myform.comboBox2.Text);
                        If test Then
                            UC.Callbutton(OnLS)  ' Z+ Jog code
                        End If
                    End If
                End If

                If currentLS = False AndAlso previousLS = True Then  'additional functionality if desired
                    'button just released, call other code
                    Dim OffLS As Integer
                    Dim test = Integer.TryParse(myform.comboBox9.Text, OffLS)


                    'int OffA = Convert.ToInt32(myform.comboBox1.Text);
                    If test Then
                        UC.Callbutton(OffLS) ' Z Jog stop codes
                    End If
                End If
            End If

            previousLS = currentLS
        End Sub


        '  RS Button
        Public Sub CheckRS(ByVal RS As Boolean)
            currentRS = RS
            Dim jogButton As Integer
            Dim jogButtonSet As Boolean
            Dim RSAssign = myform.comboLRShoulder.Text

            Select Case RSAssign
                Case "Xaxis"
                    jogButton = 148
                    jogButtonSet = True

                Case "Yaxis"
                    jogButton = 150
                    jogButtonSet = True

                Case "Zaxis"
                    jogButton = 152
                    jogButtonSet = True

                Case "Aaxis"
                    jogButton = 154
                    jogButtonSet = True

                Case "Baxis"
                    jogButton = 156
                    jogButtonSet = True

                Case "Caxis"
                    jogButton = 158
                    jogButtonSet = True

                Case "Rev_Xaxis"
                    jogButton = 147
                    jogButtonSet = True


                Case "Rev_Yaxis"
                    jogButton = 149
                    jogButtonSet = True


                Case "Rev_Zaxis"
                    jogButton = 151
                    jogButtonSet = True


                Case "Rev_Aaxis"
                    jogButton = 153
                    jogButtonSet = True


                Case "Rev_Baxis"
                    jogButton = 155
                    jogButtonSet = True


                Case "Rev_Caxis"
                    jogButton = 157
                    jogButtonSet = True


                Case Else
                    jogButtonSet = False
            End Select


            Dim stopbutton = jogButton + 82


            If Not myform.cbCustomDpad.Checked Then



                If currentRS = True AndAlso previousRS = False AndAlso jogButtonSet Then
                    'button just pressed, call code
                    stepmode = UC.GetLED(146)  'True if step mode, false if cont. mode
                    UC.Callbutton(162) ' set mode to step jog
                    UC.Callbutton(jogButton) 'Jog z-
                End If

                If currentRS = False AndAlso previousRS = True Then  'additional functionality if desired
                    'button just released, call other code


                    UC.Callbutton(stopbutton) ' axis stop

                    ' Reset back to step or continuous
                    If stepmode Then
                        UC.Callbutton(162) ' set mode to step jog
                    Else
                        UC.Callbutton(161) ' set mode to continuous jog
                    End If
                End If

            Else

                If True Then

                    If currentRS = True AndAlso previousRS = False Then

                        'button just pressed, call code
                        If True Then
                            Dim OnRS As Integer
                            Dim test = Integer.TryParse(myform.comboBox12.Text, OnRS)


                            'int OnA = Convert.ToInt32(myform.comboBox2.Text);
                            If test Then
                                UC.Callbutton(OnRS)  ' Z+ Jog code
                            End If
                        End If
                    End If

                    If currentRS = False AndAlso previousRS = True Then  'additional functionality if desired
                        'button just released, call other code
                        Dim OffRS As Integer
                        Dim test = Integer.TryParse(myform.comboBox11.Text, OffRS)


                        'int OffA = Convert.ToInt32(myform.comboBox1.Text);
                        If test Then
                            UC.Callbutton(OffRS) ' Z Jog stop codes
                        End If
                    End If
                End If
            End If

            previousRS = currentRS
        End Sub


        '  START Button
        Public Sub CheckSTART(ByVal START As Boolean)
            currentSTART = START

            If currentSTART = True AndAlso previousSTART = False Then

                'button just pressed, call code
                If True Then
                    Dim OnSTART As Integer
                    Dim test = Integer.TryParse(myform.comboBox16.Text, OnSTART)


                    'int OnA = Convert.ToInt32(myform.comboBox2.Text);
                    If test Then
                        UC.Callbutton(OnSTART)  ' Z+ Jog code
                    End If
                End If
            End If

            If currentSTART = False AndAlso previousSTART = True Then  'additional functionality if desired
                'button just released, call other code
                Dim OffSTART As Integer
                Dim test = Integer.TryParse(myform.comboBox15.Text, OffSTART)


                'int OffA = Convert.ToInt32(myform.comboBox1.Text);
                If test Then
                    UC.Callbutton(OffSTART) ' Z Jog stop codes
                End If
            End If

            previousSTART = currentSTART
        End Sub


        '  BACK Button
        Public Sub CheckBACK(ByVal BACK As Boolean)
            currentBACK = BACK

            If currentBACK = True AndAlso previousBACK = False Then

                'button just pressed, call code
                If True Then
                    Dim OnBACK As Integer
                    Dim test = Integer.TryParse(myform.comboBox14.Text, OnBACK)


                    'int OnA = Convert.ToInt32(myform.comboBox2.Text);
                    If test Then
                        UC.Callbutton(OnBACK)  ' Z+ Jog code
                    End If
                End If
            End If

            If currentBACK = False AndAlso previousBACK = True Then  'additional functionality if desired
                'button just released, call other code
                Dim OffBACK As Integer
                Dim test = Integer.TryParse(myform.comboBox13.Text, OffBACK)


                'int OffA = Convert.ToInt32(myform.comboBox1.Text);
                If test Then
                    UC.Callbutton(OffBACK) ' Z Jog stop codes
                End If
            End If

            previousBACK = currentBACK
        End Sub



        '  UP Button
        Public Sub CheckUP(ByVal UP As Boolean)
            currentUP = UP
            Dim jogButton As Integer
            Dim jogButtonSet As Boolean
            Dim UPAssign = myform.comboUDDpad.Text

            Select Case UPAssign
                Case "Xaxis"
                    jogButton = 147
                    jogButtonSet = True
                Case "Yaxis"
                    jogButton = 149
                    jogButtonSet = True

                Case "Zaxis"
                    jogButton = 151
                    jogButtonSet = True

                Case "Aaxis"
                    jogButton = 153
                    jogButtonSet = True

                Case "Baxis"
                    jogButton = 155
                    jogButtonSet = True

                Case "Caxis"
                    jogButton = 157
                    jogButtonSet = True

                Case "Rev_Xaxis"
                    jogButton = 148
                    jogButtonSet = True


                Case "Rev_Yaxis"
                    jogButton = 150
                    jogButtonSet = True


                Case "Rev_Zaxis"
                    jogButton = 152
                    jogButtonSet = True


                Case "Rev_Aaxis"
                    jogButton = 154
                    jogButtonSet = True


                Case "Rev_Baxis"
                    jogButton = 156
                    jogButtonSet = True


                Case "Rev_Caxis"
                    jogButton = 158
                    jogButtonSet = True


                Case Else
                    jogButtonSet = False
            End Select

            Dim stopbutton = jogButton + 82


            If Not myform.cbCustomDpad.Checked Then ' NOT USING CUTOM


                If currentUP = True AndAlso previousUP = False AndAlso jogButtonSet Then
                    'button just pressed, call code
                    stepmode = UC.GetLED(146)  'True if step mode, false if cont. mode
                    UC.Callbutton(162) ' set mode to step jog
                    UC.Callbutton(jogButton) 'Jog y+
                End If

                If currentUP = False AndAlso previousUP = True Then  'additional functionality if desired
                    'button just released, call other code

                    UC.Callbutton(stopbutton) ' axis stop

                    ' Reset back to step or continuous
                    If stepmode Then
                        UC.Callbutton(162) ' set mode to step jog
                    Else
                        UC.Callbutton(161) ' set mode to continuous jog
                    End If


                    'int OffUP = Convert.ToInt32(myform.numericUpDown2.Value);
                    'UC.Callbutton(OffUP);  // Z Jog stop codes
                End If


            Else

                If True Then

                    If currentUP = True AndAlso previousUP = False Then

                        'button just pressed, call code
                        If True Then
                            Dim OnUP As Integer
                            Dim test = Integer.TryParse(myform.comboBox18.Text, OnUP)


                            'int OnA = Convert.ToInt32(myform.comboBox2.Text);
                            If test Then
                                UC.Callbutton(OnUP)  ' Z+ Jog code
                            End If
                        End If
                    End If

                    If currentUP = False AndAlso previousUP = True Then  'additional functionality if desired
                        'button just released, call other code
                        Dim OffUP As Integer
                        Dim test = Integer.TryParse(myform.comboBox17.Text, OffUP)


                        'int OffA = Convert.ToInt32(myform.comboBox1.Text);
                        If test Then
                            UC.Callbutton(OffUP) ' Z Jog stop codes
                        End If
                    End If
                End If
            End If

            previousUP = currentUP
        End Sub



        '  DOWN Button
        Public Sub CheckDOWN(ByVal DOWN As Boolean)
            currentDOWN = DOWN
            Dim jogButton As Integer
            Dim jogButtonSet As Boolean
            Dim DNAssign = myform.comboUDDpad.Text

            Select Case DNAssign
                Case "Xaxis"
                    jogButton = 148
                    jogButtonSet = True
                Case "Yaxis"
                    jogButton = 150
                    jogButtonSet = True

                Case "Zaxis"
                    jogButton = 152
                    jogButtonSet = True

                Case "Aaxis"
                    jogButton = 154
                    jogButtonSet = True

                Case "Baxis"
                    jogButton = 156
                    jogButtonSet = True

                Case "Caxis"
                    jogButton = 158
                    jogButtonSet = True

                Case "Rev_Xaxis"
                    jogButton = 147
                    jogButtonSet = True


                Case "Rev_Yaxis"
                    jogButton = 149
                    jogButtonSet = True


                Case "Rev_Zaxis"
                    jogButton = 151
                    jogButtonSet = True


                Case "Rev_Aaxis"
                    jogButton = 153
                    jogButtonSet = True


                Case "Rev_Baxis"
                    jogButton = 155
                    jogButtonSet = True


                Case "Rev_Caxis"
                    jogButton = 157
                    jogButtonSet = True


                Case Else
                    jogButtonSet = False
            End Select


            Dim stopbutton = jogButton + 82


            If Not myform.cbCustomDpad.Checked Then



                If currentDOWN = True AndAlso previousDOWN = False AndAlso jogButtonSet Then
                    'button just pressed, call code
                    stepmode = UC.GetLED(146)  'True if step mode, false if cont. mode
                    UC.Callbutton(162) ' set mode to step jog
                    UC.Callbutton(jogButton) 'Jog y-
                End If

                If currentDOWN = False AndAlso previousDOWN = True Then  'additional functionality if desired
                    'button just released, call other code

                    UC.Callbutton(stopbutton) ' axis stop

                    ' Reset back to step or continuous
                    If stepmode Then
                        UC.Callbutton(162) ' set mode to step jog
                    Else
                        UC.Callbutton(161) ' set mode to continuous jog
                    End If
                End If


            Else

                If True Then

                    If currentDOWN = True AndAlso previousDOWN = False Then

                        'button just pressed, call code
                        If True Then
                            Dim OnDOWN As Integer
                            Dim test = Integer.TryParse(myform.comboBox20.Text, OnDOWN)


                            'int OnA = Convert.ToInt32(myform.comboBox2.Text);
                            If test Then
                                UC.Callbutton(OnDOWN)  ' Z+ Jog code
                            End If
                        End If
                    End If

                    If currentDOWN = False AndAlso previousDOWN = True Then  'additional functionality if desired
                        'button just released, call other code
                        Dim OffDOWN As Integer
                        Dim test = Integer.TryParse(myform.comboBox19.Text, OffDOWN)


                        'int OffA = Convert.ToInt32(myform.comboBox1.Text);
                        If test Then
                            UC.Callbutton(OffDOWN) ' Z Jog stop codes
                        End If
                    End If
                End If
            End If

            previousDOWN = currentDOWN
        End Sub



        '  LEFT Button
        Public Sub CheckLEFT(ByVal LEFT As Boolean)
            currentLEFT = LEFT
            Dim jogButton As Integer
            Dim jogButtonSet As Boolean
            Dim LEFTAssign = myform.comboLRDpad.Text

            Select Case LEFTAssign
                Case "Xaxis"
                    jogButton = 148
                    jogButtonSet = True
                Case "Yaxis"
                    jogButton = 150
                    jogButtonSet = True

                Case "Zaxis"
                    jogButton = 152
                    jogButtonSet = True

                Case "Aaxis"
                    jogButton = 154
                    jogButtonSet = True

                Case "Baxis"
                    jogButton = 156
                    jogButtonSet = True

                Case "Caxis"
                    jogButton = 158
                    jogButtonSet = True

                Case "Rev_Xaxis"
                    jogButton = 147
                    jogButtonSet = True


                Case "Rev_Yaxis"
                    jogButton = 149
                    jogButtonSet = True


                Case "Rev_Zaxis"
                    jogButton = 151
                    jogButtonSet = True


                Case "Rev_Aaxis"
                    jogButton = 153
                    jogButtonSet = True


                Case "Rev_Baxis"
                    jogButton = 155
                    jogButtonSet = True


                Case "Rev_Caxis"
                    jogButton = 157
                    jogButtonSet = True


                Case Else
                    jogButtonSet = False
            End Select


            Dim stopbutton = jogButton + 82



            If Not myform.cbCustomDpad.Checked Then ' Check if allow 'custom assignment'


                If currentLEFT = True AndAlso previousLEFT = False AndAlso jogButtonSet Then
                    'button just pressed, call code
                    stepmode = UC.GetLED(146)  'True if step mode, false if cont. mode
                    UC.Callbutton(162) ' set mode to step jog
                    UC.Callbutton(jogButton) 'Jog x-
                End If

                If currentLEFT = False AndAlso previousLEFT = True Then  'additional functionality if desired
                    'button just released, call other code


                    UC.Callbutton(stopbutton) ' axis stop

                    ' Reset back to step or continuous
                    If stepmode Then
                        UC.Callbutton(162) ' set mode to step jog
                    Else
                        UC.Callbutton(161) ' set mode to continuous jog
                    End If
                End If

            Else ' Custome Code here!

                If currentLEFT = True AndAlso previousLEFT = False Then

                    'button just pressed, call code
                    If True Then
                        Dim OnLEFT As Integer
                        Dim test = Integer.TryParse(myform.comboBox22.Text, OnLEFT)


                        'int OnA = Convert.ToInt32(myform.comboBox2.Text);
                        If test Then
                            UC.Callbutton(OnLEFT)  ' Z+ Jog code
                        End If
                    End If
                End If

                If currentLEFT = False AndAlso previousLEFT = True Then  'additional functionality if desired
                    'button just released, call other code
                    Dim OffLEFT As Integer
                    Dim test = Integer.TryParse(myform.comboBox21.Text, OffLEFT)


                    'int OffA = Convert.ToInt32(myform.comboBox1.Text);
                    If test Then
                        UC.Callbutton(OffLEFT) ' Z Jog stop codes
                    End If
                End If
            End If

            previousLEFT = currentLEFT
        End Sub



        '  RIGHT Button
        Public Sub CheckRIGHT(ByVal RIGHT As Boolean)
            currentRIGHT = RIGHT
            Dim jogButton As Integer
            Dim jogButtonSet As Boolean
            Dim RIGHTAssign = myform.comboLRDpad.Text

            Select Case RIGHTAssign
                Case "Xaxis"
                    jogButton = 147
                    jogButtonSet = True
                Case "Yaxis"
                    jogButton = 149
                    jogButtonSet = True

                Case "Zaxis"
                    jogButton = 151
                    jogButtonSet = True

                Case "Aaxis"
                    jogButton = 153
                    jogButtonSet = True

                Case "Baxis"
                    jogButton = 155
                    jogButtonSet = True

                Case "Caxis"
                    jogButton = 157
                    jogButtonSet = True

                Case "Rev_Xaxis"
                    jogButton = 148
                    jogButtonSet = True


                Case "Rev_Yaxis"
                    jogButton = 150
                    jogButtonSet = True


                Case "Rev_Zaxis"
                    jogButton = 152
                    jogButtonSet = True


                Case "Rev_Aaxis"
                    jogButton = 154
                    jogButtonSet = True


                Case "Rev_Baxis"
                    jogButton = 156
                    jogButtonSet = True


                Case "Rev_Caxis"
                    jogButton = 158
                    jogButtonSet = True


                Case Else
                    jogButtonSet = False
            End Select

            Dim stopbutton = jogButton + 82




            If Not myform.cbCustomDpad.Checked Then


                If currentRIGHT = True AndAlso previousRIGHT = False AndAlso jogButtonSet Then
                    'button just pressed, call code
                    stepmode = UC.GetLED(146)  'True if step mode, false if cont. mode
                    UC.Callbutton(162) ' set mode to step jog
                    UC.Callbutton(jogButton) 'Jog x-
                End If

                If currentRIGHT = False AndAlso previousRIGHT = True Then  'additional functionality if desired
                    'button just released, call other code

                    UC.Callbutton(stopbutton) ' axis stop

                    ' Reset back to step or continuous
                    If stepmode Then
                        UC.Callbutton(162) ' set mode to step jog
                    Else
                        UC.Callbutton(161) ' set mode to continuous jog
                    End If
                End If

            Else

                If currentRIGHT = True AndAlso previousRIGHT = False Then

                    'button just pressed, call code
                    If True Then
                        Dim OnRIGHT As Integer
                        Dim test = Integer.TryParse(myform.comboBox24.Text, OnRIGHT)


                        'int OnA = Convert.ToInt32(myform.comboBox2.Text);
                        If test Then
                            UC.Callbutton(OnRIGHT)  ' Z+ Jog code
                        End If
                    End If
                End If

                If currentRIGHT = False AndAlso previousRIGHT = True Then  'additional functionality if desired
                    'button just released, call other code
                    Dim OffRIGHT As Integer
                    Dim test = Integer.TryParse(myform.comboBox23.Text, OffRIGHT)


                    'int OffA = Convert.ToInt32(myform.comboBox1.Text);
                    If test Then
                        UC.Callbutton(OffRIGHT) ' Z Jog stop codes
                    End If
                End If
            End If

            previousRIGHT = currentRIGHT
        End Sub


#End Region


#Region "ShakeEvent"


        Public Sub Shake(ByVal numShake As Integer)
            Dim t As Thread = New Thread(AddressOf Shakethd)
            t.Start(numShake)
        End Sub

        Public Sub Shakethd(ByVal numShake As Object)
            Dim maxShake As Integer = Convert.ToInt16(numShake)

            'int countmax  = numShake;
            'Timer timer = new Timer();
            'timer.Interval = Convert.ToInt32(timeOn);

            For i = 0 To maxShake - 1
                'timer.Start();
                controls.Vibrate(100, 100)
                Thread.Sleep(150)
                controls.Vibrate(0, 0)
                Thread.Sleep(150)
            Next
        End Sub




#End Region

    End Class
End Namespace
