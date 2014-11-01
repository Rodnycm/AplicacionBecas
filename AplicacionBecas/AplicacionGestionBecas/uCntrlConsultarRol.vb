Imports EntitiesLayer

Class uCntrlConsultarRol

    Dim nombre As String
    Dim idRol As String
    Dim listarRoles As uCtrlListarRol
    Dim listaPermisos As New List(Of Permiso)

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

    Public Sub getFrmBuscar(plistarRoles As uCtrlListarRol)

        listarRoles = plistarRoles
    End Sub

    Sub listarPermisos()

        listaPermisos = objGestorRol.consultarPermisosPorRol(idRol)

        ' CLBPermisos.BeginUpdate()
        For i As Integer = 0 To listaPermisos.Count - 1
            CLBPermisos.Items.Add(listaPermisos.Item(i).Nombre)

        Next
        ' CLBPermisos.EndUpdate()
    End Sub

    Public Sub recieveData(ByVal pnombre As String, ByVal pidRol As Integer)
        txtNombre.Text = pnombre
        idRol = pidRol
    End Sub

    '''<summary>Este metodo hace que apenas se abra el usuario de control se listen los permisos </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub uCntrlConsultarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarPermisos()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub
End Class
