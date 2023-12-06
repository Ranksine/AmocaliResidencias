Public Class frm_Procesado_Consultas_Menu
    Dim transicion As String
    Private Sub frm_Procesado_Consultas_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim frm As frmPrincipal = CType(Owner, frmPrincipal)
        Select Case cboSelectConsulta.Text
            Case "Consulta General"
                frm.opendChildForm(frm_Procesado_Consultas_General)
            Case "Consulta por Rango de Fechas"
                frm.opendChildForm(frm_Procesado_Consultas_Rango)
            Case "Consulta por Fecha Específica"
                frm.opendChildForm(frm_Procesado_Consultas_Fecha)
            Case "Consulta por Responsable"
                frm.opendChildForm(frm_Procesado_Consultas_Responsable)
        End Select
        transicion = "Salida"
        TmTransiciones.Start()
    End Sub
End Class