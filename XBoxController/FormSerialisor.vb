Imports System
Imports System.IO
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Xml
Imports System.Text
Imports Xboxcontroller
Imports Plugininterface

Namespace FormSerialisation




    Public Module FormSerialisor



        ' 
        '  Drop this class into your project, and add the following line at the top of any class/form that wishes to use it...
        ' using FormSerialisation;
        ' To use the code, simply call FormSerialisor.Serialise(FormOrControlToBeSerialised, FullPathToXMLFile)
        '  
        '  For more details, see http://www.codeproject.com/KB/dialog/SavingTheStateOfAForm.aspx
        '  
        '  Last updated 13th June '10 to account for the odd behaviour of the two Panel controls in a SplitContainer (see the article)
        ' 
        Public Sub Serialise(ByVal c As Control, ByVal XmlFileName As String)
            Dim xmlSerialisedForm As XmlTextWriter = New XmlTextWriter(XmlFileName, Encoding.Default)
            xmlSerialisedForm.Formatting = Formatting.Indented
            xmlSerialisedForm.WriteStartDocument()
            xmlSerialisedForm.WriteStartElement("ChildForm")
            ' enumerate all controls on the form, and serialise them as appropriate
            AddChildControls(xmlSerialisedForm, c)
            xmlSerialisedForm.WriteEndElement() ' ChildForm
            xmlSerialisedForm.WriteEndDocument()
            xmlSerialisedForm.Flush()
            xmlSerialisedForm.Close()
        End Sub

        Private Sub AddChildControls(ByVal xmlSerialisedForm As XmlTextWriter, ByVal c As Control)
            For Each childCtrl As Control In c.Controls

                If Not (TypeOf childCtrl Is Label) Then
                    ' serialise this control
                    xmlSerialisedForm.WriteStartElement("Control")
                    xmlSerialisedForm.WriteAttributeString("Type", childCtrl.GetType().ToString())
                    xmlSerialisedForm.WriteAttributeString("Name", childCtrl.Name)

                    'xmlSerialisedForm.WriteElementString("Text", ((TextBox)childCtrl).Text);
                    If TypeOf childCtrl Is TextBox Then
                    ElseIf TypeOf childCtrl Is ComboBox Then
                        xmlSerialisedForm.WriteElementString("Text", CType(childCtrl, ComboBox).Text)
                        xmlSerialisedForm.WriteElementString("SelectedIndex", CType(childCtrl, ComboBox).SelectedIndex.ToString())
                    ElseIf TypeOf childCtrl Is ListBox Then
                        ' need to account for multiply selected items
                        Dim lst = CType(childCtrl, ListBox)

                        If lst.SelectedIndex = -1 Then
                            xmlSerialisedForm.WriteElementString("SelectedIndex", "-1")
                        Else

                            For i = 0 To lst.SelectedIndices.Count - 1
                                xmlSerialisedForm.WriteElementString("SelectedIndex", (lst.SelectedIndices(i).ToString()))
                            Next
                        End If
                    ElseIf TypeOf childCtrl Is CheckBox Then
                        xmlSerialisedForm.WriteElementString("Checked", CType(childCtrl, CheckBox).Checked.ToString())
                        ''' Added types

                    ElseIf TypeOf childCtrl Is NumericUpDown Then
                        xmlSerialisedForm.WriteElementString("Value", CType(childCtrl, NumericUpDown).Value.ToString())
                    ElseIf TypeOf childCtrl Is RadioButton Then
                        xmlSerialisedForm.WriteElementString("Checked", CType(childCtrl, RadioButton).Checked.ToString())
                    End If


                    ' this next line was taken from http://stackoverflow.com/questions/391888/how-to-get-the-real-value-of-the-visible-property
                    ' which dicusses the problem of child controls claiming to have Visible=false even when they haven't, based on the parent
                    ' having Visible=true
                    Dim visible As Boolean = GetType(Control).GetMethod("GetState", BindingFlags.Instance Or BindingFlags.NonPublic).Invoke(childCtrl, New Object() {2})
                    xmlSerialisedForm.WriteElementString("Visible", visible.ToString())

                    ' see if this control has any children, and if so, serialise them
                    If childCtrl.HasChildren Then

                        If Not (TypeOf childCtrl Is NumericUpDown) Then

                            If TypeOf childCtrl Is SplitContainer Then
                                ' handle this one as a special case
                                AddChildControls(xmlSerialisedForm, CType(childCtrl, SplitContainer).Panel1)
                                AddChildControls(xmlSerialisedForm, CType(childCtrl, SplitContainer).Panel2)
                            Else
                                AddChildControls(xmlSerialisedForm, childCtrl)
                            End If
                        End If
                    End If

                    xmlSerialisedForm.WriteEndElement() ' Control
                End If
            Next
        End Sub

        Public Sub Deserialise(ByVal c As Control, ByVal XmlFileName As String)
            If File.Exists(XmlFileName) Then
                Dim xmlSerialisedForm As XmlDocument = New XmlDocument()
                xmlSerialisedForm.Load(XmlFileName)
                Dim topLevel = xmlSerialisedForm.ChildNodes(1)

                For Each n As XmlNode In topLevel.ChildNodes

                    Try
                        'add check
                        'MessageBox.Show(Convert.ToString((Control)c));
                        SetControlProperties(c, n)
                    Catch
                    End Try
                Next
            End If
        End Sub

        Private Sub SetControlProperties(ByVal currentCtrl As Control, ByVal n As XmlNode)
            ' get the control's name and type
            Dim controlName = n.Attributes("Name").Value
            Dim controlType = n.Attributes("Type").Value
            'MessageBox.Show(controlName + " " + controlType);
            ' find the control
            Dim ctrl = currentCtrl.Controls.Find(controlName, True)

            If ctrl.Length = 0 Then
                ' can't find the control


                MessageBox.Show("can't find control in XML settings file, please hit save after loaded.")
            Else
                Dim ctrlToSet = GetImmediateChildControl(ctrl, currentCtrl)

                If ctrlToSet IsNot Nothing Then

                    If Equals(ctrlToSet.GetType().ToString(), controlType) Then

                        ' the right type too ;-)
                        Select Case controlType
                                            '((System.Windows.Forms.TextBox)ctrlToSet).Text = n["Text"].InnerText;
                            Case "System.Windows.Forms.TextBox"
                            Case "System.Windows.Forms.ComboBox"
                                '((System.Windows.Forms.ComboBox)ctrlToSet).SelectedIndex = Convert.ToInt32(n["SelectedIndex"].InnerText);
                                CType(ctrlToSet, ComboBox).Text = n("Text").InnerText
                            Case "System.Windows.Forms.ListBox"
                                ' need to account for multiply selected items
                                Dim lst = CType(ctrlToSet, ListBox)
                                Dim xnlSelectedIndex = n.SelectNodes("SelectedIndex")

                                For i = 0 To xnlSelectedIndex.Count - 1
                                    lst.SelectedIndex = Convert.ToInt32(xnlSelectedIndex(i).InnerText)
                                Next

                            Case "System.Windows.Forms.CheckBox"
                                CType(ctrlToSet, CheckBox).Checked = Convert.ToBoolean(n("Checked").InnerText)
                            Case "System.Windows.Forms.NumericUpDown"
                                CType(ctrlToSet, NumericUpDown).Value = Convert.ToDecimal(n("Value").InnerText)
                            Case "System.Windows.Forms.RadioButton"
                                CType(ctrlToSet, RadioButton).Checked = Convert.ToBoolean(n("Checked").InnerText)
                        End Select

                        ctrlToSet.Visible = Convert.ToBoolean(n("Visible").InnerText)

                        ' if n has any children that are controls, deserialise them as well
                        If n.HasChildNodes AndAlso ctrlToSet.HasChildren Then
                            Dim xnlControls = n.SelectNodes("Control")

                            For Each n2 As XmlNode In xnlControls
                                SetControlProperties(ctrlToSet, n2)
                            Next
                        End If
                    Else
                        ' not the right type
                        MessageBox.Show("wrong type of control in settings file, hit save after loaded.")
                    End If
                Else
                    ' can't find a control whose parent is the current control
                    MessageBox.Show("can't find control in settings file.")
                End If
            End If
        End Sub

        Private Function GetImmediateChildControl(ByVal ctrl As Control(), ByVal currentCtrl As Control) As Control
            Dim c As Control = Nothing

            For i = 0 To ctrl.Length - 1

                If Equals(ctrl(i).Parent.Name, currentCtrl.Name) OrElse TypeOf currentCtrl Is SplitContainer AndAlso Equals(ctrl(i).Parent.Parent.Name, currentCtrl.Name) Then
                    c = ctrl(i)
                    Exit For
                End If
            Next

            Return c
        End Function
    End Module
End Namespace
