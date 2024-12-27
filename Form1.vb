Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography.Xml

Public Class Form1
    Dim A As String = ""
    Dim B As String = ""
    Dim op As String = ""

    Private Sub Btn_0_Click(sender As Object, e As EventArgs) Handles Btn_0.Click
        If op = "" Then
            A = A + "0"
        Else
            B = B + "0"
        End If
    End Sub

    Private Sub Btn_1_Click(sender As Object, e As EventArgs) Handles Btn_1.Click
        If op = "" Then
            A = A + "1"
        Else
            B = B + "1"
        End If
    End Sub

    Private Sub Btn_2_Click(sender As Object, e As EventArgs) Handles Btn_2.Click
        If op = "" Then
            A = A + "2"
        Else
            B = B + "2"
        End If
    End Sub

    Private Sub Btn_3_Click(sender As Object, e As EventArgs) Handles Btn_3.Click
        If op = "" Then
            A = A + "3"
        Else
            B = B + "3"
        End If

    End Sub

    Private Sub Btn_4_Click(sender As Object, e As EventArgs) Handles Btn_4.Click
        If op = "" Then
            A = A + "4"
        Else
            B = B + "4"
        End If
    End Sub

    Private Sub Btn_5_Click(sender As Object, e As EventArgs) Handles Btn_5.Click
        If op = "" Then
            A = A + "5"
        Else
            B = B + "5"
        End If
    End Sub

    Private Sub Btn_6_Click(sender As Object, e As EventArgs) Handles Btn_6.Click
        If op = "" Then
            A = A + "6"
        Else
            B = B + "6"
        End If
    End Sub

    Private Sub Btn_7_Click(sender As Object, e As EventArgs) Handles Btn_7.Click
        If op = "" Then
            A = A + "7"
        Else
            B = B + "7"
        End If
    End Sub

    Private Sub Btn_8_Click(sender As Object, e As EventArgs) Handles Btn_8.Click
        If op = "" Then
            A = A + "8"
        Else
            B = B + "8"
        End If
    End Sub

    Private Sub Btn_9_Click(sender As Object, e As EventArgs) Handles Btn_9.Click
        If op = "" Then
            A = A + "9"
        Else
            B = B + "9"
        End If
    End Sub

    Private Sub Btn_plus_Click(sender As Object, e As EventArgs) Handles Btn_plus.Click
        If Not A = "" Then
            op = "+"
        End If
    End Sub

    Private Sub Btn_minus_Click(sender As Object, e As EventArgs) Handles Btn_minus.Click
        If Not A = "" Then
            op = "-"
        End If
    End Sub

    Private Sub Btn_mult_Click(sender As Object, e As EventArgs) Handles Btn_mult.Click
        If Not A = "" Then
            op = "*"
        End If
    End Sub

    Private Sub Btn_div_Click(sender As Object, e As EventArgs) Handles Btn_div.Click
        If Not A = "" Then
            op = "/"
        End If
    End Sub

    Private Sub Btn_equal_Click(sender As Object, e As EventArgs) Handles Btn_equal.Click
        Dim test As Boolean = True
        Dim res As Double
        Dim val, value2 As Double
        If IsNumeric(A) And IsNumeric(B) And Not op = "" Then
            val = Integer.Parse(A)
            value2 = Integer.Parse(B)
            If op = "+" Then
                res = val + value2
            ElseIf op = "-" Then
                res = val - value2
            ElseIf op = "*" Then
                res = val * value2
            ElseIf op = "/" And Not op = "" Then
                res = val / value2
            Else
                MessageBox.Show("division par 0")
                test = False
            End If
        Else
            MessageBox.Show(" A et B doivent etre des entier ")
            test = False
        End If
        If test Then
            txt_afficher.Text = txt_afficher.Text + "=" + res.ToString
        End If
    End Sub
End Class
