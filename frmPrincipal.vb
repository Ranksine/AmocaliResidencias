Public Class frmPrincipal

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()
    End Sub

    Private Sub hideSubMenu()
        PanelSubMnuCategorias.Visible = False
        PanelSubMnuMovimientos.Visible = False
        PanelSubMnuReportes.Visible = False
        PanelSubMnuPerfil.Visible = False
        PnSubMnu2_Procesado.Visible = False

    End Sub

    Private Sub showSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btnCategorias_Click(sender As Object, e As EventArgs) Handles btnCategorias.Click
        hideSubMenu()
        showSubMenu(PanelSubMnuCategorias)
    End Sub

    Private Sub btnMovimientos_Click(sender As Object, e As EventArgs) Handles btnMovimientos.Click
        hideSubMenu()
        showSubMenu(PanelSubMnuMovimientos)
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        hideSubMenu()
        showSubMenu(PanelSubMnuReportes)
    End Sub

    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) 
        hideSubMenu()
        showSubMenu(PanelSubMnuPerfil)
    End Sub

    '---------------------------------------SUB MENÚS-------------------------------'
    Private Sub btnCatEmpleados_Click(sender As Object, e As EventArgs) Handles btnCatEmpleados.Click
        hideSubMenu()
        opendChildForm(New frmProcesado)
    End Sub

    Private Sub btnCatEmpresas_Click(sender As Object, e As EventArgs) Handles btnCatEmpresas.Click
        hideSubMenu()
    End Sub

    Private Sub btnCatCAT_Click(sender As Object, e As EventArgs) Handles btnCatCAT.Click
        hideSubMenu()
    End Sub

    Private Sub btnCatResponsables_Click(sender As Object, e As EventArgs) Handles btnCatResponsables.Click
        hideSubMenu()
    End Sub

    Private Sub btnMovIngreso_Click(sender As Object, e As EventArgs) Handles btnMovIngreso.Click
        opendChildForm(New Recepcion)
        hideSubMenu()
    End Sub

    Private Sub btnMovClasificacion_Click(sender As Object, e As EventArgs) Handles btnMovClasificacion.Click
        hideSubMenu()
    End Sub

    Private Sub btnMovProcesado_Click(sender As Object, e As EventArgs) Handles btnMovProcesado.Click
        showSubMenu(PnSubMnu2_Procesado)
    End Sub
    Private Sub btnMovProcesado_Registro_Click(sender As Object, e As EventArgs) Handles btnMovProcesado_Registro.Click
        opendChildForm(New frmProcesado)
        hideSubMenu()
    End Sub

    Private Sub btnMovProcesado_Consultas_Click(sender As Object, e As EventArgs) Handles btnMovProcesado_Consultas.Click
        Dim frmConsMenu As New frm_Procesado_Consultas_Menu
        AddOwnedForm(frmConsMenu)
        frmConsMenu.ShowDialog()
        hideSubMenu()

    End Sub

    Private Sub btnMovSalida_Click(sender As Object, e As EventArgs) Handles btnMovSalida.Click
        opendChildForm(New frmSalidas)
        hideSubMenu()
    End Sub

    Private Sub btnRepCategorias_Click(sender As Object, e As EventArgs) Handles btnRepCategorias.Click
        hideSubMenu()
    End Sub

    Private Sub btnRepMovimientos_Click(sender As Object, e As EventArgs) Handles btnRepMovimientos.Click

        showSubMenu(PnSubMnu2_ReportesMovimientos)
    End Sub

    Private Sub btnRepCAT_Click(sender As Object, e As EventArgs) Handles btnRepCAT.Click
        hideSubMenu()
    End Sub

    Private Sub btnRep_Ingreso_Click(sender As Object, e As EventArgs) Handles btnRep_Ingreso.Click
        hideSubMenu()
    End Sub

    Private Sub btnRep_Procesado_Click(sender As Object, e As EventArgs) Handles btnRep_Procesado.Click
        Dim frmRepMenu As New frm_Procesado_Reportes_Menu
        AddOwnedForm(frmRepMenu)
        frmRepMenu.ShowDialog()
        hideSubMenu()

    End Sub

    Private Sub btnAcercaDe_Click(sender As Object, e As EventArgs) 
        hideSubMenu()
    End Sub

    Private Sub btnVerPerfil_Click(sender As Object, e As EventArgs) Handles btnVerPerfil.Click
        hideSubMenu()
    End Sub

    Private Sub btnSesion_Click(sender As Object, e As EventArgs) Handles btnSesion.Click
        hideSubMenu()
    End Sub

    Private frmActual As Form = Nothing

    Public Sub opendChildForm(frmHijo As Form)
        If frmActual IsNot Nothing Then frmActual.Close()
        frmActual = frmHijo
        frmHijo.TopLevel = False
        frmHijo.FormBorderStyle = FormBorderStyle.None
        frmHijo.Dock = DockStyle.Fill
        PanelFrmHijo.Controls.Add(frmHijo)
        PanelFrmHijo.Tag = frmHijo
        frmHijo.BringToFront()
        frmHijo.Show()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub cmdMeenu_Click(sender As Object, e As EventArgs) Handles cmdMeenu.Click
        PanelMnuLateral.Visible = False
        panelMenuCerrado.Visible = True
    End Sub

    Private Sub cmdMeenu2_Click(sender As Object, e As EventArgs) Handles cmdMeenu2.Click
        PanelMnuLateral.Visible = True
        panelMenuCerrado.Visible = False
    End Sub

    Private Sub btnSalir2_Click(sender As Object, e As EventArgs) Handles btnSalir2.Click
        Me.Close()
    End Sub

End Class
