Imports EntitiesLayer

Class uCntrlConsultarRol

    '''<summary>Este metodo oculta la ventana de consultar rol </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Dispose()
    End Sub

    '''<summary>Este metodo enseña los valores del Rol </summary>
    '''<author>Rodny Castro Mathews </author> 
    '''<param name="pnombre"> Nombre del Rol a eliminar  </param> 
    Public Sub enseñarDatos(ByVal pnombre As String)
        txtNombre.Text = pnombre
    End Sub

    '''<summary>Este metodo lista los permisos del Rol </summary>
    '''<author>Rodny Castro Mathews </author> 
    Sub listarPermisos()

        Dim listaPermisos As New List(Of Permiso)
        listaPermisos = objGestorRol.consultarPermisos

        ' CLBPermisos.BeginUpdate()
        For i As Integer = 0 To listaPermisos.Count - 1
            CLBPermisos.Items.Add(listaPermisos.Item(i).Nombre)

        Next
        ' CLBPermisos.EndUpdate()
    End Sub

    '''<summary>Este metodo hace que apenas se abra el usuario de control se listen los permisos </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub uCntrlConsultarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarPermisos()
    End Sub
End Class
