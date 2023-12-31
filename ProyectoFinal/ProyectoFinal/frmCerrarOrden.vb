Public Class frmCerrarOrden
    Dim RegistroOrdenes As New DBORDENESDataContext
    Dim estad, mensaje As String
    Dim fCierre As DateTime = DateTime.Now.ToLocalTime()
    Dim NOrden, NCierre As Integer
    Dim registros

    Private Sub tsbCierreLimipar_Click(sender As Object, e As EventArgs) Handles tsbCierreLimipar.Click
        txtCerrarNumOrden.Text = ""
        dtpCerrarFechaEjec.Value = DateTime.Now.ToLocalTime()
        rbAbortado.Checked = False
        rbCerrado.Checked = False
        txtCerrarObserv.Text = ""
        dgvCerrarOrden.Rows.Clear()
        dtpCerrarFechaEjec.Enabled = False
        txtCerrarObserv.Enabled = False
        rbAbortado.Enabled = False
        rbCerrado.Enabled = False
    End Sub

    Private Sub frmCerrarOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbAbortado.Checked = False
        rbCerrado.Checked = False
    End Sub

    Private Sub dtpCerrarFechaEjec_ValueChanged(sender As Object, e As EventArgs) Handles dtpCerrarFechaEjec.ValueChanged
        Dim fmax As DateTime = DateTime.Now.ToLocalTime()
        fmax = fmax.AddDays(0.005)
        dtpCerrarFechaEjec.MaxDate = fmax
    End Sub

    Private Sub txtCerrarNumOrden_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCerrarNumOrden.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Error, favor ingresar solo números", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub tsbCierreBuscar_Click(sender As Object, e As EventArgs) Handles tsbCierreBuscar.Click

        If txtCerrarNumOrden.Text = "" Then
            MessageBox.Show("Error, falta información, favor ingrese el número de orden", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If Not String.IsNullOrEmpty(txtCerrarNumOrden.Text) Then

                NOrden = txtCerrarNumOrden.Text

                registros = RegistroOrdenes.BUSCAR_CREARORDEN(NOrden, mensaje)

                If mensaje.Equals("Orden de trabajo no existe") Then
                    MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    RegistroOrdenes.BUSCAR_CERRARORDEN(NOrden, mensaje)

                    If mensaje.Equals("Orden de trabajo no se ha cerrado") Then
                        dtpCerrarFechaEjec.Enabled = True
                        txtCerrarObserv.Enabled = True
                        rbAbortado.Enabled = True
                        rbCerrado.Enabled = True

                        MessageBox.Show("Orden de trabajo encontrada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Else
                        MessageBox.Show("La orden ya fue cerrada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                End If
            Else
                MessageBox.Show("Error, falta información, favor ingrese el número de orden", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub

    Private Sub tsbCierreGuardar_Click(sender As Object, e As EventArgs) Handles tsbCierreGuardar.Click

        If txtCerrarNumOrden.Text.Equals("") Or txtCerrarObserv.Text.Equals("") Or (rbAbortado.Checked = False And rbCerrado.Checked = False) Then
            MessageBox.Show("Error, falta información, favor ingrese todos los datos", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If rbAbortado.Checked = True Then
                estad = "Abortado"
            Else
                estad = "Cerrado"
            End If

            RegistroOrdenes.BUSCAR_CREARORDEN(txtCerrarNumOrden.Text, mensaje)

            If mensaje.Equals("Orden de trabajo no existe") Then
                MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                RegistroOrdenes.GUARDAR_CERRARORDEN(NCierre, txtCerrarNumOrden.Text, dtpCerrarFechaEjec.Value, fCierre, estad, txtCerrarObserv.Text, mensaje)

                If mensaje.Equals("La orden ya fue cerrada") Then
                    MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    dgvCerrarOrden.Rows.Add(New String() {txtCerrarNumOrden.Text, dtpCerrarFechaEjec.Value, fCierre, estad, txtCerrarObserv.Text})
                    dtpCerrarFechaEjec.Value = DateTime.Now.ToLocalTime()
                    rbAbortado.Checked = False
                    rbCerrado.Checked = False
                    txtCerrarObserv.Text = ""
                    dtpCerrarFechaEjec.Enabled = False
                    txtCerrarObserv.Enabled = False
                    rbAbortado.Enabled = False
                    rbCerrado.Enabled = False

                    MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If
        End If
    End Sub

    Private Sub tsbCerrarCerrar_Click(sender As Object, e As EventArgs) Handles tsbCerrarCerrar.Click
        Me.Close()
    End Sub
End Class