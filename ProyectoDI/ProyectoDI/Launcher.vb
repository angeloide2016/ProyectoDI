Imports System.Globalization
Imports System.Threading

Public Class Launcher
    '       --IDIOMA PRINCIPAL--        '
    Dim resource As String

    Public Sub New()
        MyBase.New()
        Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("es-ES")
        InitializeComponent()
    End Sub




    '       --CONFIGURAR EL LOAD--      '
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerPB.Start()
    End Sub



    '       --CONFIGURAR EL TIMEPICK DE LA BARRA DE PROGRESO--      '
    Private Sub TimerPB_Tick(sender As Object, e As EventArgs) Handles TimerPB.Tick
        PbJuego.Increment(3)
        If PbJuego.Value = 100 Then
            TimerPB.Stop()
            btnEmpezar.Enabled = True
        End If
        Porcentaje.Text = PbJuego.Value & (" % ")
    End Sub

    '       --MENSAJE DE DIÁLOGO--      '
    Private Sub btnEmpezar_Click(sender As Object, e As EventArgs) Handles btnEmpezar.Click
        Dim Flogin As New Login
        Dim juego As New Juego


        If resource = "en-EN" Then
            Flogin.BtnAceptar.Text = "Accept"
            Flogin.BtnCancelar.Text = "Cancel"
            Flogin.LoginJugadores1.setlbljugador1("Player 1:")
            Flogin.LoginJugadores1.setlbljugador2("Player 2:")
        End If
        Flogin.ShowDialog()


        If Flogin.DialogResult = DialogResult.OK Then
            juego.lbljugador1.Text = Flogin.LoginJugadores1.getjugador1 + " (X) :"
            juego.lbljugador2.Text = Flogin.LoginJugadores1.getjugador2 + " (0) :"
            juego.ganadorjugador1 = Flogin.LoginJugadores1.getjugador1
            juego.ganadorjugador2 = Flogin.LoginJugadores1.getjugador2

            If resource = "en-EN" Then
                juego.Text = "Tic Tac Toe"
                juego.BtnNuevoJuego.Text = "New Game"
                juego.MenuItemComoSeJuega.Text = " How to play?"
                If juego.jugcomienza = "x" Then
                    juego.lblJugadorComienza.Text = "Start the player " + juego.lbljugador1.Text
                Else
                    juego.lblJugadorComienza.Text = "Start the player " + juego.lbljugador2.Text
                End If
            Else
                juego.Text = "3 En Raya"
                juego.BtnNuevoJuego.Text = "Nueva Partida"
                If juego.jugcomienza = "x" Then
                    juego.lblJugadorComienza.Text = "Comienza el jugador " + juego.lbljugador1.Text

                Else
                    juego.lblJugadorComienza.Text = "Comienza el jugador " + juego.lbljugador2.Text
                End If
            End If
            juego.Show()

            Me.Close()
        End If
    End Sub



    '       --CAMBIAR IDIOMA--      '

    Private Sub idioma_Click(sender As Object, e As EventArgs) Handles IdiomaEspanol.Click, IdiomaIngles.Click
        If sender.Equals(IdiomaEspanol) Then
            resource = "es-ES"
        Else
            resource = "en-EN"
        End If

        traducirInterfaz(resource)
    End Sub

    Private Sub traducirInterfaz(resource As String)
        Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo(resource)
        My.Settings.Save()
        Me.Controls.Clear()
        InitializeComponent()
        '       --INICIAMOS DE NUEVO LA PROGRESSBARD--      '
        TimerPB.Start()
        PbJuego.Increment(1)
        If PbJuego.Value = 100 Then
            TimerPB.Stop()
            btnEmpezar.Enabled = True
        End If
        Porcentaje.Text = PbJuego.Value & (" % ")

    End Sub

End Class
