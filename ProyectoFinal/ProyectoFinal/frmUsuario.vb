Public Class frmUsuario

    Dim controlIngreso As New DBUsuarioDataContext
    Public usuario As String
    Dim contrasena As String
    Dim registros
    Dim mensaje As String

    Private Sub btnAccesoIngresar_Click(sender As Object, e As EventArgs) Handles btnAccesoIngresar.Click

        If txtUsuario.Text.Equals("") Or txtContrasena.Text.Equals("") Then
            MessageBox.Show("Error, Favor ingrese todos los datos", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            If Not String.IsNullOrEmpty(txtUsuario.Text) Then

                usuario = txtUsuario.Text
                contrasena = txtContrasena.Text

                registros = controlIngreso.BUSCAR_JEFATURA(usuario, mensaje)

                If mensaje.Equals("Usuario incorrecto") Then

                    registros = controlIngreso.BUSCAR_TECNICO(usuario, mensaje)

                    If mensaje.Equals("Usuario incorrecto") Then
                        MessageBox.Show("Usuario incorrecto, favor ingrese el usuario nuevamente", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                    Else
                        For Each regystro In registros
                            If contrasena.Equals(regystro.CONTRASENA) Then
                                frmVentanaPrincipal.Show()
                            Else
                                MessageBox.Show("Contraseña incorrecta, favor ingrese la contraseña nuevamente", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                            End If
                        Next
                    End If
                Else
                    For Each registro In registros
                        If contrasena.Equals(registro.CONTRASENA) Then
                            frmVentanaPrincipal.Show()
                        Else
                            MessageBox.Show("Contraseña incorrecta, favor ingrese la contraseña nuevamente", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub btnAccesoSalir_Click(sender As Object, e As EventArgs) Handles btnAccesoSalir.Click
        End
    End Sub

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles Me.Load
        tslUsuario.Text = DateTime.Now.ToLocalTime()
        txtUsuario.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub
End Class
