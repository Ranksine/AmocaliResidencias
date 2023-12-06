Imports MySql.Data.MySqlClient

Public Class frmProcesado

    Dim conex As MySqlConnection
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Dim adapter As MySqlDataAdapter
    ''' <summary>
    ''' Establece colores de fondo de cada apartado del control TabControl1.
    ''' Crea la conexión a la base de datos Apeajaldb.
    ''' Realiza cuatro consultas:
    ''' -Obtiene el número actual de registro de procesado.
    ''' -Obtiene los datos del CAT loggeado.
    ''' -Obtiene el nombre del responsable del CAT.
    ''' -Obtiene los nombre de los responsables para comenzar el procesado.
    ''' </summary>
    Private Sub frmPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '---Añadir colores a paneles (la transparecia solo se apreciará con un fondo que no sea solido)---'
        TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        PnResumenTotales.BackColor = Color.FromArgb(120, 0, 60, 0)
        pnCabeceraGral.BackColor = Color.FromArgb(130, 10, 10, 10)
        Panel9.BackColor = Color.FromArgb(150, 255, 255, 255)
        Panel8.BackColor = Color.FromArgb(150, 255, 255, 255)
        PnResPEAD.BackColor = Color.FromArgb(70, 255, 255, 255)
        PnResPET.BackColor = Color.FromArgb(70, 255, 255, 255)
        PnResPP.BackColor = Color.FromArgb(70, 255, 255, 255)
        PnResFLEX.BackColor = Color.FromArgb(70, 255, 255, 255)
        PnResCART.BackColor = Color.FromArgb(70, 255, 255, 255)
        PnResMET.BackColor = Color.FromArgb(70, 255, 255, 255)
        PnResPFM.BackColor = Color.FromArgb(70, 255, 255, 255)
        PnResREV.BackColor = Color.FromArgb(70, 255, 255, 255)
        PnResOTRO.BackColor = Color.FromArgb(70, 255, 255, 255)
        PnResTOTAL.BackColor = Color.FromArgb(200, 200, 100, 0)

        Dim str As String
        str = "server=localhost;port=3306;uid=root;pwd='060599';database=apeajaldb;"
        conex = New MySqlConnection(str)

        Try
            conex.Open()
            comando = conex.CreateCommand

            '---Numero de Procesado---'
            comando.CommandText = "SELECT COUNT(*) FROM procesado"
            lector = comando.ExecuteReader
            lector.Read()
            txtIdProcesado.Text = lector(0) + 1
            lector.Close()

            '---Mostrar datos CAT---'
            Dim idRespCAT As Integer
            comando.CommandText = "SELECT IdCAT, IdResponsableCat, NombreCentro FROM centroacopiotemporal"
            lector = comando.ExecuteReader
            lector.Read()
            txtIdCAT.Text = lector(0)
            idRespCAT = lector(1)
            txtNombreCAT.Text = lector(2)
            lector.Close()
            '---Mostrar el nombre del responsable del cat---'
            comando.CommandText = "SELECT Nombre FROM responsablecat WHERE IdCAT=" & idRespCAT
            lector = comando.ExecuteReader
            lector.Read()
            txtResponsableCAT.Text = lector(0)
            lector.Close()

            '---Llenar combo de responsable de procesado---'
            comando.CommandText = "SELECT * FROM usuarios"
            lector = comando.ExecuteReader
            While lector.Read
                cboResponsableProcesado.Items.Add(lector(0))
            End While
            lector.Close()
        Catch ex As Exception
            conex.Close()
        End Try
        MsgBox("Selecciona un responsable para iniciar", vbOKOnly, "Procesado de Material")
    End Sub

    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
        Dim g = e.Graphics
        Dim tp = TabControl1.TabPages(e.Index)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center

        'Crear el rectangulo que se dibujara en el titulo del tab
        Dim headerRect As New RectangleF(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2)

        'Establecer el color por defecto del tab no selecionado'
        Dim sb As New SolidBrush(Color.Black)
        g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.Black), headerRect, sf)
        'Establecer color del borde'
        Dim p = New Pen(Color.FromArgb(20, 60, 50), 8)
        g.DrawRectangle(p, tp.Bounds)
        Select Case tp.Text
            Case "P.E.A.D."
                sb.Color = Color.FromArgb(10, 10, 200)
                g.FillRectangle(sb, e.Bounds)
                g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.White), headerRect, sf)
                If TabControl1.SelectedIndex = e.Index Then
                    'Aplicar el color el en tabpage actual
                    sb.Color = Color.FromArgb(5, 5, 110)
                    g.FillRectangle(sb, e.Bounds)
                    'Escribir el texto que tenia el tab
                    g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.FromArgb(233, 233, 255)), headerRect, sf)
                End If
            Case "P.E.T."
                sb.Color = Color.FromArgb(10, 177, 0)
                g.FillRectangle(sb, e.Bounds)
                g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.White), headerRect, sf)
                If TabControl1.SelectedIndex = e.Index Then
                    'Aplicar el color el en tabpage actual
                    sb.Color = Color.FromArgb(3, 96, 0)
                    g.FillRectangle(sb, e.Bounds)
                    'Escribir el texto que tenia el tab
                    g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.FromArgb(118, 255, 207)), headerRect, sf)
                End If
            Case "P.P."
                sb.Color = Color.Yellow
                g.FillRectangle(sb, e.Bounds)
                g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.Black), headerRect, sf)
                If TabControl1.SelectedIndex = e.Index Then
                    'Aplicar el color el en tabpage actual
                    sb.Color = Color.FromArgb(120, 105, 0)
                    g.FillRectangle(sb, e.Bounds)
                    'Escribir el texto que tenia el tab
                    g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.FromArgb(255, 245, 181)), headerRect, sf)
                End If
            Case "Flexible"
                sb.Color = Color.FromArgb(190, 0, 255)
                g.FillRectangle(sb, e.Bounds)
                g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.White), headerRect, sf)
                If TabControl1.SelectedIndex = e.Index Then
                    'Aplicar el color el en tabpage actual
                    sb.Color = Color.FromArgb(74, 0, 99)
                    g.FillRectangle(sb, e.Bounds)
                    'Escribir el texto que tenia el tab
                    g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.FromArgb(240, 198, 255)), headerRect, sf)
                End If
            Case "Cartón"
                sb.Color = Color.Peru
                g.FillRectangle(sb, e.Bounds)
                g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.White), headerRect, sf)
                If TabControl1.SelectedIndex = e.Index Then
                    'Aplicar el color el en tabpage actual
                    sb.Color = Color.FromArgb(89, 58, 27)
                    g.FillRectangle(sb, e.Bounds)
                    'Escribir el texto que tenia el tab
                    g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.FromArgb(234, 217, 200)), headerRect, sf)
                End If
            Case "Metal"
                sb.Color = Color.FromArgb(128, 128, 128)
                g.FillRectangle(sb, e.Bounds)
                g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.White), headerRect, sf)
                If TabControl1.SelectedIndex = e.Index Then
                    'Aplicar el color el en tabpage actual
                    sb.Color = Color.FromArgb(57, 57, 57)
                    g.FillRectangle(sb, e.Bounds)
                    'Escribir el texto que tenia el tab
                    g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.FromArgb(227, 227, 227)), headerRect, sf)
                End If
            Case "P.F.M."
                sb.Color = Color.FromArgb(75, 0, 80)
                g.FillRectangle(sb, e.Bounds)
                g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.White), headerRect, sf)
                If TabControl1.SelectedIndex = e.Index Then
                    'Aplicar el color el en tabpage actual
                    sb.Color = Color.Black
                    g.FillRectangle(sb, e.Bounds)
                    g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.White), headerRect, sf)
                End If
            Case "Revuelto"
                sb.Color = Color.Orange
                g.FillRectangle(sb, e.Bounds)
                g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.White), headerRect, sf)
                If TabControl1.SelectedIndex = e.Index Then
                    'Aplicar el color el en tabpage actual
                    sb.Color = Color.FromArgb(139, 90, 0)
                    g.FillRectangle(sb, e.Bounds)
                    'Escribir el texto que tenia el tab
                    g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.FromArgb(255, 212, 133)), headerRect, sf)
                End If
            Case "Otros"
                sb.Color = Color.Tan
                g.FillRectangle(sb, e.Bounds)
                g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.White), headerRect, sf)
                If TabControl1.SelectedIndex = e.Index Then
                    'Aplicar el color el en tabpage actual
                    sb.Color = Color.FromArgb(110, 94, 73)
                    g.FillRectangle(sb, e.Bounds)
                    'Escribir el texto que tenia el tab
                    g.DrawString(tp.Text, TabControl1.Font, New SolidBrush(Color.FromArgb(255, 237, 215)), headerRect, sf)
                End If
        End Select
    End Sub

    Private Sub actualizarTotalGRAL() 'Ver si hay forma de optimizar este cochinero de ifs'
        Dim pead, pet, pp, flex, cart, met, pfm, rev, otro As Double

        If txt_Res_PEAD.Text = "" Then
            pead = 0
        Else
            pead = CDbl(txt_Res_PEAD.Text)
        End If

        If txt_Res_PET.Text = "" Then
            pet = 0
        Else
            pet = CDbl(txt_Res_PET.Text)
        End If

        If txt_Res_PP.Text = "" Then
            pp = 0
        Else
            pp = CDbl(txt_Res_PP.Text)
        End If

        If txt_Res_Flexible.Text = "" Then
            flex = 0
        Else
            flex = CDbl(txt_Res_Flexible.Text)
        End If

        If txt_Res_Carton.Text = "" Then
            cart = 0
        Else
            cart = CDbl(txt_Res_Carton.Text)
        End If

        If txt_Res_Metal.Text = "" Then
            met = 0
        Else
            met = CDbl(txt_Res_Metal.Text)
        End If

        If txt_Res_PFM.Text = "" Then
            pfm = 0
        Else
            pfm = CDbl(txt_Res_PFM.Text)
        End If

        If txt_Res_Revuelto.Text = "" Then
            rev = 0
        Else
            rev = CDbl(txt_Res_Revuelto.Text)
        End If

        If txt_Res_Otros.Text = "" Then
            otro = 0
        Else
            otro = CDbl(txt_Res_Otros.Text)
        End If

        txt_Res_Total.Text = pead + pet + pp + flex + cart + met + pfm + rev + otro
    End Sub

    Private Function validarValoresVacios(val1 As String, val2 As String)
        Dim res As Double
        If val1 = "" Or val1 = "." Then
            val1 = 0
        End If
        If val2 = "" Or val2 = "." Then
            val2 = 0
        End If
        res = Val(val1) * CDbl(val2)
        Return res
    End Function

    '------------------------------------------------PEAD------------------------------------------'
    Private Sub actualizarTotalPEAD()
        Dim totalTrit, totalComp, totalAgra As Double
        If txt_PEAD_Trit_Total.Text = "" Then
            totalTrit = 0
        Else
            totalTrit = CDbl(txt_PEAD_Trit_Total.Text)
        End If
        If txt_PEAD_Comp_Total.Text = "" Then
            totalComp = 0
        Else
            totalComp = CDbl(txt_PEAD_Comp_Total.Text)
        End If
        If txt_PEAD_Agra_Total.Text = "" Then
            totalAgra = 0
        Else
            totalAgra = CDbl(txt_PEAD_Agra_Total.Text)
        End If

        txt_PEAD_Total.Text = totalTrit + totalComp + totalAgra
        txt_Res_PEAD.Text = txt_PEAD_Total.Text
        actualizarTotalGRAL()
    End Sub
    Dim val1, val2 As Double
    Private Sub txt_PEAD_Trit_Peso_TextChanged(sender As Object, e As EventArgs) Handles txt_PEAD_Trit_Peso.TextChanged
        txt_PEAD_Trit_Total.Text = validarValoresVacios(txt_PEAD_Trit_Cantidad.Text, txt_PEAD_Trit_Peso.Text)
        actualizarTotalPEAD()
    End Sub

    Private Sub txt_PEAD_Comp_Peso_TextChanged(sender As Object, e As EventArgs) Handles txt_PEAD_Comp_Peso.TextChanged
        txt_PEAD_Comp_Total.Text = validarValoresVacios(txt_PEAD_Comp_Cantidad.Text, txt_PEAD_Comp_Peso.Text)
        actualizarTotalPEAD()
    End Sub

    Private Sub txt_PEAD_Agra_Peso_TextChanged(sender As Object, e As EventArgs) Handles txt_PEAD_Agra_Peso.TextChanged
        txt_PEAD_Agra_Total.Text = validarValoresVacios(txt_PEAD_Agra_Cantidad.Text, txt_PEAD_Agra_Peso.Text)
        actualizarTotalPEAD()
    End Sub
    '------------------------------------------------PET------------------------------------------'
    Private Sub actualizarTotalPET()
        Dim totalTrit, totalComp, totalAgra As Double
        If txt_PET_Trit_Total.Text = "" Then
            totalTrit = 0
        Else
            totalTrit = CDbl(txt_PET_Trit_Total.Text)
        End If
        If txt_PET_Comp_Total.Text = "" Then
            totalComp = 0
        Else
            totalComp = CDbl(txt_PET_Comp_Total.Text)
        End If
        If txt_PET_Agra_Total.Text = "" Then
            totalAgra = 0
        Else
            totalAgra = CDbl(txt_PET_Agra_Total.Text)
        End If

        txt_PET_Total.Text = totalTrit + totalComp + totalAgra
        txt_Res_PET.Text = txt_PET_Total.Text
        actualizarTotalGRAL()
    End Sub

    Private Sub txt_PET_Trit_Peso_TextChanged(sender As Object, e As EventArgs) Handles txt_PET_Trit_Peso.TextChanged
        txt_PET_Trit_Total.Text = validarValoresVacios(txt_PET_Trit_Cantidad.Text, txt_PET_Trit_Peso.Text)
        actualizarTotalPET()
    End Sub

    Private Sub txt_PET_Comp_Peso_TextChanged(sender As Object, e As EventArgs) Handles txt_PET_Comp_Peso.TextChanged
        txt_PET_Comp_Total.Text = validarValoresVacios(txt_PET_Comp_Cantidad.Text, txt_PET_Comp_Peso.Text)
        actualizarTotalPET()
    End Sub

    Private Sub txt_PET_Agra_Peso_TextChanged(sender As Object, e As EventArgs) Handles txt_PET_Agra_Peso.TextChanged
        txt_PET_Agra_Total.Text = validarValoresVacios(txt_PET_Agra_Cantidad.Text, txt_PET_Agra_Peso.Text)
        actualizarTotalPET()
    End Sub

    '------------------------------------------------PP------------------------------------------'
    Private Sub txt_PP_Trit_Peso_TextChanged(sender As Object, e As EventArgs) Handles txt_PP_Trit_Peso.TextChanged
        txt_PP_Trit_Total.Text = validarValoresVacios(txt_PP_Trit_Cantidad.Text, txt_PP_Trit_Peso.Text)
        txt_PP_Total.Text = txt_PP_Trit_Total.Text
        txt_Res_PP.Text = txt_PP_Total.Text
        actualizarTotalGRAL()
    End Sub

    '------------------------------------------------FLEXIBLE------------------------------------------'
    Private Sub actualizarTotalFLEXIBLE()
        Dim totalComp, totalAgra As Double

        If txt_Flex_Comp_Total.Text = "" Then
            totalComp = 0
        Else
            totalComp = CDbl(txt_Flex_Comp_Total.Text)
        End If
        If txt_Flex_Agra_Total.Text = "" Then
            totalAgra = 0
        Else
            totalAgra = CDbl(txt_Flex_Agra_Total.Text)
        End If

        txt_Flex_Total.Text = totalComp + totalAgra
        txt_Res_Flexible.Text = txt_Flex_Total.Text
        actualizarTotalGRAL()
    End Sub
    Private Sub txt_Flex_Comp_Peso_TextChanged(sender As Object, e As EventArgs) Handles txt_Flex_Comp_Peso.TextChanged
        txt_Flex_Comp_Total.Text = validarValoresVacios(txt_Flex_Comp_Cantidad.Text, txt_Flex_Comp_Peso.Text)
        actualizarTotalFLEXIBLE()
    End Sub

    Private Sub txt_Flex_Agra_Peso_TextChanged(sender As Object, e As EventArgs) Handles txt_Flex_Agra_Peso.TextChanged
        txt_Flex_Agra_Total.Text = validarValoresVacios(txt_Flex_Agra_Cantidad.Text, txt_Flex_Agra_Peso.Text)
        actualizarTotalFLEXIBLE()
    End Sub

    '------------------------------------------------CARTON------------------------------------------'
    Private Sub actualizarTotalCARTON()
        Dim totalComp, totalAgra As Double

        If txt_Cart_Comp_Total.Text = "" Then
            totalComp = 0
        Else
            totalComp = CDbl(txt_Cart_Comp_Total.Text)
        End If
        If txt_Cart_Agra_Total.Text = "" Then
            totalAgra = 0
        Else
            totalAgra = CDbl(txt_Cart_Agra_Total.Text)
        End If

        txt_Cart_Total.Text = totalComp + totalAgra
        txt_Res_Carton.Text = txt_Cart_Total.Text
        actualizarTotalGRAL()
    End Sub

    Private Sub txt_Cart_Comp_Peso_TextChanged(sender As Object, e As EventArgs) Handles txt_Cart_Comp_Peso.TextChanged
        txt_Cart_Comp_Total.Text = validarValoresVacios(txt_Cart_Comp_Cantidad.Text, txt_Cart_Comp_Peso.Text)
        actualizarTotalCARTON()
    End Sub

    Private Sub txt_Cart_Agra_Total_TextChanged(sender As Object, e As EventArgs) Handles txt_Cart_Agra_Total.TextChanged
        actualizarTotalCARTON()
    End Sub

    '------------------------------------------------METAL------------------------------------------'
    Private Sub txt_Met_Agra_Total_TextChanged(sender As Object, e As EventArgs) Handles txt_Met_Agra_Peso.TextChanged
        txt_Met_Agra_Total.Text = validarValoresVacios(txt_Met_Agra_Cantidad.Text, txt_Met_Agra_Peso.Text)
        txt_Met_Total.Text = txt_Met_Agra_Total.Text
        txt_Res_Metal.Text = txt_Met_Total.Text
        actualizarTotalGRAL()
    End Sub

    '------------------------------------------------PFM------------------------------------------'
    Private Sub txt_PFM_Agra_Peso_TextChanged(sender As Object, e As EventArgs) Handles txt_PFM_Agra_Peso.TextChanged
        txt_PFM_Agra_Total.Text = validarValoresVacios(txt_PFM_Agra_Paquetes.Text, txt_PFM_Agra_Peso.Text)
        txt_PFM_Total.Text = txt_PFM_Agra_Total.Text
        txt_Res_PFM.Text = txt_PFM_Total.Text
        actualizarTotalGRAL()
    End Sub

    '------------------------------------------------REVUELTO------------------------------------------'
    Private Sub txt_Rev_Agra_Total_TextChanged(sender As Object, e As EventArgs) Handles txt_Rev_Agra_Total.TextChanged
        If txt_Rev_Agra_Total.Text = "" Then
            txt_Rev_Total.Text = 0
        Else
            txt_Rev_Total.Text = txt_Rev_Agra_Total.Text
        End If
        txt_Res_Revuelto.Text = txt_Rev_Total.Text
        actualizarTotalGRAL()
    End Sub

    '------------------------------------------------OTROS---------------------------------------------'
    Private Sub txt_Otros_Esp_Total_TextChanged(sender As Object, e As EventArgs) Handles txt_Otros_Esp_Total.TextChanged
        If txt_Otros_Esp_Total.Text = "" Then
            txt_Otros_Total.Text = 0
        Else
            txt_Otros_Total.Text = txt_Otros_Esp_Total.Text
        End If
        txt_Res_Otros.Text = txt_Otros_Total.Text
        actualizarTotalGRAL()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If MsgBox(“¿Seguro que deseas registrar estos valores?”, vbQuestion + vbYesNo + vbDefaultButton2, “Confirmar Registro”) = vbYes Then
            '----------------------------------------------------AQUI VA EL REGISTRO EN AMBAS TABLAS--------------------------------------------'
            Dim totalFinal As Double
            totalFinal = CDbl(txt_Res_Total.Text)
            '-------------------------------------------------------REGISTRO TABLA PROCESADO----------------------------------------------------'
            Dim fecha As String
            Dim band As Boolean = True
            fecha = dtFechaRegistro.Value.Year & "/" & dtFechaRegistro.Value.Month & "/" & dtFechaRegistro.Value.Day
            Dim trans As MySqlTransaction
            trans = conex.BeginTransaction()
            comando.Connection = conex
            comando.Transaction = trans
            Try
                adapter = New MySqlDataAdapter("insertarProcesado", conex)
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure
                adapter.SelectCommand.Parameters.Add("@IdC", MySqlDbType.Int64).Value = Val(txtIdCAT.Text)
                adapter.SelectCommand.Parameters.Add("@Resp", MySqlDbType.VarChar).Value = cboResponsableProcesado.Text
                adapter.SelectCommand.Parameters.Add("@fechaP", MySqlDbType.Date).Value = fecha
                adapter.SelectCommand.Parameters.Add("@total", MySqlDbType.Float).Value = totalFinal

                adapter.SelectCommand.ExecuteNonQuery()
                trans.Commit()
            Catch ex As Exception
                MsgBox("Ha ocurrido un error en la transaccion: " & ex.Message)
                band = False
                Try
                    trans.Rollback()
                Catch ex2 As Exception
                    MsgBox("Error en el error: " & ex2.Message)
                End Try
            Finally
                adapter.Dispose()
            End Try
            '-------------------------------------------------------REGISTRO TABLA DETPROCESADO-------------------------------------------------------'
            Dim totales, materiales As Array
            totales = {txt_Res_PEAD.Text, txt_Res_PET.Text, txt_Res_PP.Text, txt_Res_Flexible.Text, txt_Res_Metal.Text,
                txt_Res_Carton.Text, txt_Res_PFM.Text, txt_Res_Revuelto.Text, txt_Res_Otros.Text}
            materiales = {"PEAD", "PET", "PP", "FLEXIBLE", "METAL", "CARTON", "PFM", "REVUELTO", "OTRO"}
            Dim x As Integer
            For x = 0 To totales.Length - 1
                If totales(x) = "" Or totales(x) = Nothing Then
                    totales(x) = 0
                Else
                    totales(x) = CDbl(totales(x))
                End If
            Next

            For x = 0 To totales.Length - 1
                If totales(x) = 0 Then
                Else
                    trans = conex.BeginTransaction()
                    comando.Connection = conex
                    comando.Transaction = trans
                    Try
                        Dim tritCant, tritPeso, tritTot, compCant, compPeso, compTot, agraCant, agraPeso, agraPlaca, agraTot, agraTipo, total As String
                        Select Case materiales(x)
                            Case "PEAD"
                                If txt_PEAD_Trit_Cantidad.Text = "" Then
                                    tritCant = 0
                                Else
                                    tritCant = txt_PEAD_Trit_Cantidad.Text
                                End If
                                If txt_PEAD_Trit_Peso.Text = "" Then
                                    tritPeso = 0
                                Else
                                    tritPeso = txt_PEAD_Trit_Peso.Text
                                End If
                                If txt_PEAD_Trit_Total.Text = "" Then
                                    tritTot = 0
                                Else
                                    tritTot = txt_PEAD_Trit_Total.Text
                                End If
                                If txt_PEAD_Comp_Cantidad.Text = "" Then
                                    compCant = 0
                                Else
                                    compCant = txt_PEAD_Comp_Cantidad.Text
                                End If
                                If txt_PEAD_Comp_Peso.Text = "" Then
                                    compPeso = 0
                                Else
                                    compPeso = txt_PEAD_Comp_Peso.Text
                                End If
                                If txt_PEAD_Comp_Total.Text = "" Then
                                    compTot = 0
                                Else
                                    compTot = txt_PEAD_Comp_Total.Text
                                End If
                                If txt_PEAD_Agra_Cantidad.Text = "" Then
                                    agraCant = 0
                                Else
                                    agraCant = txt_PEAD_Agra_Cantidad.Text
                                End If
                                If txt_PEAD_Agra_Peso.Text = "" Then
                                    agraPeso = 0
                                Else
                                    agraPeso = txt_PEAD_Agra_Peso.Text
                                End If
                                If txt_PEAD_Agra_Total.Text = "" Then
                                    agraTot = 0
                                Else
                                    agraTot = txt_PEAD_Agra_Total.Text
                                End If
                                If txt_PEAD_Total.Text = "" Then
                                    total = 0
                                Else
                                    total = txt_PEAD_Total.Text
                                End If
                                agraPlaca = 0
                                agraTipo = 0

                            Case "PET"
                                If txt_PET_Trit_Cantidad.Text = "" Then
                                    tritCant = 0
                                Else
                                    tritCant = txt_PET_Trit_Cantidad.Text
                                End If
                                If txt_PET_Trit_Peso.Text = "" Then
                                    tritPeso = 0
                                Else
                                    tritPeso = txt_PET_Trit_Peso.Text
                                End If
                                If txt_PET_Trit_Total.Text = "" Then
                                    tritTot = 0
                                Else
                                    tritTot = txt_PET_Trit_Total.Text
                                End If
                                If txt_PET_Comp_Cantidad.Text = "" Then
                                    compCant = 0
                                Else
                                    compCant = txt_PET_Comp_Cantidad.Text
                                End If
                                If txt_PET_Comp_Peso.Text = "" Then
                                    compPeso = 0
                                Else
                                    compPeso = txt_PET_Comp_Peso.Text
                                End If
                                If txt_PET_Comp_Total.Text = "" Then
                                    compTot = 0
                                Else
                                    compTot = txt_PET_Comp_Total.Text
                                End If
                                If txt_PET_Agra_Cantidad.Text = "" Then
                                    agraCant = 0
                                Else
                                    agraCant = txt_PET_Agra_Cantidad.Text
                                End If
                                If txt_PET_Agra_Peso.Text = "" Then
                                    agraPeso = 0
                                Else
                                    agraPeso = txt_PET_Agra_Peso.Text
                                End If
                                If txt_PET_Agra_Total.Text = "" Then
                                    agraTot = 0
                                Else
                                    agraTot = txt_PET_Agra_Total.Text
                                End If
                                If txt_PET_Total.Text = "" Then
                                    total = 0
                                Else
                                    total = txt_PET_Total.Text
                                End If
                                agraPlaca = 0
                                agraTipo = 0

                            Case "PP"
                                If txt_PP_Trit_Cantidad.Text = "" Then
                                    tritCant = 0
                                Else
                                    tritCant = txt_PP_Trit_Cantidad.Text
                                End If
                                If txt_PP_Trit_Peso.Text = "" Then
                                    tritPeso = 0
                                Else
                                    tritPeso = txt_PP_Trit_Peso.Text
                                End If
                                If txt_PP_Trit_Total.Text = "" Then
                                    tritTot = 0
                                Else
                                    tritTot = txt_PP_Trit_Total.Text
                                End If
                                If txt_PP_Total.Text = "" Then
                                    total = 0
                                Else
                                    total = txt_PP_Total.Text
                                End If
                                compCant = 0
                                compPeso = 0
                                compTot = 0
                                agraCant = 0
                                agraPeso = 0
                                agraPlaca = 0
                                agraTot = 0
                                agraTipo = 0

                            Case "FLEXIBLE"
                                If txt_Flex_Comp_Cantidad.Text = "" Then
                                    compCant = 0
                                Else
                                    compCant = txt_Flex_Comp_Cantidad.Text
                                End If
                                If txt_Flex_Comp_Peso.Text = "" Then
                                    compPeso = 0
                                Else
                                    compPeso = txt_Flex_Comp_Peso.Text
                                End If
                                If txt_Flex_Comp_Total.Text = "" Then
                                    compTot = 0
                                Else
                                    compTot = txt_Flex_Comp_Total.Text
                                End If
                                If txt_Flex_Agra_Cantidad.Text = "" Then
                                    agraCant = 0
                                Else
                                    agraCant = txt_Flex_Agra_Cantidad.Text
                                End If
                                If txt_Flex_Agra_Peso.Text = "" Then
                                    agraPeso = 0
                                Else
                                    agraPeso = txt_Flex_Agra_Peso.Text
                                End If
                                If txt_Flex_Agra_Total.Text = "" Then
                                    agraTot = 0
                                Else
                                    agraTot = txt_Flex_Agra_Total.Text
                                End If
                                If txt_Flex_Total.Text = "" Then
                                    total = 0
                                Else
                                    total = txt_Flex_Total.Text
                                End If
                                tritCant = 0
                                tritPeso = 0
                                tritTot = 0
                                agraPlaca = 0
                                agraTipo = 0

                            Case "METAL"
                                If txt_Met_Agra_Cantidad.Text = "" Then
                                    agraCant = 0
                                Else
                                    agraCant = txt_Met_Agra_Cantidad.Text
                                End If
                                If txt_Met_Agra_Peso.Text = "" Then
                                    agraPeso = 0
                                Else
                                    agraPeso = txt_Met_Agra_Peso.Text
                                End If
                                If txt_Met_Agra_Total.Text = "" Then
                                    agraTot = 0
                                Else
                                    agraTot = txt_Met_Agra_Total.Text
                                End If
                                If txt_Met_Total.Text = "" Then
                                    total = 0
                                Else
                                    total = txt_Met_Total.Text
                                End If
                                tritCant = 0
                                tritPeso = 0
                                tritTot = 0
                                compCant = 0
                                compPeso = 0
                                compTot = 0
                                agraPlaca = 0
                                agraTipo = 0

                            Case "CARTON"
                                If txt_Cart_Comp_Cantidad.Text = "" Then
                                    compCant = 0
                                Else
                                    compCant = txt_Cart_Comp_Cantidad.Text
                                End If
                                If txt_Cart_Comp_Peso.Text = "" Then
                                    compPeso = 0
                                Else
                                    compPeso = txt_Cart_Comp_Peso.Text
                                End If
                                If txt_Cart_Comp_Total.Text = "" Then
                                    compTot = 0
                                Else
                                    compTot = txt_Cart_Comp_Total.Text
                                End If
                                If txt_Cart_Agra_Total.Text = "" Then
                                    agraTot = 0
                                Else
                                    agraTot = txt_Cart_Agra_Total.Text
                                End If
                                If txt_Cart_Total.Text = "" Then
                                    total = 0
                                Else
                                    total = txt_Cart_Total.Text
                                End If
                                tritCant = 0
                                tritPeso = 0
                                tritTot = 0
                                agraCant = 0
                                agraPeso = 0
                                agraPlaca = 0
                                agraTipo = 0

                            Case "PFM"
                                If txt_PFM_Agra_Paquetes.Text = "" Then
                                    agraCant = 0
                                Else
                                    agraCant = txt_PFM_Agra_Paquetes.Text
                                End If
                                If txt_PFM_Agra_Placas.Text = "" Then
                                    agraPlaca = 0
                                Else
                                    agraPlaca = txt_PFM_Agra_Placas.Text
                                End If
                                If txt_PFM_Agra_Peso.Text = "" Then
                                    agraPeso = 0
                                Else
                                    agraPeso = txt_PFM_Agra_Peso.Text
                                End If
                                If txt_PFM_Agra_Total.Text = "" Then
                                    agraTot = 0
                                Else
                                    agraTot = txt_PFM_Agra_Total.Text
                                End If
                                If txt_PFM_Total.Text = "" Then
                                    total = 0
                                Else
                                    total = txt_PFM_Total.Text
                                End If
                                tritCant = 0
                                tritPeso = 0
                                tritTot = 0
                                compCant = 0
                                compPeso = 0
                                compTot = 0
                                agraTipo = 0

                            Case "REVUELTO"
                                If txt_Rev_Agra_Total.Text = "" Then
                                    agraTot = 0
                                Else
                                    agraTot = txt_Rev_Agra_Total.Text
                                End If
                                If txt_Rev_Total.Text = "" Then
                                    total = 0
                                Else
                                    total = txt_Rev_Total.Text
                                End If
                                tritCant = 0
                                tritPeso = 0
                                tritTot = 0
                                compCant = 0
                                compPeso = 0
                                compTot = 0
                                agraCant = 0
                                agraPlaca = 0
                                agraPeso = 0
                                agraTipo = 0

                            Case "OTRO"
                                If txt_Otros_Esp_Total.Text = "" Then
                                    agraTot = 0
                                Else
                                    agraTot = txt_Otros_Esp_Total.Text
                                End If
                                If txt_Otros_Esp_Tipos.Text = "" Then
                                    agraTipo = 0
                                Else
                                    agraTipo = txt_Otros_Esp_Tipos.Text
                                End If
                                If txt_Otros_Total.Text = "" Then
                                    total = 0
                                Else
                                    total = txt_Otros_Total.Text
                                End If
                                tritCant = 0
                                tritPeso = 0
                                tritTot = 0
                                compCant = 0
                                compPeso = 0
                                compTot = 0
                                agraCant = 0
                                agraPlaca = 0
                                agraPeso = 0

                        End Select

                        adapter = New MySqlDataAdapter("insertarDetProcesado", conex)
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure
                        adapter.SelectCommand.Parameters.Add("@IdProc", MySqlDbType.Int64).Value = Val(txtIdProcesado.Text)
                        adapter.SelectCommand.Parameters.Add("@Nom", MySqlDbType.VarChar).Value = materiales(x)
                        adapter.SelectCommand.Parameters.Add("@tritCant", MySqlDbType.Int64).Value = Val(tritCant)
                        adapter.SelectCommand.Parameters.Add("@tritPeso", MySqlDbType.Float).Value = CDbl(tritPeso)
                        adapter.SelectCommand.Parameters.Add("@tritTot", MySqlDbType.Float).Value = CDbl(tritTot)
                        adapter.SelectCommand.Parameters.Add("@compCant", MySqlDbType.Int64).Value = Val(compCant)
                        adapter.SelectCommand.Parameters.Add("@compPeso", MySqlDbType.Float).Value = CDbl(compPeso)
                        adapter.SelectCommand.Parameters.Add("@compTot", MySqlDbType.Float).Value = CDbl(compTot)
                        adapter.SelectCommand.Parameters.Add("@agraCant", MySqlDbType.Int64).Value = Val(agraCant)
                        adapter.SelectCommand.Parameters.Add("@agraPeso", MySqlDbType.Float).Value = CDbl(agraPeso)
                        adapter.SelectCommand.Parameters.Add("@agraPlaca", MySqlDbType.Int64).Value = Val(agraPlaca)
                        adapter.SelectCommand.Parameters.Add("@agraTot", MySqlDbType.Float).Value = CDbl(agraTot)
                        adapter.SelectCommand.Parameters.Add("@agraTipo", MySqlDbType.VarChar).Value = agraTipo
                        adapter.SelectCommand.Parameters.Add("@total", MySqlDbType.Float).Value = CDbl(total)

                        adapter.SelectCommand.ExecuteNonQuery()
                        trans.Commit()
                    Catch ex As Exception
                        MsgBox("Ha ocurrido un error en la transaccion: " & ex.Message)
                        Try
                            trans.Rollback()
                            band = False
                        Catch ex2 As Exception
                            MsgBox("Error en el error: " & ex2.Message)
                        End Try
                    Finally
                        adapter.Dispose()
                    End Try
                End If
            Next
            If band = True Then
                MsgBox("Registro realizado correctamente", vbOKOnly, "Procesado de Material")
            End If
            limpiarTodo()

        Else
            MsgBox("Registro cancelado")
        End If
    End Sub

    Private Sub limpiarTodo()
        txt_PEAD_Trit_Cantidad.Clear()
        txt_PEAD_Trit_Peso.Clear()
        txt_PEAD_Trit_Total.Clear()
        txt_PEAD_Comp_Cantidad.Clear()
        txt_PEAD_Comp_Peso.Clear()
        txt_PEAD_Comp_Total.Clear()
        txt_PEAD_Agra_Cantidad.Clear()
        txt_PEAD_Agra_Peso.Clear()
        txt_PEAD_Agra_Total.Clear()
        txt_PEAD_Total.Clear()

        txt_PET_Trit_Cantidad.Clear()
        txt_PET_Trit_Peso.Clear()
        txt_PET_Trit_Total.Clear()
        txt_PET_Comp_Cantidad.Clear()
        txt_PET_Comp_Peso.Clear()
        txt_Cart_Comp_Total.Clear()
        txt_PET_Agra_Cantidad.Clear()
        txt_PET_Agra_Peso.Clear()
        txt_PET_Agra_Total.Clear()
        txt_PET_Total.Clear()

        txt_PP_Trit_Cantidad.Clear()
        txt_PP_Trit_Peso.Clear()
        txt_PP_Trit_Total.Clear()
        txt_PP_Total.Clear()

        txt_Flex_Comp_Cantidad.Clear()
        txt_Flex_Comp_Peso.Clear()
        txt_Flex_Comp_Total.Clear()
        txt_Flex_Agra_Cantidad.Clear()
        txt_Flex_Agra_Peso.Clear()
        txt_Flex_Agra_Total.Clear()
        txt_Flex_Total.Clear()

        txt_Met_Agra_Cantidad.Clear()
        txt_Met_Agra_Peso.Clear()
        txt_Met_Agra_Total.Clear()
        txt_Met_Total.Clear()

        txt_Cart_Comp_Cantidad.Clear()
        txt_Cart_Comp_Peso.Clear()
        txt_Cart_Comp_Total.Clear()
        txt_Cart_Agra_Total.Clear()
        txt_Cart_Total.Clear()

        txt_PFM_Agra_Paquetes.Clear()
        txt_PFM_Agra_Peso.Clear()
        txt_PFM_Agra_Placas.Clear()
        txt_PFM_Agra_Total.Clear()
        txt_PFM_Total.Clear()

        txt_Rev_Agra_Total.Clear()
        txt_Rev_Total.Clear()

        txt_Otros_Esp_Tipos.Clear()
        txt_Otros_Esp_Total.Clear()
        txt_Otros_Total.Clear()

        txt_Res_PEAD.Clear()
        txt_Res_PET.Clear()
        txt_Res_PP.Clear()
        txt_Res_Flexible.Clear()
        txt_Res_Metal.Clear()
        txt_Res_Carton.Clear()
        txt_Res_PFM.Clear()
        txt_Res_Revuelto.Clear()
        txt_Res_Otros.Clear()
        txt_Res_Total.Clear()

        comando.CommandText = "SELECT COUNT(*) FROM procesado"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdProcesado.Text = lector(0) + 1
        lector.Close()
    End Sub

    Private Sub PnSalir_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        conex.Close()
        Dispose()
    End Sub

    '----------------------------------------------------------------UIX------------------------------------------------------'


    '------------------------Validar Numeros TextBox-------------------------'
    Private Sub validarEntradaNumeros(key As KeyPressEventArgs, band As Boolean)
        Dim caract As Short = Asc(key.KeyChar)
        Dim decimales As String
        If band = True Then
            decimales = "0123456789."
        Else
            decimales = "0123456789"
        End If
        If InStr(decimales, Chr(caract)) = 0 Then
            If caract <> 8 Then
                caract = 0
            End If
            key.KeyChar = Chr(caract)
            If caract = 0 Then
                key.Handled = True
            End If
        End If
    End Sub
    '---PEAD----'
    Private Sub txt_PEAD_Trit_Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PEAD_Trit_Cantidad.KeyPress
        validarEntradaNumeros(e, False)
    End Sub
    Private Sub txt_PEAD_Trit_Peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PEAD_Trit_Peso.KeyPress
        validarEntradaNumeros(e, True)
    End Sub
    Private Sub txt_PEAD_Comp_Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PEAD_Comp_Cantidad.KeyPress
        validarEntradaNumeros(e, False)
    End Sub
    Private Sub txt_PEAD_Comp_Peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PEAD_Comp_Peso.KeyPress
        validarEntradaNumeros(e, True)
    End Sub
    Private Sub txt_PEAD_Agra_Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PEAD_Agra_Cantidad.KeyPress
        validarEntradaNumeros(e, False)
    End Sub
    Private Sub txt_PEAD_Agra_Peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PEAD_Agra_Peso.KeyPress
        validarEntradaNumeros(e, True)
    End Sub

    '---PET----'
    Private Sub txt_PET_Trit_Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PET_Trit_Cantidad.KeyPress
        validarEntradaNumeros(e, False)
    End Sub
    Private Sub txt_PET_Trit_Peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PET_Trit_Peso.KeyPress
        validarEntradaNumeros(e, True)
    End Sub
    Private Sub txt_PET_Comp_Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PET_Comp_Cantidad.KeyPress
        validarEntradaNumeros(e, False)
    End Sub
    Private Sub txt_PET_Comp_Peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PET_Comp_Peso.KeyPress
        validarEntradaNumeros(e, True)
    End Sub
    Private Sub txt_PET_Agra_Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PET_Agra_Cantidad.KeyPress
        validarEntradaNumeros(e, False)
    End Sub
    Private Sub txt_PET_Agra_Peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PET_Agra_Peso.KeyPress
        validarEntradaNumeros(e, True)
    End Sub

    '---PP----'
    Private Sub txt_PP_Trit_Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PP_Trit_Cantidad.KeyPress
        validarEntradaNumeros(e, False)
    End Sub
    Private Sub txt_PP_Trit_Peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PP_Trit_Peso.KeyPress
        validarEntradaNumeros(e, True)
    End Sub

    '---FLEXIBLE----'
    Private Sub txt_Flex_Comp_Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Flex_Comp_Cantidad.KeyPress
        validarEntradaNumeros(e, False)
    End Sub
    Private Sub txt_Flex_Comp_Peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Flex_Comp_Peso.KeyPress
        validarEntradaNumeros(e, True)
    End Sub
    Private Sub txt_Flex_Agra_Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Flex_Agra_Cantidad.KeyPress
        validarEntradaNumeros(e, False)
    End Sub
    Private Sub txt_Flex_Agra_Peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Flex_Agra_Peso.KeyPress
        validarEntradaNumeros(e, True)
    End Sub

    '---METAL----'
    Private Sub txt_Met_Agra_Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Met_Agra_Cantidad.KeyPress
        validarEntradaNumeros(e, False)
    End Sub
    Private Sub txt_Met_Agra_Peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Met_Agra_Peso.KeyPress
        validarEntradaNumeros(e, True)
    End Sub

    '---CARTON----'
    Private Sub txt_Cart_Comp_Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Cart_Comp_Cantidad.KeyPress
        validarEntradaNumeros(e, False)
    End Sub
    Private Sub txt_Cart_Comp_Peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Cart_Comp_Peso.KeyPress
        validarEntradaNumeros(e, True)
    End Sub
    Private Sub txt_Cart_Agra_Total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Cart_Agra_Total.KeyPress
        validarEntradaNumeros(e, True)
    End Sub

    '---PFM----'
    Private Sub txt_PFM_Agra_Placas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PFM_Agra_Placas.KeyPress
        validarEntradaNumeros(e, False)
    End Sub
    Private Sub txt_PFM_Agra_Paquetes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PFM_Agra_Paquetes.KeyPress
        validarEntradaNumeros(e, False)
    End Sub
    Private Sub txt_PFM_Agra_Peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PFM_Agra_Peso.KeyPress
        validarEntradaNumeros(e, True)
    End Sub

    '---REVUELTO----'
    Private Sub txt_Rev_Agra_Total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Rev_Agra_Total.KeyPress
        validarEntradaNumeros(e, True)
    End Sub

    '---OTROS----'
    Private Sub txt_Otros_Esp_Total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Otros_Esp_Total.KeyPress
        validarEntradaNumeros(e, True)
    End Sub

    Private Sub cboResponsableProcesado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboResponsableProcesado.SelectedIndexChanged
        TabControl1.Enabled = True
    End Sub
End Class