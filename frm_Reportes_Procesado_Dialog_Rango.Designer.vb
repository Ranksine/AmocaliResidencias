<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Reportes_Procesado_Dialog_Rango
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TmTransiciones = New System.Windows.Forms.Timer(Me.components)
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.lblF2 = New System.Windows.Forms.Label()
        Me.lblF1 = New System.Windows.Forms.Label()
        Me.dtFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTextoDin = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TmTransiciones
        '
        Me.TmTransiciones.Interval = 20
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.DimGray
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(12, 177)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(160, 49)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.DimGray
        Me.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiguiente.FlatAppearance.BorderSize = 0
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.Color.White
        Me.btnSiguiente.Location = New System.Drawing.Point(354, 177)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(172, 49)
        Me.btnSiguiente.TabIndex = 17
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'lblF2
        '
        Me.lblF2.AutoSize = True
        Me.lblF2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF2.ForeColor = System.Drawing.Color.Black
        Me.lblF2.Location = New System.Drawing.Point(349, 68)
        Me.lblF2.Name = "lblF2"
        Me.lblF2.Size = New System.Drawing.Size(130, 26)
        Me.lblF2.TabIndex = 14
        Me.lblF2.Text = "Fecha Final"
        Me.lblF2.Visible = False
        '
        'lblF1
        '
        Me.lblF1.AutoSize = True
        Me.lblF1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF1.ForeColor = System.Drawing.Color.Black
        Me.lblF1.Location = New System.Drawing.Point(48, 68)
        Me.lblF1.Name = "lblF1"
        Me.lblF1.Size = New System.Drawing.Size(139, 26)
        Me.lblF1.TabIndex = 15
        Me.lblF1.Text = "Fecha Inicial"
        Me.lblF1.Visible = False
        '
        'dtFechaIni
        '
        Me.dtFechaIni.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaIni.Location = New System.Drawing.Point(28, 106)
        Me.dtFechaIni.Name = "dtFechaIni"
        Me.dtFechaIni.Size = New System.Drawing.Size(204, 39)
        Me.dtFechaIni.TabIndex = 12
        '
        'dtFechaFin
        '
        Me.dtFechaFin.Enabled = False
        Me.dtFechaFin.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFin.Location = New System.Drawing.Point(303, 106)
        Me.dtFechaFin.Name = "dtFechaFin"
        Me.dtFechaFin.Size = New System.Drawing.Size(204, 39)
        Me.dtFechaFin.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.lblTextoDin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(537, 54)
        Me.Panel1.TabIndex = 11
        '
        'lblTextoDin
        '
        Me.lblTextoDin.AutoSize = True
        Me.lblTextoDin.Font = New System.Drawing.Font("Arial", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoDin.ForeColor = System.Drawing.Color.White
        Me.lblTextoDin.Location = New System.Drawing.Point(12, 9)
        Me.lblTextoDin.Name = "lblTextoDin"
        Me.lblTextoDin.Size = New System.Drawing.Size(422, 32)
        Me.lblTextoDin.TabIndex = 4
        Me.lblTextoDin.Text = "Selecciona un Rango de Fechas"
        '
        'frm_Reportes_Procesado_Dialog_Rango
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 238)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.lblF2)
        Me.Controls.Add(Me.lblF1)
        Me.Controls.Add(Me.dtFechaIni)
        Me.Controls.Add(Me.dtFechaFin)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Reportes_Procesado_Dialog_Rango"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Reportes_Procesado_Dialog"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TmTransiciones As Timer
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents lblF2 As Label
    Friend WithEvents lblF1 As Label
    Friend WithEvents dtFechaIni As DateTimePicker
    Friend WithEvents dtFechaFin As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTextoDin As Label
End Class
