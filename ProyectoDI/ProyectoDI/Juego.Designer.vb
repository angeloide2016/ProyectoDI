<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Juego
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Juego))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.lbljugador1 = New System.Windows.Forms.Label()
        Me.lbljugador2 = New System.Windows.Forms.Label()
        Me.Countx = New System.Windows.Forms.Label()
        Me.Count0 = New System.Windows.Forms.Label()
        Me.BtnNuevoJuego = New System.Windows.Forms.Button()
        Me.lblJugadorComienza = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuItemComoSeJuega = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        resources.ApplyResources(Me.Button7, "Button7")
        Me.Button7.Name = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        resources.ApplyResources(Me.Button8, "Button8")
        Me.Button8.Name = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        resources.ApplyResources(Me.Button9, "Button9")
        Me.Button9.Name = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'lbljugador1
        '
        resources.ApplyResources(Me.lbljugador1, "lbljugador1")
        Me.lbljugador1.Name = "lbljugador1"
        '
        'lbljugador2
        '
        resources.ApplyResources(Me.lbljugador2, "lbljugador2")
        Me.lbljugador2.Name = "lbljugador2"
        '
        'Countx
        '
        resources.ApplyResources(Me.Countx, "Countx")
        Me.Countx.Name = "Countx"
        '
        'Count0
        '
        resources.ApplyResources(Me.Count0, "Count0")
        Me.Count0.Name = "Count0"
        '
        'BtnNuevoJuego
        '
        resources.ApplyResources(Me.BtnNuevoJuego, "BtnNuevoJuego")
        Me.BtnNuevoJuego.Name = "BtnNuevoJuego"
        Me.BtnNuevoJuego.UseVisualStyleBackColor = True
        '
        'lblJugadorComienza
        '
        resources.ApplyResources(Me.lblJugadorComienza, "lblJugadorComienza")
        Me.lblJugadorComienza.ForeColor = System.Drawing.Color.Red
        Me.lblJugadorComienza.Name = "lblJugadorComienza"
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemComoSeJuega})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'MenuItemComoSeJuega
        '
        resources.ApplyResources(Me.MenuItemComoSeJuega, "MenuItemComoSeJuega")
        Me.MenuItemComoSeJuega.Name = "MenuItemComoSeJuega"
        Me.MenuItemComoSeJuega.Tag = ""
        '
        'Juego
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblJugadorComienza)
        Me.Controls.Add(Me.BtnNuevoJuego)
        Me.Controls.Add(Me.Count0)
        Me.Controls.Add(Me.Countx)
        Me.Controls.Add(Me.lbljugador2)
        Me.Controls.Add(Me.lbljugador1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Juego"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents lbljugador1 As Label
    Friend WithEvents lbljugador2 As Label
    Friend WithEvents Countx As Label
    Friend WithEvents Count0 As Label
    Friend WithEvents BtnNuevoJuego As Button
    Friend WithEvents lblJugadorComienza As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuItemComoSeJuega As ToolStripMenuItem
End Class
