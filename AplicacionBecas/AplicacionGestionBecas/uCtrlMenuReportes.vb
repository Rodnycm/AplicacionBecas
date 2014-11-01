Public Class uCtrlMenuReportes

    Private Sub btnConsultarBitacoraAcciones_Click(sender As Object, e As EventArgs) Handles btnConsultarBitacoraAcciones.Click

        Dim uCtrlBitacoraAcciones As New uCtrlReporteAcciones()

        frmPrincipal.Controls.Add(uCtrlBitacoraAcciones)
        uCtrlBitacoraAcciones.Show()
        uCtrlBitacoraAcciones.BringToFront()
        uCtrlBitacoraAcciones.Location = New Point(300, 50)
        Me.Hide()

    End Sub
End Class
