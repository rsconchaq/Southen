Imports Southern.DataContracts
Public Class Form1

    Dim client As New ServiceReference1.ServicioPersonaSoapClient()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub
    Private Sub Mostrar()
        Dim lista As New List(Of Persona)

        dataListado.DataSource = client.MostrarPersona
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mnuPrincipal_Click(sender As Object, e As EventArgs) Handles mnuPrincipal.Click
        Dim _txtBuscar As String = txtBuscar.Text
        Dim _cbBuscar As String = cbBuscar.SelectedIndex
        Dim _Texto As String = _cbBuscar & "|" & _txtBuscar
        dataListado.DataSource = client.BuscaPersona(_Texto)
    End Sub

    Private Sub NuevaPersona_Click(sender As Object, e As EventArgs) Handles NuevaPersona.Click
        Me.Hide()
        PersonaDetalle.Show()
        PersonaDetalle.Text = "Persona Detalle"

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        If MsgBox("Desea Salir de la apicacion ?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If

    End Sub



    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        If (dataListado.SelectedRows.Count > 0) Then
            Me.Hide()
            Dim frm As New PersonaDetalle
            frm.txtIdPersona.Text = dataListado.CurrentRow.Cells(0).Value.ToString()
            frm.txtNombre.Text = dataListado.CurrentRow.Cells(1).Value.ToString()
            frm.txtApellido.Text = dataListado.CurrentRow.Cells(2).Value.ToString()
            frm.txtNumDocumento.Text = dataListado.CurrentRow.Cells(3).Value.ToString()
            frm.lbldni.Text = dataListado.CurrentRow.Cells(3).Value.ToString()
            Dim indexTDocumento As String
            Dim indexEstado As String
            If dataListado.CurrentRow.Cells(4).Value.ToString() = "DNI" Then
                indexTDocumento = 0
            Else
                indexTDocumento = 1
            End If

            If dataListado.CurrentRow.Cells(6).Value.ToString() = "A" Then
                indexEstado = 0
            Else
                indexEstado = 1
            End If
            frm.cbTipoDocumento.SelectedIndex = indexTDocumento
            frm.mtxtEdad.Text = dataListado.CurrentRow.Cells(5).Value.ToString()
            frm.cbEstado.SelectedIndex = indexEstado

            frm.ShowDialog()
        Else
            MessageBox.Show("Por favor seleccione una fila...")
        End If
    End Sub

    Private Sub ExportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarToolStripMenuItem.Click
        Dim frm As New ReportePersona
        frm.lbltipo.Text = cbBuscar.SelectedIndex
        frm.lbldocumento.Text = txtBuscar.Text
        frm.ShowDialog()
    End Sub
End Class
