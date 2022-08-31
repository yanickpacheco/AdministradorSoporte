Public Class frmMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresarSolicitud.Click
        frmIngresoSolicitud.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnVerSolicitudes.Click
        frmSolicitudes.ShowDialog()

    End Sub

    Private Sub btnConsultarInventario_Click(sender As Object, e As EventArgs) Handles btnConsultarInventario.Click
        frmInventario.ShowDialog()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
