Imports System
Imports SlimDX
Imports SlimDX.XInput

Namespace Xbox360Controller
    Public Class GamepadState
        Private _DPad As Xbox360Controller.GamepadState.DPadState, _LeftStick As Xbox360Controller.GamepadState.ThumbstickState, _RightStick As Xbox360Controller.GamepadState.ThumbstickState, _A As Boolean, _B As Boolean, _X As Boolean, _Y As Boolean, _RightShoulder As Boolean, _LeftShoulder As Boolean, _Start As Boolean, _Back As Boolean, _RightTrigger As Single, _LeftTrigger As Single
        Private lastPacket As UInteger

        Public Sub New(ByVal userIndex As UserIndex)
            Me.UserIndex = userIndex
            Controller = New Controller(userIndex)
        End Sub

        Public ReadOnly UserIndex As UserIndex
        Public ReadOnly Controller As Controller

        Public Property DPad As DPadState
            Get
                Return _DPad
            End Get
            Private Set(ByVal value As DPadState)
                _DPad = value
            End Set
        End Property

        Public Property LeftStick As ThumbstickState
            Get
                Return _LeftStick
            End Get
            Private Set(ByVal value As ThumbstickState)
                _LeftStick = value
            End Set
        End Property

        Public Property RightStick As ThumbstickState
            Get
                Return _RightStick
            End Get
            Private Set(ByVal value As ThumbstickState)
                _RightStick = value
            End Set
        End Property

        Public Property A As Boolean
            Get
                Return _A
            End Get
            Private Set(ByVal value As Boolean)
                _A = value
            End Set
        End Property

        Public Property B As Boolean
            Get
                Return _B
            End Get
            Private Set(ByVal value As Boolean)
                _B = value
            End Set
        End Property

        Public Property X As Boolean
            Get
                Return _X
            End Get
            Private Set(ByVal value As Boolean)
                _X = value
            End Set
        End Property

        Public Property Y As Boolean
            Get
                Return _Y
            End Get
            Private Set(ByVal value As Boolean)
                _Y = value
            End Set
        End Property

        Public Property RightShoulder As Boolean
            Get
                Return _RightShoulder
            End Get
            Private Set(ByVal value As Boolean)
                _RightShoulder = value
            End Set
        End Property

        Public Property LeftShoulder As Boolean
            Get
                Return _LeftShoulder
            End Get
            Private Set(ByVal value As Boolean)
                _LeftShoulder = value
            End Set
        End Property

        Public Property Start As Boolean
            Get
                Return _Start
            End Get
            Private Set(ByVal value As Boolean)
                _Start = value
            End Set
        End Property

        Public Property Back As Boolean
            Get
                Return _Back
            End Get
            Private Set(ByVal value As Boolean)
                _Back = value
            End Set
        End Property

        Public Property RightTrigger As Single
            Get
                Return _RightTrigger
            End Get
            Private Set(ByVal value As Single)
                _RightTrigger = value
            End Set
        End Property

        Public Property LeftTrigger As Single
            Get
                Return _LeftTrigger
            End Get
            Private Set(ByVal value As Single)
                _LeftTrigger = value
            End Set
        End Property

        Public ReadOnly Property Connected As Boolean
            Get
                Return Controller.IsConnected
            End Get
        End Property


        'public void Vibrate(float leftMotor, float rightMotor)
        '{
        '    // If not connected, dont vibrate
        '    if (!Connected) return;

        '    Controller.SetVibration(new Vibration
        '    {
        '        LeftMotorSpeed = (ushort)(MathHelper.Saturate(leftMotor) * ushort.MaxValue),
        '        RightMotorSpeed = (ushort)(MathHelper.Saturate(rightMotor) * ushort.MaxValue)
        '    });
        '}

        Public Sub Vibrate(ByVal leftMotor As Single, ByVal rightMotor As Single)
            ' If not connected, dont vibrate
            If Not Connected Then Return
            Controller.SetVibration(New Vibration With {
                .LeftMotorSpeed = Saturate(leftMotor) * UShort.MaxValue,
                .RightMotorSpeed = Saturate(rightMotor) * UShort.MaxValue
            })
        End Sub

        Public Sub Update()
            ' If not connected, nothing to update
            If Not Connected Then Return

            ' If same packet, nothing to update
            Dim state As State = Controller.GetState()
            If lastPacket = state.PacketNumber Then Return
            lastPacket = state.PacketNumber
            Dim gamepadState = state.Gamepad

            ' Shoulders
            LeftShoulder = (gamepadState.Buttons And GamepadButtonFlags.LeftShoulder) <> 0
            RightShoulder = (gamepadState.Buttons And GamepadButtonFlags.RightShoulder) <> 0

            ' Triggers
            LeftTrigger = gamepadState.LeftTrigger / CSng(Byte.MaxValue)
            RightTrigger = gamepadState.RightTrigger / CSng(Byte.MaxValue)

            ' Buttons
            Start = (gamepadState.Buttons And GamepadButtonFlags.Start) <> 0
            Back = (gamepadState.Buttons And GamepadButtonFlags.Back) <> 0
            A = (gamepadState.Buttons And GamepadButtonFlags.A) <> 0
            B = (gamepadState.Buttons And GamepadButtonFlags.B) <> 0
            X = (gamepadState.Buttons And GamepadButtonFlags.X) <> 0
            Y = (gamepadState.Buttons And GamepadButtonFlags.Y) <> 0

            ' D-Pad
            DPad = New DPadState((gamepadState.Buttons And GamepadButtonFlags.DPadUp) <> 0, (gamepadState.Buttons And GamepadButtonFlags.DPadDown) <> 0, (gamepadState.Buttons And GamepadButtonFlags.DPadLeft) <> 0, (gamepadState.Buttons And GamepadButtonFlags.DPadRight) <> 0)



            ' Thumbsticks
            LeftStick = New ThumbstickState(Normalize(gamepadState.LeftThumbX, gamepadState.LeftThumbY, Gamepad.GamepadLeftThumbDeadZone), (gamepadState.Buttons And GamepadButtonFlags.LeftThumb) <> 0)
            RightStick = New ThumbstickState(Normalize(gamepadState.RightThumbX, gamepadState.RightThumbY, Gamepad.GamepadRightThumbDeadZone), (gamepadState.Buttons And GamepadButtonFlags.RightThumb) <> 0)
        End Sub

        Private Shared Function Normalize(ByVal rawX As Short, ByVal rawY As Short, ByVal threshold As Short) As Vector2
            Dim value = New Vector2(rawX, rawY)
            Dim magnitude = value.Length()
            Dim direction = value / If(magnitude = 0, 1, magnitude)
            Dim normalizedMagnitude = 0.0F
            If magnitude - threshold > 0 Then normalizedMagnitude = Math.Min((magnitude - threshold) / (Short.MaxValue - threshold), 1)
            Return direction * normalizedMagnitude
        End Function

        Public Structure DPadState
            Public ReadOnly Up, Down, Left, Right As Boolean

            Public Sub New(ByVal up As Boolean, ByVal down As Boolean, ByVal left As Boolean, ByVal right As Boolean)
                Me.Up = up
                Me.Down = down
                Me.Left = left
                Me.Right = right
            End Sub
        End Structure

        Public Structure ThumbstickState
            Public ReadOnly Position As Vector2
            Public ReadOnly Clicked As Boolean

            Public Sub New(ByVal position As Vector2, ByVal clicked As Boolean)
                Me.Clicked = clicked
                Me.Position = position
            End Sub
        End Structure
    End Class

    Public Module MathHelper
        Public Function Saturate(ByVal value As Single) As Single
            Return If(value < 0, 0, If(value > 1, 1, value))
        End Function
    End Module

    '----------

    'public class GamePadRumble
    '{
    '    float m_Time;
    '    float m_Ratio;
    '    float m_CurrTime;
    '    float m_LeftMotor;
    '    float m_RightMotor;

    '    public GamePadRumble()
    '    {

    '    }

    '    public void Dispose()
    '    {
    '        GamePad.SetVibration(0, 0, 0);
    '    }

    '    public void Update(ref float TimeElapsed)
    '    {
    '        if (GlobalObjects.m_Settings.m_RumbleEnabled)
    '        {
    '            m_CurrTime -= TimeElapsed;
    '            m_Ratio = m_CurrTime / m_Time;
    '            if (m_CurrTime <= 0)
    '            {
    '                GamePad.SetVibration(0, 0, 0);
    '            }
    '            else
    '            {
    '                GamePad.SetVibration(0, m_LeftMotor * m_Ratio, m_RightMotor * m_Ratio);
    '            }
    '        }
    '    }

    '    public void ShakePad(float Time, float LeftMotor, float RightMotor)
    '    {
    '        m_LeftMotor = LeftMotor;
    '        m_RightMotor = RightMotor;
    '        m_CurrTime = m_Time = Time;
    '    }

    '}

    '---------









End Namespace

