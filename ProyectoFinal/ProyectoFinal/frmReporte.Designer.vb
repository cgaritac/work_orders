<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporte))
        Me.txtReportNumOrden = New System.Windows.Forms.TextBox()
        Me.lblReportNumOrden = New System.Windows.Forms.Label()
        Me.dtpReportFechaOrden = New System.Windows.Forms.DateTimePicker()
        Me.lblReportFechaFinal = New System.Windows.Forms.Label()
        Me.mnuCrear = New System.Windows.Forms.ToolStrip()
        Me.tsbReportBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tsbReportLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.tsbReportCerrar = New System.Windows.Forms.ToolStripButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ptbUsuarioIm = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbReportTipoCons = New System.Windows.Forms.ComboBox()
        Me.lblReportFechaOrden = New System.Windows.Forms.Label()
        Me.dtpReportFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbReportEstado = New System.Windows.Forms.ComboBox()
        Me.lblReportEstado = New System.Windows.Forms.Label()
        Me.dgvReporte = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Plazo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRealEjec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCierreOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Solicitante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoEnsayo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadMuEnsay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoMuestra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPrueba = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Responsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prioridad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservCrear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservCierre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnuCrear.SuspendLayout()
        CType(Me.ptbUsuarioIm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtReportNumOrden
        '
        Me.txtReportNumOrden.Enabled = False
        Me.txtReportNumOrden.Location = New System.Drawing.Point(46, 56)
        Me.txtReportNumOrden.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtReportNumOrden.Name = "txtReportNumOrden"
        Me.txtReportNumOrden.Size = New System.Drawing.Size(154, 28)
        Me.txtReportNumOrden.TabIndex = 93
        '
        'lblReportNumOrden
        '
        Me.lblReportNumOrden.AutoSize = True
        Me.lblReportNumOrden.Enabled = False
        Me.lblReportNumOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportNumOrden.Location = New System.Drawing.Point(29, 25)
        Me.lblReportNumOrden.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblReportNumOrden.Name = "lblReportNumOrden"
        Me.lblReportNumOrden.Size = New System.Drawing.Size(190, 24)
        Me.lblReportNumOrden.TabIndex = 92
        Me.lblReportNumOrden.Text = "N° Orden de Trabajo:"
        '
        'dtpReportFechaOrden
        '
        Me.dtpReportFechaOrden.Enabled = False
        Me.dtpReportFechaOrden.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReportFechaOrden.Location = New System.Drawing.Point(294, 56)
        Me.dtpReportFechaOrden.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpReportFechaOrden.Name = "dtpReportFechaOrden"
        Me.dtpReportFechaOrden.Size = New System.Drawing.Size(210, 28)
        Me.dtpReportFechaOrden.TabIndex = 123
        '
        'lblReportFechaFinal
        '
        Me.lblReportFechaFinal.AutoSize = True
        Me.lblReportFechaFinal.Enabled = False
        Me.lblReportFechaFinal.Location = New System.Drawing.Point(549, 26)
        Me.lblReportFechaFinal.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblReportFechaFinal.Name = "lblReportFechaFinal"
        Me.lblReportFechaFinal.Size = New System.Drawing.Size(292, 24)
        Me.lblReportFechaFinal.TabIndex = 122
        Me.lblReportFechaFinal.Text = "Fecha cierre de orden de trabajo:"
        '
        'mnuCrear
        '
        Me.mnuCrear.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.mnuCrear.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuCrear.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbReportBuscar, Me.tsbReportLimpiar, Me.tsbReportCerrar})
        Me.mnuCrear.Location = New System.Drawing.Point(0, 0)
        Me.mnuCrear.Name = "mnuCrear"
        Me.mnuCrear.Size = New System.Drawing.Size(1182, 27)
        Me.mnuCrear.TabIndex = 127
        Me.mnuCrear.Text = "menuCrear"
        '
        'tsbReportBuscar
        '
        Me.tsbReportBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbReportBuscar.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.tsbReportBuscar.Image = CType(resources.GetObject("tsbReportBuscar.Image"), System.Drawing.Image)
        Me.tsbReportBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbReportBuscar.Name = "tsbReportBuscar"
        Me.tsbReportBuscar.Size = New System.Drawing.Size(24, 24)
        Me.tsbReportBuscar.Text = "ToolStripButton1"
        '
        'tsbReportLimpiar
        '
        Me.tsbReportLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbReportLimpiar.Image = CType(resources.GetObject("tsbReportLimpiar.Image"), System.Drawing.Image)
        Me.tsbReportLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbReportLimpiar.Name = "tsbReportLimpiar"
        Me.tsbReportLimpiar.Size = New System.Drawing.Size(24, 24)
        Me.tsbReportLimpiar.Text = "ToolStripButton2"
        '
        'tsbReportCerrar
        '
        Me.tsbReportCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbReportCerrar.Image = CType(resources.GetObject("tsbReportCerrar.Image"), System.Drawing.Image)
        Me.tsbReportCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbReportCerrar.Name = "tsbReportCerrar"
        Me.tsbReportCerrar.Size = New System.Drawing.Size(24, 24)
        Me.tsbReportCerrar.Text = "ToolStripButton1"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label22.Location = New System.Drawing.Point(456, 74)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(437, 39)
        Me.Label22.TabIndex = 126
        Me.Label22.Text = "Reporte Orden de Trabajo"
        '
        'ptbUsuarioIm
        '
        Me.ptbUsuarioIm.BackColor = System.Drawing.Color.Azure
        Me.ptbUsuarioIm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbUsuarioIm.Image = Global.ProyectoFinal.My.Resources.Resources.descarga
        Me.ptbUsuarioIm.Location = New System.Drawing.Point(288, 30)
        Me.ptbUsuarioIm.Margin = New System.Windows.Forms.Padding(4)
        Me.ptbUsuarioIm.Name = "ptbUsuarioIm"
        Me.ptbUsuarioIm.Size = New System.Drawing.Size(144, 125)
        Me.ptbUsuarioIm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbUsuarioIm.TabIndex = 128
        Me.ptbUsuarioIm.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 220)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 24)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Tipo de consulta"
        '
        'cbReportTipoCons
        '
        Me.cbReportTipoCons.FormattingEnabled = True
        Me.cbReportTipoCons.Items.AddRange(New Object() {"N° Orden de trabajo", "Fecha inicial orden de trabajo", "Fecha cierre orden de trabajo", "Estado de Orden de trabajo"})
        Me.cbReportTipoCons.Location = New System.Drawing.Point(229, 217)
        Me.cbReportTipoCons.Name = "cbReportTipoCons"
        Me.cbReportTipoCons.Size = New System.Drawing.Size(235, 30)
        Me.cbReportTipoCons.TabIndex = 130
        '
        'lblReportFechaOrden
        '
        Me.lblReportFechaOrden.AutoSize = True
        Me.lblReportFechaOrden.Enabled = False
        Me.lblReportFechaOrden.Location = New System.Drawing.Point(279, 25)
        Me.lblReportFechaOrden.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblReportFechaOrden.Name = "lblReportFechaOrden"
        Me.lblReportFechaOrden.Size = New System.Drawing.Size(239, 24)
        Me.lblReportFechaOrden.TabIndex = 131
        Me.lblReportFechaOrden.Text = "Fecha de orden de trabajo:"
        '
        'dtpReportFechaFinal
        '
        Me.dtpReportFechaFinal.Enabled = False
        Me.dtpReportFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReportFechaFinal.Location = New System.Drawing.Point(587, 54)
        Me.dtpReportFechaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpReportFechaFinal.Name = "dtpReportFechaFinal"
        Me.dtpReportFechaFinal.Size = New System.Drawing.Size(210, 28)
        Me.dtpReportFechaFinal.TabIndex = 132
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbReportEstado)
        Me.Panel1.Controls.Add(Me.lblReportEstado)
        Me.Panel1.Controls.Add(Me.lblReportNumOrden)
        Me.Panel1.Controls.Add(Me.dtpReportFechaFinal)
        Me.Panel1.Controls.Add(Me.txtReportNumOrden)
        Me.Panel1.Controls.Add(Me.lblReportFechaOrden)
        Me.Panel1.Controls.Add(Me.dtpReportFechaOrden)
        Me.Panel1.Controls.Add(Me.lblReportFechaFinal)
        Me.Panel1.Location = New System.Drawing.Point(13, 279)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1156, 107)
        Me.Panel1.TabIndex = 133
        '
        'cbReportEstado
        '
        Me.cbReportEstado.Enabled = False
        Me.cbReportEstado.FormattingEnabled = True
        Me.cbReportEstado.Items.AddRange(New Object() {"Abortado", "Cerrado"})
        Me.cbReportEstado.Location = New System.Drawing.Point(949, 52)
        Me.cbReportEstado.Name = "cbReportEstado"
        Me.cbReportEstado.Size = New System.Drawing.Size(121, 30)
        Me.cbReportEstado.TabIndex = 134
        '
        'lblReportEstado
        '
        Me.lblReportEstado.AutoSize = True
        Me.lblReportEstado.Enabled = False
        Me.lblReportEstado.Location = New System.Drawing.Point(887, 26)
        Me.lblReportEstado.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblReportEstado.Name = "lblReportEstado"
        Me.lblReportEstado.Size = New System.Drawing.Size(243, 24)
        Me.lblReportEstado.TabIndex = 133
        Me.lblReportEstado.Text = "Estado de orden de trabajo:"
        '
        'dgvReporte
        '
        Me.dgvReporte.AllowUserToAddRows = False
        Me.dgvReporte.AllowUserToDeleteRows = False
        Me.dgvReporte.AllowUserToResizeColumns = False
        Me.dgvReporte.AllowUserToResizeRows = False
        Me.dgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReporte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.FechaOrden, Me.Plazo, Me.FechaFinal, Me.FechaRealEjec, Me.FechaCierreOrden, Me.Estad, Me.Solicitante, Me.TipoEnsayo, Me.CantidadMuEnsay, Me.TipoMuestra, Me.TipoPrueba, Me.Responsable, Me.NombreCliente, Me.TipoCliente, Me.Prioridad, Me.ObservCrear, Me.ObservCierre})
        Me.dgvReporte.Location = New System.Drawing.Point(13, 405)
        Me.dgvReporte.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvReporte.Name = "dgvReporte"
        Me.dgvReporte.RowHeadersVisible = False
        Me.dgvReporte.RowTemplate.Height = 24
        Me.dgvReporte.Size = New System.Drawing.Size(1156, 269)
        Me.dgvReporte.TabIndex = 135
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "N° Orden"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 109
        '
        'FechaOrden
        '
        Me.FechaOrden.HeaderText = "Fecha de Orden"
        Me.FechaOrden.Name = "FechaOrden"
        Me.FechaOrden.Width = 163
        '
        'Plazo
        '
        Me.Plazo.HeaderText = "Días plazo"
        Me.Plazo.Name = "Plazo"
        Me.Plazo.Width = 115
        '
        'FechaFinal
        '
        Me.FechaFinal.HeaderText = "Fecha Estimada Ejecución"
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Width = 241
        '
        'FechaRealEjec
        '
        Me.FechaRealEjec.HeaderText = "Fecha Ejecución"
        Me.FechaRealEjec.Name = "FechaRealEjec"
        Me.FechaRealEjec.Width = 167
        '
        'FechaCierreOrden
        '
        Me.FechaCierreOrden.HeaderText = "Fecha Cierre Orden"
        Me.FechaCierreOrden.Name = "FechaCierreOrden"
        Me.FechaCierreOrden.Width = 190
        '
        'Estad
        '
        Me.Estad.HeaderText = "Estado"
        Me.Estad.Name = "Estad"
        Me.Estad.Width = 97
        '
        'Solicitante
        '
        Me.Solicitante.HeaderText = "Solicitante"
        Me.Solicitante.Name = "Solicitante"
        Me.Solicitante.Width = 124
        '
        'TipoEnsayo
        '
        Me.TipoEnsayo.HeaderText = "Tipo de Ensayo"
        Me.TipoEnsayo.Name = "TipoEnsayo"
        Me.TipoEnsayo.Width = 157
        '
        'CantidadMuEnsay
        '
        Me.CantidadMuEnsay.HeaderText = "Cantidad Muestras por Ensayo"
        Me.CantidadMuEnsay.Name = "CantidadMuEnsay"
        Me.CantidadMuEnsay.Width = 211
        '
        'TipoMuestra
        '
        Me.TipoMuestra.HeaderText = "Tipo de Muestra"
        Me.TipoMuestra.Name = "TipoMuestra"
        Me.TipoMuestra.Width = 161
        '
        'TipoPrueba
        '
        Me.TipoPrueba.HeaderText = "Tipo de Prueba"
        Me.TipoPrueba.Name = "TipoPrueba"
        Me.TipoPrueba.Width = 155
        '
        'Responsable
        '
        Me.Responsable.HeaderText = "Responsable"
        Me.Responsable.Name = "Responsable"
        Me.Responsable.Width = 150
        '
        'NombreCliente
        '
        Me.NombreCliente.HeaderText = "Nombre Cliente"
        Me.NombreCliente.Name = "NombreCliente"
        Me.NombreCliente.Width = 156
        '
        'TipoCliente
        '
        Me.TipoCliente.HeaderText = "Tipo Cliente"
        Me.TipoCliente.Name = "TipoCliente"
        Me.TipoCliente.Width = 128
        '
        'Prioridad
        '
        Me.Prioridad.HeaderText = "Prioridad"
        Me.Prioridad.Name = "Prioridad"
        Me.Prioridad.Width = 114
        '
        'ObservCrear
        '
        Me.ObservCrear.HeaderText = "Observaciones iniciales"
        Me.ObservCrear.Name = "ObservCrear"
        Me.ObservCrear.Width = 217
        '
        'ObservCierre
        '
        Me.ObservCierre.HeaderText = "Observaciones Cierre"
        Me.ObservCierre.Name = "ObservCierre"
        Me.ObservCierre.Width = 202
        '
        'frmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1182, 692)
        Me.Controls.Add(Me.dgvReporte)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbReportTipoCons)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ptbUsuarioIm)
        Me.Controls.Add(Me.mnuCrear)
        Me.Controls.Add(Me.Label22)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReporte"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ventana Reporte"
        Me.mnuCrear.ResumeLayout(False)
        Me.mnuCrear.PerformLayout()
        CType(Me.ptbUsuarioIm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtReportNumOrden As TextBox
    Friend WithEvents lblReportNumOrden As Label
    Friend WithEvents dtpReportFechaOrden As DateTimePicker
    Friend WithEvents lblReportFechaFinal As Label
    Friend WithEvents ptbUsuarioIm As PictureBox
    Friend WithEvents mnuCrear As ToolStrip
    Friend WithEvents tsbReportBuscar As ToolStripButton
    Friend WithEvents tsbReportLimpiar As ToolStripButton
    Friend WithEvents Label22 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbReportTipoCons As ComboBox
    Friend WithEvents lblReportFechaOrden As Label
    Friend WithEvents dtpReportFechaFinal As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblReportEstado As Label
    Friend WithEvents cbReportEstado As ComboBox
    Friend WithEvents tsbReportCerrar As ToolStripButton
    Friend WithEvents dgvReporte As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FechaOrden As DataGridViewTextBoxColumn
    Friend WithEvents Plazo As DataGridViewTextBoxColumn
    Friend WithEvents FechaFinal As DataGridViewTextBoxColumn
    Friend WithEvents FechaRealEjec As DataGridViewTextBoxColumn
    Friend WithEvents FechaCierreOrden As DataGridViewTextBoxColumn
    Friend WithEvents Estad As DataGridViewTextBoxColumn
    Friend WithEvents Solicitante As DataGridViewTextBoxColumn
    Friend WithEvents TipoEnsayo As DataGridViewTextBoxColumn
    Friend WithEvents CantidadMuEnsay As DataGridViewTextBoxColumn
    Friend WithEvents TipoMuestra As DataGridViewTextBoxColumn
    Friend WithEvents TipoPrueba As DataGridViewTextBoxColumn
    Friend WithEvents Responsable As DataGridViewTextBoxColumn
    Friend WithEvents NombreCliente As DataGridViewTextBoxColumn
    Friend WithEvents TipoCliente As DataGridViewTextBoxColumn
    Friend WithEvents Prioridad As DataGridViewTextBoxColumn
    Friend WithEvents ObservCrear As DataGridViewTextBoxColumn
    Friend WithEvents ObservCierre As DataGridViewTextBoxColumn
End Class
