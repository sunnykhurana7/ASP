Imports System.Data.SqlClient

0

Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New SqlConnection("Data Source=|DataDirectory|\Database1.sdf")
        Dim cmd As SqlCommand = New SqlCommand

        'Dim rd As SqlDataReader


        

        cmd.Connection = con


        Try
            con.Open()


            cmd.CommandText = "Select * from login where username = 'sunny' And password= 'khurana' "
            Dim a As Integer

            a = cmd.ExecuteNonQuery

            MessageBox.Show(a)





            'MessageBox.Show(a)






            '    If rd.HasRows Then
            '        Me.Hide()
            '        Reservation.Show()
            '        Reservation.Label1.Text = i

            '    Else
            '        MessageBox.Show("Wrong User Id or Password is Enter", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand)
            '        If DialogResult.Abort Then
            '            uid.Clear()
            '            pass.Clear()
            '            uid.Focus()
            '        Else
            '            Me.Close()
            '        End If
            '    End If
        Catch ex As Exception

        End Try



    End Sub
End Class
