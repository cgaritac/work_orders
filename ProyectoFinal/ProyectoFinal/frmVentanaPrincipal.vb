Imports System.Windows.Forms

Public Class frmVentanaPrincipal
    Dim acerca As String

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub frmVentanaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmUsuario.Hide()
        tslVentanaPrincipal.Text = DateTime.Now.ToLocalTime()

        If frmUsuario.usuario.Equals("TECNIC") Then
            tsmIngresarOrden.Enabled = False
            tsmReporte.Enabled = False
        End If
    End Sub

    Private Sub frmVentanaPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmUsuario.Close()
    End Sub

    Private Sub msSalir_Click(sender As Object, e As EventArgs) Handles msSalir.Click
        Me.Close()
        frmUsuario.Close()
    End Sub

    Private Sub tsmAcerca_Click(sender As Object, e As EventArgs) Handles tsmAcerca.Click

        acerca = " Relizado por Carlos Garita Campos" + vbLf + "            Proyecto Final" + vbLf + "Programación orientada a objetos II"

        MessageBox.Show(acerca, "Información de programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub tsmIngresarOrden_Click(sender As Object, e As EventArgs) Handles tsmIngresarOrden.Click
        Dim Objhijo As New frmCrearTipoPrueba
        Objhijo.MdiParent = Me
        Objhijo.Show()
    End Sub

    Private Sub tsmCerrarOrden_Click(sender As Object, e As EventArgs) Handles tsmCerrarOrden.Click
        Dim Objhijo As New frmCerrarOrden
        Objhijo.MdiParent = Me
        Objhijo.Show()
    End Sub

    Private Sub tsmReporte_Click(sender As Object, e As EventArgs) Handles tsmReporte.Click
        Dim Objhijo As New frmReporte
        Objhijo.MdiParent = Me
        Objhijo.Show()
    End Sub

End Class
