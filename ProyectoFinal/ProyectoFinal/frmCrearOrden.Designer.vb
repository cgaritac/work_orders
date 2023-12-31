<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCrearTipoPrueba
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrearTipoPrueba))
        Me.dgvCrearOrden = New System.Windows.Forms.DataGridView()
        Me.NumOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Solicitante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoEnsayo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadMuEnsay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoMuestra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPrueba = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Responsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prioridad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Plazo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCrearObserv = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCrearPlazo = New System.Windows.Forms.TextBox()
        Me.txtCrearCliente = New System.Windows.Forms.TextBox()
        Me.txtCrearSol = New System.Windows.Forms.TextBox()
        Me.txtCrearNumOrden = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.gbCrearTipoEns = New System.Windows.Forms.GroupBox()
        Me.chkMancha = New System.Windows.Forms.CheckBox()
        Me.chkViscosidad = New System.Windows.Forms.CheckBox()
        Me.chkGravEspec = New System.Windows.Forms.CheckBox()
        Me.chkCobalto = New System.Windows.Forms.CheckBox()
        Me.chkReom = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCrearSolicitante = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCrearFechaOrden = New System.Windows.Forms.TextBox()
        Me.numCrearCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbCrearTipoMuestra = New System.Windows.Forms.ComboBox()
        Me.cbCrearPrueba = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbCrearTipoClient = New System.Windows.Forms.GroupBox()
        Me.rbExterno = New System.Windows.Forms.RadioButton()
        Me.rbInterno = New System.Windows.Forms.RadioButton()
        Me.txtCrearRespons = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mnuCrear = New System.Windows.Forms.ToolStrip()
        Me.tsbCrearGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCrearLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCrearCerrar = New System.Windows.Forms.ToolStripButton()
        Me.vsbCrearPrioridad = New System.Windows.Forms.VScrollBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gbCrearPrioridad = New System.Windows.Forms.GroupBox()
        Me.ptbUsuarioIm = New System.Windows.Forms.PictureBox()
        Me.txtCrearFechaFinal = New System.Windows.Forms.TextBox()
        CType(Me.dgvCrearOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCrearTipoEns.SuspendLayout()
        CType(Me.numCrearCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCrearTipoClient.SuspendLayout()
        Me.mnuCrear.SuspendLayout()
        Me.gbCrearPrioridad.SuspendLayout()
        CType(Me.ptbUsuarioIm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCrearOrden
        '
        Me.dgvCrearOrden.AllowUserToAddRows = False
        Me.dgvCrearOrden.AllowUserToDeleteRows = False
        Me.dgvCrearOrden.AllowUserToResizeColumns = False
        Me.dgvCrearOrden.AllowUserToResizeRows = False
        Me.dgvCrearOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvCrearOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCrearOrden.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumOrden, Me.FechaOrden, Me.Solicitante, Me.TipoEnsayo, Me.CantidadMuEnsay, Me.TipoMuestra, Me.TipoPrueba, Me.Responsable, Me.NombreCliente, Me.TipoCliente, Me.Prioridad, Me.Plazo, Me.FechaFinal, Me.Observaciones})
        Me.dgvCrearOrden.Location = New System.Drawing.Point(13, 764)
        Me.dgvCrearOrden.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCrearOrden.Name = "dgvCrearOrden"
        Me.dgvCrearOrden.RowHeadersVisible = False
        Me.dgvCrearOrden.RowHeadersWidth = 102
        Me.dgvCrearOrden.RowTemplate.Height = 24
        Me.dgvCrearOrden.Size = New System.Drawing.Size(1134, 164)
        Me.dgvCrearOrden.TabIndex = 100
        '
        'NumOrden
        '
        Me.NumOrden.HeaderText = "N° Orden"
        Me.NumOrden.MinimumWidth = 12
        Me.NumOrden.Name = "NumOrden"
        Me.NumOrden.Width = 210
        '
        'FechaOrden
        '
        Me.FechaOrden.HeaderText = "Fecha de Orden"
        Me.FechaOrden.MinimumWidth = 12
        Me.FechaOrden.Name = "FechaOrden"
        Me.FechaOrden.Width = 314
        '
        'Solicitante
        '
        Me.Solicitante.HeaderText = "Solicitante"
        Me.Solicitante.MinimumWidth = 12
        Me.Solicitante.Name = "Solicitante"
        Me.Solicitante.Width = 244
        '
        'TipoEnsayo
        '
        Me.TipoEnsayo.HeaderText = "Tipo de Ensayo"
        Me.TipoEnsayo.MinimumWidth = 12
        Me.TipoEnsayo.Name = "TipoEnsayo"
        Me.TipoEnsayo.Width = 305
        '
        'CantidadMuEnsay
        '
        Me.CantidadMuEnsay.HeaderText = "Cantidad Muestras por Ensayo"
        Me.CantidadMuEnsay.MinimumWidth = 12
        Me.CantidadMuEnsay.Name = "CantidadMuEnsay"
        Me.CantidadMuEnsay.Width = 419
        '
        'TipoMuestra
        '
        Me.TipoMuestra.HeaderText = "Tipo de Muestra"
        Me.TipoMuestra.MinimumWidth = 12
        Me.TipoMuestra.Name = "TipoMuestra"
        Me.TipoMuestra.Width = 313
        '
        'TipoPrueba
        '
        Me.TipoPrueba.HeaderText = "Tipo de Prueba"
        Me.TipoPrueba.MinimumWidth = 12
        Me.TipoPrueba.Name = "TipoPrueba"
        Me.TipoPrueba.Width = 300
        '
        'Responsable
        '
        Me.Responsable.HeaderText = "Responsable"
        Me.Responsable.MinimumWidth = 12
        Me.Responsable.Name = "Responsable"
        Me.Responsable.Width = 292
        '
        'NombreCliente
        '
        Me.NombreCliente.HeaderText = "Nombre Cliente"
        Me.NombreCliente.MinimumWidth = 12
        Me.NombreCliente.Name = "NombreCliente"
        Me.NombreCliente.Width = 302
        '
        'TipoCliente
        '
        Me.TipoCliente.HeaderText = "Tipo Cliente"
        Me.TipoCliente.MinimumWidth = 12
        Me.TipoCliente.Name = "TipoCliente"
        Me.TipoCliente.Width = 249
        '
        'Prioridad
        '
        Me.Prioridad.HeaderText = "Prioridad"
        Me.Prioridad.MinimumWidth = 12
        Me.Prioridad.Name = "Prioridad"
        Me.Prioridad.Width = 221
        '
        'Plazo
        '
        Me.Plazo.HeaderText = "Días plazo"
        Me.Plazo.MinimumWidth = 12
        Me.Plazo.Name = "Plazo"
        Me.Plazo.Width = 227
        '
        'FechaFinal
        '
        Me.FechaFinal.HeaderText = "Fecha Finalización"
        Me.FechaFinal.MinimumWidth = 12
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Width = 351
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.MinimumWidth = 12
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Width = 323
        '
        'txtCrearObserv
        '
        Me.txtCrearObserv.Location = New System.Drawing.Point(779, 516)
        Me.txtCrearObserv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCrearObserv.Multiline = True
        Me.txtCrearObserv.Name = "txtCrearObserv"
        Me.txtCrearObserv.Size = New System.Drawing.Size(356, 189)
        Me.txtCrearObserv.TabIndex = 99
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(631, 519)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(279, 42)
        Me.Label23.TabIndex = 98
        Me.Label23.Text = "Observaciones:"
        '
        'txtCrearPlazo
        '
        Me.txtCrearPlazo.Enabled = False
        Me.txtCrearPlazo.Location = New System.Drawing.Point(779, 391)
        Me.txtCrearPlazo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCrearPlazo.Name = "txtCrearPlazo"
        Me.txtCrearPlazo.Size = New System.Drawing.Size(64, 49)
        Me.txtCrearPlazo.TabIndex = 94
        '
        'txtCrearCliente
        '
        Me.txtCrearCliente.Location = New System.Drawing.Point(809, 166)
        Me.txtCrearCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCrearCliente.Name = "txtCrearCliente"
        Me.txtCrearCliente.Size = New System.Drawing.Size(206, 49)
        Me.txtCrearCliente.TabIndex = 93
        '
        'txtCrearSol
        '
        Me.txtCrearSol.Enabled = False
        Me.txtCrearSol.Location = New System.Drawing.Point(232, 166)
        Me.txtCrearSol.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCrearSol.Name = "txtCrearSol"
        Me.txtCrearSol.Size = New System.Drawing.Size(188, 49)
        Me.txtCrearSol.TabIndex = 92
        '
        'txtCrearNumOrden
        '
        Me.txtCrearNumOrden.Enabled = False
        Me.txtCrearNumOrden.Location = New System.Drawing.Point(1001, 33)
        Me.txtCrearNumOrden.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCrearNumOrden.Name = "txtCrearNumOrden"
        Me.txtCrearNumOrden.Size = New System.Drawing.Size(124, 49)
        Me.txtCrearNumOrden.TabIndex = 91
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(28, 444)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(537, 42)
        Me.Label20.TabIndex = 89
        Me.Label20.Text = "Cantidad muestras por ensayo:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(631, 453)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(541, 42)
        Me.Label19.TabIndex = 88
        Me.Label19.Text = "Fecha estimada de finalización:"
        '
        'gbCrearTipoEns
        '
        Me.gbCrearTipoEns.Controls.Add(Me.chkMancha)
        Me.gbCrearTipoEns.Controls.Add(Me.chkViscosidad)
        Me.gbCrearTipoEns.Controls.Add(Me.chkGravEspec)
        Me.gbCrearTipoEns.Controls.Add(Me.chkCobalto)
        Me.gbCrearTipoEns.Controls.Add(Me.chkReom)
        Me.gbCrearTipoEns.Location = New System.Drawing.Point(32, 224)
        Me.gbCrearTipoEns.Margin = New System.Windows.Forms.Padding(4)
        Me.gbCrearTipoEns.Name = "gbCrearTipoEns"
        Me.gbCrearTipoEns.Padding = New System.Windows.Forms.Padding(4)
        Me.gbCrearTipoEns.Size = New System.Drawing.Size(430, 183)
        Me.gbCrearTipoEns.TabIndex = 85
        Me.gbCrearTipoEns.TabStop = False
        Me.gbCrearTipoEns.Text = "Tipo de Ensayo:"
        '
        'chkMancha
        '
        Me.chkMancha.AutoSize = True
        Me.chkMancha.Location = New System.Drawing.Point(211, 87)
        Me.chkMancha.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMancha.Name = "chkMancha"
        Me.chkMancha.Size = New System.Drawing.Size(190, 46)
        Me.chkMancha.TabIndex = 14
        Me.chkMancha.Text = "Mancha"
        Me.chkMancha.UseVisualStyleBackColor = True
        '
        'chkViscosidad
        '
        Me.chkViscosidad.AutoSize = True
        Me.chkViscosidad.Location = New System.Drawing.Point(17, 42)
        Me.chkViscosidad.Margin = New System.Windows.Forms.Padding(4)
        Me.chkViscosidad.Name = "chkViscosidad"
        Me.chkViscosidad.Size = New System.Drawing.Size(238, 46)
        Me.chkViscosidad.TabIndex = 10
        Me.chkViscosidad.Text = "Viscosidad"
        Me.chkViscosidad.UseVisualStyleBackColor = True
        '
        'chkGravEspec
        '
        Me.chkGravEspec.AutoSize = True
        Me.chkGravEspec.Location = New System.Drawing.Point(211, 42)
        Me.chkGravEspec.Margin = New System.Windows.Forms.Padding(4)
        Me.chkGravEspec.Name = "chkGravEspec"
        Me.chkGravEspec.Size = New System.Drawing.Size(398, 46)
        Me.chkGravEspec.TabIndex = 11
        Me.chkGravEspec.Text = "Gravedad específica"
        Me.chkGravEspec.UseVisualStyleBackColor = True
        '
        'chkCobalto
        '
        Me.chkCobalto.AutoSize = True
        Me.chkCobalto.Location = New System.Drawing.Point(17, 87)
        Me.chkCobalto.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCobalto.Name = "chkCobalto"
        Me.chkCobalto.Size = New System.Drawing.Size(185, 46)
        Me.chkCobalto.TabIndex = 13
        Me.chkCobalto.Text = "Cobalto"
        Me.chkCobalto.UseVisualStyleBackColor = True
        '
        'chkReom
        '
        Me.chkReom.AutoSize = True
        Me.chkReom.Location = New System.Drawing.Point(17, 133)
        Me.chkReom.Margin = New System.Windows.Forms.Padding(4)
        Me.chkReom.Name = "chkReom"
        Me.chkReom.Size = New System.Drawing.Size(227, 46)
        Me.chkReom.TabIndex = 12
        Me.chkReom.Text = "Reometría"
        Me.chkReom.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(631, 394)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(283, 42)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Plazo estimado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(631, 169)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(338, 42)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Nombre del cliente:"
        '
        'lblCrearSolicitante
        '
        Me.lblCrearSolicitante.AutoSize = True
        Me.lblCrearSolicitante.Location = New System.Drawing.Point(28, 169)
        Me.lblCrearSolicitante.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCrearSolicitante.Name = "lblCrearSolicitante"
        Me.lblCrearSolicitante.Size = New System.Drawing.Size(397, 42)
        Me.lblCrearSolicitante.TabIndex = 81
        Me.lblCrearSolicitante.Text = "Solicitante de la orden:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(926, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 42)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Fecha:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(792, 36)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(393, 42)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "N° Orden de Trabajo:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label22.Location = New System.Drawing.Point(389, 63)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(758, 76)
        Me.Label22.TabIndex = 106
        Me.Label22.Text = "Crear Orden de Trabajo"
        '
        'txtCrearFechaOrden
        '
        Me.txtCrearFechaOrden.Enabled = False
        Me.txtCrearFechaOrden.Location = New System.Drawing.Point(1001, 86)
        Me.txtCrearFechaOrden.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCrearFechaOrden.Name = "txtCrearFechaOrden"
        Me.txtCrearFechaOrden.Size = New System.Drawing.Size(168, 49)
        Me.txtCrearFechaOrden.TabIndex = 107
        '
        'numCrearCantidad
        '
        Me.numCrearCantidad.Location = New System.Drawing.Point(300, 442)
        Me.numCrearCantidad.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numCrearCantidad.Name = "numCrearCantidad"
        Me.numCrearCantidad.Size = New System.Drawing.Size(68, 49)
        Me.numCrearCantidad.TabIndex = 108
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 511)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(297, 42)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Tipo de muestra:"
        '
        'cbCrearTipoMuestra
        '
        Me.cbCrearTipoMuestra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCrearTipoMuestra.FormattingEnabled = True
        Me.cbCrearTipoMuestra.Items.AddRange(New Object() {"Hule A", "Hule B", "Hule C", "Hule D", "Hule E", "Hule F", "Hule G", "Hule H"})
        Me.cbCrearTipoMuestra.Location = New System.Drawing.Point(187, 508)
        Me.cbCrearTipoMuestra.Name = "cbCrearTipoMuestra"
        Me.cbCrearTipoMuestra.Size = New System.Drawing.Size(159, 50)
        Me.cbCrearTipoMuestra.TabIndex = 110
        '
        'cbCrearPrueba
        '
        Me.cbCrearPrueba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCrearPrueba.FormattingEnabled = True
        Me.cbCrearPrueba.Items.AddRange(New Object() {"Producción regular", "Experimental", "Desarrollo de hule", "Investigación de calidad", "Auditoría"})
        Me.cbCrearPrueba.Location = New System.Drawing.Point(187, 574)
        Me.cbCrearPrueba.Name = "cbCrearPrueba"
        Me.cbCrearPrueba.Size = New System.Drawing.Size(159, 50)
        Me.cbCrearPrueba.TabIndex = 112
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 577)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(280, 42)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Tipo de prueba:"
        '
        'gbCrearTipoClient
        '
        Me.gbCrearTipoClient.Controls.Add(Me.rbExterno)
        Me.gbCrearTipoClient.Controls.Add(Me.rbInterno)
        Me.gbCrearTipoClient.Location = New System.Drawing.Point(635, 208)
        Me.gbCrearTipoClient.Margin = New System.Windows.Forms.Padding(4)
        Me.gbCrearTipoClient.Name = "gbCrearTipoClient"
        Me.gbCrearTipoClient.Padding = New System.Windows.Forms.Padding(4)
        Me.gbCrearTipoClient.Size = New System.Drawing.Size(171, 164)
        Me.gbCrearTipoClient.TabIndex = 113
        Me.gbCrearTipoClient.TabStop = False
        Me.gbCrearTipoClient.Text = "Tipo de cliente:"
        '
        'rbExterno
        '
        Me.rbExterno.AutoSize = True
        Me.rbExterno.Location = New System.Drawing.Point(33, 93)
        Me.rbExterno.Margin = New System.Windows.Forms.Padding(4)
        Me.rbExterno.Name = "rbExterno"
        Me.rbExterno.Size = New System.Drawing.Size(184, 46)
        Me.rbExterno.TabIndex = 14
        Me.rbExterno.TabStop = True
        Me.rbExterno.Text = "Externo"
        Me.rbExterno.UseVisualStyleBackColor = True
        '
        'rbInterno
        '
        Me.rbInterno.AutoSize = True
        Me.rbInterno.Checked = True
        Me.rbInterno.Location = New System.Drawing.Point(33, 57)
        Me.rbInterno.Margin = New System.Windows.Forms.Padding(4)
        Me.rbInterno.Name = "rbInterno"
        Me.rbInterno.Size = New System.Drawing.Size(170, 46)
        Me.rbInterno.TabIndex = 13
        Me.rbInterno.TabStop = True
        Me.rbInterno.Text = "Interno"
        Me.rbInterno.UseVisualStyleBackColor = True
        '
        'txtCrearRespons
        '
        Me.txtCrearRespons.Location = New System.Drawing.Point(297, 645)
        Me.txtCrearRespons.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCrearRespons.Name = "txtCrearRespons"
        Me.txtCrearRespons.Size = New System.Drawing.Size(188, 49)
        Me.txtCrearRespons.TabIndex = 117
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 648)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(526, 42)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Responsable realizar pruebas:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(851, 394)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 42)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "días"
        '
        'mnuCrear
        '
        Me.mnuCrear.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.mnuCrear.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuCrear.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCrearGuardar, Me.tsbCrearLimpiar, Me.tsbCrearCerrar})
        Me.mnuCrear.Location = New System.Drawing.Point(0, 0)
        Me.mnuCrear.Name = "mnuCrear"
        Me.mnuCrear.Size = New System.Drawing.Size(1264, 31)
        Me.mnuCrear.TabIndex = 121
        Me.mnuCrear.Text = "menuCrear"
        '
        'tsbCrearGuardar
        '
        Me.tsbCrearGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCrearGuardar.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.tsbCrearGuardar.Image = CType(resources.GetObject("tsbCrearGuardar.Image"), System.Drawing.Image)
        Me.tsbCrearGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCrearGuardar.Name = "tsbCrearGuardar"
        Me.tsbCrearGuardar.Size = New System.Drawing.Size(58, 24)
        Me.tsbCrearGuardar.Text = "ToolStripButton1"
        '
        'tsbCrearLimpiar
        '
        Me.tsbCrearLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCrearLimpiar.Image = CType(resources.GetObject("tsbCrearLimpiar.Image"), System.Drawing.Image)
        Me.tsbCrearLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCrearLimpiar.Name = "tsbCrearLimpiar"
        Me.tsbCrearLimpiar.Size = New System.Drawing.Size(58, 24)
        Me.tsbCrearLimpiar.Text = "ToolStripButton2"
        '
        'tsbCrearCerrar
        '
        Me.tsbCrearCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCrearCerrar.Image = CType(resources.GetObject("tsbCrearCerrar.Image"), System.Drawing.Image)
        Me.tsbCrearCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCrearCerrar.Name = "tsbCrearCerrar"
        Me.tsbCrearCerrar.Size = New System.Drawing.Size(58, 24)
        Me.tsbCrearCerrar.Text = "ToolStripButton1"
        '
        'vsbCrearPrioridad
        '
        Me.vsbCrearPrioridad.LargeChange = 1
        Me.vsbCrearPrioridad.Location = New System.Drawing.Point(62, 34)
        Me.vsbCrearPrioridad.Maximum = 3
        Me.vsbCrearPrioridad.Minimum = 1
        Me.vsbCrearPrioridad.Name = "vsbCrearPrioridad"
        Me.vsbCrearPrioridad.Size = New System.Drawing.Size(24, 116)
        Me.vsbCrearPrioridad.TabIndex = 0
        Me.vsbCrearPrioridad.Value = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 46)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 42)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "-- Alta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(90, 80)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 42)
        Me.Label11.TabIndex = 124
        Me.Label11.Text = "-- Media"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(90, 116)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 42)
        Me.Label12.TabIndex = 125
        Me.Label12.Text = "-- Baja"
        '
        'gbCrearPrioridad
        '
        Me.gbCrearPrioridad.Controls.Add(Me.Label12)
        Me.gbCrearPrioridad.Controls.Add(Me.Label11)
        Me.gbCrearPrioridad.Controls.Add(Me.Label7)
        Me.gbCrearPrioridad.Controls.Add(Me.vsbCrearPrioridad)
        Me.gbCrearPrioridad.Location = New System.Drawing.Point(849, 208)
        Me.gbCrearPrioridad.Margin = New System.Windows.Forms.Padding(4)
        Me.gbCrearPrioridad.Name = "gbCrearPrioridad"
        Me.gbCrearPrioridad.Padding = New System.Windows.Forms.Padding(4)
        Me.gbCrearPrioridad.Size = New System.Drawing.Size(203, 164)
        Me.gbCrearPrioridad.TabIndex = 118
        Me.gbCrearPrioridad.TabStop = False
        Me.gbCrearPrioridad.Text = "Prioridad de solicitud"
        '
        'ptbUsuarioIm
        '
        Me.ptbUsuarioIm.BackColor = System.Drawing.Color.Azure
        Me.ptbUsuarioIm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbUsuarioIm.Image = Global.ProyectoFinal.My.Resources.Resources._1072172_2001
        Me.ptbUsuarioIm.Location = New System.Drawing.Point(190, 21)
        Me.ptbUsuarioIm.Name = "ptbUsuarioIm"
        Me.ptbUsuarioIm.Size = New System.Drawing.Size(156, 123)
        Me.ptbUsuarioIm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbUsuarioIm.TabIndex = 122
        Me.ptbUsuarioIm.TabStop = False
        '
        'txtCrearFechaFinal
        '
        Me.txtCrearFechaFinal.Enabled = False
        Me.txtCrearFechaFinal.Location = New System.Drawing.Point(906, 450)
        Me.txtCrearFechaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCrearFechaFinal.Name = "txtCrearFechaFinal"
        Me.txtCrearFechaFinal.Size = New System.Drawing.Size(173, 49)
        Me.txtCrearFechaFinal.TabIndex = 123
        '
        'frmCrearTipoPrueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(22.0!, 42.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1307, 853)
        Me.Controls.Add(Me.txtCrearFechaFinal)
        Me.Controls.Add(Me.ptbUsuarioIm)
        Me.Controls.Add(Me.mnuCrear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbCrearPrioridad)
        Me.Controls.Add(Me.txtCrearRespons)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.gbCrearTipoClient)
        Me.Controls.Add(Me.cbCrearPrueba)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbCrearTipoMuestra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numCrearCantidad)
        Me.Controls.Add(Me.txtCrearFechaOrden)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvCrearOrden)
        Me.Controls.Add(Me.txtCrearObserv)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtCrearPlazo)
        Me.Controls.Add(Me.txtCrearCliente)
        Me.Controls.Add(Me.txtCrearSol)
        Me.Controls.Add(Me.txtCrearNumOrden)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.gbCrearTipoEns)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCrearSolicitante)
        Me.Controls.Add(Me.Label9)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCrearTipoPrueba"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ventana Crear Orden de Trabajo"
        CType(Me.dgvCrearOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCrearTipoEns.ResumeLayout(False)
        Me.gbCrearTipoEns.PerformLayout()
        CType(Me.numCrearCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCrearTipoClient.ResumeLayout(False)
        Me.gbCrearTipoClient.PerformLayout()
        Me.mnuCrear.ResumeLayout(False)
        Me.mnuCrear.PerformLayout()
        Me.gbCrearPrioridad.ResumeLayout(False)
        Me.gbCrearPrioridad.PerformLayout()
        CType(Me.ptbUsuarioIm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCrearOrden As DataGridView
    Friend WithEvents txtCrearObserv As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtCrearPlazo As TextBox
    Friend WithEvents txtCrearCliente As TextBox
    Friend WithEvents txtCrearSol As TextBox
    Friend WithEvents txtCrearNumOrden As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents gbCrearTipoEns As GroupBox
    Friend WithEvents chkGravEspec As CheckBox
    Friend WithEvents chkViscosidad As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCrearSolicitante As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtCrearFechaOrden As TextBox
    Friend WithEvents chkMancha As CheckBox
    Friend WithEvents chkCobalto As CheckBox
    Friend WithEvents chkReom As CheckBox
    Friend WithEvents numCrearCantidad As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents cbCrearTipoMuestra As ComboBox
    Friend WithEvents cbCrearPrueba As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents gbCrearTipoClient As GroupBox
    Friend WithEvents rbExterno As RadioButton
    Friend WithEvents rbInterno As RadioButton
    Friend WithEvents txtCrearRespons As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mnuCrear As ToolStrip
    Friend WithEvents tsbCrearGuardar As ToolStripButton
    Friend WithEvents tsbCrearLimpiar As ToolStripButton
    Friend WithEvents ptbUsuarioIm As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents vsbCrearPrioridad As VScrollBar
    Friend WithEvents gbCrearPrioridad As GroupBox
    Friend WithEvents txtCrearFechaFinal As TextBox
    Friend WithEvents tsbCrearCerrar As ToolStripButton
    Friend WithEvents NumOrden As DataGridViewTextBoxColumn
    Friend WithEvents FechaOrden As DataGridViewTextBoxColumn
    Friend WithEvents Solicitante As DataGridViewTextBoxColumn
    Friend WithEvents TipoEnsayo As DataGridViewTextBoxColumn
    Friend WithEvents CantidadMuEnsay As DataGridViewTextBoxColumn
    Friend WithEvents TipoMuestra As DataGridViewTextBoxColumn
    Friend WithEvents TipoPrueba As DataGridViewTextBoxColumn
    Friend WithEvents Responsable As DataGridViewTextBoxColumn
    Friend WithEvents NombreCliente As DataGridViewTextBoxColumn
    Friend WithEvents TipoCliente As DataGridViewTextBoxColumn
    Friend WithEvents Prioridad As DataGridViewTextBoxColumn
    Friend WithEvents Plazo As DataGridViewTextBoxColumn
    Friend WithEvents FechaFinal As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
End Class
