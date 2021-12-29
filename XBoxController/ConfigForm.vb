Imports System
Imports Xboxcontroller.Plugins

Public Class ConfigForm
    Private UC As Plugininterface.Entry
    Dim PluginMain As UCCNCplugin

    Public Sub New(CallerPluginMain As UCCNCplugin)
        Me.UC = CallerPluginMain.UC
        Me.PluginMain = CallerPluginMain
        InitializeComponent()

        Lbl_btnCode.Text = My.Settings.OpenCode.ToString

        nudCodeSet.Value = My.Settings.OpenCode

    End Sub

    Private Sub ConfigForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnSetCode_Click(sender As Object, e As EventArgs) Handles btnSetCode.Click

        My.Settings.OpenCode = Convert.ToInt32(nudCodeSet.Value)
        My.Settings.Save()

        Lbl_btnCode.Text = My.Settings.OpenCode.ToString
    End Sub
End Class