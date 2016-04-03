Public Class Form1
    Dim Index As Integer

    Dim firstvalue As Double
    Dim secondvalue As Double
    Dim answer As Double
    Dim operations As String




    Dim American_Dollar As Double = 1.52
    Dim Nigerian_Naira As Double = 302.96
    Dim Canadian_Dollar As Double = 2.03
    Dim Brazilian_Real As Double = 5.86
    Dim Kenyan_shilling As Double = 156.21
    Dim Philippine_Peso As Double = 71.74
    Dim Indonesian_Rupiah As Double = 20746.75
    Dim Indian_Rupee As Double = 100.68


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = ""
        CheckBox1.Checked = False
        ComboBox1.Items.Clear()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Customer_Display.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        Bank(Index).AccountName = TextBox1.Text

        Bank(Index).Withdraw = TextBox2.Text

        Bank(Index).deposit = Val(TextBox3.Text)

        Bank(Index).AccountType = ComboBox1.Text
        Bank(Index).Overdraft = CheckBox1.Checked


        NumberOfAccount = NumberOfAccount + 1
        Index = Index + 1
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        CheckBox1.Checked = False








    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles TabPage2.Click, Button30.Click, Button29.Click, Button28.Click, Button26.Click, Button25.Click, Button24.Click, Button22.Click, Button21.Click, Button19.Click, Button18.Click
        'Code for 0 to 9
        Dim b As Button = sender
        If lblDisplay.Text = "0" Then
            lblDisplay.Text = b.Text
        Else
            lblDisplay.Text = lblDisplay.Text + b.Text

        End If
    End Sub



    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        lblDisplay.Text = "0"
        lblShowCal.Text = ""
    End Sub



    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        secondvalue = lblDisplay.Text
        If operations = "+" Then
            answer = firstvalue + secondvalue
            lblDisplay.Text = answer
            lblShowCal.Text = ""
        ElseIf operations = "-" Then
            answer = firstvalue - secondvalue
            lblDisplay.Text = answer
            lblShowCal.Text = ""
        ElseIf operations = "*" Then
            answer = firstvalue * secondvalue
            lblDisplay.Text = answer
            lblShowCal.Text = ""
        ElseIf operations = "/" Then
            answer = firstvalue / secondvalue
            lblDisplay.Text = answer
            lblShowCal.Text = ""
        End If
    End Sub

    Private Sub btnpoint_Click(sender As Object, e As EventArgs) Handles btnpoint.Click
        If InStr(lblDisplay.Text, ".") = 0 Then
            lblDisplay.Text = lblDisplay.Text + "."
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        firstvalue = lblDisplay.Text
        lblShowCal.Text = firstvalue & "+"
        lblDisplay.Text = ""
        operations = "+"
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        firstvalue = lblDisplay.Text
        lblShowCal.Text = firstvalue & "-"
        lblDisplay.Text = ""
        operations = "-"
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        firstvalue = lblDisplay.Text
        lblShowCal.Text = firstvalue & "/"
        lblDisplay.Text = ""
        operations = "/"
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        firstvalue = lblDisplay.Text
        lblShowCal.Text = firstvalue & "*"
        lblDisplay.Text = ""
        operations = "*"
    End Sub

    Private Sub btnCC_Click(sender As Object, e As EventArgs) Handles btnCC.Click
        btnCC.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmbcurrency.Text = "Choose one .... "
        Cmbcurrency.Items.Add("USA")
        Cmbcurrency.Items.Add("Kenya")
        Cmbcurrency.Items.Add("Canada")
        Cmbcurrency.Items.Add("Nigeria")
        Cmbcurrency.Items.Add("Brazil")
        Cmbcurrency.Items.Add("India")
        Cmbcurrency.Items.Add("Philippines")
        Cmbcurrency.Items.Add("Indonesia")

        txtConversion.Text = "0"


        RadioButton1.Enabled = False
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
        RadioButton5.Enabled = False





    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim British_Pounds As Double = CDbl(txtConversion.Text)
        LblConvert.Text = CStr(CursorConverter(British_Pounds))

        If Cmbcurrency.Text = "Nigeria" Then
            LblConvert.Text = "NGN:" & " " & Val(LblConvert.Text)
        ElseIf Cmbcurrency.Text = "USA" Then
            LblConvert.Text = "$:" & " " & Val(LblConvert.Text)
        ElseIf Cmbcurrency.Text = "Brazil" Then
            LblConvert.Text = "RBL:" & " " & Val(LblConvert.Text)
        ElseIf Cmbcurrency.Text = "Canada" Then
            LblConvert.Text = "C$:" & " " & Val(LblConvert.Text)
        ElseIf Cmbcurrency.Text = "kenya" Then
            LblConvert.Text = "KES:" & " " & Val(LblConvert.Text)
        ElseIf Cmbcurrency.Text = "Philippines" Then
            LblConvert.Text = "PHP:" & " " & Val(LblConvert.Text)
        ElseIf Cmbcurrency.Text = "Indonesia" Then
            LblConvert.Text = "IDR:" & " " & Val(LblConvert.Text)
        ElseIf Cmbcurrency.Text = "India" Then
            LblConvert.Text = "INR:" & " " & Val(LblConvert.Text)


        End If

    End Sub
    Function CursorConverter(ByVal money As Double) As Double
        If Cmbcurrency.Text = "Nigeria" Then
            Return Math.Round(Nigerian_Naira * money, 2)
        ElseIf Cmbcurrency.Text = "USA" Then
            Return Math.Round(American_Dollar * money, 2)
        ElseIf Cmbcurrency.Text = "Canada" Then
            Return Math.Round(Canadian_Dollar * money, 2)
        ElseIf Cmbcurrency.Text = "Brazil" Then
            Return Math.Round(Brazilian_Real * money, 2)
        ElseIf Cmbcurrency.Text = "Kenya" Then
            Return Math.Round(Kenyan_shilling * money, 2)
        ElseIf Cmbcurrency.Text = "Philppines" Then
            Return Math.Round(Philippine_Peso * money, 2)
        ElseIf Cmbcurrency.Text = "Indonesia" Then
            Return Math.Round(Indonesian_Rupiah * money, 2)
        ElseIf Cmbcurrency.Text = "India" Then
            Return Math.Round(Indian_Rupee * money, 2)
        End If


    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        btnCC.Visible = True
    End Sub

    Private Sub txtConversion_TextChanged(sender As Object, e As EventArgs) Handles txtConversion.TextChanged

    End Sub

    Private Sub txtConversion_MouseDown(sender As Object, e As MouseEventArgs) Handles txtConversion.MouseDown
        txtConversion.Text = ""
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControl1.SelectedTab = TabPage3
    End Sub



    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        TabControl1.SelectedTab = TabPage5

        Dim i(11)

        If ListBox1.FindString(lblPin.Text) Then

            i(0) = 23000
            i(1) = 199
            i(2) = 23
            i(3) = 179.9
            i(4) = 17
            i(5) = 2.9
            i(6) = 27.9
            i(7) = 89
            i(8) = 2010
            i(9) = 8.9
            i(10) = 156

            txtReceipt.AppendText(Today & vbTab & vbTab & TimeOfDay & vbNewLine)
            txtReceipt.AppendText(vbTab & vbTab & vbTab & "Mini Statement Summary" & vbNewLine)
            txtReceipt.AppendText("Descritpion " & vbTab & vbTab & "Amount" & vbNewLine)
            txtReceipt.AppendText("---------------------------------------" & vbNewLine)
            txtReceipt.AppendText("Account Number" & vbTab & vbTab & "11234" & vbNewLine)
            txtReceipt.AppendText("---------------------------------------" & vbNewLine)
            txtReceipt.AppendText("Car:" & vbTab & vbTab & vbTab & "$" & i(0) & vbNewLine)
            txtReceipt.AppendText("Laptop:" & vbTab & vbTab & vbTab & "$" & i(1) & vbNewLine)
            txtReceipt.AppendText("Tesco:" & vbTab & vbTab & vbTab & "$" & i(0) & vbNewLine)
            txtReceipt.AppendText("Macdonald:" & vbTab & vbTab & vbTab & "$" & i(1) & vbNewLine)
            txtReceipt.AppendText("Walmart:" & vbTab & vbTab & vbTab & "$" & i(2) & vbNewLine)
            txtReceipt.AppendText("KFC:" & vbTab & vbTab & vbTab & "$" & i(3) & vbNewLine)
            txtReceipt.AppendText("Box Office:" & vbTab & vbTab & vbTab & "$" & i(4) & vbNewLine)
            txtReceipt.AppendText("Carrefour:" & vbTab & vbTab & vbTab & "$" & i(5) & vbNewLine)
            txtReceipt.AppendText("PayPal:" & vbTab & vbTab & vbTab & "$" & i(6) & vbNewLine)
            txtReceipt.AppendText("Missed Payment Free:" & vbTab & vbTab & vbTab & "$" & i(7) & vbNewLine)
            txtReceipt.AppendText("Nike:" & vbTab & vbTab & vbTab & "$" & i(8) & vbNewLine)
            txtReceipt.AppendText("Lays:" & vbTab & vbTab & vbTab & "$" & i(9) & vbNewLine)
            txtReceipt.AppendText("Beers:" & vbTab & vbTab & vbTab & "$" & i(10) & vbNewLine)
            txtReceipt.AppendText("Tax:" & vbTab & vbTab & vbTab & "$" & i(11) & vbNewLine)
            txtReceipt.AppendText("Over Limit Fee:" & vbTab & vbTab & vbTab & "$" & "0.00" & vbNewLine)
            txtReceipt.AppendText("Total:" & vbTab & vbTab & vbTab & "$" & i(0) & i(1) & i(2) & i(3) & i(4) & i(5) & i(6) & i(7) & i(8) & i(9) & i(10) & i(11) & vbNewLine)

        End If


    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If lblPin.Text = "" Then
            lblPin.Text = "1"
        Else
            lblPin.Text = lblPin.Text + "1"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If lblPin.Text = "" Then
            lblPin.Text = "2"
        Else
            lblPin.Text = lblPin.Text + "2"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If lblPin.Text = "" Then
            lblPin.Text = "3"
        Else
            lblPin.Text = lblPin.Text + "3"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lblPin.Text = "" Then
            lblPin.Text = "4"
        Else
            lblPin.Text = lblPin.Text + "4"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If lblPin.Text = "" Then
            lblPin.Text = "5"
        Else
            lblPin.Text = lblPin.Text + "5"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If lblPin.Text = "" Then
            lblPin.Text = "6"
        Else
            lblPin.Text = lblPin.Text + "6"
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If lblPin.Text = "" Then
            lblPin.Text = "7"
        Else
            lblPin.Text = lblPin.Text + "7"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If lblPin.Text = "" Then
            lblPin.Text = "8"
        Else
            lblPin.Text = lblPin.Text + "8"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If lblPin.Text = "" Then
            lblPin.Text = "9"
        Else
            lblPin.Text = lblPin.Text + "9"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If lblPin.Text = "" Then
            lblPin.Text = "0"
        Else
            lblPin.Text = lblPin.Text + "0"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If ListBox1.FindString(lblPin.Text) Then
            RadioButton1.Enabled = True
            RadioButton3.Enabled = True
            RadioButton4.Enabled = True
            RadioButton5.Enabled = True

        ElseIf lblPin.Text = "" Then
            MsgBox("Enter Correct Details")
            RadioButton1.Enabled = False
            RadioButton3.Enabled = False
            RadioButton4.Enabled = False
            RadioButton5.Enabled = False

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lblPin.Text = ""
        RadioButton1.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False


        RadioButton1.Enabled = False
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
        RadioButton5.Enabled = False
        txtReceipt.Text = ""
        TabControl1.SelectedTab = TabPage1

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        lblPin.Text = ""
        RadioButton1.Enabled = False
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
        RadioButton5.Enabled = False
        txtReceipt.Text = ""
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles txtReceipt.TextChanged

    End Sub
End Class
