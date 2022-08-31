Imports System.Data.SqlClient

Public Class frmSolicitudes
    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = SOPORTE; User Id= cp; Password=Cordial.passs")
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        listaSolicitudes(dtpFecha.Value)

    End Sub

    Private Sub listaSolicitudes(ByVal fecha As Date)

        Dim mitabla As New DataTable
        Dim DA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "dbo.pa_ListaBitacora"
            cmd.Parameters.Add("@fecha", SqlDbType.Date)


            cmd.Parameters("@fecha").Value = fecha

            cmd.CommandText = sql
            cmd.Connection = cnn
            DA = New SqlDataAdapter(cmd)
            DA.Fill(mitabla)

            If mitabla.Rows.Count <= 0 Then
                MsgBox("No existen registros para la fecha", vbInformation, "")
            End If

            dtgListadoBitacora.DataSource = mitabla



        Catch ex As Exception
            MsgBox("Error Listar Inventario" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class