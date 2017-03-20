Public Class Juego
    Public ganadorjugador1 As String
    Public ganadorjugador2 As String
    Public jugcomienza As String = "x"
    Dim contadorx As Integer = 0
    Dim contador0 As Integer = 0
    Dim contadorempate As Integer = 0
    Public Function xoy(ByVal nav As String)
        If nav = "x" Then
            jugcomienza = "0"
            Return "x"
        Else
            jugcomienza = "x"
            Return "0"
        End If
    End Function
    Public Sub ganarX()
        If Button1.Text = "x" And Button2.Text = "x" And Button3.Text = "x" Then
            MsgBox("" + ganadorjugador1 + " gana el juego.", MsgBoxStyle.Information, "X wins. ")
            endofgame()
            jugcomienza = "0"
        ElseIf Button4.Text = "x" And Button5.Text = "x" And Button6.Text = "x" Then
            MsgBox("" + ganadorjugador1 + " gana el juego.", MsgBoxStyle.Information, "X wins. ")
            endofgame()
            jugcomienza = "0"
        ElseIf Button7.Text = "x" And Button8.Text = "x" And Button9.Text = "x" Then
            MsgBox("" + ganadorjugador1 + " gana el juego.", MsgBoxStyle.Information, "X wins. ")
            endofgame()
            jugcomienza = "0"
        ElseIf Button1.Text = "x" And Button4.Text = "x" And Button7.Text = "x" Then
            MsgBox("" + ganadorjugador1 + " gana el juego.", MsgBoxStyle.Information, "X wins. ")
            endofgame()
            jugcomienza = "0"
        ElseIf Button2.Text = "x" And Button5.Text = "x" And Button8.Text = "x" Then
            MsgBox("" + ganadorjugador1 + " gana el juego.", MsgBoxStyle.Information, "X wins. ")
            endofgame()
            jugcomienza = "0"
        ElseIf Button3.Text = "x" And Button6.Text = "x" And Button9.Text = "x" Then
            MsgBox("" + ganadorjugador1 + " gana el juego.", MsgBoxStyle.Information, "X wins. ")
            endofgame()
            jugcomienza = "0"
        ElseIf Button1.Text = "x" And Button5.Text = "x" And Button9.Text = "x" Then
            MsgBox("" + ganadorjugador1 + " gana el juego.", MsgBoxStyle.Information, "X wins. ")
            endofgame()
            jugcomienza = "0"
        ElseIf Button3.Text = "x" And Button5.Text = "x" And Button7.Text = "x" Then
            MsgBox("" + ganadorjugador1 + " gana el juego.", MsgBoxStyle.Information, "X wins. ")
            endofgame()
            jugcomienza = "0"
        End If
        ganar0()
    End Sub
    Public Sub ganar0()
        contadorempate += 1
        If Button1.Text = "0" And Button2.Text = "0" And Button3.Text = "0" Then
            MsgBox("" + ganadorjugador2 + " gana el juego.", MsgBoxStyle.Information, "0 wins. ")
            endofgame2()
            jugcomienza = "x"
        ElseIf Button4.Text = "0" And Button5.Text = "0" And Button6.Text = "0" Then
            MsgBox("" + ganadorjugador2 + " gana el juego.", MsgBoxStyle.Information, "0 wins. ")
            endofgame2()
            jugcomienza = "x"
        ElseIf Button7.Text = "0" And Button8.Text = "0" And Button9.Text = "0" Then
            MsgBox("" + ganadorjugador2 + " gana el juego.", MsgBoxStyle.Information, "0 wins. ")
            endofgame2()
            jugcomienza = "x"
        ElseIf Button1.Text = "0" And Button4.Text = "0" And Button7.Text = "0" Then
            MsgBox("" + ganadorjugador2 + " gana el juego.", MsgBoxStyle.Information, "0 wins. ")
            endofgame2()
            jugcomienza = "x"
        ElseIf Button2.Text = "0" And Button5.Text = "0" And Button8.Text = "0" Then
            MsgBox("" + ganadorjugador2 + " gana el juego.", MsgBoxStyle.Information, "0 wins. ")
            endofgame2()
            jugcomienza = "x"
        ElseIf Button3.Text = "0" And Button6.Text = "0" And Button7.Text = "0" Then
            MsgBox("" + ganadorjugador2 + " gana el juego.", MsgBoxStyle.Information, "0 wins. ")
            endofgame2()
            jugcomienza = "x"
        ElseIf Button1.Text = "0" And Button5.Text = "0" And Button9.Text = "0" Then
            MsgBox("" + ganadorjugador2 + " gana el juego.", MsgBoxStyle.Information, "0 wins. ")
            endofgame2()
            jugcomienza = "x"
        ElseIf Button3.Text = "0" And Button5.Text = "0" And Button7.Text = "0" Then
            MsgBox("" + ganadorjugador2 + " gana el juego.", MsgBoxStyle.Information, "0 wins. ")
            endofgame2()
            jugcomienza = "x"
        ElseIf contadorempate = 9 Then
            MsgBox("Empate", MsgBoxStyle.Information, "Empate")
            contadorempate = 0
        End If
    End Sub

    Public Sub endofgame()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        contadorx += 1
        contadorempate = 0
        Countx.Text = contadorx.ToString
    End Sub

    Public Sub endofgame2()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        contador0 += 1
        contadorempate = 0
        Count0.Text = contador0.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.lblJugadorComienza.Text = ""
        Button1.Text = xoy(jugcomienza)
        Button1.Enabled = False
        ganarX()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.lblJugadorComienza.Text = ""
        Button2.Text = xoy(jugcomienza)
        Button2.Enabled = False
        ganarX()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.lblJugadorComienza.Text = ""
        Button3.Text = xoy(jugcomienza)
        Button3.Enabled = False
        ganarX()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.lblJugadorComienza.Text = ""
        Button4.Text = xoy(jugcomienza)
        Button4.Enabled = False
        ganarX()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.lblJugadorComienza.Text = ""
        Button5.Text = xoy(jugcomienza)
        Button5.Enabled = False
        ganarX()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.lblJugadorComienza.Text = ""
        Button6.Text = xoy(jugcomienza)
        Button6.Enabled = False
        ganarX()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.lblJugadorComienza.Text = ""
        Button7.Text = xoy(jugcomienza)
        Button7.Enabled = False
        ganarX()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.lblJugadorComienza.Text = ""
        Button8.Text = xoy(jugcomienza)
        Button8.Enabled = False
        ganarX()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.lblJugadorComienza.Text = ""
        Button9.Text = xoy(jugcomienza)
        Button9.Enabled = False
        ganarX()
    End Sub

    Private Sub BtnNuevoJuego_Click(sender As Object, e As EventArgs) Handles BtnNuevoJuego.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        If jugcomienza = "x" Then
            Me.lblJugadorComienza.Text = "Comienza el jugador " + Me.lbljugador1.Text + ""
        Else
            Me.lblJugadorComienza.Text = "Comienza el jugador " + Me.lbljugador2.Text + ""
        End If

    End Sub


    Private Sub MenuItemComoSeJuega_Click(sender As Object, e As EventArgs) Handles MenuItemComoSeJuega.Click
        Try
            System.Diagnostics.Process.Start("https://ocio.uncomo.com/articulo/como-jugar-al-tres-en-raya-2442.html")
        Catch ex As Exception
        End Try
    End Sub

    '       --CONFIGURAR BOTON PARA ABRIR EL MENU DE AYUDA
    Private Sub Juego_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            MenuItemComoSeJuega_Click(Nothing, Nothing)
        End If
    End Sub

End Class