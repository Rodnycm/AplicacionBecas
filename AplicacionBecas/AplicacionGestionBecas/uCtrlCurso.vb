Imports BLL
Imports EntitiesLayer

Public Class uCtrlCurso

    Dim ucBuscarCursos As New uCtrlMantenimientoCursos

    Private Sub btnAgregarCurso_Click(sender As Object, e As EventArgs) Handles btnAgregarCurso.Click

        Dim nombre As String = txtNombreCurso.Text
        Dim codigo As String = txtCodigoCurso.Text
        Dim cuatrimestre As String = cmbCuatrimestreCurso.Text
        Dim creditos As String = txtCreditosCurso.Text
        Dim precio As String = txtPrecioCurso.Text

        Try
            objGestorCurso.agregarCurso(nombre, codigo, cuatrimestre, creditos, precio)
            objGestorCurso.guardarCambios()

        Catch ex As Exception
            MsgBox(ex)
        End Try

        refrescarPantalla()
        ucBuscarCursos.dtaListarCursos.ClearSelection()

    End Sub

    Public Sub refrescarPantalla()

        Me.Hide()
        ucBuscarCursos.Refresh()
        ucBuscarCursos.dtaListarCursos.Rows.Clear()
        ucBuscarCursos.listarCursos()


    End Sub

    Private Sub btnCancelarAgregarCurso_Click(sender As Object, e As EventArgs) Handles btnCancelarAgregarCurso.Click
        Me.Hide()
    End Sub
End Class
