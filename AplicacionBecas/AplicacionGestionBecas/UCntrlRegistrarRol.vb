
Public Class UCntrlRegistrarRol

    '''<summary>crea un nuevo Rol en el sistema </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim nombre As String = txtNombre.Text

        objGestorRol.agregarRol(nombre)
        objGestorRol.guardarCambios()
    End Sub

    '''<summary>Este metodo oculta el usuario de control de registrar Rol </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        MostrarMenuMant()
        Me.Dispose()

    End Sub

    '''<summary>Este metodo muestr el menu de mantenimiento </summary>
    '''<author>Rodny Castro Mathews </author> 
    Public Sub MostrarMenuMant()
        Dim ucMenuMant As New uCtrlMenuMantenimiento()
        ucMenuMant.Show()
    End Sub

End Class
