<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Launcher
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.PbJuego = New System.Windows.Forms.ProgressBar()
        Me.btnEmpezar = New System.Windows.Forms.Button()
        Me.TimerPB = New System.Windows.Forms.Timer(Me.components)
        Me.MenuLauncher = New System.Windows.Forms.MenuStrip()
        Me.Idioma = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaIngles = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaEspanol = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ayuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.Porcentaje = New System.Windows.Forms.Label()
        Me.MenuLauncher.SuspendLayout()
        Me.SuspendLayout()
        '
        'PbJuego
        '
        resources.ApplyResources(Me.PbJuego, "PbJuego")
        Me.PbJuego.Name = "PbJuego"
        '
        'btnEmpezar
        '
        resources.ApplyResources(Me.btnEmpezar, "btnEmpezar")
        Me.btnEmpezar.Name = "btnEmpezar"
        Me.btnEmpezar.UseVisualStyleBackColor = True
        '
        'TimerPB
        '
        '
        'MenuLauncher
        '
        resources.ApplyResources(Me.MenuLauncher, "MenuLauncher")
        Me.MenuLauncher.BackColor = System.Drawing.Color.Transparent
        Me.MenuLauncher.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Idioma, Me.Ayuda})
        Me.MenuLauncher.Name = "MenuLauncher"
        '
        'Idioma
        '
        resources.ApplyResources(Me.Idioma, "Idioma")
        Me.Idioma.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdiomaIngles, Me.IdiomaEspanol})
        Me.Idioma.Name = "Idioma"
        '
        'IdiomaIngles
        '
        resources.ApplyResources(Me.IdiomaIngles, "IdiomaIngles")
        Me.IdiomaIngles.Name = "IdiomaIngles"
        '
        'IdiomaEspanol
        '
        resources.ApplyResources(Me.IdiomaEspanol, "IdiomaEspanol")
        Me.IdiomaEspanol.Name = "IdiomaEspanol"
        '
        'Ayuda
        '
        resources.ApplyResources(Me.Ayuda, "Ayuda")
        Me.Ayuda.Name = "Ayuda"
        '
        'Porcentaje
        '
        resources.ApplyResources(Me.Porcentaje, "Porcentaje")
        Me.Porcentaje.BackColor = System.Drawing.Color.Transparent
        Me.Porcentaje.Name = "Porcentaje"
        '
        'Launcher
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoDI.My.Resources.Imagenes.Logo_3_en_raya
        Me.Controls.Add(Me.Porcentaje)
        Me.Controls.Add(Me.btnEmpezar)
        Me.Controls.Add(Me.PbJuego)
        Me.Controls.Add(Me.MenuLauncher)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuLauncher
        Me.MaximizeBox = False
        Me.Name = "Launcher"
        Me.MenuLauncher.ResumeLayout(False)
        Me.MenuLauncher.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PbJuego As ProgressBar
    Friend WithEvents btnEmpezar As Button
    Friend WithEvents TimerPB As Timer
    Friend WithEvents MenuLauncher As MenuStrip
    Friend WithEvents Idioma As ToolStripMenuItem
    Friend WithEvents IdiomaIngles As ToolStripMenuItem
    Friend WithEvents IdiomaEspanol As ToolStripMenuItem
    Friend WithEvents Ayuda As ToolStripMenuItem
    Friend WithEvents Porcentaje As Label
End Class
