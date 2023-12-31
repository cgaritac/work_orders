Public Class frmCrearTipoPrueba
    Dim RegistroOrdenes As New DBORDENESDataContext
    Dim fecha As DateTime = DateTime.Now.ToLocalTime()
    Dim tipensayo, tipcliente, prior As String
    Dim tipoensayo1 As String = ""
    Dim tipoensayo2 As String = ""
    Dim tipoensayo3 As String = ""
    Dim tipoensayo4 As String = ""
    Dim tipoensayo5 As String = ""
    Dim NOrden As Integer
    Dim registros

    Private Sub frmCrearOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        prior = "Media"
        vsbCrearPrioridad.Value = 2
        txtCrearPlazo.Text = vsbCrearPrioridad.Value
        fecha = fecha.AddDays(2)
        txtCrearFechaFinal.Text = fecha
        txtCrearFechaOrden.Text = DateTime.Now.ToLocalTime()
        txtCrearSol.Text = frmUsuario.usuario

        registros = RegistroOrdenes.BUSCAR_ORDEN()

        For Each registro In registros
            txtCrearNumOrden.Text = registro.IDORDEN + 1
        Next

        If String.IsNullOrEmpty(txtCrearNumOrden.Text) Then
            txtCrearNumOrden.Text = 1
        End If

        rbInterno.Checked = False
        rbExterno.Checked = False
    End Sub

    Private Sub tsbCrearLimpiar_Click(sender As Object, e As EventArgs) Handles tsbCrearLimpiar.Click

        chkCobalto.Checked = False
        chkGravEspec.Checked = False
        chkMancha.Checked = False
        chkReom.Checked = False
        chkViscosidad.Checked = False
        numCrearCantidad.Value = 0
        cbCrearTipoMuestra.SelectedIndex = -1
        cbCrearPrueba.SelectedIndex = -1
        txtCrearRespons.Text = ""
        txtCrearCliente.Text = ""
        rbInterno.Checked = False
        rbExterno.Checked = False
        vsbCrearPrioridad.Value = 2
        txtCrearPlazo.Text = vsbCrearPrioridad.Value
        fecha = fecha.AddDays(2)
        txtCrearFechaFinal.Text = fecha
        txtCrearObserv.Text = ""
        dgvCrearOrden.Rows.Clear()
    End Sub

    Private Sub txtCrearRespons_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCrearRespons.KeyPress
        e.Handled = IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Error, favor ingresar solamente letras", "Error ingreso de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub txtCrearCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCrearCliente.KeyPress
        e.Handled = IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Error, favor ingresar solamente letras", "Error ingreso de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub vsbCrearPrioridad_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbCrearPrioridad.Scroll
        fecha = DateTime.Now.ToLocalTime()
        txtCrearPlazo.Text = vsbCrearPrioridad.Value

        If vsbCrearPrioridad.Value = 1 Then
            fecha = fecha.AddDays(1)
            txtCrearFechaFinal.Text = fecha
            prior = "Alta"
        End If

        If vsbCrearPrioridad.Value = 2 Then
            fecha = fecha.AddDays(2)
            txtCrearFechaFinal.Text = fecha
            prior = "Media"
        End If

        If vsbCrearPrioridad.Value = 3 Then
            fecha = fecha.AddDays(3)
            txtCrearFechaFinal.Text = fecha
            prior = "Baja"
        End If
    End Sub

    Private Sub tsbCrearGuardar_Click(sender As Object, e As EventArgs) Handles tsbCrearGuardar.Click

        If (chkCobalto.Checked = False And chkGravEspec.Checked = False And chkMancha.Checked = False And chkReom.Checked = False And chkViscosidad.Checked = False) Or numCrearCantidad.Value = 0 Or cbCrearTipoMuestra.SelectedIndex = -1 Or txtCrearRespons.Text = "" Or txtCrearCliente.Text = "" Or txtCrearObserv.Text = "" Or (rbInterno.Checked = False And rbExterno.Checked = False) Then
            MessageBox.Show("Error, falta información, favor ingrese todos los datos", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If chkCobalto.Checked = True Then
                tipoensayo1 = "Cobalto-"
            End If

            If chkGravEspec.Checked = True Then
                tipoensayo2 = "Gravedad Específica-"
            End If

            If chkMancha.Checked = True Then
                tipoensayo3 = "Mancha-"
            End If

            If chkReom.Checked = True Then
                tipoensayo4 = "Reometría-"
            End If

            If chkViscosidad.Checked = True Then
                tipoensayo5 = "Viscosidad"
            End If

            tipensayo = tipoensayo1 + tipoensayo2 + tipoensayo3 + tipoensayo4 + tipoensayo5

            If rbInterno.Checked = True Then
                tipcliente = "Interno"
            Else
                tipcliente = "Externo"
            End If

            RegistroOrdenes.GUARDAR_CREARORDEN(NOrden, txtCrearFechaOrden.Text, txtCrearSol.Text, tipensayo, numCrearCantidad.Value, cbCrearTipoMuestra.Text, cbCrearPrueba.Text, txtCrearRespons.Text, txtCrearCliente.Text, tipcliente, prior, txtCrearPlazo.Text, txtCrearFechaFinal.Text, txtCrearObserv.Text)
            dgvCrearOrden.Rows.Add(New String() {NOrden, txtCrearFechaOrden.Text, txtCrearSol.Text, tipensayo, numCrearCantidad.Value, cbCrearTipoMuestra.Text, cbCrearPrueba.Text, txtCrearRespons.Text, txtCrearCliente.Text, tipcliente, prior, txtCrearPlazo.Text, txtCrearFechaFinal.Text, txtCrearObserv.Text})
            MessageBox.Show("Datos ingresados correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            NOrden = NOrden + 1
            txtCrearNumOrden.Text = NOrden

            fecha = DateTime.Now.ToLocalTime()
            chkCobalto.Checked = False
            chkGravEspec.Checked = False
            chkMancha.Checked = False
            chkReom.Checked = False
            chkViscosidad.Checked = False
            numCrearCantidad.Value = 0
            cbCrearTipoMuestra.SelectedIndex = -1
            cbCrearPrueba.SelectedIndex = -1
            txtCrearRespons.Text = ""
            txtCrearCliente.Text = ""
            rbInterno.Checked = False
            rbExterno.Checked = False
            vsbCrearPrioridad.Value = 2
            txtCrearPlazo.Text = vsbCrearPrioridad.Value
            fecha = fecha.AddDays(2)
            txtCrearFechaFinal.Text = fecha
            txtCrearObserv.Text = ""
        End If
    End Sub

    Private Sub tsbCrearCerrar_Click(sender As Object, e As EventArgs) Handles tsbCrearCerrar.Click
        Me.Close()
    End Sub
End Class