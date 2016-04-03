Public Class Customer_Display
    Dim Index As Integer


    Public Sub AccountDetails(ByVal Index As Integer)
        With Bank(Index)
            TextBox1.Text = .AccountName
            TextBox2.Text = .AccountType
            TextBox3.Text = .deposit
            TextBox4.Text = .Withdraw
            CheckBox1.Checked = .Overdraft
        End With
    End Sub

    Private Sub Customer_Display_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Index As Integer
        btnPrevious.Enabled = False
        If NumberOfAccount = 0 Then
            btnNext.Enabled = False
        ElseIf NumberOfAccount = 1 Then
            btnNext.Enabled = False
            Call AccountDetails(0)
        Else
            btnNext.Enabled = True
            Call AccountDetails(0)
        End If
        For Index = 0 To NumberOfAccount - 1
            ComboBox1.Items.Add(Bank(Index).AccountName)
        Next


    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Index = Index + 1
        Call AccountDetails(Index)
        btnPrevious.Enabled = True

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Index = Index - 1
        Call AccountDetails(Index)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim RecordNumber As Integer
        RecordNumber = ComboBox1.SelectedIndex
        Call AccountDetails(RecordNumber)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        CheckBox1.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class