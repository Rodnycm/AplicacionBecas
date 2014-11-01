
Imports EntitiesLayer
Imports BLL

Public Class uCtrlEliminarRol

    Dim nombre As String
    Dim IdROl As Integer

    '''<summary> Este Metodo esconde el usuario de control de eliminar Rol</summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    '''<summary>REcibe el dato del rol a eliminar </summary>
    '''<author>Rodny Castro Mathews </author> 
    '''<param name="pnombre"> Nombre del Rol a eliminar  </param> 
    Public Sub recieveData(ByVal pnombre As String, ByVal pid As Integer)
        nombre = pnombre
        IdROl = pid
    End Sub

    '''<summary>Elimina El rol seleccionado </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        objGestorRol.eliminarRol(nombre, IdROl)
        objGestorRol.guardarCambios()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub
End Class
