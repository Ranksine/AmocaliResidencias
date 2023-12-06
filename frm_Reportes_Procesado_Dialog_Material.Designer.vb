<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Reportes_Procesado_Dialog_Material
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
        Me.cboMateriales = New System.Windows.Forms.ComboBox()
        Me.lblTextoDin = New System.Windows.Forms.Label()
        Me.PnTitulo = New System.Windows.Forms.Panel()
        Me.PnMaterial = New System.Windows.Forms.Panel()
        Me.PnBotones = New System.Windows.Forms.Panel()
        Me.PnFechas = New System.Windows.Forms.Panel()
        Me.lblF2 = New System.Windows.Forms.Label()
        Me.lblF1 = New System.Windows.Forms.Label()
        Me.dtFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.PnTitulo.SuspendLayout()
        Me.PnMaterial.SuspendLayout()
        Me.PnBotones.SuspendLayout()
        Me.PnFechas.SuspendLayout()
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
        Me.btnCancelar.Location = New System.Drawing.Point(12, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(160, 49)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.DimGray
        Me.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiguiente.Enabled = False
        Me.btnSiguiente.FlatAppearance.BorderSize = 0
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.Color.White
        Me.btnSiguiente.Location = New System.Drawing.Point(349, 3)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(172, 49)
        Me.btnSiguiente.TabIndex = 16
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'cboMateriales
        '
        Me.cboMateriales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboMateriales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMateriales.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMateriales.FormattingEnabled = True
        Me.cboMateriales.Items.AddRange(New Object() {"Polietileno de Alta Densidad", "Polietileno", "Polipropileno", "Flexible", "Cartón", "Metal", "Placas de Fosfuro de Magnesio", "Revuelto", "Otro"})
        Me.cboMateriales.Location = New System.Drawing.Point(51, 8)
        Me.cboMateriales.Name = "cboMateriales"
        Me.cboMateriales.Size = New System.Drawing.Size(426, 40)
        Me.cboMateriales.TabIndex = 18
        '
        'lblTextoDin
        '
        Me.lblTextoDin.AutoSize = True
        Me.lblTextoDin.Font = New System.Drawing.Font("Arial", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoDin.ForeColor = System.Drawing.Color.White
        Me.lblTextoDin.Location = New System.Drawing.Point(104, 9)
        Me.lblTextoDin.Name = "lblTextoDin"
        Me.lblTextoDin.Size = New System.Drawing.Size(304, 32)
        Me.lblTextoDin.TabIndex = 4
        Me.lblTextoDin.Text = "Selecciona un Material"
        '
        'PnTitulo
        '
        Me.PnTitulo.BackColor = System.Drawing.Color.DimGray
        Me.PnTitulo.Controls.Add(Me.lblTextoDin)
        Me.PnTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PnTitulo.Name = "PnTitulo"
        Me.PnTitulo.Size = New System.Drawing.Size(533, 54)
        Me.PnTitulo.TabIndex = 17
        '
        'PnMaterial
        '
        Me.PnMaterial.BackColor = System.Drawing.Color.Transparent
        Me.PnMaterial.Controls.Add(Me.cboMateriales)
        Me.PnMaterial.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnMaterial.Location = New System.Drawing.Point(0, 54)
        Me.PnMaterial.Name = "PnMaterial"
        Me.PnMaterial.Size = New System.Drawing.Size(533, 54)
        Me.PnMaterial.TabIndex = 19
        '
        'PnBotones
        '
        Me.PnBotones.BackColor = System.Drawing.Color.Transparent
        Me.PnBotones.Controls.Add(Me.btnSiguiente)
        Me.PnBotones.Controls.Add(Me.btnCancelar)
        Me.PnBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnBotones.Location = New System.Drawing.Point(0, 122)
        Me.PnBotones.Name = "PnBotones"
        Me.PnBotones.Size = New System.Drawing.Size(533, 64)
        Me.PnBotones.TabIndex = 20
        '
        'PnFechas
        '
        Me.PnFechas.BackColor = System.Drawing.Color.Transparent
        Me.PnFechas.Controls.Add(Me.lblF2)
        Me.PnFechas.Controls.Add(Me.lblF1)
        Me.PnFechas.Controls.Add(Me.dtFechaIni)
        Me.PnFechas.Controls.Add(Me.dtFechaFin)
        Me.PnFechas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnFechas.Location = New System.Drawing.Point(0, 108)
        Me.PnFechas.Name = "PnFechas"
        Me.PnFechas.Size = New System.Drawing.Size(533, 117)
        Me.PnFechas.TabIndex = 21
        Me.PnFechas.Visible = False
        '
        'lblF2
        '
        Me.lblF2.AutoSize = True
        Me.lblF2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF2.ForeColor = System.Drawing.Color.Black
        Me.lblF2.Location = New System.Drawing.Point(347, 18)
        Me.lblF2.Name = "lblF2"
        Me.lblF2.Size = New System.Drawing.Size(130, 26)
        Me.lblF2.TabIndex = 18
        Me.lblF2.Text = "Fecha Final"
        Me.lblF2.Visible = False
        '
        'lblF1
        '
        Me.lblF1.AutoSize = True
        Me.lblF1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF1.ForeColor = System.Drawing.Color.Black
        Me.lblF1.Location = New System.Drawing.Point(46, 18)
        Me.lblF1.Name = "lblF1"
        Me.lblF1.Size = New System.Drawing.Size(139, 26)
        Me.lblF1.TabIndex = 19
        Me.lblF1.Text = "Fecha Inicial"
        Me.lblF1.Visible = False
        '
        'dtFechaIni
        '
        Me.dtFechaIni.Enabled = False
        Me.dtFechaIni.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaIni.Location = New System.Drawing.Point(26, 56)
        Me.dtFechaIni.Name = "dtFechaIni"
        Me.dtFechaIni.Size = New System.Drawing.Size(204, 39)
        Me.dtFechaIni.TabIndex = 16
        '
        'dtFechaFin
        '
        Me.dtFechaFin.Enabled = False
        Me.dtFechaFin.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFin.Location = New System.Drawing.Point(301, 56)
        Me.dtFechaFin.Name = "dtFechaFin"
        Me.dtFechaFin.Size = New System.Drawing.Size(204, 39)
        Me.dtFechaFin.TabIndex = 17
        '
        'frm_Reportes_Procesado_Dialog_Material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(533, 186)
        Me.Controls.Add(Me.PnBotones)
        Me.Controls.Add(Me.PnFechas)
        Me.Controls.Add(Me.PnMaterial)
        Me.Controls.Add(Me.PnTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Reportes_Procesado_Dialog_Material"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Reportes_Procesado_Dialog"
        Me.TopMost = True
        Me.PnTitulo.ResumeLayout(False)
        Me.PnTitulo.PerformLayout()
        Me.PnMaterial.ResumeLayout(False)
        Me.PnBotones.ResumeLayout(False)
        Me.PnFechas.ResumeLayout(False)
        Me.PnFechas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TmTransiciones As Timer
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents cboMateriales As ComboBox
    Friend WithEvents lblTextoDin As Label
    Friend WithEvents PnTitulo As Panel
    Friend WithEvents PnMaterial As Panel
    Friend WithEvents PnBotones As Panel
    Friend WithEvents PnFechas As Panel
    Friend WithEvents lblF2 As Label
    Friend WithEvents lblF1 As Label
    Friend WithEvents dtFechaIni As DateTimePicker
    Friend WithEvents dtFechaFin As DateTimePicker
End Class
