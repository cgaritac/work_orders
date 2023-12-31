Public Class frmReporte
    Dim RegistroOrdenes As New DBORDENESDataContext
    Dim registros
    Dim fechaant, fechadesp As DateTime
    Dim mensaje As String
    Dim nOrden As Integer

    Private Sub tsbReportLimpiar_Click(sender As Object, e As EventArgs) Handles tsbReportLimpiar.Click
        cbReportTipoCons.SelectedIndex = -1
        cbReportEstado.SelectedIndex = -1
        dtpReportFechaFinal.Value = DateTime.Now.ToLocalTime()
        dtpReportFechaOrden.Value = DateTime.Now.ToLocalTime()
        txtReportNumOrden.Enabled = False
        lblReportNumOrden.Enabled = False
        dtpReportFechaOrden.Enabled = False
        lblReportFechaOrden.Enabled = False
        dtpReportFechaFinal.Enabled = False
        lblReportFechaFinal.Enabled = False
        cbReportEstado.Enabled = False
        lblReportEstado.Enabled = False
        txtReportNumOrden.Text = ""
        dgvReporte.Rows.Clear()
    End Sub

    Private Sub txtReportNumOrden_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReportNumOrden.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Error, favor ingresar solo números", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub tsbReportBuscar_Click(sender As Object, e As EventArgs) Handles tsbReportBuscar.Click
        Dim fOrden, fEstFinal, fEjec, fCierre As DateTime
        Dim plaz, cantMuestras As Integer
        Dim solic, tEnsayo, tMuestra, tPrueba, respon, clien, tClien, priorid, observCre, estado, observCerr As String

        If txtReportNumOrden.Enabled = True Then
            If txtReportNumOrden.Text.Equals("") Then
                MessageBox.Show("Error, falta el información, favor ingrese el número de orden", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                If Not String.IsNullOrEmpty(txtReportNumOrden.Text) Then
                    nOrden = txtReportNumOrden.Text
                    registros = RegistroOrdenes.BUSCAR_CREARORDEN(txtReportNumOrden.Text, mensaje)

                    If mensaje.Equals("Orden de trabajo no existe") Then
                        MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Else
                        For Each registro In registros
                            fOrden = registro.FECHAORDEN
                            plaz = registro.PLAZO
                            fEstFinal = registro.FECHAESTFINAL
                            solic = registro.SOLICITANTE
                            tEnsayo = registro.TIPOENSAYO
                            cantMuestras = registro.CANTMUESTRAS
                            tMuestra = registro.TIPOMUESTRA
                            tPrueba = registro.TIPOPRUEBA
                            respon = registro.RESPONSABLE
                            clien = registro.CLIENTE
                            tClien = registro.TIPOCLIENTE
                            priorid = registro.PRIORIDAD
                            observCre = registro.OBSERVACIONESCREAR
                        Next
                        registros = RegistroOrdenes.BUSCAR_CERRARORDEN(txtReportNumOrden.Text, mensaje)

                        If mensaje.Equals("Orden de trabajo no se ha cerrado") Then

                            dgvReporte.Rows.Add(New String() {nOrden, fOrden, plaz, fEstFinal, "No aplica", "No aplica", "No aplica", solic, tEnsayo, cantMuestras, tMuestra, tPrueba, respon, clien, tClien, priorid, observCre, "No aplica"})

                            MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Else
                            For Each registro In registros
                                fEjec = registro.FECHAEJEC
                                fCierre = registro.FECHACIERRE
                                estado = registro.ESTADO
                                observCerr = registro.OBSERVACIONESCERRAR
                            Next
                            dgvReporte.Rows.Add(New String() {nOrden, fOrden, plaz, fEstFinal, fEjec, fCierre, estado, solic, tEnsayo, cantMuestras, tMuestra, tPrueba, respon, clien, tClien, priorid, observCre, observCerr})
                            MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        End If
                    End If
                End If
            End If
        End If

        If dtpReportFechaOrden.Enabled = True Then

            dgvReporte.Rows.Clear()

            fechaant = dtpReportFechaOrden.Value
            fechaant = fechaant.AddDays(-0.5)

            fechadesp = dtpReportFechaOrden.Value
            fechadesp = fechadesp.AddDays(0.5)

            registros = RegistroOrdenes.BUSCAR_REPORTFECHORDEN(fechaant, fechadesp, mensaje)

            If mensaje.Equals("No hay registros para la fecha indicada") Then
                MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                For Each registro In registros
                    dgvReporte.Rows.Add(New String() {registro.IDORDEN, registro.FECHAORDEN, registro.PLAZO, registro.FECHAESTFINAL, registro.FECHAEJEC, registro.FECHACIERRE, registro.ESTADO, registro.SOLICITANTE, registro.TIPOENSAYO, registro.CANTMUESTRAS, registro.TIPOMUESTRA, registro.TIPOPRUEBA, registro.RESPONSABLE, registro.CLIENTE, registro.TIPOCLIENTE, registro.PRIORIDAD, registro.OBSERVACIONESCREAR, registro.OBSERVACIONESCERRAR})
                Next
            End If
        End If

        If dtpReportFechaFinal.Enabled = True Then

            dgvReporte.Rows.Clear()

            fechaant = dtpReportFechaFinal.Value
            fechaant = fechaant.AddDays(-0.5)

            fechadesp = dtpReportFechaFinal.Value
            fechadesp = fechadesp.AddDays(0.5)

            registros = RegistroOrdenes.BUSCAR_CERRARORDENFECHCIERR(fechaant, fechadesp, mensaje)

            If mensaje.Equals("Ninguna orden ha sido cerrada aún") Then
                MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                For Each registro In registros
                    dgvReporte.Rows.Add(New String() {registro.IDORDEN, registro.FECHAORDEN, registro.PLAZO, registro.FECHAESTFINAL, registro.FECHAEJEC, registro.FECHACIERRE, registro.ESTADO, registro.SOLICITANTE, registro.TIPOENSAYO, registro.CANTMUESTRAS, registro.TIPOMUESTRA, registro.TIPOPRUEBA, registro.RESPONSABLE, registro.CLIENTE, registro.TIPOCLIENTE, registro.PRIORIDAD, registro.OBSERVACIONESCREAR, registro.OBSERVACIONESCERRAR})
                Next
                MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If

        If cbReportEstado.Enabled = True Then
            dgvReporte.Rows.Clear()
            If cbReportEstado.SelectedIndex = -1 Then
                MessageBox.Show("Error, falta el información, favor ingrese el estado de la orden de trabajo", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                registros = RegistroOrdenes.BUSCAR_CERRARORDENESTAD(cbReportEstado.Text, mensaje)

                If mensaje.Equals("Ninguna orden ha sido cerrada aún") Then
                    MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    For Each registro In registros
                        dgvReporte.Rows.Add(New String() {registro.IDORDEN, registro.FECHAORDEN, registro.PLAZO, registro.FECHAESTFINAL, registro.FECHAEJEC, registro.FECHACIERRE, registro.ESTADO, registro.SOLICITANTE, registro.TIPOENSAYO, registro.CANTMUESTRAS, registro.TIPOMUESTRA, registro.TIPOPRUEBA, registro.RESPONSABLE, registro.CLIENTE, registro.TIPOCLIENTE, registro.PRIORIDAD, registro.OBSERVACIONESCREAR, registro.OBSERVACIONESCERRAR})
                    Next
                    MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If
        End If
    End Sub

    Private Sub cbReportTipoCons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbReportTipoCons.SelectedIndexChanged

        txtReportNumOrden.Enabled = False
        txtReportNumOrden.Text = ""
        lblReportNumOrden.Enabled = False
        dtpReportFechaOrden.Enabled = False
        dtpReportFechaOrden.Value = DateTime.Now.ToLocalTime()
        lblReportFechaOrden.Enabled = False
        dtpReportFechaFinal.Enabled = False
        dtpReportFechaFinal.Value = DateTime.Now.ToLocalTime()
        lblReportFechaFinal.Enabled = False
        cbReportEstado.Enabled = False
        cbReportEstado.SelectedIndex = -1
        lblReportEstado.Enabled = False

        If cbReportTipoCons.SelectedIndex = 0 Then
            txtReportNumOrden.Enabled = True
            lblReportNumOrden.Enabled = True
        End If

        If cbReportTipoCons.SelectedIndex = 1 Then
            dtpReportFechaOrden.Enabled = True
            lblReportFechaOrden.Enabled = True
        End If

        If cbReportTipoCons.SelectedIndex = 2 Then
            dtpReportFechaFinal.Enabled = True
            lblReportFechaFinal.Enabled = True
        End If

        If cbReportTipoCons.SelectedIndex = 3 Then
            cbReportEstado.Enabled = True
            lblReportEstado.Enabled = True
        End If
    End Sub

    Private Sub tsbReportCerrar_Click(sender As Object, e As EventArgs) Handles tsbReportCerrar.Click
        Me.Close()
    End Sub
End Class