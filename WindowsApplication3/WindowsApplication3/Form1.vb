Imports System.Data.SqlClient

Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim name As String
        Dim pass As String

        name = TextBox1.Text
        pass = TextBox2.Text

        Dim mysqlconn = New 



    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.Database1DataSet1.login)

    End Sub
End Class
