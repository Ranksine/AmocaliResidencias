Imports System.Transactions
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class frm_Reportes_Procesado_Dialog_Material
    Private conex As MySqlConnection
    Private comando As MySqlCommand
    Private lector As MySqlDataReader
    Private adapter As MySqlDataAdapter
    Private cadenaConex As String
    Private Str As String
    Dim transicion As String
    Private Sub frm_Reportes_Procesado_Dialog_Resp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Str = "server=localhost;port=3306;uid=root;pwd='060599';database=apeajaldb;"
            conex = New MySqlConnection(Str)
            conex.ConnectionString = Str
            conex.Open()
            comando = conex.CreateCommand
        Catch ex As Exception
            MsgBox("Ha ocurrido un error en la carga de responsables: " & ex.Message)
        End Try
        transicion = "Entrada"
        TmTransiciones.Start()
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        transicion = "Salida"
        TmTransiciones.Start()
        frm_Reportes_Procesado_General.Dispose()
    End Sub
    Private nombre As String
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim fechaIni, fechaFin As String
        fechaIni = dtFechaIni.Value.Year & "/" & dtFechaIni.Value.Month & "/" & dtFechaIni.Value.Day
        fechaFin = dtFechaFin.Value.Year & "/" & dtFechaFin.Value.Month & "/" & dtFechaFin.Value.Day
        cadenaConex = "server=localhost;port=3306;uid=root;pwd='060599';database=apeajaldb;"
        Try
            conex = New MySqlConnection(cadenaConex)
            conex.ConnectionString = cadenaConex
            conex.Open()

            comando = New MySqlCommand("ConsultaProcesadoMaterialRango", conex)
            adapter = New MySqlDataAdapter(comando)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure

            adapter.SelectCommand.Parameters.Add("@Material", MySqlDbType.VarChar).Value = nombre
            adapter.SelectCommand.Parameters.Add("@FechaIni", MySqlDbType.Date).Value = fechaIni
            adapter.SelectCommand.Parameters.Add("@FechaFin", MySqlDbType.Date).Value = fechaFin

            Dim data As New Data.DataSet
            adapter.Fill(data)
            data.DataSetName = "Apeajaldb"
            Dim reporteMaterialRango As New ReportDataSource("Apeajaldb", data.Tables(0))
            reporteMaterialRango.Name = "Apeajaldb"
            reporteMaterialRango.Value = data.Tables(0)

            Dim reportParam1 As New ReportParameter("Material", nombre)
            Dim reportParam2 As New ReportParameter("Fecha1", fechaIni)
            Dim reportParam3 As New ReportParameter("Fecha2", fechaFin)

            frm_Reportes_Procesado_General.rvReportesProcesado.LocalReport.DataSources.Clear()
            frm_Reportes_Procesado_General.rvReportesProcesado.LocalReport.DataSources.Add(reporteMaterialRango)
            frm_Reportes_Procesado_General.rvReportesProcesado.LocalReport.ReportPath = "C:\Users\Omy\Desktop\Tec\ENE-JUN_2023\Proyectos\Amocali\Reporte_Procesado_MaterialPeriodo.rdlc"

            frm_Reportes_Procesado_General.rvReportesProcesado.LocalReport.SetParameters(New ReportParameter() {reportParam1, reportParam2, reportParam3})
            frm_Reportes_Procesado_General.rvReportesProcesado.RefreshReport()
            frm_Reportes_Procesado_General.Show()
            conex.Close()

        Catch ex As Exception
            MsgBox("Error en la generación del reporte de materiales: " & ex.Message)
            frm_Reportes_Procesado_General.Close()
        End Try

        transicion = "Salida"
        TmTransiciones.Start()
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        transicion = "Salida"
        TmTransiciones.Start()
    End Sub

    Private Sub cboResponsable_SelectedIndexChanged(sender As Object, e As EventArgs)
        btnSiguiente.Enabled = True
    End Sub

    Private Sub cboMateriales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMateriales.SelectedIndexChanged
        Select Case (cboMateriales.Text)
            Case "Polietileno de Alta Densidad"
                nombre = "PEAD"
            Case "Polietileno"
                nombre = "PET"
            Case "Polipropileno"
                nombre = "PP"
            Case "Flexible"
                nombre = "FLEXIBLE"
            Case "Cartón"
                nombre = "CARTON"
            Case "Metal"
                nombre = "METAL"
            Case "Placas de Fosfuro de Magnesio"
                nombre = "PFM"
            Case "Revuelto"
                nombre = "REVUELTO"
            Case = "Otro"
                nombre = "OTRO"
        End Select

        PnFechas.Visible = True
        lblF1.Visible = True
        lblF2.Visible = True
        dtFechaIni.Enabled = True
    End Sub

    Private Sub dtFechaIni_ValueChanged(sender As Object, e As EventArgs) Handles dtFechaIni.ValueChanged
        dtFechaFin.Enabled = True
    End Sub

    Private Sub dtFechaFin_ValueChanged(sender As Object, e As EventArgs) Handles dtFechaFin.ValueChanged
        btnSiguiente.Enabled = True
    End Sub
End Class