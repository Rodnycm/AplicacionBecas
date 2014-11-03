Public Class uCtrlModificarCurso

    Dim ucBuscarCursos As uCtrlMantenimientoCursos
    Dim Id As Integer
    Dim nombre As String
    Dim codigo As String
    Dim cuatrimestre As String
    Dim creditos As Integer
    Dim precio As Double

    Public Sub recieveData(pnombre As String, pcodigo As String, pcuatrimestre As String, pcreditos As Integer, pprecio As Double, pid As Integer)


        txtNombreCurso.Text = pnombre
        txtCodigoCurso.Text = pcodigo
        cmbCuatrimestreCurso.Text = pcuatrimestre
        txtCreditosCurso.Text = pcreditos
        txtPrecioCurso.Text = pprecio
        txtId.Text = pid
        MsgBox(pid)

    End Sub


    Private Sub btnAceptarModificarCurso_Click(sender As Object, e As EventArgs) Handles btnAceptarModificarCurso.Click


        nombre = txtNombreCurso.Text
        codigo = txtCodigoCurso.Text
        cuatrimestre = cmbCuatrimestreCurso.Text
        creditos = txtCreditosCurso.Text
        precio = txtPrecioCurso.Text
        Id = txtId.Text
        MsgBox(Id)


        objGestorCurso.modificarCurso(nombre, codigo, cuatrimestre, creditos, precio, Id)
        objGestorCurso.guardarCambios()


        'ucBuscarCursos.listarCursos()
        'ucBuscarCursos.dtaListarCursos.Rows.Clear()

        Me.Hide()
        Me.Dispose()

    End Sub

    Private Sub btnCancelarAgregarCurso_Click(sender As Object, e As EventArgs) Handles btnCancelarAgregarCurso.Click
        ucBuscarCursos = New uCtrlMantenimientoCursos()
        Me.SendToBack()
        Me.Controls.Add(ucBuscarCursos)
        ucBuscarCursos.Show()


    End Sub
End Class
