﻿Public Class uCtrlRegistrarBeneficio

    Dim uCntrlBuscarBeneficio As uCntrlBuscarBeneficio

    ''' <summary>
    ''' Setea una instancia del UsrControlBuscarBeneficio
    ''' </summary>
    ''' <param name="puCntrlBuscarBeneficio">Es la instancia del usrControl</param>
    ''' <remarks></remarks>
    Public Sub getFrmBuscar(puCntrlBuscarBeneficio As uCntrlBuscarBeneficio)

        uCntrlBuscarBeneficio = puCntrlBuscarBeneficio
    End Sub

    ''' <summary>
    ''' Este método toma los valores ingresados en la pantalla y los envía al GestorBeneficios para crear un beneficio.
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="sender"></param>
    ''' <param name="e">Es el evento</param>

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        Dim nombre As String
        Dim porcentaje As Double
        Dim asociacion As String

        If (IsNumeric(txPorcentaje.Text) = True) Then

            nombre = txtNombre.Text
            porcentaje = CType(txPorcentaje.Text, Double)
            asociacion = txtAplicacion.Text

            objGestorBeneficio.agregarBeneficio(nombre, porcentaje, asociacion)
            objGestorBeneficio.guardarCambios()

            MsgBox("El Beneficio se creo correctamente")

        Else

            MsgBox("El Porcentaje debe ser un numero")

        End If

        uCntrlBuscarBeneficio.dtaBuscarBeneficio.Rows.Clear()
        uCntrlBuscarBeneficio.listarBeneficios()

        txtNombre.Clear()
        txPorcentaje.Clear()
        txtAplicacion.Clear()

    End Sub

    ''' <summary>
    ''' Este método esconde la pantalla, cuando el usuario selecciona el boton cancelar.
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        uCntrlBuscarBeneficio.dtaBuscarBeneficio.Rows.Clear()
        uCntrlBuscarBeneficio.listarBeneficios()
    End Sub
End Class
