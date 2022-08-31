Imports System.Data.SqlClient

Public Class frmInventario

    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = SOPORTE; User Id= mg; Password=Cordial.passs")
    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles Me.Load


        listaInventario()

    End Sub

    Private Sub listaInventario()

        Dim mitabla As New DataTable
        Dim DA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "dbo.pa_ListaInventario"


            cmd.CommandText = sql
            cmd.Connection = cnn
            DA = New SqlDataAdapter(cmd)
            DA.Fill(mitabla)


            dtgInventario.DataSource = mitabla

        Catch ex As Exception
            MsgBox("Error Listar Inventario" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class