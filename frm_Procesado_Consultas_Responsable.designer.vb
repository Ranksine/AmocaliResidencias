<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Procesado_Consultas_Responsable
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cboResponsables = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtIdProcesado = New System.Windows.Forms.TextBox()
        Me.dgDetalleProcesado = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Trit_Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Trit_PesoProm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Trit_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comp_Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comp_PesoProm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comp_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Agra_Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Agra_PesoProm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Agra_Placas_PFM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Agra_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Agra_Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgProcesamiento = New System.Windows.Forms.DataGridView()
        Me.IdProcesado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponsableProcesado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgDetalleProcesado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgProcesamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.cboResponsables)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(21, 96)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(582, 81)
        Me.Panel4.TabIndex = 18
        '
        'cboResponsables
        '
        Me.cboResponsables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboResponsables.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.cboResponsables.FormattingEnabled = True
        Me.cboResponsables.Location = New System.Drawing.Point(394, 20)
        Me.cboResponsables.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboResponsables.Name = "cboResponsables"
        Me.cboResponsables.Size = New System.Drawing.Size(171, 39)
        Me.cboResponsables.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(14, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(348, 38)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Selecciona un responsable"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.DimGray
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 16.2!)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(1177, 10)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(143, 53)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "Volver"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1332, 72)
        Me.Panel1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(964, 54)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Consulta de Procesado por Responsable Específico"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtIdProcesado)
        Me.Panel3.Controls.Add(Me.dgDetalleProcesado)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(21, 407)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1299, 314)
        Me.Panel3.TabIndex = 16
        '
        'txtIdProcesado
        '
        Me.txtIdProcesado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdProcesado.Enabled = False
        Me.txtIdProcesado.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.txtIdProcesado.Location = New System.Drawing.Point(1189, 15)
        Me.txtIdProcesado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdProcesado.Name = "txtIdProcesado"
        Me.txtIdProcesado.Size = New System.Drawing.Size(100, 38)
        Me.txtIdProcesado.TabIndex = 5
        '
        'dgDetalleProcesado
        '
        Me.dgDetalleProcesado.AllowUserToAddRows = False
        Me.dgDetalleProcesado.AllowUserToDeleteRows = False
        Me.dgDetalleProcesado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetalleProcesado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgDetalleProcesado.BackgroundColor = System.Drawing.Color.White
        Me.dgDetalleProcesado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalleProcesado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Trit_Cantidad, Me.Trit_PesoProm, Me.Trit_Total, Me.Comp_Cantidad, Me.Comp_PesoProm, Me.Comp_Total, Me.Agra_Cantidad, Me.Agra_PesoProm, Me.Agra_Placas_PFM, Me.Agra_Total, Me.Agra_Tipo, Me.TotalDet})
        Me.dgDetalleProcesado.Enabled = False
        Me.dgDetalleProcesado.Location = New System.Drawing.Point(21, 65)
        Me.dgDetalleProcesado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgDetalleProcesado.Name = "dgDetalleProcesado"
        Me.dgDetalleProcesado.ReadOnly = True
        Me.dgDetalleProcesado.RowHeadersWidth = 51
        Me.dgDetalleProcesado.RowTemplate.Height = 29
        Me.dgDetalleProcesado.Size = New System.Drawing.Size(1268, 233)
        Me.dgDetalleProcesado.TabIndex = 0
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 85
        '
        'Trit_Cantidad
        '
        Me.Trit_Cantidad.HeaderText = "Trit_Cantidad"
        Me.Trit_Cantidad.MinimumWidth = 6
        Me.Trit_Cantidad.Name = "Trit_Cantidad"
        Me.Trit_Cantidad.ReadOnly = True
        Me.Trit_Cantidad.Width = 116
        '
        'Trit_PesoProm
        '
        Me.Trit_PesoProm.HeaderText = "Trit_PesoProm"
        Me.Trit_PesoProm.MinimumWidth = 6
        Me.Trit_PesoProm.Name = "Trit_PesoProm"
        Me.Trit_PesoProm.ReadOnly = True
        Me.Trit_PesoProm.Width = 126
        '
        'Trit_Total
        '
        Me.Trit_Total.HeaderText = "Trit_Total"
        Me.Trit_Total.MinimumWidth = 6
        Me.Trit_Total.Name = "Trit_Total"
        Me.Trit_Total.ReadOnly = True
        Me.Trit_Total.Width = 93
        '
        'Comp_Cantidad
        '
        Me.Comp_Cantidad.HeaderText = "Comp_Cantidad"
        Me.Comp_Cantidad.MinimumWidth = 6
        Me.Comp_Cantidad.Name = "Comp_Cantidad"
        Me.Comp_Cantidad.ReadOnly = True
        Me.Comp_Cantidad.Width = 133
        '
        'Comp_PesoProm
        '
        Me.Comp_PesoProm.HeaderText = "Comp_PesoProm"
        Me.Comp_PesoProm.MinimumWidth = 6
        Me.Comp_PesoProm.Name = "Comp_PesoProm"
        Me.Comp_PesoProm.ReadOnly = True
        Me.Comp_PesoProm.Width = 143
        '
        'Comp_Total
        '
        Me.Comp_Total.HeaderText = "Comp_Total"
        Me.Comp_Total.MinimumWidth = 6
        Me.Comp_Total.Name = "Comp_Total"
        Me.Comp_Total.ReadOnly = True
        Me.Comp_Total.Width = 110
        '
        'Agra_Cantidad
        '
        Me.Agra_Cantidad.HeaderText = "Agra_Cantidad"
        Me.Agra_Cantidad.MinimumWidth = 6
        Me.Agra_Cantidad.Name = "Agra_Cantidad"
        Me.Agra_Cantidad.ReadOnly = True
        Me.Agra_Cantidad.Width = 126
        '
        'Agra_PesoProm
        '
        Me.Agra_PesoProm.HeaderText = "Agra_PesoProm"
        Me.Agra_PesoProm.MinimumWidth = 6
        Me.Agra_PesoProm.Name = "Agra_PesoProm"
        Me.Agra_PesoProm.ReadOnly = True
        Me.Agra_PesoProm.Width = 136
        '
        'Agra_Placas_PFM
        '
        Me.Agra_Placas_PFM.HeaderText = "Agra_Placas_PFM"
        Me.Agra_Placas_PFM.MinimumWidth = 6
        Me.Agra_Placas_PFM.Name = "Agra_Placas_PFM"
        Me.Agra_Placas_PFM.ReadOnly = True
        Me.Agra_Placas_PFM.Width = 149
        '
        'Agra_Total
        '
        Me.Agra_Total.HeaderText = "Agra_Total"
        Me.Agra_Total.MinimumWidth = 6
        Me.Agra_Total.Name = "Agra_Total"
        Me.Agra_Total.ReadOnly = True
        Me.Agra_Total.Width = 103
        '
        'Agra_Tipo
        '
        Me.Agra_Tipo.HeaderText = "Agra_Tipo"
        Me.Agra_Tipo.MinimumWidth = 6
        Me.Agra_Tipo.Name = "Agra_Tipo"
        Me.Agra_Tipo.ReadOnly = True
        '
        'TotalDet
        '
        Me.TotalDet.HeaderText = "Total (kg)"
        Me.TotalDet.MinimumWidth = 6
        Me.TotalDet.Name = "TotalDet"
        Me.TotalDet.ReadOnly = True
        Me.TotalDet.Width = 93
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.Label4.Location = New System.Drawing.Point(1133, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 31)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!)
        Me.Label3.Location = New System.Drawing.Point(14, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 38)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Detalle"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dgProcesamiento)
        Me.Panel2.Location = New System.Drawing.Point(629, 96)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(688, 289)
        Me.Panel2.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!)
        Me.Label2.Location = New System.Drawing.Point(10, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 38)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripción General"
        '
        'dgProcesamiento
        '
        Me.dgProcesamiento.AllowUserToAddRows = False
        Me.dgProcesamiento.AllowUserToDeleteRows = False
        Me.dgProcesamiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgProcesamiento.BackgroundColor = System.Drawing.Color.White
        Me.dgProcesamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProcesamiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProcesado, Me.IdCAT, Me.ResponsableProcesado, Me.Fecha, Me.TotalKg})
        Me.dgProcesamiento.Enabled = False
        Me.dgProcesamiento.Location = New System.Drawing.Point(15, 46)
        Me.dgProcesamiento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgProcesamiento.Name = "dgProcesamiento"
        Me.dgProcesamiento.ReadOnly = True
        Me.dgProcesamiento.RowHeadersWidth = 51
        Me.dgProcesamiento.RowTemplate.Height = 29
        Me.dgProcesamiento.Size = New System.Drawing.Size(666, 226)
        Me.dgProcesamiento.TabIndex = 0
        '
        'IdProcesado
        '
        Me.IdProcesado.HeaderText = "IdProcesado"
        Me.IdProcesado.MinimumWidth = 6
        Me.IdProcesado.Name = "IdProcesado"
        Me.IdProcesado.ReadOnly = True
        '
        'IdCAT
        '
        Me.IdCAT.HeaderText = "IdCAT"
        Me.IdCAT.MinimumWidth = 6
        Me.IdCAT.Name = "IdCAT"
        Me.IdCAT.ReadOnly = True
        '
        'ResponsableProcesado
        '
        Me.ResponsableProcesado.HeaderText = "Responsable"
        Me.ResponsableProcesado.MinimumWidth = 6
        Me.ResponsableProcesado.Name = "ResponsableProcesado"
        Me.ResponsableProcesado.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'TotalKg
        '
        Me.TotalKg.HeaderText = "Total (kg)"
        Me.TotalKg.MinimumWidth = 6
        Me.TotalKg.Name = "TotalKg"
        Me.TotalKg.ReadOnly = True
        '
        'frm_Procesado_Consultas_Responsable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 732)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_Procesado_Consultas_Responsable"
        Me.Text = "frm_Procesado_Consultas_Responsable"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgDetalleProcesado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgProcesamiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents cboResponsables As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtIdProcesado As TextBox
    Friend WithEvents dgDetalleProcesado As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Trit_Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Trit_PesoProm As DataGridViewTextBoxColumn
    Friend WithEvents Trit_Total As DataGridViewTextBoxColumn
    Friend WithEvents Comp_Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Comp_PesoProm As DataGridViewTextBoxColumn
    Friend WithEvents Comp_Total As DataGridViewTextBoxColumn
    Friend WithEvents Agra_Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Agra_PesoProm As DataGridViewTextBoxColumn
    Friend WithEvents Agra_Placas_PFM As DataGridViewTextBoxColumn
    Friend WithEvents Agra_Total As DataGridViewTextBoxColumn
    Friend WithEvents Agra_Tipo As DataGridViewTextBoxColumn
    Friend WithEvents TotalDet As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgProcesamiento As DataGridView
    Friend WithEvents IdProcesado As DataGridViewTextBoxColumn
    Friend WithEvents IdCAT As DataGridViewTextBoxColumn
    Friend WithEvents ResponsableProcesado As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents TotalKg As DataGridViewTextBoxColumn
End Class
