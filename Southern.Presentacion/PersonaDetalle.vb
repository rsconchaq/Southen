Imports Southern.DataContracts

Public Class PersonaDetalle
    Dim client As New ServiceReference1.ServicioPersonaSoapClient()
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
        Form1.Visible = True
    End Sub

    Private Sub Grabar_Click(sender As Object, e As EventArgs) Handles Grabar.Click
        Dim respuesta = ""

        If txtNombre.Text = String.Empty Then
            MessageBox.Show("Ingrese el Nombre")
            txtNombre.BackColor = Color.Yellow
            txtNombre.Focus()
            Exit Sub
        ElseIf txtApellido.Text = String.Empty Then
            MessageBox.Show("Ingrese el Apellido")
            txtApellido.BackColor = Color.Yellow
            txtApellido.Focus()

        ElseIf txtNumDocumento.Text = String.Empty Then
            MessageBox.Show("Ingrese Numero de documento")
            txtNumDocumento.BackColor = Color.Yellow
            txtNumDocumento.Focus()
        ElseIf mtxtEdad.Text = String.Empty Then
            MessageBox.Show("Ingrese Numero de Edad")
            mtxtEdad.BackColor = Color.Yellow
            mtxtEdad.Focus()
        ElseIf cbTipoDocumento.Text = String.Empty Then
            MessageBox.Show("Seleccione un Tipo documento")
            cbTipoDocumento.Focus()
            Exit Sub
        Else
            txtNumDocumento.BackColor = Color.White

            If client.ConsultaDocumento(txtNumDocumento.Text) = True Then
                MessageBox.Show("Documento ya registrado")
            Else

                Dim oPersona As New Persona
                With oPersona
                    .Nombre = txtApellido.Text
                    .Apellido = txtApellido.Text
                    .Documento = txtNumDocumento.Text
                    .TipoDocumento = cbTipoDocumento.SelectedItem
                    .Estado = cbEstado.SelectedItem
                    .Edad = mtxtEdad.Text
                End With
                respuesta = client.RegistrarPersona(oPersona)
                MessageBox.Show("Se Guardo Correctamente")
                Me.Close()
                Form1.Visible = True

                Dim frm As New Form1
                frm.dataListado.DataSource = client.MostrarPersona
                frm.dataListado.Refresh()

            End If



        End If
    End Sub

    Private Sub PersonaDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtIdPersona.Text = String.Empty Then
            Eliminar.Enabled = False
        Else
            Eliminar.Enabled = True
        End If



    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim respuesta = ""
        respuesta = client.EliminarPersona(txtIdPersona.Text)
        MessageBox.Show("Se Elimino correctamente")
        Me.Close()
        Form1.Visible = True


    End Sub

    Private Sub PersonaDetalle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim frm As New Form1
        frm.dataListado.DataSource = client.MostrarPersona
    End Sub

    Private Sub ExportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarToolStripMenuItem.Click
        Dim frm As New ReportePersonaAgrupado
        frm.lbldocumento.Text = txtNumDocumento.Text
        frm.ShowDialog()
    End Sub
End Class