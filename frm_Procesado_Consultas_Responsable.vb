Imports MySqlConnector

Public Class frm_Procesado_Consultas_Responsable
    Dim conex As MySqlConnection
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Dim adapter As MySqlDataAdapter
    Private Sub frm_Procesado_Consultas_Responsable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String
        str = "server=localhost;port=3306;uid=root;pwd='060599';database=apeajaldb;"
        conex = New MySqlConnection(str)
        MsgBox("Selecciona un responsable de procesado para mostrar sus registros", vbOKOnly, "Consulta por Responsable")
        Try
            conex.Open()
            comando = conex.CreateCommand

            comando.CommandText = "SELECT Nombre FROM usuarios"
            lector = comando.ExecuteReader
            While lector.Read
                cboResponsables.Items.Add(lector(0))
            End While
            lector.Close()
        Catch
            MsgBox("Excepcion en el proceso de muestra de datos de la tabla procesado")
        End Try
    End Sub

    Private Sub cboResponsables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboResponsables.SelectedIndexChanged
        limpiarRejillas()
        Dim responsable As String = cboResponsables.Text

        comando.CommandText = "SELECT * FROM procesado WHERE ResponsableProcesado='" & responsable & "';"
        lector = comando.ExecuteReader
        While lector.Read
            dgProcesamiento.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
        If dgProcesamiento.RowCount = 0 Then
            dgProcesamiento.Enabled = False
            dgDetalleProcesado.Enabled = False
        Else
            dgProcesamiento.Enabled = True
            dgDetalleProcesado.Enabled = True
        End If
    End Sub

    Private Sub dgProcesamiento_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProcesamiento.CellDoubleClick
        Dim id As String
        dgDetalleProcesado.Rows.Clear()
        Try
            id = dgProcesamiento.CurrentRow.Cells(0).Value.ToString
            comando.CommandText = "Select * FROM detprocesado WHERE IdProcesado = " & id
            lector = comando.ExecuteReader
            While lector.Read
                dgDetalleProcesado.Rows.Add(lector(1), lector(2), lector(3), lector(4), lector(5), lector(6),
                    lector(7), lector(8), lector(9), lector(10), lector(11), lector(12), lector(13))
            End While
            lector.Close()
            txtIdProcesado.Text = id
        Catch ex As Exception
            MsgBox("Excepcion encontrada en el proceso de muestra de datos del detalle de procesado: " & ex.Message)
        End Try
        dgDetalleProcesado.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub limpiarRejillas()
        dgProcesamiento.Rows.Clear()
        dgDetalleProcesado.Rows.Clear()
        txtIdProcesado.Clear()
    End Sub
End Class