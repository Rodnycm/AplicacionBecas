Imports EntitiesLayer

Public Class uCtrlListarRol

    Public Property uCtrlRol As UCntrlRegistrarRol = New UCntrlRegistrarRol()


    '''<summary> Este metodo lista los roles</summary>
    '''<author>Rodny Castro Mathews </author> 
    Sub ListarRoles()

        Dim listaRoles As New List(Of Rol)
        listaRoles = objGestorRol.consultarRoles()

        For i As Integer = 0 To listaRoles.Count - 1

            DGVRol.Rows.Add(1)
            DGVRol.Rows(i).Cells(0).Value = listaRoles.Item(i).Nombre()

        Next
    End Sub
    '''<summary>Este metodo hace que apenas se abra el usuario de control le liste los roles </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub ListarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarRoles()
    End Sub

    '''<summary>Metodo  modifica el rol seleccionado</summary>
    '''<author>Rodny Castro Mathews </author>
    ''' '''<param name="numfila"> numero de fila en el que se encuentra el rol a modificar  </param>  
    Private Sub modificarRol(numfila As Integer)

        Dim value1 As Object = DGVRol.Rows(numfila).Cells(0).Value

        Dim uCtrlModRol As New uCtrlModificarRol()
        uCtrlModRol.recieveData(value1)
        uCtrlModRol.txtNombre.Text = CType(value1, String)
        frmPrincipal.Controls.Add(uCtrlModRol)
        uCtrlModRol.Show()
        uCtrlModRol.BringToFront()
        uCtrlModRol.Location = New Point(250, 170)

    End Sub

    '''<summary>Este metodo elimina el rol seleccionado </summary>
    '''<author>Rodny Castro Mathews </author> 
    '''<param name="numfila"> Numero de fila del rol a eliminar  </param> 
    Private Sub eliminarRol(numfila As Integer)

        Dim value1 As Object = DGVRol.Rows(numfila).Cells(0).Value

        Dim uCtrlEliRol As New uCtrlEliminarRol()
        uCtrlEliRol.recieveData(value1)
        frmPrincipal.Controls.Add(uCtrlEliRol)
        uCtrlEliRol.Show()
        uCtrlEliRol.Location = New Point(250, 170)
        uCtrlEliRol.BringToFront()

    End Sub

    '''<summary>Este metodo consulta el rol seleccionado </summary>
    '''<author>Rodny Castro Mathews </author> 
    '''<param name="numfila"> Numero de fila de rol a consultar  </param> 
    Private Sub consultarRol(numfila As Integer)

        Dim value1 As String = DGVRol.Rows(numfila).Cells(0).Value
        DGVRol.Rows.Clear()
        Dim uCtrlConsulRol As New uCntrlConsultarRol()
        uCtrlConsulRol.enseñarDatos(value1)
        uCtrlConsulRol.txtNombre.Text = value1
        frmPrincipal.Controls.Add(uCtrlConsulRol)
        uCtrlConsulRol.Show()
        uCtrlConsulRol.BringToFront()
        uCtrlConsulRol.Location = New Point(250, 170)
    End Sub

    '''<summary> </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub DGVRol_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGVRol.EditingControlShowing
        ' Only for a DatagridComboBoxColumn at ColumnIndex 1.
        If DGVRol.CurrentCell.ColumnIndex = 1 Then
            Dim combo As ComboBox = CType(e.Control, ComboBox)
            If (combo IsNot Nothing) Then
                ' Remove an existing event-handler, if present, to avoid 
                ' adding multiple handlers when the editing control is reused.
                RemoveHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)

                ' Add the event handler. 
                AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
            End If
        End If
    End Sub

    '''<summary> Este metodo indica si hay que eliminar,ver,modificar dependiendo de lo que escoja </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim combo As ComboBox = CType(sender, ComboBox)
        Dim fila As Integer = DGVRol.CurrentCell.RowIndex
        If combo.SelectedItem = "Editar" Then
            MsgBox(fila)
            modificarRol(fila)

        ElseIf combo.SelectedItem = "Eliminar" Then
            MsgBox(fila)
            eliminarRol(fila)

        ElseIf combo.SelectedItem = "Ver" Then
            MsgBox(fila)
            consultarRol(fila)


        End If

    End Sub

    '''<summary>este metodo lista el rol a buscar </summary>
    '''<author>Rodny Castro Mathews </author> 
    Sub ListarRol()

        Dim Rol As New Rol
        Rol = objGestorRol.consultarRolPorNombre(txtBuscarRol.Text)
        DGVRol.Rows.Clear()
        DGVRol.Rows.Add(1)
        DGVRol.Rows(0).Cells(0).Value = Rol.Nombre()
    End Sub

    '''<summary>Este metodo llama al usuario de control de crear rol </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub btnCrearRoles_Click(sender As Object, e As EventArgs) Handles btnCrearRoles.Click
        uCtrlRol = New UCntrlRegistrarRol()
        frmPrincipal.Controls.Add(uCtrlRol)
        uCtrlRol.BringToFront()
        uCtrlRol.Show()
        uCtrlRol.Location = New Point(250, 170)
    End Sub

    '''<summary>Este boton Busca el rol digitado </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub btnBuscarRol_Click(sender As Object, e As EventArgs) Handles btnBuscarRol.Click
        If txtBuscarRol.Text = Nothing Then
            DGVRol.Rows.Clear()
            ListarRoles()
        Else
            DGVRol.Rows.Clear()
            ListarRol()

        End If

    End Sub

End Class
