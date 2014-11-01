
Imports EntitiesLayer
Public Class FrmIniciarSesion

    Public Property principal As frmPrincipal = New frmPrincipal()


    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim nombreUsuario As String = txtNombreUsuario.Text
        Dim contraseña As String = txtContraseña.Text
        Dim listaUsuarios As List(Of Usuario)

        listaUsuarios = objGestorUsuario.iniciarSesion(nombreUsuario, contraseña)
        If listaUsuarios.Count > 0 Then
            Me.Hide()
            Globals.userName = listaUsuarios(0).primerNombre
            principal.Show()
        Else
            MsgBox("Nombre de usuario o contraseña incorrectos")
        End If
    End Sub

End Class