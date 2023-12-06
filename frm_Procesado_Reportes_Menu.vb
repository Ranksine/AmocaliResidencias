Imports Microsoft.Reporting.Chart.WebForms
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class frm_Procesado_Reportes_Menu
    Private conex As MySqlConnection
    Private comando As MySqlCommand
    Private adapter As MySqlDataAdapter
    Private str As String

    Dim transicion As String
    Dim frmG As frm_Reportes_Procesado_General = CType(Owner, frm_Reportes_Procesado_General)
    Private Sub frm_Procesado_Reportes_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        transicion = "Entrada"
        Me.Left = Me.Left + 15
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

    Private Function btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        transicion = "Salida"
        TmTransiciones.Start()
        Return frmPrincipal
    End Function

    Private Sub cboSelectConsulta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectConsulta.SelectedIndexChanged
        If frm_Reportes_Procesado_General.Visible = True Then
            frm_Reportes_Procesado_General.Close()
        End If
        Dim frm As frmPrincipal = CType(Owner, frmPrincipal)
        frm.opendChildForm(frm_Reportes_Procesado_General)
        Select Case cboSelectConsulta.Text
            Case "General"
                str = "server=localhost;port=3306;uid=root;pwd='060599';database=apeajaldb;"
                Try
                    conex = New MySqlConnection(Str)
                    conex.ConnectionString = str
                    conex.Open()
                    comando = New MySqlCommand("ConsultaProcesadoGeneral", conex)
                    adapter = New MySqlDataAdapter(comando)
                    Dim data As New Data.DataSet
                    adapter.Fill(data)
                    data.DataSetName = "Apeajaldb"
                    Dim reporte1 As New ReportDataSource("Apeajaldb", data.Tables(0))
                    frm_Reportes_Procesado_General.rvReportesProcesado.LocalReport.DataSources.Clear()
                    frm_Reportes_Procesado_General.rvReportesProcesado.LocalReport.DataSources.Add(reporte1)
                    frm_Reportes_Procesado_General.rvReportesProcesado.LocalReport.ReportPath = "C:\Users\Omy\Desktop\Tec\ENE-JUN_2023\Proyectos\Amocali\Reporte_Procesado_General.rdlc"
                    frm_Reportes_Procesado_General.rvReportesProcesado.RefreshReport()
                    frm_Reportes_Procesado_General.Show()
                    conex.Close()

                Catch ex As Exception
                    MsgBox("Error en la generación del reporte General: " & ex.Message)
                End Try

            Case "Por Rango de Fechas"
                frm_Reportes_Procesado_Dialog_Rango.Show()
            Case "Por Material Específico"
                frm_Reportes_Procesado_Dialog_Material.Show()

            Case "Por Resposable de procesado"
                frm_Reportes_Procesado_Dialog_Resp.Show()

            Case "Por Fecha Específica"
                frm_Reportes_Procesado_Dialog_Fecha.Show()
            Case "Por Material más procesado"
                frm_Reportes_Procesado_Dialog_MaterialMasProcesadoRango.Show()
        End Select

        transicion = "Salida"
        TmTransiciones.Start()
    End Sub

End Class