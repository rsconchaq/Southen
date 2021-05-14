
Public Class ReportePersona
    Dim nombre As String



    Private Sub ReportePersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nombre = lbltipo.Text & "|" & lbldocumento.Text
        Me.P_buscapersonaTableAdapter.Fill(Me.BDSouthern.p_buscapersona, nombre)
        reportViewer1.RefreshReport()
    End Sub
End Class