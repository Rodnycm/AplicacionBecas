Imports EntitiesLayer
Public Class FrmIniciarSesion

    Public Property principal As frmPrincipal = New frmPrincipal()
    Dim UcntrlIniciar As UcntrlIniciar = New UcntrlIniciar()
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        'Me.InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub FrmIniciarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Controls.Add(UcntrlIniciar)
        UcntrlIniciar.Location = New Point(135, 125)
        UcntrlIniciar.BringToFront()
        UcntrlIniciar.Show()
    End Sub

End Class