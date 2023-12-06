﻿Imports System.Transactions
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class frm_Reportes_Procesado_Dialog_MaterialMasProcesadoRango
    Private conex As MySqlConnection
    Private comando As MySqlCommand
    Private adapter As MySqlDataAdapter
    Private cadenaConex As String

    Dim transicion As String
    Private Sub frm_Reportes_Procesado_Dialog_Rango_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        transicion = "Entrada"
        TmTransiciones.Start()
    End Sub

    Private Sub dtFechaIni_ValueChanged(sender As Object, e As EventArgs) Handles dtFechaIni.ValueChanged
        dtFechaFin.Enabled = True
    End Sub

    Private Sub TmTransiciones_Tick(sender As Object, e As EventArgs) Handles TmTransiciones.Tick
        If transicion.Equals("Entrada") Then
            If Me.Opacity = 1 Then
            Else
                Me.Opacity = Me.Opacity + 0.15
                Me.Top = Me.Top - 3
            End If
        ElseIf transicion.Equals("Salida") Then
            If Me.Opacity = 0 Then
                Me.Close()
            Else
                Me.Opacity = Me.Opacity - 0.15
                Me.Top = Me.Top + 3
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        transicion = "Salida"
        TmTransiciones.Start()
        frm_Reportes_Procesado_General.Dispose()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim fechaIni, FechaFin As String
        fechaIni = dtFechaIni.Value.Year & "/" & dtFechaIni.Value.Month & "/" & dtFechaIni.Value.Day
        FechaFin = dtFechaFin.Value.Year & "/" & dtFechaFin.Value.Month & "/" & dtFechaFin.Value.Day

        cadenaConex = "server=localhost;port=3306;uid=root;pwd='060599';database=apeajaldb;"
        Try
            conex = New MySqlConnection(cadenaConex)
            conex.ConnectionString = cadenaConex
            conex.Open()

            comando = New MySqlCommand("ConsultarProcesadoMaterialesMasProcesadosRango", conex)
            adapter = New MySqlDataAdapter(comando)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure
            adapter.SelectCommand.Parameters.Add("@FechaIni", MySqlDbType.Date).Value = fechaIni
            adapter.SelectCommand.Parameters.Add("@FechaFin", MySqlDbType.Date).Value = FechaFin

            Dim data As New Data.DataSet
            adapter.Fill(data)
            data.DataSetName = "Apeajaldb"
            Dim reporteMasMaterial As New ReportDataSource("Apeajaldb", data.Tables(0))
            reporteMasMaterial.Name = "Apeajaldb"
            reporteMasMaterial.Value = data.Tables(0)

            Dim reportParam1 As New ReportParameter("FechaIni", fechaIni)
            Dim reportParam2 As New ReportParameter("FechaFin", FechaFin)

            frm_Reportes_Procesado_General.rvReportesProcesado.LocalReport.DataSources.Clear()
            frm_Reportes_Procesado_General.rvReportesProcesado.LocalReport.DataSources.Add(reporteMasMaterial)
            frm_Reportes_Procesado_General.rvReportesProcesado.LocalReport.ReportPath = "C:\Users\Omy\Desktop\Tec\ENE-JUN_2023\Proyectos\Amocali\Reporte_Procesado_MaterialesMasProcesadosRango.rdlc"
            frm_Reportes_Procesado_General.rvReportesProcesado.LocalReport.SetParameters(New ReportParameter() {reportParam1, reportParam2})
            frm_Reportes_Procesado_General.rvReportesProcesado.RefreshReport()
            frm_Reportes_Procesado_General.Show()
            conex.Close()

        Catch ex As Exception
            MsgBox("Error en la generación del reporte de material con mayor procesamiento: " & ex.Message)
        End Try

        transicion = "Salida"
        TmTransiciones.Start()
    End Sub

End Class