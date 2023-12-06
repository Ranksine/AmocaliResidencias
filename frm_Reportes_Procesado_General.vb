Imports MySql.Data.MySqlClient

Public Class frm_Reportes_Procesado_General
    Private Sub Ffrm_Reportes_Procesado_General_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rvReportesProcesado.Clear()
        Me.rvReportesProcesado.RefreshReport()

    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub
End Class
