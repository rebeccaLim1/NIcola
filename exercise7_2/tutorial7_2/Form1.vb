Public Class Form1
    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        userName()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        passWord()
    End Sub


    Sub userName()
        Dim Name As String
        Name = TextBox1.Text
        If Name = "Nic" Then
            MsgBox("your username is correct!")
        Else
            MsgBox("your username is wrong!")
        End If
    End Sub

    Sub passWord()
        Dim password As String

        password = TextBox2.Text

        If password = "Help" Then
            MsgBox("your password is correct!")

        Else : MsgBox("your password is wrong!")

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class






