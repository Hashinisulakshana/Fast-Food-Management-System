Public Class HomeForm
    Private sidepane1 As Object
    Private lblusername As Object
    Public Property Timer1 As Object

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Timer1.Enabled = True
        lblusername.Text = Login.TextBox1.Text
    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnMaster_Click(sender As Object, e As EventArgs) Handles BtnMaster.Click
        sidepane1.Height = BtnMaster.Height
        sidepane1.Top = BtnMaster.Top
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        Login.Show()


    End Sub

    Private Sub Btntools_Click(sender As Object, e As EventArgs)
        sidepane1.Height = Btntools.Height
        sidepane1.Top = Btntools.Top
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnRecords_Click(sender As Object, e As EventArgs) Handles BtnRecords.Click
        sidepane1.Height = BtnRecords.Height
        sidepane1.Top = BtnRecords.Top
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)




    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btndashboard_Click(sender As Object, e As EventArgs) Handles Btndashboard.Click
        sidepane1.Height = Btndashboard.Height
        sidepane1.Top = Btndashboard.Top




    End Sub

    Private Sub BtnBilling_Click(sender As Object, e As EventArgs) Handles BtnBilling.Click
        sidepane1.Height = BtnBilling.Height
        sidepane1.Top = BtnBilling.Top
    End Sub

    Private Sub Btnadmin_Click(sender As Object, e As EventArgs) Handles Btnadmin.Click
        sidepane1.Height = Btnadmin.Height
        sidepane1.Top = Btnadmin.Top
    End Sub

    Private Sub Btnreports_Click(sender As Object, e As EventArgs)
        sidepane1.Height = Btnreports.Height
        sidepane1.Top = Btnreports.Top
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()


    End Sub
End Class