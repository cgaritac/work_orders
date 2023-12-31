<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentanaPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Me.msPrincipal = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmIngresarOrden = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCerrarOrden = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmReporte = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmAcerca = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.tslVentanaPrincipal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.msPrincipal.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'msPrincipal
        '
        Me.msPrincipal.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.msPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.WindowsMenu, Me.HelpMenu, Me.msSalir})
        Me.msPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.msPrincipal.MdiWindowListItem = Me.WindowsMenu
        Me.msPrincipal.Name = "msPrincipal"
        Me.msPrincipal.Padding = New System.Windows.Forms.Padding(10, 3, 0, 3)
        Me.msPrincipal.Size = New System.Drawing.Size(1282, 35)
        Me.msPrincipal.TabIndex = 5
        Me.msPrincipal.Text = "MenuStrip"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmIngresarOrden, Me.tsmCerrarOrden, Me.tsmReporte})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(103, 29)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'tsmIngresarOrden
        '
        Me.tsmIngresarOrden.Image = Global.ProyectoFinal.My.Resources.Resources.mantenimiento_actualizaot
        Me.tsmIngresarOrden.Name = "tsmIngresarOrden"
        Me.tsmIngresarOrden.Size = New System.Drawing.Size(289, 30)
        Me.tsmIngresarOrden.Text = "Crear orden de trabajo"
        '
        'tsmCerrarOrden
        '
        Me.tsmCerrarOrden.Image = Global.ProyectoFinal.My.Resources.Resources._2326551____Version2
        Me.tsmCerrarOrden.Name = "tsmCerrarOrden"
        Me.tsmCerrarOrden.Size = New System.Drawing.Size(289, 30)
        Me.tsmCerrarOrden.Text = "Cerrar orden de trabajo"
        '
        'tsmReporte
        '
        Me.tsmReporte.Image = Global.ProyectoFinal.My.Resources.Resources.reporte
        Me.tsmReporte.Name = "tsmReporte"
        Me.tsmReporte.Size = New System.Drawing.Size(289, 30)
        Me.tsmReporte.Text = "Generar reporte"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(101, 29)
        Me.WindowsMenu.Text = "&Ventanas"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.CascadeToolStripMenuItem.Text = "&Cascada"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.TileVerticalToolStripMenuItem.Text = "Mosaico &vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.TileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.CloseAllToolStripMenuItem.Text = "C&errar todo"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Organizar iconos"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator8, Me.tsmAcerca})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(77, 29)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(182, 6)
        '
        'tsmAcerca
        '
        Me.tsmAcerca.Name = "tsmAcerca"
        Me.tsmAcerca.Size = New System.Drawing.Size(185, 30)
        Me.tsmAcerca.Text = "&Acerca de..."
        '
        'msSalir
        '
        Me.msSalir.Name = "msSalir"
        Me.msSalir.Size = New System.Drawing.Size(61, 29)
        Me.msSalir.Text = "Salir"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslVentanaPrincipal})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 728)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 24, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1282, 25)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'tslVentanaPrincipal
        '
        Me.tslVentanaPrincipal.Name = "tslVentanaPrincipal"
        Me.tslVentanaPrincipal.Size = New System.Drawing.Size(54, 20)
        Me.tslVentanaPrincipal.Text = "Estado"
        '
        'frmVentanaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1282, 753)
        Me.Controls.Add(Me.msPrincipal)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msPrincipal
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmVentanaPrincipal"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventana Principal"
        Me.msPrincipal.ResumeLayout(False)
        Me.msPrincipal.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmAcerca As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents tslVentanaPrincipal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents msPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msSalir As ToolStripMenuItem
    Friend WithEvents tsmIngresarOrden As ToolStripMenuItem
    Friend WithEvents tsmCerrarOrden As ToolStripMenuItem
    Friend WithEvents tsmReporte As ToolStripMenuItem
End Class
