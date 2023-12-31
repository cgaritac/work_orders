<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCerrarOrden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCerrarOrden))
        Me.txtCerrarNumOrden = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gbCerrarEstado = New System.Windows.Forms.GroupBox()
        Me.rbCerrado = New System.Windows.Forms.RadioButton()
        Me.rbAbortado = New System.Windows.Forms.RadioButton()
        Me.dtpCerrarFechaEjec = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCerrarObserv = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dgvCerrarOrden = New System.Windows.Forms.DataGridView()
        Me.mnuCrear = New System.Windows.Forms.ToolStrip()
        Me.tsbCierreGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCierreBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCierreLimipar = New System.Windows.Forms.ToolStripButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ptbUsuarioIm = New System.Windows.Forms.PictureBox()
        Me.NumOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEjec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCierre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tsbCerrarCerrar = New System.Windows.Forms.ToolStripButton()
        Me.gbCerrarEstado.SuspendLayout()
        CType(Me.dgvCerrarOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuCrear.SuspendLayout()
        CType(Me.ptbUsuarioIm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCerrarNumOrden
        '
        Me.txtCerrarNumOrden.Location = New System.Drawing.Point(248, 24)
        Me.txtCerrarNumOrden.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtCerrarNumOrden.Name = "txtCerrarNumOrden"
        Me.txtCerrarNumOrden.Size = New System.Drawing.Size(154, 28)
        Me.txtCerrarNumOrden.TabIndex = 93
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(210, 24)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "N° Orden de Trabajo:"
        '
        'gbCerrarEstado
        '
        Me.gbCerrarEstado.Controls.Add(Me.rbCerrado)
        Me.gbCerrarEstado.Controls.Add(Me.rbAbortado)
        Me.gbCerrarEstado.Location = New System.Drawing.Point(589, 24)
        Me.gbCerrarEstado.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.gbCerrarEstado.Name = "gbCerrarEstado"
        Me.gbCerrarEstado.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.gbCerrarEstado.Size = New System.Drawing.Size(214, 128)
        Me.gbCerrarEstado.TabIndex = 114
        Me.gbCerrarEstado.TabStop = False
        Me.gbCerrarEstado.Text = "Estado:"
        '
        'rbCerrado
        '
        Me.rbCerrado.AutoSize = True
        Me.rbCerrado.Enabled = False
        Me.rbCerrado.Location = New System.Drawing.Point(45, 73)
        Me.rbCerrado.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.rbCerrado.Name = "rbCerrado"
        Me.rbCerrado.Size = New System.Drawing.Size(99, 28)
        Me.rbCerrado.TabIndex = 14
        Me.rbCerrado.Text = "Cerrado"
        Me.rbCerrado.UseVisualStyleBackColor = True
        '
        'rbAbortado
        '
        Me.rbAbortado.AutoSize = True
        Me.rbAbortado.Enabled = False
        Me.rbAbortado.Location = New System.Drawing.Point(45, 33)
        Me.rbAbortado.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.rbAbortado.Name = "rbAbortado"
        Me.rbAbortado.Size = New System.Drawing.Size(108, 28)
        Me.rbAbortado.TabIndex = 13
        Me.rbAbortado.Text = "Abortado"
        Me.rbAbortado.UseVisualStyleBackColor = True
        '
        'dtpCerrarFechaEjec
        '
        Me.dtpCerrarFechaEjec.Enabled = False
        Me.dtpCerrarFechaEjec.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCerrarFechaEjec.Location = New System.Drawing.Point(291, 99)
        Me.dtpCerrarFechaEjec.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpCerrarFechaEjec.Name = "dtpCerrarFechaEjec"
        Me.dtpCerrarFechaEjec.Size = New System.Drawing.Size(160, 28)
        Me.dtpCerrarFechaEjec.TabIndex = 121
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(28, 104)
        Me.Label19.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(254, 24)
        Me.Label19.TabIndex = 120
        Me.Label19.Text = "Fecha ejecución del ensayo:"
        '
        'txtCerrarObserv
        '
        Me.txtCerrarObserv.Enabled = False
        Me.txtCerrarObserv.Location = New System.Drawing.Point(180, 171)
        Me.txtCerrarObserv.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtCerrarObserv.Multiline = True
        Me.txtCerrarObserv.Name = "txtCerrarObserv"
        Me.txtCerrarObserv.Size = New System.Drawing.Size(932, 131)
        Me.txtCerrarObserv.TabIndex = 125
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(28, 175)
        Me.Label23.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(142, 24)
        Me.Label23.TabIndex = 124
        Me.Label23.Text = "Observaciones:"
        '
        'dgvCerrarOrden
        '
        Me.dgvCerrarOrden.AllowUserToAddRows = False
        Me.dgvCerrarOrden.AllowUserToDeleteRows = False
        Me.dgvCerrarOrden.AllowUserToResizeColumns = False
        Me.dgvCerrarOrden.AllowUserToResizeRows = False
        Me.dgvCerrarOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCerrarOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCerrarOrden.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumOrden, Me.FechaEjec, Me.FechaCierre, Me.Estado, Me.Observaciones})
        Me.dgvCerrarOrden.Location = New System.Drawing.Point(16, 555)
        Me.dgvCerrarOrden.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dgvCerrarOrden.Name = "dgvCerrarOrden"
        Me.dgvCerrarOrden.RowHeadersVisible = False
        Me.dgvCerrarOrden.RowTemplate.Height = 24
        Me.dgvCerrarOrden.Size = New System.Drawing.Size(1141, 171)
        Me.dgvCerrarOrden.TabIndex = 126
        '
        'mnuCrear
        '
        Me.mnuCrear.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.mnuCrear.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuCrear.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCierreGuardar, Me.tsbCierreBuscar, Me.tsbCierreLimipar, Me.tsbCerrarCerrar})
        Me.mnuCrear.Location = New System.Drawing.Point(0, 0)
        Me.mnuCrear.Name = "mnuCrear"
        Me.mnuCrear.Size = New System.Drawing.Size(1182, 27)
        Me.mnuCrear.TabIndex = 128
        Me.mnuCrear.Text = "menuCrear"
        '
        'tsbCierreGuardar
        '
        Me.tsbCierreGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCierreGuardar.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.tsbCierreGuardar.Image = CType(resources.GetObject("tsbCierreGuardar.Image"), System.Drawing.Image)
        Me.tsbCierreGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCierreGuardar.Name = "tsbCierreGuardar"
        Me.tsbCierreGuardar.Size = New System.Drawing.Size(24, 24)
        Me.tsbCierreGuardar.Text = "ToolStripButton1"
        '
        'tsbCierreBuscar
        '
        Me.tsbCierreBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCierreBuscar.Image = CType(resources.GetObject("tsbCierreBuscar.Image"), System.Drawing.Image)
        Me.tsbCierreBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCierreBuscar.Name = "tsbCierreBuscar"
        Me.tsbCierreBuscar.Size = New System.Drawing.Size(24, 24)
        Me.tsbCierreBuscar.Text = "ToolStripButton3"
        '
        'tsbCierreLimipar
        '
        Me.tsbCierreLimipar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCierreLimipar.Image = CType(resources.GetObject("tsbCierreLimipar.Image"), System.Drawing.Image)
        Me.tsbCierreLimipar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCierreLimipar.Name = "tsbCierreLimipar"
        Me.tsbCierreLimipar.Size = New System.Drawing.Size(24, 24)
        Me.tsbCierreLimipar.Text = "ToolStripButton2"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label22.Location = New System.Drawing.Point(485, 63)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(411, 39)
        Me.Label22.TabIndex = 127
        Me.Label22.Text = "Cerrar Orden de Trabajo"
        '
        'ptbUsuarioIm
        '
        Me.ptbUsuarioIm.BackColor = System.Drawing.Color.Azure
        Me.ptbUsuarioIm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbUsuarioIm.Image = Global.ProyectoFinal.My.Resources.Resources.papel_texto_verificado_318_61628
        Me.ptbUsuarioIm.Location = New System.Drawing.Point(303, 31)
        Me.ptbUsuarioIm.Margin = New System.Windows.Forms.Padding(4)
        Me.ptbUsuarioIm.Name = "ptbUsuarioIm"
        Me.ptbUsuarioIm.Size = New System.Drawing.Size(146, 124)
        Me.ptbUsuarioIm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbUsuarioIm.TabIndex = 129
        Me.ptbUsuarioIm.TabStop = False
        '
        'NumOrden
        '
        Me.NumOrden.HeaderText = "N° Orden"
        Me.NumOrden.Name = "NumOrden"
        '
        'FechaEjec
        '
        Me.FechaEjec.HeaderText = "Fecha de Ejecución"
        Me.FechaEjec.Name = "FechaEjec"
        '
        'FechaCierre
        '
        Me.FechaCierre.HeaderText = "Fecha de Cierre"
        Me.FechaCierre.Name = "FechaCierre"
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtCerrarNumOrden)
        Me.Panel1.Controls.Add(Me.gbCerrarEstado)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.txtCerrarObserv)
        Me.Panel1.Controls.Add(Me.dtpCerrarFechaEjec)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Location = New System.Drawing.Point(16, 201)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1141, 334)
        Me.Panel1.TabIndex = 130
        '
        'tsbCerrarCerrar
        '
        Me.tsbCerrarCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCerrarCerrar.Image = CType(resources.GetObject("tsbCerrarCerrar.Image"), System.Drawing.Image)
        Me.tsbCerrarCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCerrarCerrar.Name = "tsbCerrarCerrar"
        Me.tsbCerrarCerrar.Size = New System.Drawing.Size(24, 24)
        Me.tsbCerrarCerrar.Text = "ToolStripButton1"
        '
        'frmCerrarOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.ptbUsuarioIm)
        Me.Controls.Add(Me.mnuCrear)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.dgvCerrarOrden)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCerrarOrden"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ventana Cerrar Orden de Trabajo"
        Me.gbCerrarEstado.ResumeLayout(False)
        Me.gbCerrarEstado.PerformLayout()
        CType(Me.dgvCerrarOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuCrear.ResumeLayout(False)
        Me.mnuCrear.PerformLayout()
        CType(Me.ptbUsuarioIm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCerrarNumOrden As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents gbCerrarEstado As GroupBox
    Friend WithEvents rbCerrado As RadioButton
    Friend WithEvents rbAbortado As RadioButton
    Friend WithEvents dtpCerrarFechaEjec As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCerrarObserv As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents dgvCerrarOrden As DataGridView
    Friend WithEvents ptbUsuarioIm As PictureBox
    Friend WithEvents mnuCrear As ToolStrip
    Friend WithEvents tsbCierreGuardar As ToolStripButton
    Friend WithEvents tsbCierreLimipar As ToolStripButton
    Friend WithEvents Label22 As Label
    Friend WithEvents tsbCierreBuscar As ToolStripButton
    Friend WithEvents NumOrden As DataGridViewTextBoxColumn
    Friend WithEvents FechaEjec As DataGridViewTextBoxColumn
    Friend WithEvents FechaCierre As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tsbCerrarCerrar As ToolStripButton
End Class
